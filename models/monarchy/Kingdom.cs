// Королевство - наследник монархии
using System;

class Kingdom:Monarchy
{
  protected int years;

  public Kingdom() {
    this.id = State.count;
    this.name = "Гоcударство (монархия-королевство) " + id;
    this.years = 240;
  }

  public Kingdom(string name, int years) {
    this.name = name;
    this.years = years;
  }

  public override void Show() {
    Console.WriteLine("Королевство.\n ID: {0}\n Название: {1} \n Лет: {2} \n", id, name, years);
  }

  public int Years {
    get { return years; }
    set { years=value; }
  }
}
