namespace SpendDollars.Services
{
    public interface IMoneySpentService
    {
        Dictionary<string, int> GetLatest();
        Dictionary<string, int> GetAverage();

    }
}
