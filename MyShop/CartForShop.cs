namespace MyShop;

public class CartForShop: ICartForShop
{
    public List<Product> Products = new List<Product>();
    
    public void AddToCart(Product product)
    {
        Products.Add(product);
    }

    public void RemoveFromCart(Product product)
    {
        Products.Remove(product);
    }

    public IReadOnlyList<Product> GetCart()
    {
        return Products;
    }
}