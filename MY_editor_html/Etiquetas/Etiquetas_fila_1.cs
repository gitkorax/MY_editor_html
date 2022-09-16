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

        private void Boton_etiqueta_main_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.SelectedText = _Etiqueta_main.Insertar_etiqueta(My_textbox.SelectedText);
            My_textbox.Focus();
        }


        private void Boton_etiqueta_header_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.SelectedText = _Etiqueta_header.Insertar_etiqueta(My_textbox.SelectedText);
            My_textbox.Focus();
        }

        private void Boton_etiqueta_nav_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.SelectedText = _Etiqueta_nav.Insertar_etiqueta(My_textbox.SelectedText);
            My_textbox.Focus();
        }

        private void Boton_etiqueta_aside_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.SelectedText = _Etiqueta_aside.Insertar_etiqueta(My_textbox.SelectedText);
            My_textbox.Focus();
        }

        private void Boton_etiqueta_section_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.SelectedText = _Etiqueta_section.Insertar_etiqueta(My_textbox.SelectedText);
            My_textbox.Focus();
        }

        private void Boton_etiqueta_article_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.SelectedText = _Etiqueta_article.Insertar_etiqueta(My_textbox.SelectedText);
            My_textbox.Focus();
        }

        private void Boton_etiqueta_footer_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.SelectedText = _Etiqueta_footer.Insertar_etiqueta(My_textbox.SelectedText);
            My_textbox.Focus();
        }

        private void Boton_etiqueta_Div_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.SelectedText = _Etiqueta_div.Insertar_etiqueta(My_textbox.SelectedText);
            My_textbox.Focus();
        }

        private void Boton_etiqueta_figure_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.SelectedText = _Etiqueta_figure.Insertar_etiqueta(My_textbox.SelectedText);
            My_textbox.Focus();
        }

        private void Boton_etiqueta_img_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.SelectedText = _Etiqueta_img.Insertar_etiqueta(My_textbox.SelectedText);
            My_textbox.Focus();
        }

        private void Boton_etiqueta_video_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.SelectedText = _Etiqueta_video.Insertar_etiqueta(My_textbox.SelectedText);
            My_textbox.Focus();
        }

    }
}
