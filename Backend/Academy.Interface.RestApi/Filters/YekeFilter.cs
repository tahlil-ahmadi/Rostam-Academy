using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Academy.Interface.RestApi.Filters
{
    public class YekeFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var arguments = context.ActionArguments;
            foreach (var argument in arguments)
            {
                var obj = argument.Value;
                var properties = obj.GetType().GetProperties()
                    .Where(a => a.PropertyType == typeof(string))
                    .ToList();

                foreach (var propertyInfo in properties)
                {
                    var value = propertyInfo.GetValue(obj).ToString();

                    var desiredValue = $"??{value}??";
                    propertyInfo.SetValue(obj,desiredValue);
                }

            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }
    }
}
