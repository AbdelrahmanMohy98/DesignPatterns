namespace StatePattern.States
{
    public class OrderDeliverState : IOrderState
    {
        private readonly Order _order;

        public OrderDeliverState(Order order)
        {
            _order = order;
        }

        public void Cancel()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void Return()
        {
            _order.State = new OrderReturnState(_order);
        }

        public void Ship()
        {
            throw new NotImplementedException();
        }
    }
}
