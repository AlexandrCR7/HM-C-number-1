System.Console.WriteLine("Введите первое число: ");
int i = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int x = int.Parse(Console.ReadLine());
if(i > x){
    System.Console.WriteLine("Максимальное число = " + i);
}
else{
    System.Console.WriteLine("Максимальное число = " + x);
}