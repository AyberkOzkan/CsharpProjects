Console.WriteLine("a" == "a");  // True
Console.WriteLine("a" == "A");  // False
Console.WriteLine(1 == 2);      // False

string myValue = "a";
Console.WriteLine(myValue == "a");  // True
Console.WriteLine("---------------------------------------------------");

Console.WriteLine("a" != "a");  // False
Console.WriteLine("a" != "A");  // True
Console.WriteLine(1 != 2);      // True

string myValue2 = "a";
Console.WriteLine(myValue2 != "a");  // False
Console.WriteLine("---------------------------------------------------");

Console.WriteLine(1 > 2);   // False
Console.WriteLine(1 < 2);   // True
Console.WriteLine(1 >= 1);  // True
Console.WriteLine(1 <= 1);  // True
Console.WriteLine("---------------------------------------------------");

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox")); // True
Console.WriteLine(pangram.Contains("cow")); // False

// These two lines of code will create the same output

Console.WriteLine(pangram.Contains("fox") == false);    // False
Console.WriteLine(!pangram.Contains("fox"));            // False
Console.WriteLine("---------------------------------------------------");

int a = 7;
int b = 6;
Console.WriteLine(a != b); // output: True
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2); // output: False
Console.WriteLine("---------------------------------------------------");


int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;
// Console.WriteLine($"Discount: {discount}");
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");