using System.Security.Cryptography;

namespace Gazi.ODEV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                {
                    string ilk, son, c;
                    Random rnd = new Random();
   
                        ilk = "Başlangıç sayısını giriniz:";
                        son = "Bitiş sayısı giriniz:";
                        c = "Sayı adeti gir:";
                    
                    

                    Console.WriteLine(ilk);
                    byte bas = byte.Parse(Console.ReadLine());
                    Console.WriteLine(son);
                    byte bit = byte.Parse(Console.ReadLine());
                    Console.WriteLine(c);
                    byte count = byte.Parse(Console.ReadLine());


                    int[] numbers = new int[count];
                    int num;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        num = rnd.Next(bas,bit);
                        if (i == 0)
                        {
                            numbers[i] = num;
                        }
                        for (int j = 0; j < i; j++)
                        {
                            if (numbers[j] == num)
                            {
                                
                                break;
                            }
                           
                        }
                    }
                    Array.Sort(numbers);
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        Console.WriteLine(numbers[i]);
                    }

                }
            }
        }
    }
}