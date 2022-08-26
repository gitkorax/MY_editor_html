using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MY_editor_html
{
    public partial class MainWindow
    {
        private void Añadir_Click(object sender, RoutedEventArgs e)
        {
            CB_apertura.Items.Add(Textbox_apertura.Text);
            CB_cierre.Items.Add(Textbox_cierre.Text);
        }

        private void Eliminar_Click(object sender, RoutedEventArgs e)
        {
            CB_apertura.Items.Remove(CB_apertura.SelectedItem);
            CB_cierre.Items.Remove(CB_cierre.SelectedItem);
        }
        private void CB_apertura_DropDownClosed(object sender, EventArgs e)
        {
            if(CB_apertura.Text != "") Textbox_apertura.Text = CB_apertura.Text;
            CB_cierre.SelectedIndex = CB_apertura.SelectedIndex;
        }

        private void CB_cierre_DropDownClosed(object sender, EventArgs e)
        {
           if(CB_cierre.Text != "") Textbox_cierre.Text = CB_cierre.Text;
        }        
    }
}
