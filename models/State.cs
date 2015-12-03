// Государство
using System;

class State : HasShow, IComparable <State>
{
  public static int count=0;

  protected int id;
  protected string name;
  protected int age;

  public State() {
    count++;
    this.id = State.count;
    this.name = "Гоcударство " + id;
    this.age = 500;
  }

  public State(string name, int age) {
    count++;
    this.id = State.count;
    this.name = name;
    this.age = age;
  }

  public int CompareTo(State c)
  {
    return Age.CompareTo(c.Age);
  }

  public override void Show(string extenstion = null) {
    if (extenstion != null) {
      Console.WriteLine("Гоcударство{0}.\n ID: {1}\n Название: {2}\n Возраст: {3}", extenstion, id, name, age);
    } else {
      Console.WriteLine("Гоcударство.\n ID: {0}\n Название: {1}\n Возраст: {2}\n", id, name, age);
    }
  }

  public virtual int Id {
    get { return id; }
    set { id=value; }
  }

  public virtual string Name {
    get { return name; }
    set{ name=value; }
  }

  public virtual int Age {
    get { return age; }
    set { age=value; }
  }

}
