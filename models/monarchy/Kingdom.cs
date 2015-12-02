// Королевство - наследник монархии
using System;

class Kingdom:Monarchy
{
  protected bool inheritance;

  public Kingdom() : base() {
    this.name = "Гоcударство (монархия-королевство) " + id;
    this.inheritance = true;
  }

  public Kingdom(string name, string monarch_name, bool inheritance) : base(name, monarch_name) {
    this.inheritance = inheritance;
  }

  public override void Show() {
    Console.WriteLine("Королевство.\n ID: {0}\n Название: {1} \n Имя монарха: {2}\n Передача власти по наследству: {3} \n", id, name, monarch_name, inheritance);
  }

  public bool Inheritance {
    get { return inheritance; }
    set { inheritance=value; }
  }

  public string KingName {
    get { return monarch_name; }
    set { monarch_name=value; }
  }
}
