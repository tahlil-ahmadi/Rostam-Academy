using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Core.DataFiltering
{
    public interface IFilter
    {
        long Page { get; }
        long PageSize { get; }
    }
}
