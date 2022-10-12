// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// ["Hello", "2", "world", ":-)"] → ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] → ["-2"]
// ["Russia", "Denmark", "Kazan"] → []

void PrintMassive(string[] massive)
{
    Console.Write("[" + string.Join(", ", massive) + "]");
    Console.WriteLine();
}

Console.Write("Введите кол-во строк будет в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
string[] firstMassive = new string[N];
for (int i = 0; i < firstMassive.Length; i++)
{
    Console.Write($"Введите значение в {i + 1}й строке массива: ");
    firstMassive[i] = Console.ReadLine();
}

string[] SelectionMassive(string[] massive)
{
    int count = 0;
    string[] newMassive = new string[massive.Length];
    foreach (string item in massive)
    {
        if (item.Length <= 3)
        {
            newMassive[count] = item;
            count++;
        }
    }
    Array.Resize(ref newMassive, count);
    return newMassive;
}

PrintMassive(firstMassive);
PrintMassive(SelectionMassive(firstMassive));