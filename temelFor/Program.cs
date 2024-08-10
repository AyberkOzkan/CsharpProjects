for (int i = 0; i < 10; i++) {
    Console.WriteLine(i);
}
Console.WriteLine("---------------------");

for (int i = 10; i >= 0; i--) {
    Console.WriteLine(i);
}
Console.WriteLine("---------------------");

for (int i = 0; i < 10; i += 3) {
    Console.WriteLine(i);
}
Console.WriteLine("---------------------");

for (int i = 0; i < 10; i++) {
    Console.WriteLine(i);
    if (i == 7) break;
}
Console.WriteLine("---------------------");

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--) {
    Console.WriteLine(names[i]);
}
Console.WriteLine("---------------------");

// foreach (var name in names){
//     // Can't do this: Cannot assign to name because it is a 'foreach iteration variable'
//     if (name == "David") name = "Sammy";
// }
// Console.WriteLine("---------------------");

for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") names[i] = "Sammy";

foreach (var name in names) Console.WriteLine(name);
Console.WriteLine("---------------------");


for (int i = 0; i < names.Length; i++) {
    if (names[i] == "David") {
        names[i] = "Sammy";
    }
}

foreach (var name in names) {
    Console.WriteLine(name);
}
Console.WriteLine("---------------------");
