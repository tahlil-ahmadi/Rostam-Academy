using System.Collections.Generic;
using Academy.Domain.Model.Classes;

namespace Academy.Application.Classes
{
    public interface IClassService
    {
        void Create(Class @class);
        void Delete(long id);
        List<Class> GetAll();
    }
}