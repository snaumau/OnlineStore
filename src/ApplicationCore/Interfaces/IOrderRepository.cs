using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
