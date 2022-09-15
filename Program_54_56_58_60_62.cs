/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07

Задача со звездочкой. Написать функцию Sqrt(x) - квадратного корня, которая принимает на вход целочисленное значение x и возвращает целую часть квадратного корня от введенного числа.
Нельзя использовать встроенные функции библиотеки Math!

*/



double rnd_a_b (double a, double b) //Возвращает случайное вещественное число между a и b
{
  Random rand = new Random();
  return a + rand.NextDouble() * (b-a);
}
// Заполняет массив Rows х Columns случайными вещественными числами от a до b
void generate_rnd_m_n_double (ref double[,] A, ref int Rows, ref int Columns, ref double a, ref double b)
{
    A = new double [Rows, Columns];

    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Columns; j++)
        {
          A[i, j] = rnd_a_b (a,b);
        }
    }    
    return;
}
// Заполняет массив Rows х Columns случайными целыми числами от a до b
void generate_rnd_m_n_int (ref int[,] A, ref int Rows, ref int Columns, ref int a, ref int b)
{
    A = new int [Rows, Columns];

    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Columns; j++)
        {
          Random rand = new Random();  
          A[i, j] = rand.Next (a, b);
        }
    }    
    return;
}
//Выводит в консоли значения двумерного массива m x n
void console_write_m_n_double (double[,] A, int Rows, int Columns)
{
    for (int i = 0; i < Rows; i++)
    {
        Console.WriteLine($" ");
        for (int j = 0; j < Columns; j++)
        {
            Console.Write($" {A[i, j]}");
        }
    }    
    return;
} 
void console_write_m_n_int (int[,] A, int Rows, int Columns)
{
    for (int i = 0; i < Rows; i++)
    {
        Console.WriteLine($" ");
        for (int j = 0; j < Columns; j++)
        {
            Console.Write($" {A[i, j]}");
        }
    }    
    return;
} 
void console_write_m_n_int_3d (int[, ,] A, int Rows, int Columns, int z)
{
    for (int r=0; r<z; r++)
    {
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                Console.Write($" {A[i, j, r]}");
                Console.Write($" ({i}");
                Console.Write($",{j}");
                Console.Write($",{r}");
                Console.Write(") ");

            }
            Console.WriteLine();
        }    
        Console.WriteLine();
    }

    return;
}
//Проверка на непохожесть элементов
bool true_cifra(int ch, int[, ,] A, int r, int c, int z)
{
    for (int i=0; i<r; i++)
    {
        for (int j=0; j<c; j++)
        {
            for (int q=0; q<z; q++)
            {
                if (A[i,j,q] == ch) {return false;}
            }
        }
    }
    return true;
}

