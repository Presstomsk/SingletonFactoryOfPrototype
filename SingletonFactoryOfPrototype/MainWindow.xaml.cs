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

namespace SingletonFactoryOfPrototype
{
    /// <summary>
    /// TODO: Создать Singletone фабрику, которая выпускает клонов людей. 
    /// </summary>

   
    
    public partial class MainWindow : Window
    {
        

        CloneHumanFactory cloneFactory;
        IHuman man;
        IHuman clone;
        public MainWindow()
        {
            InitializeComponent();
            cloneFactory = CloneHumanFactory.GetSingletone();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            man = new Person("Bob", 45);
            Tb1.Text = man.Name;
            Tb2.Text = man.Age.ToString();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            clone = cloneFactory.HumanCloneFactory(man);
            if (clone != default)
            {
                Tb3.Text = clone.Name;
                Tb4.Text = clone.Age.ToString();
            }
        }
    }
}
