// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.

// 1, 2, 5, 7, 19, 2, 4, 9 -> [1, 2, 5, 7, 19, 2, 4, 9 ]
// 6, 1, 33, 2, 93, 15, 424, 0-> [6, 1, 33, 2, 93, 15, 424, 0]

PrintInfo();
int lenght = 8;
int[] array = InputArray(lenght);
PrintArray(array);

void PrintInfo(){
    Console.WriteLine("Программа задает массив из 8 элементов и выводит их на экран");
}

int[] InputArray(int lenght){
    int[] array = new int[lenght];
    for (int i = 0; i < lenght; i++){
    Console.WriteLine($"Введите значение для элемента [{i}]: ");
    array[i] = int.Parse(Console.ReadLine());
    }
  return array;
}

void PrintArray(int[] array){
    for (int i = 0; i < lenght; i++){
        Console.Write($"{array[i]} ");
    }
 }
 




// int i;
// string[] str1;
// for(i=0;i</*кол-во строк*/;i++)
// str1[i] = Console.ReadLine();