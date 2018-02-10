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

namespace Wpf2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            Controller.GetInstance().AddPerson();
            Controller.GetInstance().CurentPerson.FirstName = Textbox1.Text;
            Controller.GetInstance().CurentPerson.LastName = Textbox2.Text;
            Controller.GetInstance().CurentPerson.Age = Convert.ToInt32(Textbox3.Text);
            Controller.GetInstance().CurentPerson.TelephoneNr = Textbox4.Text;
            PersonCount.Content = Controller.GetInstance().PerconCount;
            Index.Content = Controller.GetInstance().PersonIndex;
            
            //Alternativ måde at lave personcount og index
            //int percount = Convert.ToInt32(PersonCount.Content);
            //PersonCount.Content = percount + 1;
            //int perindex = Convert.ToInt32(PersonCount.Content);
            //perindex = percount - 1;
            //Index.Content = perindex + 1;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Controller.GetInstance().DeletePerson();
            PersonCount.Content = Controller.GetInstance().PerconCount;
            Index.Content = Controller.GetInstance().PersonIndex;
            if (Controller.GetInstance().CurentPerson != null)
            {
                Textbox1.Text = Controller.GetInstance().CurentPerson.FirstName;
                Textbox2.Text = Controller.GetInstance().CurentPerson.LastName;
                Textbox3.Text = Controller.GetInstance().CurentPerson.Age.ToString();
                Textbox4.Text = Controller.GetInstance().CurentPerson.TelephoneNr;
            }
        }

        private void Up_Click(object sender, RoutedEventArgs e)
        {
            Controller.GetInstance().NextPerson();
            Textbox1.Text = Controller.GetInstance().CurentPerson.FirstName;
            Textbox2.Text = Controller.GetInstance().CurentPerson.LastName;
            Textbox3.Text = Controller.GetInstance().CurentPerson.Age.ToString();
            Textbox4.Text = Controller.GetInstance().CurentPerson.TelephoneNr;
        }

        private void Down_Click(object sender, RoutedEventArgs e)
        {
            Controller.GetInstance().PrevPerson();
            Textbox1.Text = Controller.GetInstance().CurentPerson.FirstName;
            Textbox2.Text = Controller.GetInstance().CurentPerson.LastName;
            Textbox3.Text = Controller.GetInstance().CurentPerson.Age.ToString();
            Textbox4.Text = Controller.GetInstance().CurentPerson.TelephoneNr;

        }
    }
}
