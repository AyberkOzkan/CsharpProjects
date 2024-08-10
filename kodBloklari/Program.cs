bool flag = true;
if (flag) {
    int value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

// Inside the code block: 10

Console.WriteLine("--------------------------------------");

bool flag2 = true;
if (flag2) {
    int value2 = 10;
    Console.WriteLine($"Inside the code block: {value2}");
}
// Console.WriteLine($"Outside the code block: {value2}");
// Program.cs(16,46): error CS0103: The name 'value2' does not exist in the current context
Console.WriteLine("--------------------------------------");

bool flag3 = true;
int value3;

if (flag3)
{
    // Console.WriteLine($"Inside the code block: {value3}");
    // Program.cs(25,49): error CS0165: Use of unassigned local variable 'value3'
}

value3 = 10;
Console.WriteLine($"Outside the code block: {value3}");
Console.WriteLine("--------------------------------------");


