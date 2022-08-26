using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace MY_editor_html
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            init();
        }

        //cuadros de diaologo
        Microsoft.Win32.OpenFileDialog op = new Microsoft.Win32.OpenFileDialog();
        Microsoft.Win32.OpenFileDialog opcombobox = new Microsoft.Win32.OpenFileDialog();
        Microsoft.Win32.SaveFileDialog sfcombobox = new Microsoft.Win32.SaveFileDialog();
        Microsoft.Win32.SaveFileDialog sf = new Microsoft.Win32.SaveFileDialog();

        private void init()
        {
            // Combobox etiquetas H1 H2...
            My_combobox_H.SelectedIndex = 0;

            Instanciacion_de_etiquetas();

            // fontsize
            _fontsize = new MY_editor_html.Menu_header.FontSize();
            _fontsize.FontSize_aceptar.Click += FontSize_aceptar_Click;
            for (int i = 8; i <= 24; i += 2) _fontsize.FontSize_combobox.Items.Add(i);
            for (int i = 28; i <= 48; i += 4) _fontsize.FontSize_combobox.Items.Add(i);
            _fontsize.FontSize_combobox.SelectedIndex = 2;


            // Cuadros de dialogo
            sf.FileOk += Sf_FileOk;
            sfcombobox.FileOk += Sfcombobox_FileOk;
            sfcombobox.InitialDirectory = Environment.CurrentDirectory;

            op.FileOk += Op_FileOk;

            opcombobox.FileOk += Opcombobox_FileOk;
            opcombobox.InitialDirectory = Environment.CurrentDirectory;


        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _fontsize.Close();
        }

        // Código no utilizado en la aplicación.
        private void pruebas()
        {
            var controles = (UIElementCollection)this.mygrid.Children;

            List<DockPanel> listadockpanels = new List<DockPanel>();
            for (int i = 0; i < controles.Count; i++)
            {
                if (controles[i] is DockPanel)
                {
                    listadockpanels.Add((DockPanel)controles[i]);
                }
            }
            
            for (int i = 0; i < listadockpanels.Count; i++)
            {
                UIElementCollection uie = listadockpanels[i].Children;

                foreach (UIElement u in uie)
                {
                    if (u is Button)
                    {
                        Button b = (Button)u;
                        b.Background = new SolidColorBrush(Color.FromRgb(170, 170, 170));  
                    }                   
                }                
            }      
        }

        private void Boton_etiqueta_main_Click(object sender, RoutedEventArgs e)
        {
            // pruebas();
        }


    }
}




    

       
    
