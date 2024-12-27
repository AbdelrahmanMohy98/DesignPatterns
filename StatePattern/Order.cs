using StatePattern.States;

namespace StatePattern
{
    public class Order
    {

        public Order()
        {
            State = new OrderDraftState(this);
        }

        
        public IOrderState State { get; internal set; }

        public List<OrderLine> OrderLines { get; set; } = new();


        public void Confirm()
        {
            State.Confirm();
        }

        public void Cancel()
        {
            State.Cancel();
        }

        public void Process()
        {
            State.Process();
        }

        public void Ship()
        {
            State.Ship();
        }

        public void Deliver()
        {
            State.Deliver();
        }

        public void Return()
        {
            State.Return();
        }

    }
}
