using Microsoft.Win32;
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

namespace Perfwill_Smith
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Pessoa pessoaAtual;

        public MainWindow()
        {
            InitializeComponent();
            imgShit.Source = new BitmapImage(new Uri("D:/higor/Perfwill Smith/anonymous.jpg"));
        }

        private void btnSetImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            imgShit.Source = new BitmapImage(new Uri(fileDialog.FileName));
        }

        private void btnNovoJogo_Click(object sender, RoutedEventArgs e)
        {
            txtPalpite.IsEnabled = true;
            btnPalpitar.IsEnabled = true;
            btnDica.IsEnabled = true;

            pessoaAtual.NomeAtual = "D'Addario";
        }

        private void btnPalpitar_Click(object sender, RoutedEventArgs e)
        {
            if (txtPalpite.Text == pessoaAtual.NomeAtual)
            {

            }
        }
    }
}
