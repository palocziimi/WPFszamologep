using System;
using System.Windows;
using System.Windows.Input;

namespace szamologep
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOsszead_Click(object sender, RoutedEventArgs e)
        {
            String eredmeny = $"{txtAszam.Text} + {txtBszam.Text} = {Convert.ToDouble(txtAszam.Text) + Convert.ToDouble(txtBszam.Text)}";
            MessageBox.Show("Az összeadás eredménye: " + eredmeny);
            lbEredmenyek.Items.Add(eredmeny);
            
        }

        private void btnKivon_Click(object sender, RoutedEventArgs e)
        {
            String eredmeny = $"{txtAszam.Text} - {txtBszam.Text} = {Convert.ToDouble(txtAszam.Text) - Convert.ToDouble(txtBszam.Text)}";
            MessageBox.Show("Az összeadás eredménye: " + eredmeny);
            lbEredmenyek.Items.Add(eredmeny);
        }

        private void btnSzoroz_Click(object sender, RoutedEventArgs e)
        {
            String eredmeny = $"{txtAszam.Text} * {txtBszam.Text} = {Convert.ToDouble(txtAszam.Text) * Convert.ToDouble(txtBszam.Text)}";
            MessageBox.Show("Az összeadás eredménye: " + eredmeny);
            lbEredmenyek.Items.Add(eredmeny);
        }

        private void btnOszt_Click(object sender, RoutedEventArgs e)
        {

            if (Convert.ToDouble(txtBszam.Text) == 0)
                return;
            
            String eredmeny = $"{txtAszam.Text} / {txtBszam.Text} = {Convert.ToDouble(txtAszam.Text) / Convert.ToDouble(txtBszam.Text)}";
            MessageBox.Show("Az összeadás eredménye: " + eredmeny);
            lbEredmenyek.Items.Add(eredmeny);
        }

        private void lbEredmenyek_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            String bevitel = lbEredmenyek.SelectedItem.ToString();
            txtAszam.Text = bevitel.Split(' ')[0];
            txtBszam.Text = bevitel.Split(' ')[2];
        }
    }
}
