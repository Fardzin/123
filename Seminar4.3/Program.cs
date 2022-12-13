//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.



int[] NewArray(){
Console.Write("Введите колличество чисел в массиве:\t");
int numbers = int.Parse(Console.ReadLine());

int[] array = new int[numbers];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"\n Введите число для заполнения массива {i}:\t");
    array[i] = int.Parse(Console.ReadLine());
    
}
Console.WriteLine("[{0}]", string.Join(", ", array));
return array;
}
 int[] resalt = NewArray();
 
