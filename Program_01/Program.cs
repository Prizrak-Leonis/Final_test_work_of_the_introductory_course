// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// ["Hello", "2", "world", ":-)"] → ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] → ["-2"]
// ["Russia", "Denmark", "Kazan"] → []

void PrintMassive(string[] massive)
{
    Console.Write("[" + string.Join(", ", massive) + "]");
    Console.WriteLine();
}

string[] firstMassive = { "Hello", "2", "world", ":-)" };
int limitLength = 3;
int count = 0;
for (int i = 0; i < firstMassive.Length; i++)
{
    if (firstMassive[i].Length <= limitLength)
        count++;
}
string[] endMassive = new string[count];
int j = 0;
int k = 0;
while (j < endMassive.Length)
{
    if (firstMassive[k].Length <= limitLength)
    {
        endMassive[j] = firstMassive[k];
        j++;
    }
    k++;
}

PrintMassive(firstMassive);
PrintMassive(endMassive);