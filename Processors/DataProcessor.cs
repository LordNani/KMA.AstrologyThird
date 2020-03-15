using System;
using System.Windows;
using System.Threading;
using System.Net.Mail;
using CSharp_lab2.DataException;
namespace CSharp_lab2.Processors
{
  class DataProcessor
  {
    private String[] eastSignArr = { "Monkey", "Rooster", "Dog",   "Pig",
                                     "Rat",    "Bull",    "Tiger", "Rabbit",
                                     "Dragon", "Snake",   "Horse", "Goat" };

    public bool IsValid(string emailaddress)
    {
      try {
        MailAddress m = new MailAddress(emailaddress);

        return true;
      } catch (FormatException) {
        MessageBox.Show(
          "Wrong e-mail!", "Oops!", MessageBoxButton.OK, MessageBoxImage.Error);
        return false;
      }
    }
    public int calculateAge(DateTime dateOfBirth)
    {
#if DEBUG
      Thread.Sleep(500); // testing async
#endif
      if (DateTime.Today.DayOfYear == dateOfBirth.DayOfYear)
        MessageBox.Show("Happy birthday! ",
                        "Yeehaw!",
                        MessageBoxButton.OK,
                        MessageBoxImage.Exclamation);
      int age = DateTime.Today.Year - dateOfBirth.Year;
      if (DateTime.Today.DayOfYear < dateOfBirth.DayOfYear)
        age--;

      try {
        validateAge(age);
      } catch (Exception e) {
        if (e is AgeExceededException)
          MessageBox.Show(
            e.Message, "Oops!", MessageBoxButton.OK, MessageBoxImage.Error);
        else if (e is AgeFutureException)
          MessageBox.Show("Sorry, but your age needs to be above 0 :)",
                          "Oops!",
                          MessageBoxButton.OK,
                          MessageBoxImage.Error);
        return -1;
      }

      return age;
    }

    public String calculateSignEast(DateTime dateOfBirth)
    {
#if DEBUG
      Thread.Sleep(700); // testing async
#endif
      String result = eastSignArr[dateOfBirth.Year % 12];
      return result;
    }

    public void validateAge(int age)
    {
      if (age > 135)
        throw new DataException.AgeExceededException(
          $"Age limit exceeded. Given age: {age}", age);
      else if (age < 0)
        throw new DataException.AgeFutureException(
          $"This person haven't born yet");
    }
    public String calculateSignWest(DateTime dateOfBirth)
    {
      String result = "";
      switch (dateOfBirth.Month) {
        case 1: {
          if (dateOfBirth.Day < 20)
            result = "Capricorn";
          else
            result = "Aquarius";
          break;
        }
        case 2: {
          if (dateOfBirth.Day < 19)
            result = "Aquarius";
          else
            result = "Pisces";
          break;
        }
        case 3: {
          if (dateOfBirth.Day < 21)
            result = "Pisces";
          else
            result = "Aries";
          break;
        }
        case 4: {
          if (dateOfBirth.Day < 20)
            result = "Aries";
          else
            result = "Taurus";
          break;
        }
        case 5: {
          if (dateOfBirth.Day < 21)
            result = "Taurus";
          else
            result = "Gemini";
          break;
        }
        case 6: {
          if (dateOfBirth.Day < 21)
            result = "Gemini";
          else
            result = "Cancer";
          break;
        }
        case 7: {
          if (dateOfBirth.Day < 23)
            result = "Cancer";
          else
            result = "Leo";
          break;
        }
        case 8: {
          if (dateOfBirth.Day < 23)
            result = "Leo";
          else
            result = "Virgo";
          break;
        }
        case 9: {
          if (dateOfBirth.Day < 23)
            result = "Virgo";
          else
            result = "Libra";
          break;
        }
        case 10: {
          if (dateOfBirth.Day < 23)
            result = "Libra";
          else
            result = "Scorpio";
          break;
        }
        case 11: {
          if (dateOfBirth.Day < 22)
            result = "Scorpio";
          else
            result = "Sagittarius";
          break;
        }
        case 12: {
          if (dateOfBirth.Day < 22)
            result = "Sagittarius";
          else
            result = "Capricorn";
          break;
        }
        default: {
          result = "Can't calculate your sign, sorry";
          break;
        }
      }

      return result;
    }
  }
}
