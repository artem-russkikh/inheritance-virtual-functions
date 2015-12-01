// Республика, монархия, королевство, государство;
// государство -> монархия -> королевство
// государство -> республика

using System;

class Program
{
    static void Main(string[] args)
    {
      Random rand = new Random();
      State[] mas = new State[12];
      State[] massss = new State[4];
      for(int i=0;i<mas.Length;i++){
      massss[0] = new Kingdom();
      massss[1] = new Republic();
      massss[2] = new State();
      massss[3] = new Monarchy();
        mas[i]=massss[rand.Next(0,4)];
      }
      for(int i=0;i<mas.Length;i++){
        mas[i].Show();
      }
      zadanie3(mas);
    }

    public static void zadanie3(State[] mass){
      bool cikl = true;
            int swi = -1;
            while (cikl)
            {
                while (true)
                {
                    Console.WriteLine("1-узнать name по id");
                    Console.WriteLine("2-запрос 2");
                    Console.WriteLine("3-запрос 3");
                    Console.WriteLine("4-просмотр масива");
                    Console.WriteLine("5-выход");
                    try
                    {
                        swi = int.Parse(Console.ReadLine());
                        if (swi < 1 || swi > 5) { Console.WriteLine("неверно"); continue; }
                        else break;
                    }
                    catch (FormatException e) { Console.WriteLine("неверно");continue; }
                }
                switch (swi)
                {
                    case 1: {
                                          int netres=0;
                                          int idpoisk = -1;
                                          while (true){
                                        Console.WriteLine("введи id");
                                        try
                                        {
                                            idpoisk = int.Parse(Console.ReadLine());
                                            break;
                                        }
                                        catch (FormatException e) { Console.WriteLine("неверно");continue; }
                                    }
                                    for(int i=0;i<mass.Length;i++){
                                      if(mass[i].Id==idpoisk){
                                        mass[i].Show();
                                        netres++;
                                      }}
                                            if(netres==0)Console.WriteLine("нет такого id");
                      }  break;
                    case 2: {  } break;
                    case 3: {  } break;
                    case 4: { for(int i=0;i<mass.Length;i++)mass[i].Show(); } break;
                    case 5: { cikl=false; } break;
                }
            }
    }
}
