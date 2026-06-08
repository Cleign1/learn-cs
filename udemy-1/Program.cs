// See https://aka.ms/new-console-template for more information
// implicit conversion
int myInt;
myInt = 2147483647;
double myDouble;
myDouble = myInt;

Console.WriteLine(myInt);


// explicit conversion
long myLong = 3242343234324234323;
Console.WriteLine(myLong);
int myInt2 = (int)myLong;
Console.WriteLine(myInt2);

float myFloat = 3.14f;
myDouble = 112.1232132132312f;
myFloat = (float)myDouble;
Console.WriteLine(myFloat);