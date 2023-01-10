#region  Array icindeki minimum elementi tapmaq
//int[] number = { 12, 24, 1, 16, 45, 17, 23 };
//int min = 0;
//for (int i = 1; i < number.Length; i++)
//{
//    if (number[i] < number[min])
//    {
//        number[min] = number[i];
//    }
//}
//Console.WriteLine($"En kicik reqem : {number[min]}");
#endregion

#region Arrayin uzunlugunu tapan alqoritma
//int[] number1 = { 12, 24, 1, 16, 45, 17, 23 };
//int count = 0;

//for (int i = 0; i < number1.Length; i++)
//{
//    count++;
//}
//Console.WriteLine($"Arrayin uzunlugu : {count}");
#endregion

#region 2 ededin EBOB unu tapan alqoritma
//int number1 = 24;
//int number2 = 18;

//int EBOB=0;


//for (int i = 1; i < number2; i++)
//{
//    if (number1 % i == 0 && number2 % i == 0)
//    {
//        EBOB = i;
//    }
//}
//Console.WriteLine($"{number1} ve {number2} - in en boyuk ortaq boluneni : {EBOB}");


#endregion

#region Verilen reqemin 2 usdunden derecesini tapan alqoritma
//Console.WriteLine("Zehmet olmasa reqem daxil edin : ");
//int reqem = int.Parse(Console.ReadLine());

//for (int i = 0; i < 50; i++)
//{
//    if (reqem == Math.Pow(2, i))
//    {
//        Console.WriteLine($"{reqem} reqeminin 2 usdunden derecesi {i}");

//    }
//    if (reqem!= Math.Pow(2,i))
//    {
//        Console.WriteLine("Daxil etdiyiniz reqem 2 usdunden derecesi yoxdur");
//        break;
//    }


//}
#endregion




#region Daxil edilen reqemin tersini yazan alqoritm
//Console.WriteLine("Reqem daxil edin");
//int reqem = int.Parse(Console.ReadLine());
//int r;
//int result = 0;
//while (reqem != 0)
//{
//r = reqem % 10;
//reqem = reqem / 10;
//    Console.Write(r);
//}

#endregion

#region Daxil edilən ədədnin rəqəmlərnin kublarının cəmini tapan alqoritm
//Console.WriteLine("Zehmet olmasa reqem daxil edin");
//int number = int.Parse(Console.ReadLine());
//int n = 0;
//double toplam = 0;

//while (number != 0)
//{
//n = number % 10;
//number = number / 10;
//toplam += Math.Pow(n, 3);
//}
//Console.WriteLine($"Ededin reqemlerin cemi {toplam}");




#endregion

#region Daxil edilən ədədin rəqəmlərindən ən böyük olanının sayını tapan alqoritm
Console.WriteLine("Zehmet olmasa 6 reqemli eded daxil edin :");
int number = int.Parse(Console.ReadLine());
int[] n = new int[6];
int i = 0;
while (number != 0)
{

    n[i] = number % 10;
    number = number / 10;
    i++;

}

int max = 0;
int count = 0;
for (int j = 1; j < n.Length; j++)
{
    if (n[j] > n[max])
    {
        n[max] = n[j];

    }
    if (n[j] == n[max])
    {
        count++;
    }

}
Console.WriteLine($"En boyuk reqem {n[max]}");
Console.WriteLine($"Eyni reqemlerin sayi {count}");


#endregion


#region MyRegion



int number = int.Parse(Console.ReadLine());

string s = Convert.ToString(number);
int count = 0;
for (int i = 0; i < s.Length; i++)
{
    count++;
}
if (count == 3)
{
    int result = (3000 + number) * 10 + 3;

    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Zehmet olmasa 3 reqemli eded daxil edin");
}



#endregion