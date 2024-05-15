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
using static System.Net.Mime.MediaTypeNames;

namespace Notatnik
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool zapisane = false;
        private string sciezka = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Wytnij_Click(object sender, EventArgs e)
        {
            Text.Cut();
        }

        private void Kopiuj_Click(object sender, EventArgs e)
        {
            Text.Copy();
        }

        private void Wklej_Click(object sender, EventArgs e)
        {
            Text.Paste();
        }

        private void Usun_Click(object sender, EventArgs e)
        {
            int poczatekZaznaczenia = Text.SelectionStart;
            Text.Text = Text.Text.Remove(poczatekZaznaczenia, Text.SelectionLength);
            Text.Select(poczatekZaznaczenia, 0);
        }

        private void Otworz_Click(object sender, EventArgs e)
        {
            Otworz();
        }

        private void ZapiszJako_Click(object sender, EventArgs e)
        {
            ZapiszJako();
        }

        private void Zapisz_Click(object sender, EventArgs e)
        {
            Zapisz();
        }
    }
}