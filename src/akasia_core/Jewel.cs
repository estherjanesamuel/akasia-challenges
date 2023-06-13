namespace akasia_core;

public class Jewel
{
    public JewelType JewelType { get; set; }
    public string JewelName { get;} 
    public string JewelDescription { get;}
    public int Quantity { get; set; }
    public decimal Price { get; set; }

}

public enum JewelType
{
    Ruby,
    Topaz,
    Permata
}