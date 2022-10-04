// Colculator with four function
double a, b, c;
string op;
//while(true){
Console.WriteLine("Enter first num: ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("Please enter an operand (+, -, /, *): ");
op = Console.ReadLine();
Console.WriteLine("Enter second num: ");
b = Convert.ToDouble(Console.ReadLine());

switch(op)
{
    case "-":
    c = a - b;
    break;
    case "+":
    c = a + b;
    break;
     case "/":
    c = a / b;
    break;
     case "*":
    c = a * b;
    break;
     default:
     c = 0;
     break;
     
}
    Console.WriteLine("Our result is: " + c);
    //break;
//}
    

