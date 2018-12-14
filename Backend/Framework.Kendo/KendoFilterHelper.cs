using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Framework.Core.DataFiltering;
using Kendo.Mvc.Extensions;

namespace Framework.Kendo
{
    public class KendoFilterHelper : IFilterHelper
    {
        public async Task<PagedResult<T>> ApplyAsync<T>(IQueryable<T> query, IFilter filter)
        {
            var kendoFilter = (KendoFilter) filter;
            var request = await query.ToDataSourceResultAsync(kendoFilter.Request);
            return new PagedResult<T>(request.Data as List<T>, request.Total);
        }
    }
}