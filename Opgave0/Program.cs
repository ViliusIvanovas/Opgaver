internal class Program
{
    private static void Main(string[] args)
    {
        # region calc1

        Calculator1 cal1 = new Calculator1();

        cal1.SetOpeandA(4.5);
        cal1.SetOpeandB(5.5);

        Console.WriteLine("Calculator 1");

        double result = cal1.Add();

        Console.WriteLine("add " + result);

        result = cal1.Subtract();

        Console.WriteLine("sub " + result);

        result = cal1.Multiply();

        Console.WriteLine("mul " + result);

        result = cal1.Divide();

        Console.WriteLine("div " + result);
        Console.ReadKey();

        #endregion

        #region calc2

        Console.WriteLine("Calculator 2");

        Calculator2 cal2 = new Calculator2();

        result = cal2.Add(4.5, 5.5);

        Console.WriteLine("add " + result);

        result = cal2.Subtract(4.5, 5.5);

        Console.WriteLine("sub " + result);

        result = cal2.Multiply(4.5, 5.5);

        Console.WriteLine("mul " + result);

        result = cal2.Divide(4.5, 5.5);

        Console.WriteLine("div " + result);
        Console.ReadKey();

        #endregion

        #region calc3

        Console.WriteLine("Calculator 3");

        result = Calculator3.Add(4.5, 5.5);

        Console.WriteLine("add " + result);

        result = Calculator3.Subtract(4.5, 5.5);

        Console.WriteLine("sub " + result);

        result = Calculator3.Multiply(4.5, 5.5);

        Console.WriteLine("mul " + result);

        result = Calculator3.Divide(4.5, 5.5);

        Console.WriteLine("div " + result);
        Console.ReadKey();

        #endregion
    }
}