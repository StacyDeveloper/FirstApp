(string name, int age) anketa;
Console.WriteLine("Мое имя: Анастасия");
Console.WriteLine("Мой возраст: 28");
Console.Write("Введите ваше имя: \n");
anketa.name = Console.ReadLine();
Console.Write("Введите ваш возраст: \n");
anketa.age = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ваш рост: \n");
int height = int.Parse(Console.ReadLine());
Console.Write("Укажите вашу дату рождения: \n");
DateOnly date = DateOnly.Parse(Console.ReadLine());
Console.Write("Давайте проверим информацию: \n");
Console.WriteLine("Вас зовут {0}, Вам {1} лет, Ваш рост {2} см, Ваша дата рождения {3}", anketa.name, anketa.age, height, date);
Console.ReadKey();




