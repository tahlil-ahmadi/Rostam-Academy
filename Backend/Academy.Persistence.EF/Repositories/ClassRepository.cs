using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Academy.Domain.Model.Classes;

namespace Academy.Persistence.EF.Repositories
{
    public class ClassRepository:IClassRepository
    {
        private readonly AcademyContext _context;

        public ClassRepository(AcademyContext context)
        {
            _context = context;
        }
        public void Add(Class @class)
        {
            _context.Add(@class);
            _context.SaveChanges();
        }

        public void Delete(Class @class)
        {
            _context.Remove(@class);
            _context.SaveChanges();
        }

        public Class GetClassById(long id)
        {
            return _context.Classes.FirstOrDefault(x => x.Id.Equals(id));
        }

        public List<Class> GetAll()
        {
            return _context.Classes.ToList();
        }
    }
}
