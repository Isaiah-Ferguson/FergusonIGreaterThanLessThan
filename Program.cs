//Isaiah Keith Ferguson
//10/17/2022
//Greater Than or Less than


Console.Clear();
string answer = "";
double Validnum = 0;
double Validnum2 = 0;
bool Truth = true;
bool Truth2 = true;

while(answer != "end")
{
Console.WriteLine("This Program will be comparing 2 different numbers");
Console.WriteLine("Enter your 1st number:");

string num1 = Console.ReadLine();

Console.WriteLine("Enter your 2nd number:");

string num2 = Console.ReadLine();

Truth = double.TryParse(num1, out Validnum);
Truth2 = double.TryParse(num2, out Validnum2);

if((Truth != true) || (Truth2 != true)){
    Console.WriteLine("One of or both of your entries were not numbers.");
}
else if( Validnum > Validnum2)
{
    Console.WriteLine(Validnum + " is greater than " + Validnum2);
    Console.WriteLine(Validnum2 + " is Less than " + Validnum);
}
else if( Validnum < Validnum2 )
{
    Console.WriteLine(Validnum + " is Less than " + Validnum2);
    Console.WriteLine(Validnum2 + " is greater than " + Validnum);
}
else if(num1 == num2)
{
    Console.WriteLine(Validnum + " Is equal too " + Validnum2);
}
  Console.WriteLine("Type 'End' to terminate the program or press 'enter' to replay.");
    answer = Console.ReadLine().ToLower();
}
