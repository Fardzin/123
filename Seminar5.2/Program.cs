/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/



Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int min =-100;
int max=100;  
int [] array = CreateArray(size, min, max);

ShowArray(array);

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

int Summ(int [] array){
    int summ=0;
    for (int i=0; i<array.Length; i++){
        if (i%2>0)
           summ+= array[i];
    }
    return summ;
}

Console.WriteLine($"Сумма чисел на нечётных позициях: {Summ(array)}");


