public class Caculator1
{
    private double _a;
    private double _b;

    public Caculator1()
    {

    }
    public void SetOpeandA(double a)
    {
        _a = a;
    }
    public void SetOpeandB(double b)
    {
        _b = b;
    }
    public double Add()
    {
        return _a + _b;
    }
    public double Subtract()
    {
        return _a - _b;
    }
    public double Multiply()
    {
        return _a * _b;
    }
    public double Divide()
    {
        return _a / _b;
    }
}