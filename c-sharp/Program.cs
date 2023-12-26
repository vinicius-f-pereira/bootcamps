using System.Data;
using c_sharp.Models; // it's like a include in c lang.

Person person1 = new Person(); // it's like a function that returns a struct initialized.

person1.Name = "Thalia Franco Cardoso de Freitas";
person1.Age = 3;
person1.Greeting();

// some types to work with numbers.
int amount = 1;
double height = 1.80;
decimal price = 1.90M; // this is a good variable to work with currency or things that you need more precision in decimals.

Console.WriteLine("Amount \n" + amount);
Console.WriteLine("Height \n" + height.ToString("0.00")); // this is needed to print within full decimals.
Console.WriteLine("Price \n" + price);

// we have a type to work with data and time too.
DateTime dataNow =  DateTime.Now.AddDays(amount);
Console.WriteLine(dataNow);
dataNow =  DateTime.Now.AddDays(5);
Console.WriteLine(dataNow.ToString("dd/MM/yyyy"));
