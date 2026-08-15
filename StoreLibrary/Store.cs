namespace StoreLibrary;

public class Store
{
    public string Title { get; set; } = string.Empty;
    private List<Product> Products { get; set; } = new List<Product>();
}