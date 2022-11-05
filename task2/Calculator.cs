public class Calculator
{
    private double num1;
    private double num2;
    public Calculator(double num1,double num2)
    {
        this.num1=num1;
        this.num2=num2;
    }
    public double Add()
    {
        return num1+num2;
    }
    public double Subtract()
    {
        if(num1>num2)
        {
            var p;
            p=num1;
            num1=num2;
            num2=num1;
        }
        return num2-num1; // abs();
    }
    public double Multiply()
    {
        return num1*num2;
    }
    public double Divide()
    {
        if(num1>num2)
        {
            var d;
            d=num1;
            num1=num2;
            num2=num1;
        }
        return num2/num1;
    }
}

