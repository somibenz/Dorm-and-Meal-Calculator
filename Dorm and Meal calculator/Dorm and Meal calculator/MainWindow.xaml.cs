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

namespace Dorm_and_Meal_calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int dorm = 0;
        int meal = 0;
        int total = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

     

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (listBox.SelectedIndex == 0)
                {
                    dorm = 1500;
                }
                else if (listBox.SelectedIndex == 1)
                {
                    dorm = 1600;
                }
                else if (listBox.SelectedIndex == 2)
                {
                    dorm = 1800;
                }
                else if (listBox.SelectedIndex == 3)
                {
                    dorm = 2500;
                }
                if (listBox1.SelectedIndex == 0)
                {
                    meal = 600;
                }
                else if (listBox1.SelectedIndex == 1)
                {
                    meal = 1200;
                }
                else if (listBox1.SelectedIndex == 2)
                {
                    meal = 1700;
                }
                total = dorm * meal;
                label.Content = total;
                new form1().Show();
                this.Hide();
            }
            catch (Exception)
            {


            }
        }   
    }
}
