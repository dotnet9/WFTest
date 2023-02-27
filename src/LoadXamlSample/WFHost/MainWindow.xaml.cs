using System.Activities;
using System.Activities.XamlIntegration;
using System.IO;
using System.Text;
using System.Windows;

namespace WFHost
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RunButton_OnClick(object sender, RoutedEventArgs e)
        {
            var utf8 = new UTF8Encoding();
            var bs = utf8.GetBytes(this.Run.Text);
            var memoryStream = new MemoryStream(bs);
            var activity = ActivityXamlServices.Load(memoryStream);
            var instance = new WorkflowApplication(activity);
            instance.Run();
        }
    }
}