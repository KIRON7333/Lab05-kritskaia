int dayNumber = 6;

switch (dayNumber)
{
    case 5 or 6 or 7:
        Console.WriteLine("Выходной");
        break;
    default:
        Console.WriteLine("Будний");
        break;
}

int score = 78;

switch (score)
{
    case >= 0 and <= 39:
        Console.WriteLine("Неудовлетворительно");
        break;
    case >= 40 and <= 59:
        Console.WriteLine("Удовлетворительно");
        break;
    case >= 60 and <= 79:
        Console.WriteLine("Хорошо");
        break;
    case >= 80 and <= 100:
        Console.WriteLine("Отлично");
        break;
    default:
        Console.WriteLine("Некорректный балл");
        break;
}


int temperature = 20;

string result = temperature switch {
    < 0 => "Мороз",
    >= 0 and <= 14 => "Прохладно",
    >= 15 and <= 24 => "Комфортно",
    >= 25 and <= 34 => "Жарко",
    >= 35 => "Очень жарко"
};


Console.WriteLine(result);

string role = "user";

string result = role switch {
    "admin" => "Полный доступ",
    "teacher" => "Доступ преподавателя",
    _ => "Ограниченный доступ"
};

Console.WriteLine(result);

int age = 20;
bool hasTicket = true;

switch (age)
{
    case >= 18 when hasTicket:
        Console.WriteLine("Вход разрешён");
        break;
    case >= 18:
        Console.WriteLine("Нет билета");
        break;
    default:
        Console.WriteLine("Возраст не подходит");
        break;
}

int month = 12;

string season = month switch {
    12 or 1 or 2 => "Зима",
    3 or 4 or 5 => "Весна",
    6 or 7 or 8 => "Лето",
    9 or 10 or 11 => "Осень",
    _ => "Неверный месяц"
};

Console.WriteLine(season);

int age = 25;

string ageCategory = age switch {
    < 0 => "Ошибка",
    >= 0 and <= 6 => "Ребёнок",
    >= 7 and <= 17 => "Подросток",
    >= 18 and <= 64 => "Взрослый",
    >= 65 => "Пенсионер"
};

Console.WriteLine(ageCategory);


string userRole = "admin";

string accessLevel = userRole switch {
    "admin" => "Полный доступ",
    "teacher" => "Доступ преподавателя",
    "user" => "Ограниченный доступ",
    _ => "Неизвестная роль"
};

Console.WriteLine(accessLevel);


int hour = 14;

string tariff = hour switch {
    >= 0 and <= 5 => "Ночной тариф",
    >= 6 and <= 9 => "Утренний тариф",
    >= 10 and <= 17 => "Дневной тариф",
    >= 18 and <= 23 => "Вечерний тариф",
    _ => "Некорректный час"
};

Console.WriteLine(tariff);

Console.WriteLine(tariff);

int number = 42;

string numberCategory = number switch {
    < 0 => "Отрицательное",
    1 or 2 or 3 => "Маленькое число",
    >= 0 and <= 9 => "Однозначное",
    >= 10 and <= 99 => "Двузначное",
    >= 100 => "Трёхзначное или больше"
};

Console.WriteLine(numberCategory);