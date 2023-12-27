using System.Data;
using System.Formats.Asn1;
using System.Xml.Serialization;
using c_sharp.Models; // it's like a include in c lang.

Person person1 = new Person(); // it's like a function that returns a struct initialized.

person1.Name = "Thalia Pereira";
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
DateTime dataNow = DateTime.Now.AddDays(amount);
Console.WriteLine(dataNow);
dataNow = DateTime.Now.AddDays(5);
Console.WriteLine(dataNow.ToString("dd/MM/yyyy"));

/* ******************************** */

// Casting

/* int number = "5" */
long number = Convert.ToInt32("5");
// number = Convert.ToUInt16("5");
// number = Convert.ToInt64("5");
Console.WriteLine(number);
/**
* Some types can't be converted because don't fit in anothers.
* like try convert to int64 if the variable was declared as int (same as int32)
*/

/**
* We can use Parse too, but parse can fail if data is invalid. Parse will stop
* the program, while convert if receive a null input will
* return '0'. */

string test = Convert.ToString(5); /* not common way to convert */
test = number.ToString(); // better way to convert a number

Console.WriteLine(test);


/**
* implict casting as talked above, when a type fit in another type we can
* use a implicit casting. e.g. (int a = 5, double b = a).
 */

/**
* the best way to convert in c# (until now)
*/

string source = "15-";
int x = 0;

int.TryParse(source, out x);

Console.WriteLine(x);
Console.WriteLine("Conversion done successfully");

/* if and else statement are like in pure c lang. */

int stock = 10;
int salesAmount = 0;
bool enough = salesAmount > 0 && stock >= salesAmount;

Console.WriteLine($"Stock: {stock}");
Console.WriteLine($"Customer amount: {salesAmount}");
Console.WriteLine($"We have in stock?: {enough}");

if (salesAmount == 0)
	Console.WriteLine("Invalid amount");
else if (enough)
	Console.WriteLine("Sold");
else
	Console.WriteLine("Sorry, out of stock.");

/* switch case */

Console.WriteLine("Type a letter");
string letter = Console.ReadLine();

switch (letter)
{
	case "a":
	case "e":
	case "i":
	case "o":
	case "u":
		Console.WriteLine("Vowel");
		break;
	default:
		Console.WriteLine("Not Vowel");
		break;
}

