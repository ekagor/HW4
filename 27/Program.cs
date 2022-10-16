// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

PrintInfo();
Console.Write("Введите число A: ");
int number = int.Parse(Console.ReadLine());
int length = NumberLenght(number);
PrintResult();

void PrintInfo(){
    Console.WriteLine("Программа принимает на вход число и выдаёт сумму цифр в числе");
}

int NumberLenght(int a){ 
    int i = 0; 
    while (a > 0) 
    { 
        a /= 10; 
        i++; } 
        return i; 
} 

 int SumNumbers(int n, int len){ 
    int sum = 0; 
    for (int i = 1; i <= len; i++){ 
        sum += n % 10; 
        n /= 10; 
    } 
    return sum; 
}

void PrintResult(){
    Console.Write($"Сумма цифр в числе: {SumNumbers(number, length)}");
}