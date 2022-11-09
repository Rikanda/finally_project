using System;
using System.Linq;
using System.Collections.Generic;

// создаются объекты классов для работы с первым и вторым массивами

First f = new First();
Second s = new Second();

// добавляем первую строку в первый массив
f.AddElements();

// добавляем произвольное количество строк в первый массив
while (true)
{
    Console.Write("Хотите добавить еще одну строку? (Y/n): ");
    string? ask = Console.ReadLine();
    if (ask!= null)
    {
        if (ask.ToLower() == "n")
        {
            break;
        }

        if (ask.ToLower() == "y")
        {
            f.AddElements();
        }
    }
}

Console.WriteLine("Исходный массив: [" + String.Join(", ", f.FirstArray) + "]");
Console.WriteLine("Формируем массив с записями длиной меньше или равно 3 символа...");
// формируем записи второго массива на основе первого в соответствии с условием задачи
s.AddElements(f.FirstArray);
Console.WriteLine("Сформированный массив: [" + String.Join(", ", s.SecondArray) + "]");

// класс для работы с первым массивом, строки которого вводятся через консоль
public class First
{
    public string[] FirstArray = { };
    public void AddElements()
    {
        Console.Write("Введите строку для добавления в массив: ");
        string? b = Console.ReadLine();
        if (b != null)
            FirstArray = FirstArray.Concat(new string[] { b }).ToArray();
    }
}

// класс для работы со вторым массивом, строки которого добавляются по условию задачи из первого массива
public class Second
{
    public string[] SecondArray = { };

    public void AddElements(string[] F)
    {
        if (F == null)
            return;

        for(int i = 0; i < F.Length; i++)
        {
            string b = F[i];
            if(b.Length<=3)
                SecondArray = SecondArray.Concat(new string[] { b }).ToArray();
        }
    }
}


