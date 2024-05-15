﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
    }
}