/* 
    Çözümünüz bir do-while veya while yineleme içermelidir.

    Yineleme bloğundan önce: çözümünüz kullanıcıdan 5 ile 10 arasında bir tamsayı değeri istemesi için bir deyim kullanmalıdır Console.WriteLine() .

    Yineleme bloğunun içinde:

    Çözümünüz kullanıcıdan giriş almak için bir Console.ReadLine() deyimi kullanmalıdır.
    Çözümünüz girişin bir tamsayının geçerli bir gösterimi olduğundan emin olmalıdır.
    Tamsayı değeri 5 ile 10 arasında değilse, kodunuzun kullanıcıdan 5 ile 10 arasında bir tamsayı değeri istemesi için bir deyimi kullanması Console.WriteLine() gerekir.
    Çözümünüz yinelemeden çıkmadan önce tamsayı değerinin 5 ile 10 arasında olduğundan emin olmalıdır.
    Yineleme kodu bloğunun altında (sonra): çözümünüz kullanıcıya giriş değerinin kabul edildiğini bildirmek için bir Console.WriteLine() deyimi kullanmalıdır.

    Enter an integer value between 5 and 10
    two
    Sorry, you entered an invalid number, please try again
    2
    You entered 2. Please enter a number between 5 and 10.
    7
    Your input value (7) has been accepted.
*/

string? readStatus;
string value = "";
int number;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10. ");
do {
    readStatus = Console.ReadLine();

    if (readStatus != null) {
        value = readStatus; 
    }
    
    validNumber = int.TryParse(value, out number);

    if (validNumber == true) {
        if ((number <= 5) || (number >= 10)) {
            validNumber = false;
            Console.WriteLine($"You entered { number }. Please enter a number between 5 and 10.");
            
        } 
    } else {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }

} while (validNumber == false); Console.WriteLine($"Your input value ({ number }) has been accepted.");

readStatus = Console.ReadLine();
