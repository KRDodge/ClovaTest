using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using ClovaTest.Control;
using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using ClovaTest.ViewModel;
using System;

namespace ClovaTest.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        private ViewModelBase _currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                Set(nameof(CurrentViewModel), ref _currentViewModel, value);
            }
        }

        public MainViewModel()
        {
            Messenger.Default.Register<GotoPage>(this, (action) => ReceiveMessage(action));
            CurrentViewModel = ServiceLocator.Current.GetInstance<MainPageModel>();
        }

        private void ReceiveMessage(GotoPage action)
        {
            switch (action.PageName)
            {
                case PageName.Main:
                    CurrentViewModel = ServiceLocator.Current.GetInstance<MainPageModel>();
                    break;
            }
        }
    }
}