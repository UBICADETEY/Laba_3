using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_3
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);
            
            int t, N;
            double X;
            t = Convert.ToInt32(Console.ReadLine());
            N = Convert.ToInt32(Console.ReadLine());
            X = Convert.ToDouble(Console.ReadLine());
            

            int i, stepen = 1, znam = 1;
            double chisl, Z;

            Z = 0;

            if(t==0)
                for(i =1;i<=N; i++)
                    if(i==1)
                    {
                        Z += 1 / (znam * (znam + 2));
                        znam++;
                    }
                    else
                    {
                        if (i == 2)
                        {
                            chisl = -Math.Pow(X, stepen);
                        }
                        else
                        {
                            if (i % 2 == 1)
                                chisl = Math.Pow(X, stepen);
                            else
                                chisl = -Math.Pow(X, stepen);

                        }

                        Z += chisl / (znam * (znam + 2));
                        znam++;
                        stepen++;
                    }
            if (t == 1)
            {
                i = 1;
                while (i <= N)
                {
                    if (i == 1)
                    {
                        Z += 1 / (znam * (znam + 2));
                        znam++;
                    }
                    else
                    {
                        if (i == 2)
                        {
                            chisl = -Math.Pow(X, stepen);
                        }
                        else
                        {
                            if (i % 2 == 1)
                                chisl = Math.Pow(X, stepen);
                            else
                                chisl = -Math.Pow(X, stepen);

                        }

                        Z += chisl / (znam * (znam + 2));
                        znam++;
                        stepen++;
                        i++;
                        
                    }
                }

            }
            if (t == 2)
            {
                i = 1;
                do
                {
                    if (i == 1)
                    {
                        Z += 1 / (znam * (znam + 2));
                        znam++;
                    }
                    else
                    {
                        if (i == 2)
                        {
                            chisl = -Math.Pow(X, stepen);
                        }
                        else
                        {
                            if (i % 2 == 1)
                                chisl = Math.Pow(X, stepen);
                            else
                                chisl = -Math.Pow(X, stepen);

                        }

                        Z += chisl / (znam * (znam + 2));
                        znam++;
                        stepen++;
                        i++;

                    }
                } while (i <= N);
            }
            Console.WriteLine(String.Format("{0:0.0000000}", Z));
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
        }
    }
}
