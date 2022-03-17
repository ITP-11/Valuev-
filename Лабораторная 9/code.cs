using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, amount = 0, amount1 = 0, k = 0, j = 0, f = 0, ff = 0, t = 0, del;


            Console.WriteLine("Введите кол-во разделов.");
            n = Convert.ToInt32(Console.ReadLine());

            int[,] A = new int[n,3];

            int[,] B = new int[3, 100];

            for (i=0; i< n; i++)
            {
                Console.WriteLine("Введите размер для {0}-го раздела",i+1);
                A[i, 0] = Convert.ToInt32(Console.ReadLine());
                amount = amount + A[i, 0];
            } 

            Console.Clear();
            while (k != 4)
            {
                    Console.WriteLine("Меню:");
                    Console.WriteLine("1. Добавить процесс");
                    Console.WriteLine("2. Удалить");
                    Console.WriteLine("3. Шаг");
                    Console.WriteLine("4. Выход");
                try
                {
                    k = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    k = 3;
                }
                switch (k)
                {
                    case 1:
                        {
                            B[0, j] = 0;
                            Console.WriteLine("Введите количество требуемой процессу памяти");
                            B[1, j] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите в какой раздел добавить");
                            B[2, j] = Convert.ToInt32(Console.ReadLine());
                            j++;
                            Console.Clear();

                            break;
                        }
                    case 2:
                        {
                            Console.Write(" Нажмите номер процесса которого вы хотите удалить");
                            try
                            {
                                del = Convert.ToInt32(Console.ReadLine());
                                try
                                {
                                    if (B[1, del] != 0 && B[2, del] != 0)
                                    {
                                        B[1, del] = 0;
                                        B[2, del] = 0;
                                        Console.Clear();
                                        Console.WriteLine("Процесс удалён");
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Такого процесса нет");
                                    }
                                }
                                catch (IndexOutOfRangeException)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Такого процесса нет");
                                }
                            }
                            catch(FormatException)
                            {
                                Console.Clear();
                            }
                            
                            

                            break;
                        }
                    case 3:
                        {

                            Console.Clear();

                            while (f < n)
                            {
                                while(ff == 0 && t < 100)
                                {

                                    if (B[2,t] == f+1 )
                                    {
                                        Console.Write("Раздел {0} размер  {1} необходимо памяти для р{2} {3}", f+1, A[f,0],t, B[1,t]);
                                        if(B[1,t] > A[f, 0])
                                        {
                                            Console.Write(" Отказано!!!");
                                            B[1, t] = 0;
                                        }
                                        Console.WriteLine();

                                        amount1 = amount1 + B[1, t];
                                        B[2, t] = 0;
                                        ff = 1;
                                    }

                                    t++;

                                    if (ff == 0 && t == 100)
                                    {
                                        Console.WriteLine("Раздел {0} размер  {1} нужно памяти для р  0", f + 1, A[f, 0]);
                                    }

                                }
                                t = 0;
                                ff = 0;
                                f++;
                            }
                            f = 0;
                            
                            Console.WriteLine("Объём памяти {0}",amount);
                            Console.WriteLine("Объём свободной памяти {0}", amount-amount1);
                            amount1 = 0;
                            break;
                        }
                    case 4:
                        {
                            break;
                        }
                }
            }
            Console.ReadKey();
        }
    }
}
