using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using TrainingApp.Models;
using TrainingApp.ViewModel.BaseVM;
using TrainingApp.Views;

namespace TrainingApp.ViewModel
{
  public partial class MainPageViewModel : BaseViewModel
  {
    public MainPageViewModel()
    {
      Title = "Accueil";

      LoadCategory().GetAwaiter();
      LoadProduct().GetAwaiter();
    }

    [ObservableProperty]
    ObservableCollection<CategoryModel> _categoryModels;
    [ObservableProperty]
    ObservableCollection<ProductModel> _productModels;
    [ObservableProperty]
    ProductModel _product;

    [RelayCommand]
    async Task GoToDetails(ProductModel product)
    {
      if (product == null)
      {
        await Application.Current.MainPage.DisplayAlert("Alert", "You have been alerted", "OK");
      }
      else
      {
        await Shell.Current.GoToAsync(nameof(ProductDetailsPage), true, new Dictionary<string, object> {
        { "Product", product }
      });
      }
    }

    [RelayCommand]
    async Task GoToManageProduct()
    {
      await Shell.Current.GoToAsync(nameof(ManageProductPage));
    }

    async Task LoadCategory()
    {
      await Task.Delay(250);

      CategoryModels = new ObservableCollection<CategoryModel>() {
        new CategoryModel { Id = 1, CategoryName = "Veste" },
        new CategoryModel { Id = 1, CategoryName = "Chemise" },
        new CategoryModel { Id = 1, CategoryName = "Chaussure" },
        new CategoryModel { Id = 1, CategoryName = "Pantalon" }
      };
    }

    async Task LoadProduct()
    {
      await Task.Delay(250);

      ProductModels = new ObservableCollection<ProductModel>() {
        new ProductModel { Id = 1, Name = "Gucci V", Category = "Veste" },
        new ProductModel { Id = 3, Name = "Gucci Bard", Category = "Chemise" },
        new ProductModel { Id = 5, Name = "Adidas Flyout", Category = "Chaussure" },
        new ProductModel { Id = 7, Name = "Cargo Lacost", Category = "Pantalon" },
      };
    }
  }
}
