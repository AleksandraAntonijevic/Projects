using Novo.Shared.DTO;

namespace Novo.Client.Services.CartServices
{
    public interface ICartService
    {
        event Action OnChange;
        int Count { get; set; }
        Task AddToCart(MyCartModel myCartModel);
        Task<List<CartModel>> GetCart();
        Task RemoveCartItem(int productId);
    }
}
