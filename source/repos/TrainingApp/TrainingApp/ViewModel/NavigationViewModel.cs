using CommunityToolkit.Mvvm.Input;
using TrainingApp.ViewModel.BaseVM;
using TrainingApp.Views;

namespace TrainingApp.ViewModel
{
  public partial class NavigationViewModel : BaseViewModel
  {
    public NavigationViewModel()
    {

    }

    [RelayCommand]
    async Task GoToManageProduct()
    {
      await Shell.Current.GoToAsync(nameof(ManageProductPage));
    }

  }
}
