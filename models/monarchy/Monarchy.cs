// Монархия - наследник государства
using System;

class Monarchy:State
{
  protected int id;
  protected string name;

  public static int  count=0;

  public Monarchy() {
    this.id = State.count + 1;
    this.name = "Гоcударство"+id;
    count++;
  }

  public Monarchy(int id, string name) {
    this.id = id;
    this.name = name;
    count++;
  }

  public override void Show() {
    Console.WriteLine("Монархия.\n ID: {0}\n Название: {1}", id, name);
  }

  public int Id {
    get { return id; }
    set{ id=value; }
  }

  public string Name {
    get { return name; }
    set{ name=value; }
  }
}
