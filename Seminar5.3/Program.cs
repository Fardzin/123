/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. Не использовать готовые методы Min и Max

[3 7 22 2 78] -> 76 */






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

int Dec(int [] array){
    int dec=0;
    int min = array[0];
    int max=array[0];
    for (int i=1; i<array.Length; i++){
        if (min>array[i])
           min= array[i];
        if (max<array[i])
            max=array[i];
    }
        dec=max-min;    
    return dec;
}

Console.WriteLine($"Разница макс и мин элементов массива равна: {Dec(array)}");
