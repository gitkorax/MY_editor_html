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

        private void Boton_cortar_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.Cut();
            My_textbox.SelectedText = "";
        }

        private void Boton_copiar_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.Copy();
        }

        private void Boton_pegar_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.Paste();
        }

        private void Boton_seleccionar_todo_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.SelectAll();
        }

        private void Boton_deshacer_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.Undo();
        }

        private void Boton_rehacer_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.Redo();
        }
       
    }

}
