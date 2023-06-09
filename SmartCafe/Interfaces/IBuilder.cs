using System.Numerics;

namespace SmartCafe.Interfaces
{
    public interface IBuilder
    {
        public void setOrderNumber(int  orderNumber);
        public void setOrderState(bool state);
        public void setTableNumber(int tableNumber);
        public void setOrderTime(System.DateTime dateTime);
    }
}
