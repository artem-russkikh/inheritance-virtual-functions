// Республика - наследник государства
using System;

class Republic:State
{
  protected bool president;

  public Republic() : base() {
    this.name = "Гоcударство (республика) " + id;
    this.president = true;
  }

  public Republic(string name, int age, bool president) : base(name, age) {
    this.president = president;
  }

  public override object Clone() {
    return new Republic(this.name, this.age, this.president);
  }

  public override void Show(string extenstion = null) {
    if (extenstion != null) {
      base.Show(extenstion);
      Console.WriteLine(" Президентская?: {0}", President);
    } else {
      base.Show("-республика");
      Console.WriteLine(" Президентская?: {0} \n", President);
    }
  }

  public bool President {
    get { return president; }
    set { president=value; }
  }

}
