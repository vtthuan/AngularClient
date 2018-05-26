using AngularClient.Models;
using AngularClient.Models.Identity;
using AngularClient.Models.Steps;
using AngularClient.ViewModel;
using AutoMapper;
using System;
using System.Globalization;
using System.Linq;

namespace RTF.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RegisterViewModel, ApplicationUser>().ForMember(au => au.UserName, map => map.MapFrom(vm => vm.Email));

            CreateMap<Category, CategoryViewModel>();
            
            CreateMap<Video, VideoViewModel>()
                .ForMember(d => d.CodeLearning, opt => opt.UseValue("fr"))
                .ForMember(d => d.CodeNative, opt => opt.UseValue("vi"))
                .ForMember(d => d.VideoId, opt => opt.MapFrom(src => src.MediaInfo.VideoID))
                .ForMember(d => d.Title, opt => opt.MapFrom(src => src.MediaInfo.Title))
                .ForMember(d => d.ViewCount, opt => opt.MapFrom(src => src.MediaInfo.ViewCount.ToString("# ###")))
                .ForMember(d => d.Duration, opt => opt.MapFrom(src => ConvertDurationFormat(src.MediaInfo.Duration)))
                .ForMember(d => d.VideoUrl, opt => opt.MapFrom(src => src.MediaInfo.GetVideoUrl()))
                .ForMember(d => d.ThumbnailUrl, opt => opt.MapFrom(src => src.MediaInfo.GetThumbnailUrl()))
                .ForMember(d => d.UserName, opt => opt.MapFrom(src => src.User.UserName));

            //CreateMap<Answer, AnswerViewModel>();

            //CreateMap<CoinType, CoinTypeViewModel>()
            //    .ForMember(d => d.IsFree, opt => opt.MapFrom(src => src.Price == 0));

            //CreateMap<Question, QuestionViewModel>();

            CreateMap<Step, StepViewModel>()
                .ForMember(d => d.State, opt => opt.MapFrom(src => AtOrBelowMaxStepAllowed(src) ? "active" : "disabled"));
                

            CreateMap<Transaction, TransactionIndexViewModel>()
                .ForMember(d => d.Duration, opt => opt.MapFrom(src => ConvertDurationFormat(src.Video.MediaInfo.Duration * src.Steps.Count)))
                .ForMember(d => d.VideoId, opt => opt.MapFrom(src => src.Video.MediaInfo.VideoID))
                .ForMember(d => d.ShowAccessLink, opt => opt.MapFrom( src=> src.Id == 0))
                .ForMember(d => d.ShowRestartLink, opt => opt.MapFrom(src => src.Id != 0))
                .ForMember(d => d.ShowResumeLink, opt => opt.MapFrom(src => src.Id != 0));

            CreateMap<Remarque, RemarqueViewModel>()
                .ForMember(d => d.Min, opt => opt.MapFrom(src => src.Min.ToString("#.000")));

            CreateMap<SubtitleRecord, RemarqueCreateViewModel>()
                .ForMember(d=> d.Min, opt=> opt.MapFrom(src=> src.Start));


            CreateMap<Transaction, PreviewStepTransactionViewModel>()
                .ForMember(d => d.Video, opt => opt.MapFrom( src => AutoMapper.Mapper.Map<VideoViewModel>(src.Video)))
                .ForMember(d => d.Remarques, opt => opt.MapFrom(x => x.Video.Remarques.Where(r => r.NativeLanguage.Code == "vi")));

            CreateMap<Transaction, ViewStepTransactionViewModel>()
                
                .ForMember(d => d.Video, opt => opt.MapFrom(src => AutoMapper.Mapper.Map<VideoViewModel>(src.Video)))
                .ForMember(d => d.Remarques, opt => opt.MapFrom(x => x.Video.Remarques.Where(r => r.NativeLanguage.Code == "vi")));

            CreateMap<Transaction, SubtitleStepTransactionViewModel>()
                
                .ForMember(d => d.Video, opt => opt.MapFrom(src => AutoMapper.Mapper.Map<VideoViewModel>(src.Video)));
        }

        private bool AtOrBelowMaxStepAllowed(Step step)
        {
            return step.IsFinished || step.Transaction.CurrentStep.Order == step.Order;
        }

        private double ConvertTimeSpanToDouble(string timespan)
        {
            var rs = 0d;
            var format = @"hh\:mm\:ss\,fff";
            var culture = CultureInfo.CurrentCulture;
            try
            {
                var interval = TimeSpan.ParseExact(timespan, format, culture);

                return interval.TotalSeconds;
            }
            catch (FormatException)
            {
                Console.WriteLine("'{0}': Bad Format for '{1}'", timespan, format);
            }
            catch (OverflowException)
            {
                Console.WriteLine("'{0}': Overflow", timespan);
            }
            return rs;
        }

        private string ConvertDurationFormat(int duration)
        {
            duration = duration - duration % 60;
            var d = TimeSpan.FromSeconds(duration);
            if (duration >= 3600)
                return d.ToString(@"hh\:mm\:ss");
            else
            {
                return d.ToString(@"mm\:ss");
            }
        }
    }
}