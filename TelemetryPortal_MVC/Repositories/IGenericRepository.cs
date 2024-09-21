using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TelemetryPortal_MVC.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(Guid id);
        Task Add(T entity);
        void Update(T entity);
        Task Delete(Guid id);
    }
}

