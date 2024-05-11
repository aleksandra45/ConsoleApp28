using System;
using System.Collections.Generic;
using System.Threading;

class User
{
    public string Login { get; set; }
    public string Name { get; set; }
    public bool IsPremium { get; set; }
}

class Program
{
    static void Main()
    {
        List<User> users = new List<User>
        {
            new User { Name = "Иван", IsPremium = true },
            new User { Name = "Мария", IsPremium = false },
            new User { Name = "Алексей", IsPremium = true }
        };

        foreach (User user in users)
        {
            GreetUser(user);
            if(!user.IsPremium)
            {
                ShowAd();
            }
        }
    }

    static void GreetUser(User user)
    {
        Console.WriteLine("Привет, " + user.Name + "!");
    }

    static void ShowAd()
    {
        Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
        // Остановка на 1 с
        Thread.Sleep(1000);

        Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
        // Остановка на 2 с
        Thread.Sleep(2000);

        Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
        // Остановка на 3 с
        Thread.Sleep(3000);
    }
}