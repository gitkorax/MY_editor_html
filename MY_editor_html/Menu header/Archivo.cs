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
        
        string _path = "";
        bool guardado = false;

        private void My_textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            guardado = false;
        }
        private void Boton_archivo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Boton_nuevo_Click(object sender, RoutedEventArgs e)
        {
             guardar(_path);

            if ( guardado == true)
            {
                My_textbox.Text = "";
                _path = "";
                guardado = false;
            }
        }

        private MessageBoxResult resultado_pregunta_guardar()
        {
            MessageBoxResult r = MessageBox.Show(" ¿Guardar los cambios? ", "Salir de la aplicación", MessageBoxButton.YesNo);
            return r;
        }

        // Código del el botón de abrir documento
        
        private void Boton_abrir_documento_Click(object sender, RoutedEventArgs e)
        {
            op.ShowDialog();
        }

        private void Op_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.IO.StreamReader sr = new System.IO.StreamReader(op.FileName);
            My_textbox.Text = sr.ReadToEnd();
            _path = op.FileName;
            sr.Close();
        }

        // -----------------------------------------
        private void Boton_guardar_Click ( object sender, RoutedEventArgs e)
        {
            if (System.IO.File.Exists(_path))
            {
                guardar(_path);
                guardado = true;
                
            }else diaologoguardar();      
        }

        private void Boton_guardar_como_Click ( object sender, RoutedEventArgs e)
        {
            diaologoguardar();            
        }


        private void Boton_abrir_combobox_Click(object sender, RoutedEventArgs e)
        {
            opcombobox.ShowDialog();
        }

        private void Opcombobox_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string[] datos = System.IO.File.ReadAllLines(opcombobox.FileName);

            for (int i = 0; i < datos.Length / 2; i++)
            {
                CB_apertura.Items.Add(datos[i]);
            }

            for (int i = datos.Length / 2; i < datos.Length; i++)
            {
                CB_cierre.Items.Add(datos[i]);
            }


        }


        // Código del guardado del combobox 

        string _pathcombobox;
        private void Boton_guardar_combobox_Click(object sender, RoutedEventArgs e)
        {
            sfcombobox.ShowDialog();
        }

        private void Sfcombobox_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _pathcombobox = sfcombobox.FileName;
            string[] datos = new string[CB_apertura.Items.Count ];
            for (int i = 0; i < CB_apertura.Items.Count; i++)
            {
                datos[i] = CB_apertura.Items[i].ToString();
            }

            string[] datos2 = new string[CB_cierre.Items.Count];
            for (int i = 0; i < CB_cierre.Items.Count; i++)
            {
                datos2[i] = CB_cierre.Items[i].ToString();
            }
            datos = datos.Concat(datos2).ToArray();

            System.IO.File.WriteAllLines(_pathcombobox, datos);
        }

        // --------------

        private void Boton_salir_Click( object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();            
        }


        private void guardar(string path)
        {
            if (path == "") diaologoguardar(); else System.IO.File.WriteAllText(path, My_textbox.Text);
        }

        
        private void diaologoguardar()
        {
            sf.Filter = "html|*.html|txt|*.txt|Todos los tipos de archivo *.*|*.*"; ;
            sf.ShowDialog();            
        }


        private void Sf_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.IO.File.WriteAllText(sf.FileName, My_textbox.Text);
            _path = sf.FileName;
            guardado = true;
            
        }

    }
}
