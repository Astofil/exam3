Calculator calc=new Calculator(60,15);

calc.num1=Convert.ToDouble(Console.ReadLine());
calc.num2=Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("sum of num1 and num2: ");
System.Console.WriteLine(calc.Add());

System.Console.WriteLine("difference of num1 and num2: ");
System.Console.WriteLine(calc.Subtract());

System.Console.WriteLine("multiplication of numbers: ");
System.Console.WriteLine(calc.Multiply());

System.Console.WriteLine("division of numbers: ");
System.Console.WriteLine(calc.Divide());

