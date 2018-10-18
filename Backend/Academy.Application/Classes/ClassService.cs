using System.Collections.Generic;
using Academy.Domain.Model.Classes;

namespace Academy.Application.Classes
{
    public class ClassService : IClassService
    {
        private readonly IClassRepository _repository;

        public ClassService(IClassRepository repository)
        {
            this._repository = repository;
        }
        public void Create(Class @class)
        {
            _repository.Add(@class);
        }

        public void Delete(long id)
        {
            var @class = _repository.GetClassById(id);
            if (!ClassIsNull(@class))
                _repository.Delete(@class);
        }

        private bool ClassIsNull(Class @class)
        {
            return @class == null;
        }
        public List<Class> GetAll()
        {
            return _repository.GetAll();
        }
    }
}