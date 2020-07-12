using ApplicationCore.Entities;
using System.Collections.Generic;

namespace ApplicationCore.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAll { get; }
    }
}
