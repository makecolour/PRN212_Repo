using System;

class Account
{
    private int _amount;
    public int Amount
    {
        get => _amount;
        set
        {
            _amount = value;
            OnChangedAmount();
        }
    }

    private event EventHandler _onChangedAmount;
    public event EventHandler ChangedAmount
    {
        add
        {
            _onChangedAmount += value;
        }
        remove
        {
            _onChangedAmount -= value;
        }
    }

    private void OnChangedAmount()
    {
        if (_onChangedAmount != null)
        {
            _onChangedAmount(this, EventArgs.Empty);
        }
    }
}

//class Program
//{
//    public static void Main(string[] args)
//    {
//        Account account = new Account();
//        account.Amount = 100;
//        account.ChangedAmount += Account_ChangeAmount;
//        account.Amount = 200;
//        account.Amount = 300;
//        account.ChangedAmount -= Account_ChangeAmount;
//        Console.ReadLine();
//    }

//    private static void Account_ChangeAmount(object sender, EventArgs e)
//    {
//        Console.WriteLine("Amount changed");
//    }
//}




//class Account
//{
//    private int _amount;
//    public int Amount
//    {
//        get => _amount;
//        set
//        {
//            int _old = _amount;
//            _amount = value;
//            OnChangedAmount(_old, value);
//        }
//    }

//    private event EventHandler <MyEventArgs> _onChangedAmount;
//    public event EventHandler<MyEventArgs> ChangedAmount
//    {
//        add
//        {
//            _onChangedAmount += value;
//        }
//        remove
//        {
//            _onChangedAmount -= value;
//        }
//    }

//    private void OnChangedAmount(int old, int New)
//    {
//        if (_onChangedAmount != null)
//        {
//            _onChangedAmount(this, new MyEventArgs(old,New));
//        }
//    }

//}

//class MyEventArgs : EventArgs
//{
//    public int OldAmount { get; set; }
//    public int NewAmount { get; set; }

//    public MyEventArgs(int oldAmount, int newAmount)
//    {
//        OldAmount = oldAmount;
//        NewAmount = newAmount;
//    }   
//}

//class Using
//{
//    public static void Main(string[] args)
//    {
//        Account account = new Account();
//        account.Amount = 100;
//        Using u = new Using();
//        account.ChangedAmount += Account_ChangeAmount;
//        account.Amount = 200;
//        account.Amount = 300;
//        account.ChangedAmount -= Account_ChangeAmount;
//        Console.ReadLine();
//    }

//    private static void Account_ChangeAmount(object? sender, MyEventArgs e)
//    {
//        Console.WriteLine($"Amount changed from {e.OldAmount} to {e.NewAmount}");
//    }

//}