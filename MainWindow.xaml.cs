using DesignPatterns.Observer;
using DesignPatterns.Proxy;
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

namespace DesignPatterns
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BaseStock ObjBase  = new Observer.BaseStock("Base Object", 1000);

        public MainWindow()
        {
            InitializeComponent();
        }

        #region Singleton Pattern
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Settings.Instance().SampleVariable = txtConstantVal.Text;
                MessageBox.Show("Value Saved in Window 1");
            }
            catch (Exception ex)
            {
                //Error Catching
            }
        }

        private void btnNavigate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SecondPage objSecondPage = new DesignPatterns.SecondPage();
                objSecondPage.ShowDialog();
                txtConstantVal.Text = Settings.Instance().SampleVariable;
            }
            catch (Exception ex)
            {
                //Error Catching
            }
        }
        #endregion

        #region Proxy Pattern
        private void btnSaveProxy_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ProxySubject ObjProxy = new ProxySubject();
                ObjProxy.Request(txtSampleVal.Text);

            }
            catch (Exception ex)
            {
                //Error Catching
            }
        }
        #endregion

        #region Observer Pattern
        private void btnAddInvestor_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ObjBase.Subscribe(new Investor(txtInvestor.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateAmt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ObjBase.Price = Convert.ToDouble(txtNewAmout.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
