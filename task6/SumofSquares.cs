public class SumOfSquares
{
    public double num1;
    public double num2;
    public double num3;
    public SumOfSquares(double num1, double num2, double num3)
    {
        this.num1=num1;
        this.num2=num2;
        this.num3=num3;
    }
    public double SquareSum()
    {
        return num1*num1+num2*num2+num3*num3;
    }
}