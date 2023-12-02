using TrainingApp.ViewModel;

namespace TrainingApp.Views;

public partial class ProductDetailsPage : ContentPage
{
	public ProductDetailsPage()
	{
		InitializeComponent();
		BindingContext = new ProductDetailsViewModel();
	}
}