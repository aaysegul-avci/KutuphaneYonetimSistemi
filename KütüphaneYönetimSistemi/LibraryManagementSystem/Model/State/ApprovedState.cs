
public class ApprovedState : IBorrowState
{
    public void Next(BorrowContext context)
    {
        context.SetState(new DeliveredState());
    }

    public string GetStateName() => "Onaylandı";
}
