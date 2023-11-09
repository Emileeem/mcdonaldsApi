using System.Threading.Tasks;

namespace McDonaldsAPI.Services;

using Mod;

public interface IOrderRepository
{
    Task<string> CreateOrder(int storeId);
    Task CancelOrder(string orderId);
    Task<List<Product>> GetMenu(int orderId);
    Task<List<Product>> GetOrderItems(int orderId);
    Task AddItem(int orderId, int itemId);
    Task RemoveItem(int orderId, int itemId);
    tasl FinishOrder(int orderId);
    Task DeliveryOrder(int orderId);
}