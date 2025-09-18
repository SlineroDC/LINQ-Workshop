namespace LINQ_Practical_Project;

public class Sell
{
    public Guid Id { get; set; }
    public DateOnly DateSold { get; set; }
    public double PriceProduct { get; set; }
    public int Quantity { get; set; }
    public string? Seller { get; set; }
    public string? Buyer { get; set; }
    private string? WarrantyTime {get; set;}
}
