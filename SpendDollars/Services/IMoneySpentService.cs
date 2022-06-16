namespace SpendDollars.Services
{
    public interface IMoneySpentService
    {
        Dictionary<string, decimal> GetAverage();
        Dictionary<string, decimal> GetLatest();

    }
}
