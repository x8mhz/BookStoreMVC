using System.Collections.Generic;

namespace BookStore.Repositories.Contracts.Common
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

    }
}