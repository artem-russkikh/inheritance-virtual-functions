using System;

abstract class HasShow : ICloneable {
  abstract public void Show(string extenstion = null);

  virtual public object Clone() {
      throw new NotImplementedException();
  }
}
