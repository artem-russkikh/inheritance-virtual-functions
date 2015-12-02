// Республика - наследник государства
using System;

class Republic:State
{
  protected bool president;

  public Republic() {
    this.id = State.count;
    this.name = "Гоcударство (республика) " + id;
    this.president = true;
  }

  public Republic(string name, bool president) {
    this.name = name;
    this.president = president;
  }

  public override void Show() {
    Console.WriteLine("Республика.\n ID: {0}\n Название: {1} \n Президентская?: {2} \n", id, name, President);
  }

  public bool President {
    get { return president; }
    set { president=value; }
  }

}
