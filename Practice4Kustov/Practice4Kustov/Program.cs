using System;

namespace Practice4Kustov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Давайте создадим матрицу из случайных чисел желанного размера");

            Console.WriteLine("\nВведите кол-во строк:");
            int stroki = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов:");
            int stolbci = int.Parse(Console.ReadLine());
            Console.WriteLine("\nМАССИВ:");
            Random random = new Random();
            int sum = 0;
            int sumstr = 0;
            int[,] array = new int[stroki,stolbci];
            int[,] sumstl = new int[stroki, stolbci];
            
            for (int i=0; i < stroki; i++ )
            {
                for (int j = 0; j < stolbci; j++)
                {
                    array[i, j] = random.Next(10);
                    sum += array[i, j];
                    Console.Write($"{array[i, j]} ");
                    sumstr += array[i,j]; //сумма строк
                }
                Console.Write($"= {sumstr} ");
                sumstr = 0;
                Console.WriteLine();  
            }
            
            Console.WriteLine($"\nСумма всех чисел массива: {sum}");
            Console.ReadKey();



            Console.WriteLine("\nСоздадим последовательность из ваших чисел и найдем наименьшее число");

            Console.Write("\nВведите кол-во цифр:\t");
            int posled = int.Parse(Console.ReadLine());

            int[] massiv = new int[posled];
            
            for (int i = 0; i < massiv.Length; i++)
            {
                Console.Write($"\nВведите элемент массива {i+1}:\t");
                massiv[i] = int.Parse(Console.ReadLine());
            }
            int min = int.MaxValue;
            for (int i = 0; i < massiv.Length; i++)
            {
                Console.Write($" {massiv[i]}");
                if (massiv[i]<min)
                {
                    min = massiv[i];
                }
               
            }
            Console.WriteLine($" Минимум: {min}");
            Console.ReadLine();
            // По заданию в рекомендациях не очень понял как через именно Max.Value сделать, просто мне проще через MinValue, это минимальное число
            // И дальше при помощи if перебираю
            Random chislo = new Random();
            Console.WriteLine("Давай сыграем в игру 'Отгадай число'");
            Console.Write("\nНапиши число в пределах которого будешь отгадывать: \t");
            int predelDiap = int.Parse(Console.ReadLine());
            int Number = chislo.Next(0, predelDiap);
            int userNumber;
            string textUser;
            int count = 0;
            Console.WriteLine("Отгадайте число (введите):");
            while (true)
            {
                
                textUser = Console.ReadLine();
                if (textUser == "")
                {
                    Console.WriteLine($"Увы, было загадано: {Number} \nЧисло попыток: {count}");
                    Console.ReadKey();
                    break;
                }    
                userNumber = Convert.ToInt32(textUser);
                count++;
                if (userNumber < Number)
                {
                    Console.WriteLine("Число меньше загаданного, попробуйте еще:");
                }
                else if (userNumber > Number)
                {
                    Console.WriteLine("Число больше загаданного, попробуйте еще:");
                }
                else if (userNumber == Number)
                {
                    Console.WriteLine($"\nПоздравляю, ты угадал. УРАААА!!! \nЧисло попыток: {count}");
                    Console.ReadKey();
                    break;
                }
               
                

            }


        }
    }
}
