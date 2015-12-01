// Королевство - наследник монархии
using System;

class Kingdom:Monarchy
{
  public Kingdom() {
    this.id = State.count;
    this.name = "Гоcударство (королевство) " + id;
  }

  public override void Show() {
    Console.WriteLine("Королевство.\n ID: {0}\n Название: {1} \n", id, name);
  }
}
