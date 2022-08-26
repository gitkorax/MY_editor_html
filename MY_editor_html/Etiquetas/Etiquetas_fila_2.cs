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

        private void Boton_etiqueta_p_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.SelectedText = _Etiqueta_p.Insertar_etiqueta(My_textbox.SelectedText);
            My_textbox.Focus();
        }

        private void Boton_etiqueta_b_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.SelectedText = _Etiqueta_b.Insertar_etiqueta(My_textbox.SelectedText);
            My_textbox.Focus();
        }

        private void Boton_etiqueta_i_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.SelectedText = _Etiqueta_i.Insertar_etiqueta(My_textbox.SelectedText);
            My_textbox.Focus();
        }

        private void Boton_etiqueta_span_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.SelectedText = _Etiqueta_span.Insertar_etiqueta(My_textbox.SelectedText);
            My_textbox.Focus();
        }


        private void Boton_etiqueta_em_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.SelectedText = _Etiqueta_em.Insertar_etiqueta(My_textbox.SelectedText);
            My_textbox.Focus();
        }

        private void Boton_etiqueta_bdo_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.SelectedText = _Etiqueta_bdo.Insertar_etiqueta(My_textbox.SelectedText);
            My_textbox.Focus();
        }

        private void Boton_etiqueta_pre_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.SelectedText = _Etiqueta_pre.Insertar_etiqueta(My_textbox.SelectedText);
            My_textbox.Focus();
        }

        private void Boton_etiqueta_strong_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.SelectedText = _Etiqueta_strong.Insertar_etiqueta(My_textbox.SelectedText);
            My_textbox.Focus();
        }

        private void Boton_etiqueta_code_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.SelectedText = _Etiqueta_code.Insertar_etiqueta(My_textbox.SelectedText);
            My_textbox.Focus();
        }

        private void Boton_etiqueta_br_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.SelectedText = _Etiqueta_br.Insertar_etiqueta(My_textbox.SelectedText);
            My_textbox.Focus();
        }

        private void Boton_etiqueta_hr_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.SelectedText = _Etiqueta_hr.Insertar_etiqueta(My_textbox.SelectedText);
            My_textbox.Focus();
        }

        private void Boton_etiqueta_table_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.SelectedText = _Etiqueta_table.Insertar_etiqueta(My_textbox.SelectedText);
            My_textbox.Focus();
        }

        private void Boton_etiqueta_thead_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.SelectedText = _Etiqueta_thead.Insertar_etiqueta(My_textbox.SelectedText);
            My_textbox.Focus();
        }

        private void Boton_etiqueta_tbody_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.SelectedText = _Etiqueta_tbody.Insertar_etiqueta(My_textbox.SelectedText);
            My_textbox.Focus();
        }

        private void Boton_etiqueta_tfoot_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.SelectedText = _Etiqueta_tfoot.Insertar_etiqueta(My_textbox.SelectedText);
            My_textbox.Focus();
        }

        private void Boton_etiqueta_th_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.SelectedText = _Etiqueta_th.Insertar_etiqueta(My_textbox.SelectedText);
            My_textbox.Focus();
        }

        private void Boton_etiqueta_tr_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.SelectedText = _Etiqueta_tr.Insertar_etiqueta(My_textbox.SelectedText);
            My_textbox.Focus();
        }

        private void Boton_etiqueta_td_Click(object sender, RoutedEventArgs e)
        {
            My_textbox.SelectedText = _Etiqueta_td.Insertar_etiqueta(My_textbox.SelectedText);
            My_textbox.Focus();
        }

    }
}
