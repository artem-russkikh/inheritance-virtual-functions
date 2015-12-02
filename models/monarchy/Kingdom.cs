// Королевство - наследник монархии
using System;

class Kingdom:Monarchy
{
  protected int years;

  public Kingdom() : base() {
    this.name = "Гоcударство (монархия-королевство) " + id;
    this.years = 240;
  }

  public Kingdom(string name, string monarch_name, int years) : base(name, monarch_name) {
    this.years = years;
  }

  public override void Show() {
    Console.WriteLine("Королевство.\n ID: {0}\n Название: {1} \n Имя монарха: {2}\n Лет: {3} \n", id, name, monarch_name, years);
  }

  public int Years {
    get { return years; }
    set { years=value; }
  }
}
