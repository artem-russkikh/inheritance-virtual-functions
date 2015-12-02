// Королевство - наследник монархии
using System;

class Kingdom:Monarchy
{
  protected bool inheritance;

  public Kingdom() : base() {
    this.name = "Гоcударство (монархия-королевство) " + id;
    this.inheritance = true;
  }

  public Kingdom(string name, int age, string monarch_name, bool inheritance) : base(name, age, monarch_name) {
    this.inheritance = inheritance;
  }

  public override void Show(string extenstion = null) {
    if (extenstion != null) {
      base.Show(extenstion);
      Console.WriteLine(" Передача власти по наследству: {0}", inheritance);
    } else {
      base.Show("-монархия-королевство");
      Console.WriteLine(" Передача власти по наследству: {0} \n", inheritance);
    }
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
