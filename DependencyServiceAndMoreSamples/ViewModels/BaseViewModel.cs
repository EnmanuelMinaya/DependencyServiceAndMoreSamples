using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DependencyServiceAndMoreSamples.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public abstract string Title { get; }
        protected INavigationService navigationService { get; }
        public BaseViewModel(INavigationService navigationService)
        {

        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
