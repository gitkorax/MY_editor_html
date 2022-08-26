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

        MY_editor_html.Menu_header.FontSize _fontsize;       

        private void Boton_tamaño_fuente_Click(object sender, RoutedEventArgs e)
        {            
            _fontsize.Visibility = Visibility.Visible;         
        }

        private void FontSize_aceptar_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.FontSize = My_textbox.FontSize = Convert.ToDouble(_fontsize.FontSize_combobox.Text);
            _fontsize.Visibility = Visibility.Hidden;
        }

    }
}
