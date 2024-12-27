namespace StatePattern.States
{
    public interface IOrderState
    {
        void Confirm();

        void Cancel();

        void Process();

        void Ship();

        void Deliver();

        void Return();
    }
}