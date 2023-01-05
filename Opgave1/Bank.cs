public class Bank
{
    private string _name;
    private string _address;
    private List<Account> _accounts;
    private List<ATM> _atms;

    public Bank(string name, string address)
    {
        _accounts = new List<Account>();
        _atms = new List<ATM>();

        _name = name;
        _address = address;
    }
    public void addAccount(Account account)
    {
        _accounts.Add(account);
    }
    public Account GetAccount(String accountNumber)
    {
        Account accId = null;

        foreach (var acc in _accounts)
        {
            if(acc.GetAccountId() == accountNumber)
            {
                accId = acc;
            }
        }

        return accId;
    }
    void UpdateAccount(Account account)
    {
        
    }
}