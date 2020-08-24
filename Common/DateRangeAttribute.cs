using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;

namespace _08202020_Lab21Lab25.Common
{
    public class DateRangeAttribute : RangeAttribute
    {
       public DateRangeAttribute(string minimumDate) : base(typeof(DateTime), minimumDate, DateTime.Now.ToShortDateString())
        {

        }
    }
}
