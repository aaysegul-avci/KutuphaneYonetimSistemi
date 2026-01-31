public interface IBorrowState
{
    void Next(BorrowContext context);
    string GetStateName();
}
