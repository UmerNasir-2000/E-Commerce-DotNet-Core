using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;

namespace Infrastructure.Interfaces
{
    public interface IProductInterface
    {
        Task<Product> GetProductByIdAsync(int id);

        Task<IReadOnlyList<Product>> GetProductsAsync();
    }
}