using Prism.Navigation;
using System.ComponentModel;

namespace DependencyServiceAndMoreSamples.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public abstract string Title { get; }
        protected INavigationService NavigationService { get; }
        public BaseViewModel(INavigationService NavigationService)
        {

        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
