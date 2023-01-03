namespace Task1.Services
{
    public class ProductManagementService
    {
        public Task<bool> CreateProductAsync(DataModels.ProductModel pmodel)
        {
            try
            {
                FakeDatabase.products.Add(pmodel);
                return Task.FromResult(true);
            }
            catch (Exception)
            {
                return Task.FromResult(false);
            }
        }
        public Task<List<DataModels.ProductModel>> GetAllProductsAsync()
        {
            return Task.FromResult(FakeDatabase.products);
        }
        public Task<bool> DeleteProductAsync(Guid id)
        {
            try
            {
                FakeDatabase.products.Remove(FakeDatabase.products.Where(x => x.id == id).ToArray()[0]);
                return Task.FromResult(true);
            }
            catch (Exception)
            {
                return Task.FromResult(false);
            }
        }

    }
}
