using SmartCafe.Models;

namespace SmartCafe.Interfaces
{
    public interface IState
    {
        public void ShowOrderDetails(Order order);
    }
}
