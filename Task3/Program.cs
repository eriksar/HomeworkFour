/* 
Задача 29 Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
5 -> [1, 2, 5, 7, 19]; 3 -> [6, 1, 33] 
*/

int lenArray = ReadInt("Введите длинну массива: ");

int[] randomArray = new int[lenArray];
Random rnd = new Random();
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = rnd.Next(1,9);
    Console.Write(randomArray[i] + " ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}