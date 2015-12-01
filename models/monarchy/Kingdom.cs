// Королевство - наследник монархии
using System;

class Kingdom:Monarchy
{
  public static int  count=0;

  protected int id;
  protected string name;

  public override void Show(){
    Console.WriteLine("Королевство.\n ID: {0}\n Название: {1}", id, name);
  }

  public Kingdom() {
    this.id = State.count + 1;
    this.name = "Гоcударство"+id;
    count++;
  }

  public Kingdom(int id, string name) {
    this.id = id;
    this.name = name;
    count++;
  }

  public int Id {
    get { return id; }
    set { id=value; }
  }

  public string Name {
    get { return name; }
    set { name=value; }
  }
}
