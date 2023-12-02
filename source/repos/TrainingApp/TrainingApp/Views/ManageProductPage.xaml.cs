using TrainingApp.ViewModel;

namespace TrainingApp.Views;

public partial class ManageProductPage : ContentPage
{
  public ManageProductPage()
  {
    InitializeComponent();
    BindingContext = new ManageProductViewModel();
  }
}