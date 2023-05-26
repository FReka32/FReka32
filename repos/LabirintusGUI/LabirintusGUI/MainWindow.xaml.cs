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
using System.IO;

namespace LabirintusGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 5; i <= 20; i++)
            {
                cmb_Sor.Items.Add(i);
                cmb_Oszlop.Items.Add(i);
                cmb_FajlSorszam.Items.Add(i-4);
            }
            cmb_Sor.SelectedItem = 12;
            cmb_Oszlop.SelectedItem = 12;
            cmb_FajlSorszam.SelectedItem = 3;
        }

        private void btn_Letrehozas_Click(object sender, RoutedEventArgs e)
        {
            //ide kell a törlés
     

            for (int i = vaszon.Children.Count-1; i >=0; i--)
            {
                if (vaszon.Children[i] is CheckBox)
                {
                    vaszon.Children.Remove(vaszon.Children[i] as CheckBox);
                }
            }

            int sor = (int)cmb_Sor.SelectedItem;
            int oszlop = (int)cmb_Oszlop.SelectedItem;
            for (int i = 0; i < sor; i++)
            {
                for (int j = 0; j < oszlop; j++)
                {
                    CheckBox checkBox= new CheckBox();
                    checkBox.Margin= new Thickness(20+j*15,105+i*15,0,0);
                    if(i==0 || i==sor-1)
                    {
                        checkBox.IsChecked= true;
                        checkBox.IsEnabled= false;
                    }
                    if (j == 0 || j == oszlop - 1)
                    {
                        checkBox.IsChecked = true;
                        checkBox.IsEnabled = false;
                    }
                    if(i==1 && j == 0 || (i==sor-2 && j==oszlop-1))
                    {
                        checkBox.IsChecked= false;
                    }
                    vaszon.Children.Add(checkBox);
                }

            }
        }

        private void btn_Mentes_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StreamWriter writer = new StreamWriter("Lab" + cmb_FajlSorszam.Text + ".txt");
                int oszlopSzamlalo = 0;
                int oszlop = (int)cmb_Oszlop.SelectedItem;
                for (int i = 0; i < vaszon.Children.Count; i++)
                {
                   
                    if (vaszon.Children[i] is CheckBox)
                    {
                        oszlopSzamlalo++;
                        if ((bool)(vaszon.Children[i] as CheckBox).IsChecked)
                        {
                            writer.Write("X");
                        }
                        else
                        {
                            writer.Write(" ");
                        }
                    }
                    if (oszlopSzamlalo == oszlop)
                    {
                        writer.WriteLine();
                        oszlopSzamlalo = 0;
                    }
                }
                writer.Close();
                MessageBox.Show("Az állomány mentése sikeres");
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
