using Microsoft.UI.Xaml;
using FirstWinUI.ViewModels;

namespace FirstWinUI
{

    public sealed partial class MainWindow : Window
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();
        public MainWindow()
        {
           this.InitializeComponent();

            (this.Content as FrameworkElement).DataContext = ViewModel;

        }
    }
}
