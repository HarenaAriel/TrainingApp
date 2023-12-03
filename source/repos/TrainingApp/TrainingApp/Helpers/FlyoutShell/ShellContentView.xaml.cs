using TrainingApp.ViewModel;

namespace TrainingApp.Helpers.FlyoutShell;

public partial class ShellContentView : ContentView
{
	public ShellContentView()
	{
		InitializeComponent();
		BindingContext = new NavigationViewModel();
	}
}