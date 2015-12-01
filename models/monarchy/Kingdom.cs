// Королевство - наследник монархии
using System;

class Kingdom:Monarchy
{
  public override void Show(){
    Console.WriteLine("Королевство.\n ID: {0}\n Название: {1} \n", id, name);
  }

  public Kingdom() {
    this.id = State.count + 1;
    this.name = "Гоcударство (королевство) "+id;
    count++;
  }
}
