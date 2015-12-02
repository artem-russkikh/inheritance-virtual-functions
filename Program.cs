// Республика, монархия, королевство, государство;
// государство -> монархия -> королевство
// государство -> республика

using System;

class Program
{
  static void MainMenu()
  {
    Console.WriteLine("\n12 вариант.");
    Console.WriteLine("государство -> монархия -> королевство");
    Console.WriteLine("государство -> республика");
    Console.WriteLine("1. Просмотр массива с экземплярами классов.");
    Console.WriteLine("2. Вызов запросов.");
    Console.WriteLine("3. Интерфейсы.");
    Console.WriteLine("0. Выход из программы.");
    Console.Write("\nВыберите команду: ");
    int choose = -1;
    do
    {
      try {
        choose = int.Parse(Console.ReadLine());
        if (choose < 0 || choose > 3)
        {
          Console.Write("Введена несуществующая команда. Повторите ввод: ");
        }
      }
      catch (FormatException)
      {
        Console.Write("Введен некорректный символ. Повторите ввод: ");
      }
      catch (Exception)
      {
        Console.Write("Введен некорректный символ. Повторите ввод: ");
      }
    } while (choose < 0 || choose > 3);
    switch (choose)
    {
        case 0:
            {
              System.Environment.Exit(0);
              break;
            }
        case 1:
            {
              FirstPart();
              break;
            }
        case 2:
            {
              SecondPart();
              break;
            }
        case 3:
            {
              ThirdPart();
              break;
            }
        default: break;
    }
  }

  static void FirstPart() {
    Console.WriteLine("\nИспользование конструкторов с параметрами:");
    var customParams = new Republic("Республика конструктор с параметрами", false);
    customParams.Show();
    var customParams2 = new Kingdom("Королевство конструктор с параметрами", "Имя монарха кастомное и передается в конструктор базового класса Monarchy", false);
    customParams2.Show();
    Console.WriteLine("...............\n");
    System.Threading.Thread.Sleep(2000);
    Console.WriteLine("Использование конструкторов без параметров:");
    var mas = new State[4];
    mas[0] = new State();
    mas[1] = new Republic();
    mas[2] = new Monarchy();
    mas[3] = new Kingdom();
    for(int i=0;i<mas.Length;i++){
      mas[i].Show();
    }
    Console.WriteLine("...............\n");
    System.Threading.Thread.Sleep(2000);
    Console.WriteLine("Получение имени монарха для Id='{0}' через KingName='{1}' и MonarchName='{2}'\n", customParams2.Id,  customParams2.KingName, customParams2.MonarchName);
    System.Threading.Thread.Sleep(2000);
  }
  static void SecondPart() {}
  static void ThirdPart() {}

  static void Main(string[] args)
  {
    while (true)
    {
      MainMenu();
    }
    // bool cikl = true;
    //   int swi = -1;
    //   while (cikl)
    //   {
    //       while (true)
    //       {
    //           Console.WriteLine("1-узнать name по id");
    //           Console.WriteLine("2-запрос 2");
    //           Console.WriteLine("3-запрос 3");
    //           Console.WriteLine("4-просмотр масива");
    //           Console.WriteLine("5-выход");
    //           try
    //           {
    //               swi = int.Parse(Console.ReadLine());
    //               if (swi < 1 || swi > 5) { Console.WriteLine("Неправильный ввод"); continue; }
    //               else break;
    //           }
    //           catch (FormatException e) { Console.WriteLine("Неправильный ввод");continue; }
    //       }
    //       switch (swi)
    //       {
    //           case 1: {
    //                                 int netres=0;
    //                                 int idpoisk = -1;
    //                                 while (true){
    //                               Console.WriteLine("введи id");
    //                               try
    //                               {
    //                                   idpoisk = int.Parse(Console.ReadLine());
    //                                   break;
    //                               }
    //                               catch (FormatException e) { Console.WriteLine("неверно");continue; }
    //                           }
    //                           for(int i=0;i<mas.Length;i++){
    //                             if(mas[i].Id==idpoisk){
    //                               mas[i].Show();
    //                               netres++;
    //                             }}
    //                                   if(netres==0)Console.WriteLine("нет такого id");
    //             }  break;
    //           case 2: {  } break;
    //           case 3: {  } break;
    //           case 4: { for(int i=0;i<mas.Length;i++)mas[i].Show(); } break;
    //           case 5: { cikl=false; } break;
    //       }
    //   }
  }
}
