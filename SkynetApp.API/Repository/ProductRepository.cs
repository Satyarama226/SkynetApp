using SkynetApp.API.Services;

namespace SkynetApp.API.Repository
{
    public class ProductRepository : IProductService
    {
        public string GetAllProducts()
        {
            return "delivered all products";
            //throw new NotImplementedException();
        }
    }
}
