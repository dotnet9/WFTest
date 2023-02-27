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
            MyDataGrid.ItemsSource = new List<TestItem> { new TestItem(){Name = "测试名称"}};
            this.MouseDown += (s, e) => MyDataGrid.CommitEdit();
        }

        private void DgData_OnMouseLeave(object sender, MouseEventArgs e) {
            MyDataGrid.CommitEdit();
        }
    }

    public class TestItem
    {
        public string Name { get; set; }

    }
}