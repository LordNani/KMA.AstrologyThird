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
    private SignModel _model = new SignModel();
    private DateTime _pickedDate = DateTime.Today;
    private DataProcessor _processor = new DataProcessor();
    public RelayCommand<object> _submitDate;
#endregion

#region Properties
    public DateTime BirthDate
    {
      get { return _pickedDate; }
      set
      {
        _pickedDate = value;
        OnPropertyChanged("BirthDate");
      }
    }

    public int Age
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
        return _submitDate ??(
          _submitDate = new RelayCommand<object>(o => {
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
            int userAge = await Task.Run(() => _processor.calculateAge(_pickedDate));

            if (userAge != -1)
            {
                Age = userAge;
                WesternSign = await Task.Run(() => _processor.calculateSignWest(_pickedDate));
                EasternSign = await Task.Run(() => _processor.calculateSignEast(_pickedDate));
            }
        }

    public bool CanExecuteCommand(object o)
    {
      return !(_pickedDate.Equals(null));
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
