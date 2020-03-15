using System;

namespace CSharp_lab2.Models
{

  internal class Person
  {
    private DateTime _birthDate = DateTime.Today;
    private String _easternSign;
    private String _westernSign;
    private String _age;
    private String _name;
    private String _surname;
    private String _email;

#region Constructors
    public Person(String name, String surname, String email, DateTime date)
    {
      _name = name;
      _surname = surname;
      _birthDate = date;
    }

    public Person() {}
    public Person(String name, String surname, String email)
    {
      _name = name;
      _surname = surname;
      _email = email;
    }
    public Person(String name, String surname, DateTime date)
    {
      _name = name;
      _surname = surname;
      _birthDate = date;
    }
#endregion
    public String Age
    {
      get { return _age; }
      set { _age = value; }
    }
    public String Email
    {
      get { return _email; }
      set { _email = value; }
    }
    public String Name
    {
      get { return _name; }
      set { _name = value; }
    }
    public String Surname
    {
      get { return _surname; }
      set { _surname = value; }
    }
    public String EasternSign
    {
      get { return _easternSign; }
      set { _easternSign = value; }
    }
    public String WesternSign
    {
      get { return _westernSign; }
      set { _westernSign = value; }
    }
    public DateTime BirthDate
    {
      get { return _birthDate; }
      set { _birthDate = value; }
    }
  }
}
