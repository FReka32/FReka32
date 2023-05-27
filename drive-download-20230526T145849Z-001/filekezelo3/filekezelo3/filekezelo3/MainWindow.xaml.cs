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

namespace filekezelo3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string path = Directory.GetCurrentDirectory();
            kiirmindent(path);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
        }

        
        private void kiirmindent(string path)
        {
            
            /*richTextBox1.Document.Blocks.Clear();
            richTextBox1.AppendText("A jelenlegi elérési út:" + "\n\n");
            richTextBox1.AppendText(path + "\n");
            richTextBox1.AppendText("mappák:" + "\n");*/
            string[] mappak = Directory.GetDirectories(path);
            string[] fajlok = Directory.GetFiles(path);
            List<string> lista = new List<string>();
            lista.Add("..");
            foreach (var item in mappak)
            {
                string[] darabok = item.Split('\\');
                //richTextBox1.AppendText(darabok[darabok.Length - 1] + "\n");
                lista.Add("[M] " + darabok[darabok.Length - 1]);
            }

            //richTextBox1.AppendText("fájlok:" + "\n");
            
            foreach (var item in fajlok)
            {
                string[] darabok = item.Split('\\');
                //richTextBox1.AppendText(darabok[darabok.Length - 1] + "\n");
                lista.Add("[f] " + darabok[darabok.Length - 1]);
            }
            listBox1.ItemsSource = lista;
            listBox1.Items.Refresh();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(listBox1.SelectedItem.ToString() == "..")
            {
                richTextBox1.Document.Blocks.Clear();
                string path = Directory.GetCurrentDirectory();
                string newpath = System.IO.Path.GetDirectoryName(path);
                Directory.SetCurrentDirectory(newpath);
                kiirmindent(newpath);
                richTextBox1.AppendText(newpath + "\n");

            }
            else
            {
                string[] nevdarabok = listBox1.SelectedItem.ToString().Split(' ');
                richTextBox1.Document.Blocks.Clear();
                if(nevdarabok[0] == "[M]")
                {
                    string path = Directory.GetCurrentDirectory();
                    string newpath = path + "\\" + nevdarabok[1];
                    Directory.SetCurrentDirectory(newpath);
                    kiirmindent(newpath);
                    richTextBox1.AppendText(path + "\n");
                }
        
            }
        }
    }
}
