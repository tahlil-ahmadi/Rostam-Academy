using System.Collections.Generic;

namespace Framework.Core.DataFiltering
{
    public class PagedResult<T>
    {
        public List<T> Data { get; set; }
        public long Total { get; set; }
        public PagedResult(List<T> data, long total)
        {
            Data = data;
            Total = total;
        }
    }
}
