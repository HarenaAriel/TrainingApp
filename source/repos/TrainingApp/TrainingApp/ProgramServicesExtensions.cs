using TrainingApp.ViewModel;
using TrainingApp.Views;

namespace TrainingApp
{
  public static class ProgramServicesExtensions
  {
    public static IServiceCollection CustomConfigurationService(this IServiceCollection services)
    {
      services.AddSingleton<MainPage>();
      services.AddSingleton<MainPageViewModel>();

      services.AddTransient<ProductDetailsPage>();
      services.AddTransient<ProductDetailsViewModel>();

      services.AddTransient<ManageProductPage>();
      services.AddTransient<ManageProductViewModel>();

      return services;
    }
  }
}
