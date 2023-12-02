using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TrainingApp.ViewModel.BaseVM;

namespace TrainingApp.ViewModel
{
  public partial class ManageProductViewModel : BaseViewModel
  {
    public ManageProductViewModel() { }

    [ObservableProperty]
    string _productName;
    [ObservableProperty]
    string _productCategory;

    [RelayCommand]
    async Task AddToProductRepos()
    {
      await Application.Current.MainPage.DisplayAlert("Information", $"{ProductName} and {ProductCategory} has been enterred", "OK");
    }

  }
}
