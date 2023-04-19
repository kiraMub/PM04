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

namespace ClientPM04
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Name_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Name.Text.Length < 3 || Name.Text.Length > 30) // в этой строке указывается диапазон длинны по заданию в билете
            {
                Name.Background = Brushes.Red;
                string name = "Неправильно введены данные";
                textBlock1.Text = name;

            }
            else
            {
                Name.Background = Brushes.Green;
                string name1 = "Вы правильно ввели";
                textBlock1.Text = name1;
            }
        }
        private void LastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (LastName.Text.Length < 2 || LastName.Text.Length > 35) // в этой строке указывается диапазон длинны по заданию в билете
            {
                LastName.Background = Brushes.Red;
                string lastname = "Неправильно введены данные";
                textBlock2.Text = lastname;

            }
            else
            {
                LastName.Background = Brushes.Green;
                string lastname1 = "Вы правильно ввели";
                textBlock2.Text = lastname1;
            }
        }
        

        private void Age_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1) || (Age.Text == "" && e.Text == "-"))
            {
                e.Handled = true;
            }
        }


    }
}


    

