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

namespace GroupProject1_Book_Store
{
    /// <summary>
    /// Interação lógica para U
    /// </summary>
    public partial class UserControlEscolha : UserControl
    {
        clsBookManager BookManager;
        public UserControlEscolha()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            String name = "The Silent Wife";
            BookManager = new clsBookManager();
            txtdesc1.Text = BookManager.GetBookDesc(name);
            txtcost1.Text = BookManager.GetBookCost(name);
            txtname1.Text = BookManager.GetBookAuth(name);
            name = "To sleep in a sea of stars";
            txtcost2.Text = BookManager.GetBookCost(name);
            txtdesc2.Text = BookManager.GetBookDesc(name);
            txtname2.Text = BookManager.GetBookAuth(name);
            name = "The Way of Kings";
            txtcost3.Text = BookManager.GetBookCost(name);
            txtdesc3.Text = BookManager.GetBookDesc(name);
            txtname3.Text = BookManager.GetBookAuth(name);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void txtname1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}