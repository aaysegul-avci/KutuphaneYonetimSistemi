
public class PendingState : IBorrowState
{
    public void Next(BorrowContext context)
    {
        context.SetState(new ApprovedState());
    }

    public string GetStateName() => "Beklemede";
}
