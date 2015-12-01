// Монархия - наследник государства
using System;

class Monarchy:State
{
  public Monarchy() {
    this.id = State.count + 1;
    this.name = "Гоcударство (монархия) "+id;
    count++;
  }

  public override void Show() {
    Console.WriteLine("Монархия.\n ID: {0}\n Название: {1} \n", id, name);
  }
}
