namespace StoreLibrary;

public class Product
{
    public long Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string? Description { get; set; } 
    public ProductType Type { get; set; }

    public override string ToString()
    {
       return $"{Title} - {Price:C}";
    }
}
