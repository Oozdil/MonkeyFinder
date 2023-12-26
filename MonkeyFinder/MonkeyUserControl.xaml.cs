using MonkeyFinder.Models;
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

namespace MonkeyFinder
{
    /// <summary>
    /// Interaction logic for MonkeyUserControl.xaml
    /// </summary>
    public partial class MonkeyUserControl : UserControl
    {
        public MonkeyUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        public string Image { get; set; }
        public string MonkeyName { get; set; }
        public string Location { get; set; }
        public Monkey MyMonkey { get; set; }
    }
}
