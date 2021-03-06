// Монархия - наследник государства
using System;

class Monarchy:State
{
  protected string monarch_name;

  public Monarchy() : base() {
    this.name = "Гоcударство (монархия) " + id;
    this.monarch_name = "Людовиг III";
  }

  public Monarchy(string name, int age, string monarch_name) : base(name, age) {
    this.monarch_name = monarch_name;
  }

  public override object Clone() {
    return new Monarchy(this.name, this.age, this.monarch_name);
  }

  public override void Show(string extenstion = null) {
    if (extenstion != null) {
      base.Show(extenstion);
      Console.WriteLine(" Имя монарха: {0}", MonarchName);
    } else {
      base.Show("-монархия");
      Console.WriteLine(" Имя монарха: {0} \n", MonarchName);
    }
  }

  public string MonarchName {
    get { return monarch_name; }
    set { monarch_name=value; }
  }
}
