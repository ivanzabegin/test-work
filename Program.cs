// написать программу, которая из имеющегося массива строк формирует массив
// длина которых меньше, либо равна 3 символам. Первоначальный 
// массив строк задается с клавиатуры, либо задается вначале.

Console.Clear();

Console.Write("Количество слов");
int n = int.Parse(Console.ReadLine());

string[] wordsInArray = new string[n];

Console.WriteLine($"Введите слова {n}");
for (int i = 0; i < wordsInArray.Length; i++) wordsInArray[i] = Console.ReadLine();

int count = 0; 

foreach (var item in wordsInArray) 
    if (item.Length<=3) count++;

string[] finalArray = new string[count]; 

count=0;
for (int i = 0; i < wordsInArray.Length; i++) 
    if (wordsInArray[i].Length <= 3) 
    {
        finalArray[count] = wordsInArray[i]; 
        count++;
    }

Console.Write("Результат: ");
string str = string.Join(" ", finalArray);
Console.WriteLine($"{str}\n");



