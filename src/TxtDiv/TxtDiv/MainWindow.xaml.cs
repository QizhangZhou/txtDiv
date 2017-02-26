using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;


namespace TxtDiv
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            TxtIO TxtR = new TxtIO();
            TxtDispose TxtDp = new TxtDispose();
            TxtDivFunc1 Func1 = new TxtDivFunc1("TextFile.txt", 32800);
            TxtBox.Text = TxtR.TxtRead("TextFile.txt");
            TxtBlk.Text = TxtR.FileSize("TextFile.txt").ToString();
            Func1.func1(2);

            
        }

    }
}