//-------------------------------------------------------------------------------------------------------------
Console.WriteLine("Введите номер задачи: 54, 56, 58, 60 или 62:");
int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{
//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
//двумерного массива.
case 54: 
    {
        Console.WriteLine("Введите число m:");
        Console.Write("m= "); int m = Convert.ToInt32(Console.ReadLine()); if (m<=2) {m=2;}
        Console.WriteLine("Введите число n:");
        Console.Write("n= "); int n = Convert.ToInt32(Console.ReadLine()); if (n<=2) {n=2;}
        Console.WriteLine("Введите вещественное число a:");
        Console.Write("a= "); int a = Convert.ToInt32(Console.ReadLine());           
        Console.WriteLine("Введите вещественное число b:");
        Console.Write("b= "); int b = Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine("Упорядочить по убыванию строки (1) или столбцы (0):");
        Console.Write("stroki= "); int stroki = Convert.ToInt32(Console.ReadLine());

        int[,] Array = null;
        generate_rnd_m_n_int (ref Array, ref m, ref n, ref a, ref b);
        console_write_m_n_int (Array, m, n); 
        Console.WriteLine();

    if (stroki == 0)
    {
        for (int j=0; j<n; j++)
        {
            for (int i1=0; i1<m; i1++)
            {
                for (int i2=0; i2<m-1; i2++)
                {
                  if (Array[i2,j] <= Array[i2+1,j]) {int old=Array[i2,j]; Array[i2,j]=Array[i2+1,j]; Array[i2+1,j]=old;}     
                }
            }    
        }
    } else {
        for (int i=0; i<m; i++)
        {
            for (int j1=0; j1<n; j1++)
            {
                for (int j2=0; j2<n-1; j2++)
                {
                  if (Array[i,j2] <= Array[i,j2+1]) {int old=Array[i,j2]; Array[i,j2]=Array[i,j2+1]; Array[i,j2+1]=old;}     
                }
            }    
        }
    }    
        console_write_m_n_int (Array, m, n); 

        break;    
    } //Zadacha 54

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
case 56:
    {
        Console.WriteLine("Введите число m:");
        Console.Write("m= "); int m1 = Convert.ToInt32(Console.ReadLine()); if (m1<=2) {m1=2;}
        Console.WriteLine("Введите вещественное число a:");
        Console.Write("a= "); int a1 = Convert.ToInt32(Console.ReadLine());           
        Console.WriteLine("Введите вещественное число b:");
        Console.Write("b= "); int b1 = Convert.ToInt32(Console.ReadLine());           

        int[,] Array1 = null;
        generate_rnd_m_n_int (ref Array1, ref m1, ref m1, ref a1, ref b1);
        console_write_m_n_int (Array1, m1, m1); 
        Console.WriteLine();

        int min = 2*b1*m1;
        int ch_min=0;
        int str=0;
        for (int i=0; i<m1; i++)
        {
            ch_min = 0;
            for (int j=0; j<m1; j++)
            {
                ch_min = ch_min + Array1 [i,j];    
            }
            if (ch_min <= min) {min = ch_min; str = i;}
        }
        
        Console.Write($"Минимальная сумма {min}");     
        Console.WriteLine($" в строке номер {str+1}");

        break;
    } //Zadacha 56

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. 
// m1 x n1 - размерность 1-й матрицы  m2 x n2 - размерность 2-й матрицы
case 58:
    {
        Console.WriteLine("Введите число m1:");
        Console.Write("m1= "); int m2 = Convert.ToInt32(Console.ReadLine()); if (m2<=2) {m2=2;}
        Console.WriteLine("Введите число n1:");
        Console.Write("n1= "); int n2 = Convert.ToInt32(Console.ReadLine()); if (n2<=2) {n2=2;}

        Console.WriteLine("Введите число m2:");
        Console.Write("m2= "); int m3 = Convert.ToInt32(Console.ReadLine()); if (m3<=2) {m3=2;}
        Console.WriteLine("Введите число n2:");
        Console.Write("n2= "); int n3 = Convert.ToInt32(Console.ReadLine()); if (n3<=2) {n3=2;}

        Console.WriteLine("Введите вещественное число a:");
        Console.Write("a= "); int a2 = Convert.ToInt32(Console.ReadLine());           
        Console.WriteLine("Введите вещественное число b:");
        Console.Write("b= "); int b2 = Convert.ToInt32(Console.ReadLine());   

        if (m2 != n3) {n3 = m2; Console.WriteLine("Матрица 2 скорректирована");}

        int[,] Array2 = null;
        generate_rnd_m_n_int (ref Array2, ref m2, ref n2, ref a2, ref b2);
        int[,] Array3 = null;
        generate_rnd_m_n_int (ref Array3, ref m3, ref n3, ref a2, ref b2);
        
/*
Проверка:

Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

        m2 = 2; 
        n2 = 2;
        Array2 = new int [m2, n2];
        Array2 [0,0] = 2;
        Array2 [0,1] = 4;
        Array2 [1,0] = 3;
        Array2 [1,1] = 2;

        m3 = 2;
        n3 = 2;
        Array3 = new int [m3, n3];
        Array3 [0,0] = 3;
        Array3 [0,1] = 4;
        Array3 [1,0] = 3;
        Array3 [1,1] = 3;
*/
        console_write_m_n_int (Array2, m2, n2);
        Console.WriteLine(); 
        console_write_m_n_int (Array3, m3, n3);
        Console.WriteLine();        

        int[,] Array4 = null;
        Array4 = new int [m3, n2];
        
        for (int i = 0; i<n2; i++)
        {
            for (int j = 0; j<m3; j++)
            {
                int ch = 0;
                for (int r=0; r<m2; r++)
                {
                    ch = ch + Array2[i,r] * Array3[r,j];
                }
                Array4[i,j] = ch;
            }        
        }

        console_write_m_n_int (Array4, m3, n2);  //Проверка произведена. Все работает!!!       
        
        break;
    } //Zadacha 58

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Размер массива: m x n x r
case 60:
    {
        Console.WriteLine("Введите число m:");
        Console.Write("m= "); int m4 = Convert.ToInt32(Console.ReadLine()); if (m4<=2) {m4=2;}
        Console.WriteLine("Введите число n:");
        Console.Write("n= "); int n4 = Convert.ToInt32(Console.ReadLine()); if (n4<=2) {n4=2;}
        Console.WriteLine("Введите число r:");
        Console.Write("r= "); int r4 = Convert.ToInt32(Console.ReadLine()); if (r4<=2) {r4=2;}

        if (m4*n4*r4 >= 100) {Console.WriteLine("Задача решения не имеет!");}

        int[, ,] Array4 = null;
        Array4 = new int [m4, n4, r4];
        int ch = 0;

        for (int i=0; i<m4; i++)
        {
            for (int j=0; j<n4; j++)
            {
                for (int r=0; r<r4; r++)
                {
                    do
                    {
                        Random rand = new Random();  
                        ch = rand.Next (10, 99);
                    } while (! (true_cifra(ch, Array4, i+1, j+1, r+1)) );  //Проверка на непохожесть значения

                    Array4[i,j,r] = ch;
                }
            }
        }

        console_write_m_n_int_3d (Array4, m4, n4, r4);

        break;
    } //Zadacha 60    

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
case 62:
    {
        
        Console.WriteLine("Введите число m:");
        Console.Write("m= "); int mm = Convert.ToInt32(Console.ReadLine()); if (mm<4) {mm=4;}

        int[,] Array5 = null;
        Array5 = new int [mm, mm];
        int move = 1;
        int ix=0; 
        int jx=0;
        int ch=1;
        Array5[ix,jx] = ch;

        do
        {
            ch++;
                if (move == 1) //left
                {
                    if (jx+1 < mm)
                    {
                        if (Array5[ix,jx+1]>0) {move=2;} else {jx++; Array5[ix,jx] = ch;} 
                    } else {move=2;}   
                }
                if (move == 2) //doun
                {
                    if (ix+1 < mm)
                    {
                        if (Array5[ix+1,jx]>0) {move=3;} else {ix++; Array5[ix,jx] = ch;}    
                    } else {move=3;} 
                }
                if (move == 3) //right
                {
                    if (jx > 0)
                    {
                        if (Array5[ix,jx-1]>0) {move=4;} else {jx--; Array5[ix,jx] = ch;}    
                    } else {move=4;} 
                }
                if (move == 4) //up
                {
                    if (ix > 0)
                    {
                        if (Array5[ix-1,jx]>0) {move=1; ch--;} else {ix--; Array5[ix,jx] = ch;}    
                    } else {move=1;} 
                }
                
        } while (ch<mm*mm);

        console_write_m_n_int (Array5, mm, mm);

        break;
    } //Zadacha 62

}