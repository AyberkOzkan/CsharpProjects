/* 
    Yineleme deyiminin kod bloğu içinde 1 ile 100 arasında, satır başına bir sayı olan çıkış değerleri.
    Mevcut değer 3’e bölünebiliyorsa sayının yanındaki Fizz terimini yazdırın.
    Mevcut değer 5’e bölünebiliyorsa sayının yanındaki Buzz terimini yazdırın.
    Mevcut değer hem 3’e hem de 5’e bölünebiliyorsa sayının yanındaki FizzBuzz terimini yazdırın.

    1
    2
    3 - Fizz
    4
    5 - Buzz
    6 - Fizz
    7
    8
    9 - Fizz
    10 - Buzz
    11
    12 - Fizz
    13
    14
    15 - FizzBuzz
    16
    17
    18 - Fizz
    19
    20 - Buzz
    21 - Fizz
    22
    .
    .
    .
*/

for (int i = 1; i <= 100; i++) {

    if ((i % 3 == 0) && (i % 5 == 0)) {
        Console.WriteLine($"{i} - FizzBuzz");
    } else if (i % 3 == 0) {
        Console.WriteLine($"{i} - Fizz");
    } else if (i % 5 == 0) {
        Console.WriteLine($"{i} - Buzz");
    } else {
        Console.WriteLine($"{i} - ");
    }
    
}