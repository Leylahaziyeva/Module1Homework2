////1. Massivin cəmini tapın.

//Console.Write("Massivi daxil edin: ");
//int n = int.Parse(Console.ReadLine());
//int[] mass = new int[n];
//int sum = 0;

//for (int i = 0; i < n; i++)
//{
//    Console.Write("Massivi daxil edin: ");
//    mass[i] = int.Parse(Console.ReadLine());
//    sum += mass[i];
//}
//Console.WriteLine($"Massivin cemi: {sum}");

////2. Massivin elementləri arasında ortalamasını tapın.

//Console.Write("Massivi daxil edin: ");
//int n = int.Parse(Console.ReadLine());
//int[] mass = new int[n];
//int sum = 0;

//for (int i = 0; i < n; i++)
//{
//    Console.Write("Ededleri daxil edin: ");
//    mass[i] = int.Parse(Console.ReadLine());
//    sum += mass[i];
//}
//double average = (double)sum / n;
//Console.WriteLine("Massivin ortalaması: " + average);

////3. Massivdə müəyyən bir ədədin olub olmadığını yoxlayın.

//Console.Write("Massivi daxil edin: ");
//int n = int.Parse(Console.ReadLine());
//int[] mass = new int[n];
//bool isFind = false;

//for (int i = 0; i < n; i++)
//{
//    Console.WriteLine("Massivin {0}-cı elementini daxil edin: ", i + 1);
//    mass[i] = int.Parse(Console.ReadLine());
//}

//Console.WriteLine("Axtarılacaq ededi daxil edin:");
//int searchedNum = int.Parse(Console.ReadLine());

//for (int i = 0; i < n; i++)
//{
//    if (mass[i] == searchedNum)
//    {
//        isFind = true;
//        break;
//    }
//}
//if (isFind)
//{
//    Console.WriteLine($"{searchedNum} massivde tapıldı.");
//}
//else
//{
//    Console.WriteLine($"{searchedNum} massivde tapılmadı.");
//}

////4. Massivdəki ən kiçik və ən böyük ədədləri tapın.

//Console.Write("Massivi daxil edin: ");
//int n = int.Parse(Console.ReadLine());
//int[] mass = new int[n];
//mass[0] = int.Parse(Console.ReadLine()); 

//int min = mass[0];
//int max = mass[0];

//for (int i = 1; i < n; i++) 
//{
//    mass[i] = int.Parse(Console.ReadLine());
//}

//for (int i = 0; i < n; i++)
//{
//    if (mass[i] < min)
//    {
//        min = mass[i];
//    }
//    if (mass[i] > max)
//    {
//        max = mass[i];
//    }
//}
//Console.WriteLine("En kicik eded: " + min);
//Console.WriteLine("En boyuk eded: " + max);

////5. Massivdəki cüt ədədlərin cəmini tapın.

//Console.Write("Massivi daxil edin: ");
//int n = int.Parse(Console.ReadLine());
//int[] mass = new int[n];
//int sum = 0;

//for (int i = 0; i < n; i++)
//{
//    Console.WriteLine("Massivin {0}-cı elementini daxil edin: ", +i + 1);
//    mass[i] = int.Parse(Console.ReadLine());
//}

//for (int i = 0; i < n; i++)
//{
//    if (mass[i] % 2 == 0)
//    {
//        sum += mass[i];
//    }
//}
//Console.WriteLine("Cüt ededlerin cemi: " + sum);