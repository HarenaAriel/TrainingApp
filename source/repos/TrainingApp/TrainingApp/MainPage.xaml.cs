using TrainingApp.ViewModel;
using TrainingApp.Views;

namespace TrainingApp
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();
      BindingContext = new MainPageViewModel();
    }
  }
}