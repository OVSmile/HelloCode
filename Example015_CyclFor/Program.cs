string Method4(int count, string text) // Метод принимает и возвращает значение
{
    string result = String.Empty; // String.Empty указывает на то что строка пуста вместо ""
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(4, "Новый текст "); // Пример вызова метода.
Console.WriteLine(res);


for (int i = 2; i <= 10; i++)         // Цикл вывода таблицы умножения
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j}  = {i * j}");
    }
}

// ===== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками, 
// маленькие буквы "к" заменить на большие "К",
// большие "С" заменть маленькими "с".

string text = "- Я думаю, _ Сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие русского короля."
            + "Вы так красноречивы. Вы датите мне чаю?";    


// strimg s = "qwerty...."
//             012345....
// s[] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result += $"{newValue}"; 
        else result += $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
newText = Replace(newText, 'к', 'К');
newText = Replace(newText, 'С', 'с');

Console.WriteLine(newText);