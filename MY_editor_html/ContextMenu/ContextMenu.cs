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

        // Menu contextual del textbox principal
        private void My_textbox_Cortar_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.Cut();
            My_textbox.SelectedText = "";

        }

        private void My_textbox_Copiar_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.Copy();
        }

        private void My_textbox_Pegar_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.Paste();
        }

        private void My_textbox_seleccionar_todo_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.SelectAll();
        }

        private void My_textbox_codificar_caracteres_Click(object sender, RoutedEventArgs e)
        {
            codificar_caracteres_html();
        }

        private void My_text_decodificar_palabras_Click(object sender, RoutedEventArgs e)
        {
            decodificar_caracteres_html();
        }
        private void My_textbox_Deshacer_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.Undo();
        }

        private void My_textbox_Rehacer_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.Redo();
        }

        // Menu contextual del textbox de apertura

        private void textbox_apertura_contextmenu_cortar_Click(object sender, RoutedEventArgs e)
        {
            Textbox_apertura.Cut();
            Textbox_apertura.SelectedText = "";
        }

        private void textbox_apertura_contextmenu_copiar_Click(object sender, RoutedEventArgs e)
        {
            Textbox_apertura.Copy();
        }

        private void textbox_apertura_contextmenu_pegar_Click(object sender, RoutedEventArgs e)
        {
            Textbox_apertura.Paste();
        }

        // Menu contextual del textbox de cierre

        private void textbox_cierre_contextmenu_cortar_Click(object sender, RoutedEventArgs e)
        {
            Textbox_cierre.Cut();
            Textbox_cierre.SelectedText = "";
        }

        private void textbox_cierre_contextmenu_copiar_Click(object sender, RoutedEventArgs e)
        {
            Textbox_cierre.Copy();
        }

        private void textbox_cierre_contextmenu_pegar_Click(object sender, RoutedEventArgs e)
        {
            Textbox_cierre.Paste();
        }

    }
}
