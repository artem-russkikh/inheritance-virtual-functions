// Государство
using System;

class State
{
  public static int count=0;

  protected int id;
  protected string name;

  public State() {
    this.id = State.count + 1;
    this.name = "Гоcударство "+id;
    count++;
  }

  public State(int id, string name) {
    this.id = id;
    this.name = name;
    count++;
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
