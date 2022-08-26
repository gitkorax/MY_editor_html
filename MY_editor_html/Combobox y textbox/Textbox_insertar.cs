using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MY_editor_html
{
public partial class MainWindow
    {
        private void Button_insertar_textboxes_Click(object sender, RoutedEventArgs e)
        {
            _Etiqueta_textbox.Apertura = Textbox_apertura.Text;
            _Etiqueta_textbox.Cierre = Textbox_cierre.Text;

            My_textbox.SelectedText =  _Etiqueta_textbox.Insertar_etiqueta(My_textbox.SelectedText);
            My_textbox.Focus();

            
        }
    }
}
