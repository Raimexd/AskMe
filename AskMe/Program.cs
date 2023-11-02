
Random rnd = new Random();
int a;

while (true)
{

    Console.WriteLine("Спроси что угодно!");
    Console.ReadLine();

    a = rnd.Next(6);

    switch (a)
    {
        case 0:
            Console.WriteLine("Да!");
            Console.WriteLine("Нажми Enter, если не лох");
            Console.ReadLine();
            break;

        case 1:
            Console.WriteLine("Нет!");
            Console.WriteLine("Нажми Enter, если не лох");
            Console.ReadLine();
            break;

        case 2:
            Console.WriteLine("Возможно!");
            Console.WriteLine("Нажми Enter, если не лох");
            Console.ReadLine();
            break;

        case 3:
            Console.WriteLine("Я по вашему мнению должен это знать?!");
            Console.WriteLine("Нажми Enter, если не лох");
            Console.ReadLine();
            break;

        case 4:
            Console.WriteLine("Скорее да, чем нет!");
            Console.WriteLine("Нажми Enter, если не лох");
            Console.ReadLine();
            break;

        case 5:
            Console.WriteLine("Скорее нет, чем да!");
            Console.WriteLine("Нажми Enter, если не лох");
            Console.ReadLine();
            break;
    }

    Console.Clear();
}