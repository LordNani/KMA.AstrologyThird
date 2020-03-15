using System;


namespace CSharp_lab2.Models {
  internal class Person {
    private DateTime _birthDate = DateTime.Today;
    private String _easternSign;
    private String _westernSign;
    private int _age;

    public int Age {
      get { return _age; }
      set { _age = value; }
    }
    public String EasternSign {
      get { return _easternSign; }
      set { _easternSign = value; }
    }
    public String WesternSign {
      get { return _westernSign; }
      set { _westernSign = value; }
    }
    public DateTime BirthDate {
      get { return _birthDate; }
      set { _birthDate = value; }
    }
  }
}
