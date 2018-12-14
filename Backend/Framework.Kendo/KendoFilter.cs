using System;
using Framework.Core.DataFiltering;
using Kendo.Mvc.UI;

namespace Framework.Kendo
{
    public class KendoFilter : IFilter
    {
        public long Page => Request.Page;
        public long PageSize => Request.PageSize;
        public DataSourceRequest Request { get; set; }
        public KendoFilter(DataSourceRequest request)
        {
            this.Request = request;
        }
    }
}
