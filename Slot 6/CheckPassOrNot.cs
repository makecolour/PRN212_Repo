using System;

class Caculate
{
    private int _toan;
    private int _li;
    private int _hoa;

    public int Toan
    {
        get => _toan;
        set
        {
            int oldToan = _toan;
            _toan = value;
            OnChangedTotal(_toan, _li, _hoa);
        }
    }

    public int Li
    {
        get => _li;
        set
        {
            int oldLi = _li;
            _li = value;
            OnChangedTotal(_toan, _li, _hoa);
        }
    }

    public int Hoa
    {
        get => _hoa;
        set
        {
            int oldHoa = _hoa;
            _hoa = value;
            OnChangedTotal(_toan, _li, _hoa);
        }
    }

    private event EventHandler<MyEventArgs> _onChangedTotal;
    public event EventHandler<MyEventArgs> ChangedTotal
    {
        add
        {
            _onChangedTotal += value;
        }
        remove
        {
            _onChangedTotal -= value;
        }
    }

    private void OnChangedTotal(int toan, int li, int hoa)
    {
        _onChangedTotal?.Invoke(this, new MyEventArgs(toan, li, hoa));
    }

    public double CalculateAverage()
    {
        return (Toan + Li + Hoa) / 3.0;
    }
}

class MyEventArgs : EventArgs
{
    public int Toan { get; set; }
    public int Li { get; set; }
    public int Hoa { get; set; }

    public MyEventArgs(int toan, int li, int hoa)
    {
        Toan = toan;
        Li = li;
        Hoa = hoa;
    }
}

//class Program
//{
//    public static void Main(string[] args)
//    {
//        Caculate caculate = new Caculate();
//        caculate.ChangedTotal += Caculate_ChangedTotal;

//        caculate.Toan = 90;
//        caculate.Li = 80;
//        caculate.Hoa = 85;

//        Console.WriteLine($"Average Score: {caculate.CalculateAverage()}");
//        Console.ReadKey();
//        Console.ReadLine();
//    }

//    private static void Caculate_ChangedTotal(object sender, MyEventArgs e)
//    {
//        Console.WriteLine($"Scores updated: Toan = {e.Toan}, Li = {e.Li}, Hoa = {e.Hoa}");
//    }
//}
