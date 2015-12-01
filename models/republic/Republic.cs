// Республика - наследник государства
using System;

class Republic:State
{
  public Republic() {
    this.id = State.count + 1;
    this.name = "Гоcударство (республика) " + id;
    count++;
  }

  public override void Show() {
    Console.WriteLine("Республика.\n ID: {0}\n Название: {1} \n", id, name);
  }
}
