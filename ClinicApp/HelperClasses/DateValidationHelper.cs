using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.HelperClasses
{
    public class DateValidationHelper
    {
        public string FieldName { get; private set; }
        public string Message { get; private set; }
        public DateValidationHelper(string fieldName) {
            FieldName = fieldName;
        }

        public bool IsValid(DateTime? field)
        {
            switch (DateCheckHelper.CheckDateValidation(field))
            {
                case DateCheckHelper.Result.Empty:
                    Message = FieldName + " - обязательное поле для ввода.\n";
                    return false;
                case DateCheckHelper.Result.BelowMin:
                    Message = String.Format("{0} должна быть не раннее {1}.\n", FieldName, DateCheckHelper.MinDateTime.ToShortDateString());
                    return false;
                case DateCheckHelper.Result.AboveMax:
                    Message = FieldName + " не может быть в будущем.\n";
                    return false;
            }
            return true;
        }
    }
}
