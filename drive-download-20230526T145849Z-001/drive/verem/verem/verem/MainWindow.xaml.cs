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

namespace verem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int verem_meret;
        private Verem ujverem;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void verem_button_Click(object sender, RoutedEventArgs e)
        {
            verem_meret = Convert.ToInt32(verem_textbox.Text);
            ujverem = new Verem(verem_meret);
            verem_box.Height = verem_meret * 23;
            verem_box.Visibility = Visibility.Visible;
        }

        private void pop_button_Click(object sender, RoutedEventArgs e)
        {
            int szam = ujverem.Pop();
            if(szam == -1)
            {
                hiba_text.Content = "Üres verem!";
            }
            else
            {
                pop_textbox.Text = szam + "";
            }
            kiir();
        }

        private void push_button_Click(object sender, RoutedEventArgs e)
        {
            int szam = Convert.ToInt32(push_textbox.Text);
            
            if (ujverem.Tartalom().Count() == verem_meret)
            {
                hiba_text.Content = "Telített verem!";
            }
            else
            {
                ujverem.Push(szam);
            }
            push_textbox.Text = "";
            kiir();
        }
        private void kiir()
        {
            List<int> ujveremlistaforditva = ujverem.Tartalom();
            for (int i = ujveremlistaforditva.Count(); i > 0; i--)
            {
                verem_box.DataContext += ujveremlistaforditva[i] + "\n";
            }
            
        }
    }
}
