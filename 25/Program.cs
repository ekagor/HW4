// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

PrintInfo();
Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());
PrintResult();

void PrintInfo(){
    Console.WriteLine("Программа возводит число A в натуральную степень B");
}

int  NumberToPower(int a, int b){
    int result = 1;
    for (int i = 1; i <= b; i++){
        result = result * a;
    }
        return result;
}

void PrintResult(){
    Console.WriteLine($"Получим: {NumberToPower(a, b)}");
}