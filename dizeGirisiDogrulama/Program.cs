/* 

    Çözümünüz bir do-while veya while yineleme içermelidir.

    Yineleme bloğundan önce: çözümünüz kullanıcıdan üç rol adı istemesi için bir Console.WriteLine() deyim kullanmalıdır: Yönetici istrator, Manager veya User.

    Yineleme bloğunun içinde:

    Çözümünüz kullanıcıdan giriş almak için bir Console.ReadLine() deyimi kullanmalıdır.
    Çözümünüz, girilen değerin üç rol seçeneğinden biriyle eşleştiğinden emin olmalıdır.
    Çözümünüz, baştaki Trim() ve sondaki boşluk karakterlerini yoksaymak için giriş değerinde yöntemini kullanmalıdır.
    Çözümünüz büyük/küçük harf kullanımını yoksaymak için giriş değerinde yöntemini kullanmalıdır ToLower() .
    Girilen değer rol seçeneklerinden biriyle eşleşmiyorsa, kodunuzun kullanıcıdan geçerli bir giriş istemesi için bir Console.WriteLine() deyimi kullanması gerekir.
    Yineleme kodu bloğunun altında (sonra): Çözümünüz, kullanıcıya giriş değerinin kabul edildiğini bildirmek için bir Console.WriteLine() deyimi kullanmalıdır.

Enter your role name (Administrator, Manager, or User)
Admin
The role name that you entered, "Admin" is not valid. Enter your role name (Administrator, Manager, or User)
   Administrator
Your input value (Administrator) has been accepted.

*/

string? readRole;
string roleName = "";
bool entry = false;

do {
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readRole = Console.ReadLine();
    if (readRole != null) {
        roleName = readRole.Trim();
    }
    if ((roleName.ToLower() == "administrator") || (roleName.ToLower() == "manager") || (roleName.ToLower() == "user")) {
        
        entry = true;
    } else {

        Console.WriteLine($"The role name that you entered, \"{ roleName.ToLower() }\" is not valid. Enter your role name (Administrator, Manager, or User)");
    }

} while (entry == false); Console.WriteLine($"Your input value { roleName.ToLower() } has been accepted.");
readRole = Console.ReadLine();

