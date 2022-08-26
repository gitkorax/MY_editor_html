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

        private void Boton_etiqueta_h_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.SelectedText = "<" + My_combobox_H.Text.ToString() + ">" 
                + My_textbox.SelectedText 
                + "</" + My_combobox_H.Text.ToString() + ">"
                ;
            My_textbox.Focus();
        }
        
        private void My_combobox_H_DropDownClosed(object sender, EventArgs e)
        {
            Boton_etiqueta_h.Content = My_combobox_H.Text ;
            My_textbox.Focus();
        }

    }
}
