/* 

    Deyimini do-while veya deyimini while bir dış oyun döngüsü olarak kullanmanız gerekir.
    Hem karakter hem de canavar oyuna 10 can puanıyla başlar.
    Tüm saldırılar 1 ila 10 arasında bir değere sahip olur.
    İlk saldırıyı karakter yapar.
    Canavarın kaybettiği can puanı ve kalan can puanı yazdırılır.
    Canavarın can puanı sıfırdan büyükse canavar karaktere saldırır.
    Karakterin kaybettiği can puanı ve kalan can puanı yazdırılır.
    Canavarın veya karakterin can puanı sıfıra veya altına düşene kadar bu saldırı dizisi devam eder.
    Kazanan taraf yazdırılır.
----------------------------------------------------------------------------------------------------------------
    Monster was damaged and lost 1 health and now has 9 health.
    Hero was damaged and lost 1 health and now has 9 health.
    Monster was damaged and lost 7 health and now has 2 health.
    Hero was damaged and lost 6 health and now has 3 health.
    Monster was damaged and lost 9 health and now has -7 health.
    Hero wins!
*/

int karakter = 10;
int canavar = 10;
Random dice = new Random();

do {
    // Önce karakter saldırıyor.
    int saldiri = dice.Next(1, 11);
    canavar -= saldiri;
    Console.WriteLine($"Karakter canavara saldırdı. Canavarın canı { saldiri } kadar düştü. Canavarın sağlığı { canavar }");

    if (canavar > 0) {
        saldiri = dice.Next(1, 11);
        karakter -= saldiri;
        Console.WriteLine($"Canavar karaktere saldırdı. Karakterin canı { saldiri } kadar düştü. Karakterin sağlığı { karakter }");
    }

} while ((karakter > 0) && (canavar > 0)) ; Console.WriteLine(karakter > canavar ? "Karakter Kazandı!" : "Canavar Kazandı!");
