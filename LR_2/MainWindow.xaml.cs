using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LR_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClassAero aero = new ClassAero();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSaveaero_Click(object sender, RoutedEventArgs e)
        {
            aero.NAME = TxtN.Text;
            aero.Num = double.Parse(TxtN2.Text);
            aero.TYPE = TxtStip.Text;

            LstAero.Items.Clear();
            LstAero.Items.Add(aero.PrintToScreen());
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == false)
                return;
            aero.SaveToFile(saveFileDialog.FileName);
        }
    }
}
