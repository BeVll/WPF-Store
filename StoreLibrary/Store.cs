namespace StoreLibrary;

public class Store
{
    public string Title { get; set; } = string.Empty;
    private List<Product> Products { get; set; } = new List<Product>();

    public Store(string title)
    {
        Title = title;
    }


    public List<Product> GetAllProducts()
    {
        return Products;
    }

    public Product? GetProductById(int id)
    {
        return Products.FirstOrDefault(p => p.Id == id);
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public void UpdateProduct(Product product)
    {
        var findProduct = Products.FirstOrDefault(p => p.Id == product.Id);

        var index = Products.IndexOf(findProduct);

        Products[index] = product;
    }

    
}