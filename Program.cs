// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string firstName = "Jeremy";
char middleInitial = 'B';
string lastName = "Fowler";


Console.WriteLine($"Hello, my full name is {firstName.ToUpper()} {middleInitial} {lastName}");


int num = 3;
double halfNum = 2.5;
double total = num + halfNum;
Console.WriteLine(total);


bool jeremyLikesCats = true;

if (jeremyLikesCats)
{
  Console.WriteLine("Of course this is true");
}

if (firstName != "Sam")
{
  Console.WriteLine("My name is not Sam");
}

if (total > 2)
{
  Console.WriteLine("Total was greater than 2");
}

int[] numbers = { 1, 2, 3, 4, 5 };

for (int i = 0; i < numbers.Length; i++)
{
  int number = numbers[i];
  Console.WriteLine(number);
}


List<string> names = new List<string>();

names.Add("Sam");
names.Add("Savnnah");
names.Add(firstName);
names.Add("Stinky");
names.Remove("Stinky");

foreach (string name in names)
{
  Console.WriteLine($"My name is {name}");
}
