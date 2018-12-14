using System.Linq;
using System.Threading.Tasks;

namespace Framework.Core.DataFiltering
{
    public interface IFilterHelper
    {
        Task<PagedResult<T>> ApplyAsync<T>(IQueryable<T> query, IFilter filter);
    }
}