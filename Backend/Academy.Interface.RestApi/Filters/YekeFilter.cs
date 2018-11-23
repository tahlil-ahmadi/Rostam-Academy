using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Academy.Interface.RestApi.Filters
{
    public class YekeFilter : IActionFilter
    {
        public const char ArabicYeChar = (char)1610;
        public const char PersianYeChar = (char)1740;

        public const char ArabicKeChar = (char)1603;
        public const char PersianKeChar = (char)1705;

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var data = context.ActionArguments;
            foreach (var item in data)
            {
                var value = item.Value;
                var properties = value.GetType()
                    .GetProperties()
                    .Where(a=>a.PropertyType == typeof(string))
                    .ToList();

                foreach (var propertyInfo in properties)
                {
                    var propertyValue = propertyInfo.GetValue(value).ToString();

                    propertyValue = propertyValue
                        .Replace(ArabicKeChar, PersianKeChar)
                        .Replace(ArabicYeChar, PersianYeChar);
                    propertyInfo.SetValue(value,propertyValue);
                }
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }
    }
}
