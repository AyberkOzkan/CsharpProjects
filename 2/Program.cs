/*
Bir gün, dünyaca ünlü bir matematikçi, üç sayının gücüne dair bir bulmaca yaratmaya karar verdi. 
Matematikçi, bir hedef sayı belirledi ve insanlara, 
verilen bir sayı listesinden üç sayı seçerek bu hedef sayıya en yakın toplamı bulmaları görevini verdi. Ancak, bir kural koydu: 
eğer iki farklı üçlü toplamı hedef sayıya eşit derecede yakınsa, daha büyük olan toplamı seçmek gerekiyordu. 
Matematikçi bu bulmacayı, insanların sayılarla olan ilişkilerini test etmek ve onları daha etkin düşünmeye teşvik etmek için yaratmıştı.

Random 100 elemanlı 0-10 arasında bir dizi oluşturacaksın ve kullanıcıdan hedef sayı alıp problemi hikayeye göre çözeceksin.
*/
using System;
using System.Linq;

class Program{
    static void Main(){
        // Random 100 eleman
        
        Random random = new Random();
        int[] numbers = Enumerable.Range(0, 100).Select(n => random.Next(0, 11)).ToArray();

        // Hedef Sayıyı al
        Console.WriteLine("Hedef Sayıyı Giriniz: ");
        // int target = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        int target;

        if (!int.TryParse(input, out target) || target < 0 || target > 10){

            Console.WriteLine("Geçersiz giriş. Lütfen 0 ile 10 arasında bir tam sayı girin.");
            return;
        }
        //En yakın sayıyı bul
        int closestSum = int.MaxValue;
        int[] closestNumbers = new int[3];

        for (int i = 0; i < (numbers.Length - 2); i++){
            for (int j =  i + 1; j < (numbers.Length - 1); j++){
                for (int l = j + 1; l < numbers.Length; l++){
                        
                    int sum = numbers[i] + numbers[j] + numbers[l]; 
                    int d = Math.Abs(target - sum);
                    int m = Math.Abs(target - closestSum);

                    if (d < m || 
                        d == m &&
                            sum > closestSum)
                        {
                            closestNumbers[0] = numbers[i];
                            closestNumbers[1] = numbers[j];
                            closestNumbers[2] = numbers[l];
                            closestSum = sum;
                        }
                        
                    }
                    
                }
                
            }

        Console.WriteLine($"En yakın toplam: {closestSum}");
        Console.WriteLine($"Seçilen sayılar: {string.Join(", ", closestNumbers)}");
    }
}