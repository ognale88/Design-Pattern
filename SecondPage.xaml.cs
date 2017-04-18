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
using System.Windows.Shapes;

namespace DesignPatterns
{
    /// <summary>
    /// Interaction logic for SecondPage.xaml
    /// </summary>
    public partial class SecondPage : Window
    {
        public SecondPage()
        {
            try
            {
                InitializeComponent();
                txtConstant.Text = Settings.Instance().SampleVariable;
            }
            catch (Exception ex)
            {
                //Error Catching
            }
        }

        private void btnSaveValue_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Settings.Instance().SampleVariable = txtConstant.Text;
                MessageBox.Show("Value Saved in Window 2");

            }
            catch (Exception ex)
            {
                //Error Catching
            }
        }
    }
}
