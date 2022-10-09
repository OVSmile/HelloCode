// Вид 1
void method1()                         // Метод ничего не возвращает и не принимает (в примере использование методо для указания афторства) 
{
    Console.WriteLine("Автор Олег");
}
method1();                             // Пример вызова метода.



// Вид 2
void Method2(string msg)               // Метод ничего не возвращает, но может принимать аргуметы, например сообщение
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");            // Пример вызова метода.

void Method2_1(string msg, int count)  // Метод принимает несколько аргументов, которые можно использовать в теле метода
{
    int i = 0;
    while (i < count) // Второй аргумент (count) использован как колличество повторений Первого аргумента (msg)
    {
        Console.WriteLine(msg);
        i++; // увеличение переменной называют Инкримент, уменьшение Декримент
    }
}
Method2_1("Текст", 3);                  // Пример вызова метода.
Method2_1(count: 3, msg: "Текст2");     // Пример вызова метода. При использовании именованных аргументов, не обязательно писать их по порядку.


// Вид 3

int Methot3()                          // Метод ничего непринимает, но возвращает значение
{
    return DateTime.Now.Year; // DateTime.Now.Year (Year, Month, Hour, Minute, Second)
}

int year = Methot3();
Console.WriteLine(year);               // Пример вызова метода.


// Вид 4

string Method4(int count, string text) // Метод принимает и возвращает значение
{
    int i = 0;
    string result = String.Empty; // String.Empty указывает на то что строка пуста вместо ""
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(4, "Новый текст "); // Пример вызова метода.
Console.WriteLine(res);