using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Academy.Domain.Model.Classes
{
    public interface IClassRepository
    {
        void Add(Class @class);
        void Delete(Class @class);
        Class GetClassById(long id);
        List<Class> GetAll();
    }
}
