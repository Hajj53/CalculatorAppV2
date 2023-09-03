// See https://aka.ms/new-console-template for more information
Console.WriteLine("Calculator App\n");

/*How to turn a string (string "45.80") into a number

int num = Convert.ToInt32("45");
Console.WriteLine(num + 6);
*/

Console.Write("Enter a number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter another number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num1 + num2);

