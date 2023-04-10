System.Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
while(i <= N){
     if(i % 2 == 0)
     System.Console.Write(i + ", ");
     i++;
}