// Республика, монархия, королевство, государство;
// государство -> монархия -> королевство
// государство -> республика

using System;
using System.Linq;
using System.Collections.Generic;

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
    Console.WriteLine("CODE:\new Republic('Республика конструктор с параметрами', 100, false);");
    var customParams = new Republic("Республика конструктор с параметрами", 100, false);
    customParams.Show();
    Console.WriteLine("CODE:\nnew Kingdom('Королевство конструктор с параметрами', 200, 'Имя монарха кастомное и передается в конструктор базового класса Monarchy', false);");
    var customParams2 = new Kingdom("Королевство конструктор с параметрами", 200, "Имя монарха кастомное и передается в конструктор базового класса Monarchy", false);
    customParams2.Show();
    Console.WriteLine("...............\n");
    System.Threading.Thread.Sleep(400);
    Console.WriteLine("Использование конструкторов без параметров:");
    var mas = new State[4];
    mas[0] = new State();
    mas[1] = new Republic();
    mas[2] = new Monarchy();
    mas[3] = new Kingdom();
    for(int i = 0; i < mas.Length; i++) {
      mas[i].Show();
    }
    Console.WriteLine("...............\n");
    System.Threading.Thread.Sleep(400);
    Console.WriteLine("Получение имени монарха для Id='{0}' через KingName='{1}' и MonarchName='{2}'\n", customParams2.Id,  customParams2.KingName, customParams2.MonarchName);
    System.Threading.Thread.Sleep(400);
  }

  static State[] GenerateMas() {
    Random rand = new Random();
    State[] mas = new State[12];
    State[] tmp = new State[4];
    for(int i = 0; i < mas.Length; i++) {
      tmp[0] = new State();
      tmp[0].Age = rand.Next(10, 2000);
      tmp[1] = new Kingdom();
      tmp[1].Age = rand.Next(10, 2000);
      tmp[2] = new Republic();
      tmp[2].Age = rand.Next(10, 2000);
      tmp[3] = new Monarchy();
      tmp[3].Age = rand.Next(10, 2000);
      mas[i]=tmp[rand.Next(0,4)];
    }
    return mas;
  }

  static void SecondPart() {
    Console.WriteLine("\nМассив государств\n");
    System.Threading.Thread.Sleep(400);
    State[] mas = GenerateMas();
    for(int i = 0; i < mas.Length; i++) {
      mas[i].Show();
    }
    Console.WriteLine("1. Имена всех государств, которые существуют менее 1000 лет");
    Console.WriteLine("2. Количество государств - королевств");
    Console.WriteLine("3. Средний возраст всех государств");
    Console.WriteLine("4. Наименование старейшего государства");
    Console.WriteLine("0. Назад.");
    Console.Write("\nВыберите команду: ");
    int choose = -1;
    do
    {
      try {
        choose = int.Parse(Console.ReadLine());
        if (choose < 0 || choose > 4)
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
    } while (choose < 0 || choose > 4);
    switch (choose)
    {
        case 0:
            {
              break;
            }
        case 1:
            {
              firstQuery(mas);
              break;
            }
        case 2:
            {
              secondQuery(mas);
              break;
            }
        case 3:
            {
              thirdQuery(mas);
              break;
            }
        case 4:
            {
              fourthQuery(mas);
              break;
            }
        default: break;
    }
  }
  static void firstQuery(State[] states) {
    var stateQuery =
      from state in states
      where state.Age < 1000
      select state;
    foreach (State state in stateQuery) {
      Console.WriteLine(state.Name);
    }
  }
  static void secondQuery(State[] states) {
    var stateQuery =
      from state in states
      where state is Kingdom
      select state;
    Console.WriteLine(stateQuery.Count());
  }
  static void thirdQuery(State[] states) {
    var stateQuery =
      from state in states
      select state;
    var stateAgeQuery =
      from state in states
      select state.Age;
    int sumAge = 0;
    foreach (State state in stateQuery) {
      sumAge += state.Age;
    }
    Console.WriteLine("{0} / {1} = {2}", sumAge, states.Length, stateAgeQuery.Average());
  }
  static void fourthQuery(State[] states) {
    var stateQuery =
      from state in states
      select state;
    int maxId = 0;
    int max = 0;
    foreach (State state in stateQuery) {
      if (max < state.Age) {
        max = state.Age;
        maxId = state.Id;
      }
    }
    var stateQuery2 =
      from state in states
      where state.Id == maxId
      select state;
    State st = stateQuery2.First();
    Console.WriteLine(st.Name);
  }

  static void ThirdPart() {
    Console.WriteLine("\nИспользование интерфейса для сортировки по возрасту:");
    System.Threading.Thread.Sleep(400);
    State[] mas = GenerateMas();
    Array.Sort(mas);
    for(int i = 0; i < mas.Length; i++) {
      mas[i].Show();
    }

    int idpoisk = -1;
    while (true) {
      Console.Write("Поиск по ID: ");
      try
      {
          idpoisk = int.Parse(Console.ReadLine());
          break;
      }
      catch (FormatException e) { Console.WriteLine("Неправильный ввод {0}", e); continue; }
    }

    State s = Array.Find(mas, item => item.Id == idpoisk);
    if (s != null) {
      s.Show();
    } else {
      Console.WriteLine("Элемент не найден!");
    }

    Console.WriteLine("\nИспользование интерфейса для копирования объекта:");

    State cloningObject = null;
    if (mas[0] is State) {
      cloningObject = (State) mas[0].Clone();
    } else {
      Console.WriteLine("mas[0] != State");
    }
    cloningObject.Show();
  }

  static void Main(string[] args)
  {
    while (true)
    {
      MainMenu();
    }
  }
}
