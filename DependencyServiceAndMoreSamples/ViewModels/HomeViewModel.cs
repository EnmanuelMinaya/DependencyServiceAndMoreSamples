using DependencyServiceAndMoreSamples.Services;
using Prism.Commands;
using Prism.Navigation;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace DependencyServiceAndMoreSamples.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel(INavigationService NavigationService) : base(NavigationService)
        {
            GetOrientationCommand = new DelegateCommand(() =>
            {
                DeviceOrientation orientation = DependencyService.Get<IDeviceOrientationService>().GetOrientation();
                OrientationText = orientation.ToString();
            });
        }

        public ICommand GetOrientationCommand { get; }

        public DeviceOrientation Orientation;

        public override string Title => "Home";
        public string OrientationText { get; set; }

    }
}
