namespace PieShopApp.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}