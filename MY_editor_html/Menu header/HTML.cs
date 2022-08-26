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
        private void Boton_codificar_caracteres_html_Click(object sender, RoutedEventArgs e)
        {
            codificar_caracteres_html();
        }

        private void Boton_decodificar_palabras_html_Click(object sender, RoutedEventArgs e)
        {
            decodificar_caracteres_html();
        }

        private void codificar_caracteres_html()
        {
            My_textbox.SelectedText = System.Web.HttpUtility.HtmlEncode(My_textbox.SelectedText);
        }

        private void decodificar_caracteres_html()
        {
            My_textbox.SelectedText = System.Web.HttpUtility.HtmlDecode(My_textbox.SelectedText);
        }

    }
}
