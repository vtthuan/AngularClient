using System;
using System.Globalization;

namespace AngularClient.Models
{
    public class SubtitleRecord
    {
        public int Identifier { get; set; }
        public double Start { get; set; }
        public double End { get; set; }
        public string PhraseLearning { get; set; }

        //public double ToStartSecond()
        //{
        //    var rs = 0d;
        //    var format = @"hh\:mm\:ss\,fff";
        //    var culture = CultureInfo.CurrentCulture;
        //    try
        //    {
        //        var interval = TimeSpan.ParseExact(this.Start, format, culture);

        //        return interval.TotalSeconds;
        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("'{0}': Bad Format for '{1}'", this.Start, format);
        //    }
        //    catch (OverflowException)
        //    {
        //        Console.WriteLine("'{0}': Overflow", this.Start);
        //    }
        //    return rs;
        //}
    
    }
}