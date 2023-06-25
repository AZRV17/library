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
using JSON;

namespace WPFLib
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

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            string input = TextBox.Text;
            List<Class2> s = Class1.LoadFromJson<Class2>();
            foreach (Class2 c in s)
            {
                if (c.name == input) 
                {
                    Name.Text = c.name;
                    Age.Text = c.age.ToString();
                }
            }
        }
    }

    internal class Class2
    {
        public string name;
        public int age;
    }
}
