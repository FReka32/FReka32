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

namespace KaracsonyWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<int> list = new List<int>();
            for (int i = 0 ; i < 40; i++)
            {
                list.Add(i+1);
            }
            comboBox1.ItemsSource = list;
            comboBox1.SelectedIndex = 0;
        }
        string szoveg = "";
        
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int nap = Convert.ToInt32(comboBox1.SelectedItem);
            int elkeszitett = Convert.ToInt32(textBox1.Text);
            int eladott = Convert.ToInt32(textBox2.Text);

            if (elkeszitett < 0 || eladott < 0 || elkeszitett - eladott < 0)
            {
                label4.Content = "Nem lehet negatív!";
            }
            else
            {
                label4.Content = "";
                szoveg += nap + " .nap\t" + elkeszitett + " db\t" + eladott + " db\n";
                richTextBox1.Document.Blocks.Clear();
                richTextBox1.Document.Blocks.Add(new Paragraph(new Run(szoveg)));
                List<int> list = new List<int>();
                for (int i = nap; i < 40; i++)
                {
                    list.Add(i + 1);
                }
                comboBox1.ItemsSource = list;
                comboBox1.SelectedIndex = 0;
            }
        }
    }
}
