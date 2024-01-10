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
                    Console.WriteLine("Bir dil seçiniz/Select a language(E/T)");
                    string cev = Console.ReadLine().ToUpper();
                    Random rnd = new Random();
                    if (cev == "E")
                    {
                        ilk = "Enter the starting number:";
                        son = "Enter the ending number:";
                        c = "Enter the count of numbers:";

                    }
                    else
                    {
                        ilk = "Başlangıç sayısını giriniz:";
                        son = "Bitiş sayısı giriniz:";
                        c = "Sayı adeti gir:";
                    }

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
                                i--;
                                break;
                            }
                            else
                            {
                                numbers[i] = num;
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