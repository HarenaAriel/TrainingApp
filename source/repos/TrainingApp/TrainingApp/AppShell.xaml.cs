using TrainingApp.Views;

namespace TrainingApp
{
  public partial class AppShell : Shell
  {
    public AppShell()
    {
      InitializeComponent();

      Routing.RegisterRoute(nameof(ProductDetailsPage), typeof(ProductDetailsPage));
      Routing.RegisterRoute(nameof(ManageProductPage), typeof(ManageProductPage));
    }
  }
}