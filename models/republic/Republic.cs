// Республика - наследник государства
using System;

class Republic:State
{
  public Republic() {
    this.id = State.count;
    this.name = "Гоcударство (республика) " + id;
  }

  public override void Show() {
    Console.WriteLine("Республика.\n ID: {0}\n Название: {1} \n", id, name);
  }
}
