using CommunityToolkit.Mvvm.ComponentModel;
using TrainingApp.Models;
using TrainingApp.ViewModel.BaseVM;

namespace TrainingApp.ViewModel
{
  [QueryProperty("Product", "Product")]
  public partial class ProductDetailsViewModel : BaseViewModel
  {
    public ProductDetailsViewModel() { }

    [ObservableProperty]
    ProductModel _product;
  }
}
