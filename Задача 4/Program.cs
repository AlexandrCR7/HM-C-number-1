System.Console.WriteLine("Введите первое число: ");
int first = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int second = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите третье число: ");
int third = int.Parse(Console.ReadLine());

if(first > second && first > third){
        System.Console.WriteLine("Максимальное число " + first);
    }

else if(second > third){
    System.Console.WriteLine("Максимальное число " + second);
    }

else{
System.Console.WriteLine("Максимальное число " + third);
}