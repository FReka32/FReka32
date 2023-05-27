using System;
using System.Collections.Generic;
using System.IO;
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

namespace HelsinkiWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<HelsinkiConsole.Record> adatok= HelsinkiConsole.helsinki1952.AdatokBeolvasasa();
        public MainWindow()
        {
            InitializeComponent();
            dg.ItemsSource=adatok;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            adatok.RemoveAt(dg.SelectedIndex);
            dg.Items.Refresh();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            StreamWriter writer = new StreamWriter("helsinki2.txt");
            foreach(HelsinkiConsole.Record record in adatok)
            {
                writer.WriteLine($"{record.Helyezes} {record.TagokSzama} {record.SportagNeve} {record.VersenyszamNeve} {record.Pontszam}");
            }
            writer.Close();
            MessageBox.Show("Sikeres mentés!");
        }
    }
}
