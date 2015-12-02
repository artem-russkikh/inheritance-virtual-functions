// Государство
using System;

class State
{
  public static int count=0;

  protected int id;
  protected string name;

  public State() {
    count++;
    this.id = State.count;
    this.name = "Гоcударство " + id;
  }

  public State(string name) {
    count++;
    this.id = State.count;
    this.name = name;
  }

  public virtual void Show() {
    Console.WriteLine("Гоcударство.\n ID: {0}\n Название: {1}\n", id, name);
  }

  public virtual int Id {
    get { return id; }
    set { id=value; }
  }

  public virtual string Name {
    get { return name; }
    set{ name=value; }
  }
}
