using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AngularClient.ViewModel;
using AngularClient.Models;
using AngularClient.Core;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace AngularClient.Controllers
{
    [Authorize(Policy = "AuthUser")]
    [Route("api/Transaction")]
    public class TransactionController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ClaimsPrincipal _caller;

        public TransactionController(IUnitOfWork unit,IHttpContextAccessor httpContextAccessor)
        {
            _caller = httpContextAccessor.HttpContext.User;
            _unitOfWork = unit;
        }

        
        public PreviewStepTransactionViewModel Preview(int videoId, string transactionId)
        {
            var t = new Transaction();
            return new PreviewStepTransactionViewModel()
            {
                Steps = new List<StepViewModel>()
                {
                    new StepViewModel(){ Name = "23"}
                }
            };
        }

        [HttpPost]
        public StepTransactionViewModel Get(Video video)
        {
            var userIdClaim = _caller.Claims.Single(c => c.Type == "id");
            var customer = _unitOfWork.CustomerRepository.GetCustomer(userIdClaim.Value);
            var userId = customer.IdentityId;

            Transaction transaction = null;
            var transactions = _unitOfWork.TransactionRepository.Get(userId, video.Id);

            //first time see video, deduire coin
            if (transactions.Count == 0)
            {
                transaction = new Transaction(userId, video);
                //first time see the video or review the video
                //save first step
                _unitOfWork.TransactionRepository.Add(transaction);
                _unitOfWork.Complete();
                
            }
            else
            {
                if (transactions.FirstOrDefault(x => !x.IsFinished) == null)
                {
                    transaction = new Transaction(userId, video);
                    //all transaction has finish, review the video from zéro
                    _unitOfWork.TransactionRepository.Add(transaction);
                    _unitOfWork.Complete();
                }
                else
                {
                    transaction = transactions.FirstOrDefault(x => !x.IsFinished);

                }
                
            }
            StepTransactionViewModel model = null;
            switch(transaction.CurrentStep.Name)
            {
                case "PreviewStep":
                    model = Mapper.Map<PreviewStepTransactionViewModel>(transaction);
                    break;
                case "ViewStep":
                    model = Mapper.Map<ViewStepTransactionViewModel>(transaction);
                    break;
                case "SubtitleStep":
                    model = Mapper.Map<SubtitleStepTransactionViewModel>(transaction);
                    break;
            }
            return model;
        }
    }
}