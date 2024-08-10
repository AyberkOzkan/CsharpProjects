    Yerel topluluğu desteklemeyi seven bir geliştirici olduğunuzu varsayalım. Siz ve bazı arkadaşlarınız başıboş veya terk edilmiş kedi ve köpekler için yeni evler bulmaya yardımcı olan bir iş başlattınız. İşletmeniz küçük bir başlangıç yaptı, sadece birkaç başıboşla, ama büyümeye başladı. Bakımınızdaki hayvanları evcil hayvan arayan kişilerle eşleştirmenize yardımcı olacak bir uygulama oluşturmak istiyorsunuz. Olası sahiplerle paylaşmak için hayvanların ayrıntılı bir açıklamasının bulunmasının önemli olduğunu fark ettiniz. Buna ek olarak, köpeğin veya kedinin kişiliğini tarif edebilmek, potansiyel sahiplere daha çekici hale getirir. Önem vermekte olduğunuz köpekler ve kediler hakkındaki bilgileri yönetmenize yardımcı olacak bir uygulama oluşturmaya karar verirsiniz.

    Bu modül, Contoso Pets uygulamasının veri merkezli özelliklerini geliştirme sürecinde size yol gösterir. Örnek veriler oluşturmak, bakımınızdaki hayvanları listelemek ve işletmenize yeni hayvanlar eklemek için seçim ve yineleme deyimlerini kullanacaksınız. Uygulama genelinde kod dallarının yürütülmesini denetlemek için değişkenleri ve ifadeleri kullanacaksınız. Ayrıca değişkenlerin uygun şekilde kapsamının belirlenmiş olduğundan da emin olursunuz.

    Geliştirdiğiniz uygulama:

    Pets dizisine önceden tanımlanmış örnek veriler ekleyin.
    Uygulamanızın dış döngüsünü oluşturmak için "menü seçenekleri ve kullanıcı seçimi" kod bloğunu yineleyin.
    Kullanıcının menü seçimlerine karşılık gelen kod dallarını uygulayın.
    Evcil hayvan verilerini depolamak için kullanılan dizide yer alan tüm bilgileri görüntüleyin (kullanıcının menü seçimine göre).
    Kullanıcının evcil hayvan dizisine bir veya daha fazla yeni hayvan eklemesine olanak tanıyan bir "yeni hayvan bilgisi ekle" kod bloğunu yineleyin (kullanıcının menü seçimine göre).

```c#
// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    if (i == 0)
    {
        animalSpecies = "dog";
        animalID = "d1";
        animalAge = "2";
        animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
        animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
        animalNickname = "lola";
    }
    else if (i == 1)
    {
        animalSpecies = "dog";
        animalID = "d2";
        animalAge = "9";
        animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
        animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
        animalNickname = "loki";
    }
    else if (i == 2)
    {
        animalSpecies = "cat";
        animalID = "c3";
        animalAge = "1";
        animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
        animalPersonalityDescription = "friendly";
        animalNickname = "Puss";
    }
    else if (i == 3)
    {
        animalSpecies = "cat";
        animalID = "c4";
        animalAge = "?";
        animalPhysicalDescription = "";
        animalPersonalityDescription = "";
        animalNickname = "";
    }
    else
    {
        animalSpecies = "";
        animalID = "";
        animalAge = "";
        animalPhysicalDescription = "";
        animalPersonalityDescription = "";
        animalNickname = "";
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

// display the top-level menu options

Console.Clear();

Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
Console.WriteLine(" 1. List all of our current pet information");
Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
Console.WriteLine(" 5. Edit an animal’s age");
Console.WriteLine(" 6. Edit an animal’s personality description");
Console.WriteLine(" 7. Display all cats with a specified characteristic");
Console.WriteLine(" 8. Display all dogs with a specified characteristic");
Console.WriteLine();
Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

readResult = Console.ReadLine();
if (readResult != null)
{
    menuSelection = readResult.ToLower();
}

Console.WriteLine($"You selected menu option {menuSelection}.");
Console.WriteLine("Press the Enter key to continue");

// pause code execution
readResult = Console.ReadLine();
```
    Bu alıştırmada Starter projesindeki kodu gözden geçirecek, bazı kod temizleme görevleri gerçekleştirecek ve ardından uygulamanıza özellik eklemeye başlayacaksınız. Bu alıştırma sırasında tamamladığınız görevler şunlardır:

    Kod incelemesi: Program.cs dosyasının içeriğini gözden geçirin.
    Örnek veriler: if-elseif-else yapısını okunabilirliği geliştiren anahtar-durum yapısına dönüştürün.
    Menü döngüsü: Ana menü ve menü öğesi seçimini, kullanıcı "çıkış" girene kadar yineleyen bir döngü içine alın.
    Menü seçimleri: Her menü seçeneği için ayrı kod dalları oluşturan bir anahtar-servis talebi yapısının kodunu yazın.
    Kod dalları: Uygulama özellikleri geliştirilene kadar kullanıcı geri bildirimi sağlayan menü öğesi dallarına yer tutucu yazın.
    Doğrulama testi: Bu alıştırmada geliştirdiğiniz kod için doğrulama testleri gerçekleştirin.