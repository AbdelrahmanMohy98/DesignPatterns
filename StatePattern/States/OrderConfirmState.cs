namespace StatePattern.States
{
    public class OrderConfirmState : IOrderState
    {
        private readonly Order _order;

        public OrderConfirmState(Order order)
        {
            _order = order;
        }

        public void Cancel()
        {
            _order.State = new OrderCancelState(_order);
        }

        public void Confirm()
        {
            throw new NotImplementedException();
        }

        public void Deliver()
        {
            throw new NotImplementedException();
        }

        public void Process()
        {
            _order.State = new OrderProcessState(_order);
        }

        public void Return()
        {
            throw new NotImplementedException();
        }

        public void Ship()
        {
            throw new NotImplementedException();
        }
    }
}
