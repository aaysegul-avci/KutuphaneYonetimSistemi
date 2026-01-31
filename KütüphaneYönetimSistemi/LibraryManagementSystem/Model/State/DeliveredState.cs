
public class DeliveredState : IBorrowState
{
    public void Next(BorrowContext context)
    {
        context.SetState(new ReturnedState());
    }

    public string GetStateName() => "Teslim Edildi";
}
