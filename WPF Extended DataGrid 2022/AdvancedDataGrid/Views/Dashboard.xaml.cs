using MultiEventCommand.ViewModels;
using System.Windows;

namespace MultiEventCommand.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Dashboard
    {
        readonly DashboardViewModel _model=new DashboardViewModel();
        public Dashboard()
        {
         
            DataContext = _model;
            InitializeComponent();
            
        }

        private void RibbonWindow_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            this.Title = "WPF Extended DataGrid " + System.Windows.Forms.Application.ProductVersion;
        }
    }
}
