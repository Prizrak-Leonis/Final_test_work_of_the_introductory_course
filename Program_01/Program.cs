// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// ["Hello", "2", "world", ":-)"] → ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] → ["-2"]
// ["Russia", "Denmark", "Kazan"] → []

void Print_massive(string[] massive)
{
    Console.Write("[ "+ string.Join(", ", massive) + " ]");
    Console.WriteLine();
}

string[] first_massive = { "Hello", "2", "world", ":-)" };
int count = 0;
for (int i = 0; i < first_massive.Length; i++)
{
    if (first_massive[i].Length <= 3)
        count++;
}
string[] end_massive = new string[count];
int j = 0;
int k = 0;
while (j < end_massive.Length)
{
    if (first_massive[k].Length <= 3)
    {
        end_massive[j] = first_massive[k];
        j++;
    }
    k++;
}

Print_massive(first_massive);
Print_massive(end_massive);