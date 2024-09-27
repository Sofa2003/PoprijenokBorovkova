using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
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

namespace PoprijenokBorovkova
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        
        public Window1(int pr)
        {
            InitializeComponent();
            priorety.Text = pr.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                helper.flag = true;
                helper.prioritet = Convert.ToInt32(priorety.Text);
                this.Close();
            } catch (Exception ex) { MessageBox.Show("Введите целочисленное значение "); }
           

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
