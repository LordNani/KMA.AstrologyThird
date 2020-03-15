using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;
using CSharp_lab2.Tools;
using CSharp_lab2.Models;
using System.Threading.Tasks;
using CSharp_lab2.Processors;

namespace CSharp_lab2.ViewModels
{

  internal class SignViewModel : INotifyPropertyChanged
  {
#region Fleids
    private Person _model = new Person();
    private DateTime _pickedDate = DateTime.Today;
    private String _isBirthday = "";
    private String _dateToDisplay = "";

    private bool _isProgressBarVisible = false;
    private bool _fieldsEnabled = true;
    private DataProcessor _processor = new DataProcessor();
    public RelayCommand<object> _submitDate;
#endregion

#region Properties

    public bool IsProgressBarVisible
    {
      get { return _isProgressBarVisible; }
      private set
      {
        _isProgressBarVisible = value;
        OnPropertyChanged();
      }
    }

    public bool FieldsEnabled
    {
      get { return _fieldsEnabled; }
      set
      {
        _fieldsEnabled = value;
        OnPropertyChanged();
      }
    }
    public DateTime BirthDate
    {
      get { return _pickedDate; }
      set
      {
        _pickedDate = value;
        OnPropertyChanged();
      }
    }
    public String IsBirthday
    {
      get { return _isBirthday; }
      set { _isBirthday = value;
                OnPropertyChanged();
            }
    }

    public String Email
    {
      get { return _model.Email; }
      set { _model.Email = value; }
    }
    public String DateBirthDisplay
    {
      get { return _dateToDisplay; }
      set
      {
        _dateToDisplay = value;
        OnPropertyChanged();
      }
    }
    public String Name
    {
      get { return _model.Name; }
      set { _model.Name = value; }
    }
    public String Surname
    {
      get { return _model.Surname; }
      set { _model.Surname = value; }
    }
    public String Age
    {
      get { return _model.Age; }
      set
      {
        _model.Age = value;
        OnPropertyChanged();
      }
    }

    public String EasternSign
    {
      get { return _model.EasternSign; }
      set
      {
        _model.EasternSign = value;
        OnPropertyChanged();
      }
    }
    public String WesternSign
    {
      get { return _model.WesternSign; }
      set
      {
        _model.WesternSign = value;
        OnPropertyChanged();
      }
    }

    public RelayCommand<object> submitDate
    {
      get
      {
        return _submitDate ??(_submitDate = new RelayCommand<object>(o => {
                               // MessageBox
                               //    .Show
                               //        ($"Date picked: {BirthDate}");
                               calculateAll();
                             }, CanExecuteCommand));
      }
    }

#endregion

    private async void calculateAll()
    {
      IsProgressBarVisible = true;
      FieldsEnabled = false;

      int userAge = await Task.Run(() => _processor.calculateAge(BirthDate));

      if (userAge != -1 && _processor.IsValid(Email)) {
                //TODO exception and isValidAge
        Age = userAge.ToString();
        WesternSign =
          await Task.Run(() => _processor.calculateSignWest(BirthDate));
        EasternSign =
          await Task.Run(() => _processor.calculateSignEast(BirthDate));
        DateBirthDisplay = BirthDate.ToShortDateString();
        OnPropertyChanged("Email");
        OnPropertyChanged("Name");
        OnPropertyChanged("Surname");
                if (DateTime.Today.DayOfYear == BirthDate.DayOfYear)
                    IsBirthday = "Yes";
                else
                    IsBirthday = "No";
        
      }
      IsProgressBarVisible = false;
      FieldsEnabled = true;
    }

    public bool CanExecuteCommand(object o)
    {
      return !string.IsNullOrWhiteSpace(Name) &&
             !string.IsNullOrWhiteSpace(Surname) &&
             !string.IsNullOrWhiteSpace(Email);
    }

#region INotifyPropertyImplementation
    public event PropertyChangedEventHandler PropertyChanged;

    //[NotifyPropertyChangedInvocator]
    protected virtual void OnPropertyChanged(
      [ CallerMemberName ] string propertyName = null)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
#endregion
  }
}
