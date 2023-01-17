namespace Taskkkk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Arrayin icindeki cut ededlerin ortalamasi
            //int[] numbers = { 24, 15, 17, 64, 10, 11 };

            //int sum = 0;
            //double count = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%2==0)
            //    {
            //        sum += numbers[i];
            //        count++;
            //    }
            //}
            //double avarage = sum/count;

            //Console.WriteLine(avarage);
            #endregion

            #region Array icinde en boyuk ededi tapmaq
            //int[] numbers = { 15, 25, 11, 9, 45, 28, 96 };
            //int max = numbers[0];
            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //    }

            //}
            //Console.WriteLine(max);

            #endregion

            #region Verilmis 3 ededin en boyuyunu tapmaq
            //Console.Write("1 ci ededi daxil edin : ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("2 ci ededi daxil edin : ");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.Write("3 cu ededi daxil edin : ");
            //int num3 = int.Parse(Console.ReadLine());

            //if (num1 >= num2 && num1 >= num3)
            //{
            //    Console.WriteLine($"En boyuk eded {num1}");
            //}
            //else if (num2 >= num1 && num2 >= num3)
            //{
            //    Console.WriteLine($"En boyuk ededn {num2}");
            //}
            //else
            //{
            //    Console.WriteLine($"En boyuk reqem {num3}");
            //}


            #endregion

            #region Verilmis 3 ededin en kiciyini tapin
            //Console.Write("1 ci ededi daxil edin : ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("2 ci ededi daxil edin : ");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.Write("3 cu ededi daxil edin : ");
            //int num3 = int.Parse(Console.ReadLine());

            //if (num1 <= num2 && num1 <= num3)
            //{
            //    Console.WriteLine($"En kicik eded {num1}");
            //}
            //else if (num2 <= num1 && num2 <= num3)
            //{
            //    Console.WriteLine($"En kicik ededn {num2}");
            //}
            //else
            //{
            //    Console.WriteLine($"En kicik reqem {num3}");
            //}

            #endregion

            #region Consoldan gelen ededleri arrayin icine elave eden alqoritma
            //int[] numbers = new int[6];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"{i+1} ci reqemi daxil edin : ");
            //    int getNumber = int.Parse(Console.ReadLine());
            //    numbers[i] = getNumber;


            //}
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            #endregion

            #region Arrayin icinde 3 bolunen reqemlerin ededi ortasini tapan alqoritma
            //int[] numbers = { 33, 10, 12, 64, 27, 11 };

            //int sum = 0;
            //double count = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        sum += numbers[i];
            //        count++;
            //    }
            //}
            //double avarage = sum / count;

            //Console.WriteLine(avarage);
            #endregion

            #region Arrayin icinde 3 reqemli eded olub olmadigini yoxlayan proqram
            int[] numbers = { 21, 123, 525, -456, -112, -65, 1000 };
            string numberStr;
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numberStr = Convert.ToString(numbers[i]);
                if (numberStr.Length == 3 && numberStr[0] != '-' || numberStr.Length == 4 && numberStr[0] == '-')
                {
                    count++;
                }
            }
            if (count != 0)
            {
                Console.WriteLine($"Arrayin icinde {count} dene 3 reqemli eded var");

            }
            else
            {
                Console.WriteLine("Arrayin icinde 3 reqemli eded yoxdur");
            }

            #endregion
        }
    }
}