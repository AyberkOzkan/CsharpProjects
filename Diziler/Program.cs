/*string[] fraudulentOrderIDs = new string[3]; // 3 dediğimiz için en sondaki veriyi ekleyemeyiz. Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.       
                                             //    at Program.<Main>$(String[] args) in C:\Users\kenan\Desktop\CsharpProjects\Diziler\Program.cs:line 6

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";
*/

// int[] myarray = new int[3]; myarray[0] = 1; myarray[1] = 2; myarray[2] = 3;
string[] fraudulentOrderIDs = { "A123", "B456", "C789" };


Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000"; // yeniden atama

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");