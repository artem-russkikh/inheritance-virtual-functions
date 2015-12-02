// Монархия - наследник государства
using System;

class Monarchy:State
{
  protected string monarch_name;

  public Monarchy() {
    this.id = State.count;
    this.name = "Гоcударство (монархия) " + id;
    this.monarch_name = "Людовиг III";
  }

  public Monarchy(string name, string monarch_name) {
    this.name = name;
    this.monarch_name = monarch_name;
  }

  public override void Show() {
    Console.WriteLine("Монархия.\n ID: {0}\n Название: {1} \n Имя монарха: {2} \n", id, name, monarch_name);
  }

  public string MonarchName {
    get { return monarch_name; }
    set { monarch_name=value; }
  }
}
