using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dgData.ItemsSource = new List<TestItem> { new TestItem(){Name = "测试名称"}};
        }

        private void EventSetter_OnHandler(object sender, KeyboardFocusChangedEventArgs e)
        {
            dgData.CommitEdit();
        }

        private void DgData_OnRowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
        }
    }

    public class TestItem
    {
        public string Name { get; set; }

    }
}