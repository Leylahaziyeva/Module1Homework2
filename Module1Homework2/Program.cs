////1. Massivin cəmini tapın.

//Console.Write("Massivi daxil edin: ");
//int n = int.Parse(Console.ReadLine());
//int[] mass = new int[n];
//int sum = 0;

//for (int i = 0; i < n; i++)
//{
//    Console.Write("Massivin elementini daxil edin: ");
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
//    Console.Write("Massivin elementini daxil edin: ");
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
//    Console.WriteLine("Massivin {0}-cı elementini daxil edin: ", i + 1);
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

////6. Massivi tərsinə dövr etməklə yeni massiv yaradın.

//Console.Write("Massivi daxil edin: ");
//int n = int.Parse(Console.ReadLine());
//int[] mass = new int[n];

//for (int i = 0; i < n; i++)
//{
//    Console.Write("Massivin elementini daxil edin: ");
//    mass[i] = int.Parse(Console.ReadLine());
//}

//int[] reversedMass = new int[n];

//for (int i = 0; i < n; i++)
//{
//    reversedMass[i] = mass[n - 1 - i];
//}
//Console.Write("Tersine çevrilmiş massiv:");
//for (int i = 0; i < n; i++)
//{
//    Console.Write(reversedMass[i] + " ");
//}

////7. Massivdəki ən böyük iki ədədi tapın.

//Console.Write("Massivi daxil edin: ");
//int n = int.Parse(Console.ReadLine());
//int[] mass = new int[n];

//int firstBiggerDigit = int.MinValue; //En kicik mumkun tam eded deyeridir. En kicik ededler ile muqayise etmeye icaze verir.
//int secondBiggerDigit = int.MinValue;

//for (int i = 0; i < n; i++)
//{
//    Console.Write("Massivin elementini daxil edin: ");
//    mass[i] = int.Parse(Console.ReadLine());
//}

//for (int i = 0; i < n; i++)
//{
//    if (mass[i] > firstBiggerDigit)
//    {
//        secondBiggerDigit = firstBiggerDigit;
//        firstBiggerDigit = mass[i];
//    }
//    else if (mass[i] > secondBiggerDigit && mass[i] != firstBiggerDigit)
//    {
//        secondBiggerDigit = mass[i];
//    }
//}
//Console.WriteLine($"Birinci en böyük eded: {firstBiggerDigit}");
//Console.WriteLine($"İkinci en böyük eded: {secondBiggerDigit}");

///8. Massivin bütün elementlərinin 2 qatını tapın və yeni massiv yaradın.

//Console.Write("Massivi daxil edin: ");
//int originalMassLength = int.Parse(Console.ReadLine()); 
//int[] mass = new int[originalMassLength];

//for (int i = 0; i < originalMassLength; i++)
//{
//    Console.WriteLine("Massivin {0}-cı elementini daxil edin: ", i + 1);
//    mass[i] = int.Parse(Console.ReadLine()); 
//} 

//int[] doubledMass = new int[originalMassLength];

//for (int i = 0; i < originalMassLength; i++)
//{
//    doubledMass[i] = mass[i] * 2;
//}

//Console.WriteLine("Yeni massiv (2 qatlı):");
//for (int i = 0; i < doubledMass.Length; i++)
//{
//    Console.Write(doubledMass[i] + " ");
//}

////9. İnsanın anadan olduğu il,ay,gün və bu günki tarixverilmişdi. İnsanın yaşını hesablayan proqramı yazın.

//Console.WriteLine("Doğum tarixini daxil edin:");
//Console.Write("Gün: ");
//int birthDay = int.Parse(Console.ReadLine());
//Console.Write("Ay: ");
//int birthMonth = int.Parse(Console.ReadLine());
//Console.Write("İl: ");
//int birthYear = int.Parse(Console.ReadLine());

//Console.WriteLine("Bu günün tarixini daxil edin:");
//Console.Write("Gün: ");
//int currentDay = int.Parse(Console.ReadLine());
//Console.Write("Ay: ");
//int currentMonth = int.Parse(Console.ReadLine());
//Console.Write("IL: ");
//int currentYear = int.Parse(Console.ReadLine());

//int age = currentYear - birthYear;

//if (currentMonth < birthMonth || (currentMonth == birthMonth && currentDay < birthDay))
//{
//    age--;
//}
//Console.WriteLine("Yaş: " + age);

////10. Daxil edilmiş parçanın uzunluğuna verilmiş vahidə çevirin (d-dm, k-km, M-m, m-mm, s-sm) uyğun olaraq istənilən vahidə çevirən proqram yazın. 
///Giriş: 50 K Çıxış: 50000 metr

//Console.WriteLine("Çevirmek istediyiniz ölçü vahidini seçin: (d - dm, k - km, M - m, m - mm, s - sm)");
//string unit = Console.ReadLine();

//Console.WriteLine("Daxil edilen ölçü deyerini yazın:");
//double value = Convert.ToDouble(Console.ReadLine());
//double result = 0;

//switch (unit) 
//{
//    case "d": 
//        result = value * 0.1;
//         break;
//    case "k": 
//        result = value * 1000; 
//          break;
//    case "M": 
//         result = value;
//         break;
//    case "m": 
//        result = value * 0.001;
//        break;
//    case "s": 
//        result = value * 0.01;
//        break;
//    default:
//        Console.WriteLine("Yanlış vahid daxil etdiniz.");
//        return;
//}
//Console.WriteLine($"Daxil edilmiş {value} {unit} uzunluğu {result} metre beraberdir.");