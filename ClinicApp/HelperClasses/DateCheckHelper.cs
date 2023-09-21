using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.HelperClasses
{
    public static class DateCheckHelper
    {
        public enum Result
        {
            Ok = 0,
            Empty,
            BelowMin,
            AboveMax
        }

        public static readonly DateTime MinDateTime = System.Data.SqlTypes.SqlDateTime.MinValue.Value;

        public static Result CheckDateValidation(DateTime? date)
        {
            if (date == null)
            {
                return Result.Empty;
            }
            else if (date < MinDateTime)
            {
                return Result.BelowMin;
            }
            else if (date > DateTime.Now)
            {
                return Result.AboveMax;
            }
            else
            {
                return Result.Ok;
            }
        }
    }
}
