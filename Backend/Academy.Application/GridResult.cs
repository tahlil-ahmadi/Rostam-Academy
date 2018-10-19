using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Application
{
    public class GridResult<T>
    {
        public List<T> Data { get; set; }
        public long Total { get; set; }
        public GridResult(List<T> data, long total)
        {
            Data = data;
            Total = total;
        }
    }
}
