using Microsoft.Win32;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace desktopowa
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

        //Encrypt
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var textToEncrpypt = textTextBox.Text;
            int key = 0;
            if(int.TryParse(keyTextBox.Text, out key)){

            }

            var encryptedText = Encrypt(textToEncrpypt, key);

            encryptedTextBlock.Text = encryptedText;
        }

        //Save to file
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var fileDialog = new SaveFileDialog();
            fileDialog.DefaultExt = ".txt";

            var result = fileDialog.ShowDialog();

            if (result == true)
            {
                File.WriteAllText(fileDialog.FileName, encryptedTextBlock.Text);
            }
        }


        static string Encrypt(string text, int key)
        {
            if (key == 0)
            {
                return text;
            }

            var encryptedText = "";
            var displace = key % 26;

            for (var i = 0; i < text.Length; i++)
            {
                var c = text[i];

                if (c != ' ')
                {
                    c += (char)displace;
                    if (c < 97)
                    {
                        c += (char)26;
                    }
                    else if (c > 122)
                    {
                        c -= (char)26;
                    }
                }

                encryptedText += c;
            }

            return encryptedText;
        }
    }
}