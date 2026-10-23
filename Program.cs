using System;
//Task 1
// int a = 0;
// while (a < 10)
// {
//     a++;
//     Console.Write(a );
// }

// do
// {
//     a++;
//     Console.Write(a );
// } while(a<10);

// for (int i = 0; i < 10; i++)
// {
//     a++;
//     Console.Write(a );
// }
//Task 2

// Console.WriteLine("Ile dni trwa wyprawa? ");
// int days = int.Parse(Console.ReadLine()!);
// int all = 0;
// int more = 0;
// for (int i = 0; i <days; i++)
// {
//     Console.WriteLine($"Złoto w dniu {i}: ");
//     int gold = int.Parse(Console.ReadLine()!);
//     all+=gold;
//     if (gold >= 10) more+=1;
// }

// Console.WriteLine($"Łącznie znaleziono: {all} sztuk złota.\n"+
// $"Dni z wynikiem powyżej 10: {more}");

//Task 3
// int n =5;
// for(int i=0; i<=n; i++) {
//   for (int j=0; j<=n-i-1; j++) {
//     Console.Write(" ");
    
//   }
//   for (int j = 0; j < 2 * i + 1; j++)
//     {
//         Console.Write("*");
//     }
//     Console.WriteLine();

// }
// for (int i = 0; i < n - 1; i++)
// {
//     Console.Write(" ");
// }
// Console.WriteLine("*");

//Task 4
// Console.WriteLine("Podaj liczbę tur od 1 do 10: ");
// string tur = Console.ReadLine()!;
// bool answer = false;
// do
// {
//     if (int.TryParse(tur,out int resault1)){
//         if (resault1 < 1)
//         {
//             Console.WriteLine("Liczba musi należeć do zakresu 1–10.");
//             continue;
//         }
//         else if (resault1 > 10)
//         {
//             Console.WriteLine("Liczba musi należeć do zakresu 1–10.");
//             continue;
//         }
//         else
//         {
//             Console.WriteLine($"Rozpoczynam grę na {resault1} tur.");
//             answer = true;
//             break;
//         }
//     } else
//     {
//         Console.WriteLine("Wpisz liczbę całkowitą.");
//         continue;
//     }

// } while (answer==true);

//Task 5
Random losowanie = new Random();
int zdrowieBohatera = 60;
int zdrowiePrzeciwnika = 45;
int obrazeniaBohatera = losowanie.Next(8, 16);
int obrazeniaPrzeciwnika = losowanie.Next(4, 10);
int liczbaMikstur = 2;
int numerTury = 1;
bool uczieczka = false;
while (true){
    Console.WriteLine($"Numer tury: {numerTury}\nStan Bohatera: {zdrowieBohatera}\nStan Przeciwnika: {zdrowiePrzeciwnika}\nLiczba mikstur: {liczbaMikstur}");
    if (zdrowieBohatera<=0&&zdrowieBohatera<=zdrowiePrzeciwnika)
    {
        Console.WriteLine("Przegrałeś!");
        Console.WriteLine($"Stan Bohatera: 0 \n Stan Przeciwnika {zdrowiePrzeciwnika}\n Numer tury w ogóle {numerTury}");
        break;
    }
    else if(zdrowiePrzeciwnika<=0&&zdrowieBohatera>=zdrowiePrzeciwnika) {
        Console.WriteLine("Wygrałeś!");
        Console.WriteLine($"Stan Bohatera: {zdrowieBohatera} \n Stan Przeciwnika: 0\n Numer tury w ogóle {numerTury}");
        break;
    }
    else if (uczieczka == true)
    {
        Console.WriteLine("Uczikłeś");
        Console.WriteLine($"Stan Bohatera: {zdrowieBohatera} \n Stan Przeciwnika: {zdrowiePrzeciwnika}\n Numer tury w ogóle {numerTury}");
        break;
    }
    else if (zdrowieBohatera == zdrowiePrzeciwnika)
    {
        Console.WriteLine("Remis");
        Console.WriteLine($"Stan Bohatera: 0 \n Stan Przeciwnika: 0\n Numer tury w ogóle {numerTury}");
    }
    else
    {
        Console.WriteLine("pokaż menu: 1 — atak, 2 — mikstura, 3 — ucieczka");
    int num = int.Parse(Console.ReadLine()!);
    switch (num)
    {
        case 1:
        zdrowiePrzeciwnika-=obrazeniaPrzeciwnika;
        zdrowieBohatera-=obrazeniaBohatera;
        numerTury ++;
        break;
        case 2:
        if (liczbaMikstur <= 0)
            {
                Console.WriteLine("Nie masz mikstur");
            }
        else
            {
                zdrowieBohatera+=15;
                liczbaMikstur--;
            }
        break;
        case 3:
        Console.WriteLine("Uczekłesz z walki");
        uczieczka=true;
        break;
        default:
        Console.WriteLine("Proszę wpisać albo 1 albo 2 albo 3");
        break;
    }

    }
}