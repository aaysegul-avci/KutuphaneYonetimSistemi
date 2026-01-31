public class BorrowContext
{
    public IBorrowState State { get; private set; }

    public BorrowContext()
    {
        State = new PendingState();
    }

    public void SetState(IBorrowState state)
    {
        State = state;
    }

    public void NextState()
    {
        State.Next(this);
    }
}
