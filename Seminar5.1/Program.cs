/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/


int [] CreateArray(int size, int min, int max){
    int []array=new int[size];
    for(int i=0; i<size; i++){
        array[i]= new Random().Next(min, max);
}
    return array;
}

void ShowArray(int [] array){
    for (int i=0; i<array.Length; i++){
        Console.Write($"{array[i]} ");
    }
        Console.WriteLine();
}

int EvenNumb(int [] array){
    int evens=0;
    for (int i=0; i<array.Length; i++){
        if (array[i]%2==0)
            evens++;
    }
    return evens;
}
Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int min =100;
int max=1000;  
int [] array = CreateArray(size, min, max);

ShowArray(array);

Console.WriteLine($"Число четных чисел в массиве равно: {EvenNumb(array)}");