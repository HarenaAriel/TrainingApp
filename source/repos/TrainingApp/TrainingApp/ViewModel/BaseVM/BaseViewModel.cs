using CommunityToolkit.Mvvm.ComponentModel;

namespace TrainingApp.ViewModel.BaseVM
{
  public partial class BaseViewModel : ObservableObject
  {
    public BaseViewModel()
    {
      Title = "Home";
    }

    [ObservableProperty]
    string _title;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    bool _isBusy;

    public bool IsNotBusy => !IsBusy;
  }
}
