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

namespace PeriodicTable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Elements.Add( new Element { Column = 2, Row = 1, Name = "Copper"});
            Elements.Add(new Element { Column = 1, Row = 2, Name = "Gold" });
        }

        public List<Element> Elements { get; set; } = new List<Element>();
    }

    public class Element
    {
        public int Row { get; set; }

        public int Column { get; set; }

        public string Name { get; set; }
    }
}
