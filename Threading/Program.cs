using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        // Task.Run orqali asinxron ishni boshlang
        Task.Run(() => YourFunction("Salom, Task.Run dan!"));

        // Boshqa kodlar shu yerdan davom etishi mumkin
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Asosiy kod ishlayapti...");
            // Shu joyda kerakli boshqa amallarni bajara olishingiz mumkin
            System.Threading.Thread.Sleep(1000); // Uxlash amaliyoti (sinxron)
        }

        // YourFunction() tugaganidan so'ng, uni kuzatmasdan kod davom etadi
        Console.WriteLine("Programma tugadi.");
        Console.ReadLine(); // Foydalanuvchi interfeysini yopish uchun biror tugma o'zgartiring
    }

    static void YourFunction(string message)
    {
        // Bu funksiya asinxron bo'lib ishlaydi
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine(message);
    }
}
