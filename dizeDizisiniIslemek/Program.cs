/*

    çözümünüz, kodlama mantığınızın girişini göstermek için aşağıdaki dize dizisini kullanmalıdır:

    string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
    Çözümünüz, bir dize içindeki nokta karakterinin konumunu tutmak için kullanılabilecek adlı periodLocation bir tamsayı değişkeni bildirmelidir.

    Çözümünüz, dizideki her dize öğesini işlemek için kullanılabilecek bir dış foreach veya for döngü içermelidir. Döngülerin içinde işlenecek dize değişkeni olarak adlandırılmalıdır myString.

    Dış döngüde, çözümünüz değişkendeki IndexOf() ilk dönem karakterinin myString konumunu almak için sınıfının yöntemini String kullanmalıdır. Yöntem çağrısı şuna benzer olmalıdır: myString.IndexOf("."). Dizede nokta karakteri yoksa, -1 değeri döndürülür.

    Çözümünüz, değişkeni işlemek myString için kullanılabilecek bir iç do-while veya while döngü içermelidir.

    İç döngüde, çözümünüzün işlenen dizelerin her birinde yer alan her tümceyi ayıklaması ve görüntülemesi (konsola yazması) gerekir.

    İç döngüde çözümünüz nokta karakterini görüntülememelidir.

    İç döngüde, çözümünüz dize bilgilerini işlemek için , Substring() ve TrimStart() yöntemlerini kullanmalıdır Remove()

    I like pizza
    I like roast chicken
    I like salad
    I like all three of the menu choices

*/
string myString = "";
int index = 0;
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

for (int i = 0; i < stringsCount; i++) {
    myString = myStrings[i];
    index = myString.IndexOf(".");
    string mySentence;

    while (index != -1) {
        mySentence = myString.Remove(index);
        myString = myString.Substring(index + 1);
        myString = myString.TrimStart();
        index = myString.IndexOf(".");
        Console.WriteLine(mySentence);
    }
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}