using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_editor_html
{
    public class Etiquetas_Model
    {

        public Etiquetas_Model(string apertura, string cierre)
        {
         Apertura = apertura; 
         Cierre = cierre;         
        }

        public string Apertura { get; set; }
        public string Cierre { get; set; }

        public string Insertar_etiqueta(string Contenido)
        {
            return Apertura + Contenido + Cierre;
        }

    }

    public partial class MainWindow
    {

        Etiquetas_Model _Etiqueta_header;
        Etiquetas_Model _Etiqueta_nav;
        Etiquetas_Model _Etiqueta_aside;
        Etiquetas_Model _Etiqueta_section;
        Etiquetas_Model _Etiqueta_article;
        Etiquetas_Model _Etiqueta_footer;
        Etiquetas_Model _Etiqueta_div;
        Etiquetas_Model _Etiqueta_figure;
        Etiquetas_Model _Etiqueta_img;
        Etiquetas_Model _Etiqueta_video;

        Etiquetas_Model _Etiqueta_p;
        Etiquetas_Model _Etiqueta_b;
        Etiquetas_Model _Etiqueta_i;
        Etiquetas_Model _Etiqueta_span;
        Etiquetas_Model _Etiqueta_em;
        Etiquetas_Model _Etiqueta_bdo;
        Etiquetas_Model _Etiqueta_pre;
        Etiquetas_Model _Etiqueta_strong;
        Etiquetas_Model _Etiqueta_code;
        Etiquetas_Model _Etiqueta_br;
        Etiquetas_Model _Etiqueta_hr;

        Etiquetas_Model _Etiqueta_table;
        Etiquetas_Model _Etiqueta_thead;
        Etiquetas_Model _Etiqueta_tbody;
        Etiquetas_Model _Etiqueta_tfoot;
        Etiquetas_Model _Etiqueta_th;
        Etiquetas_Model _Etiqueta_tr;
        Etiquetas_Model _Etiqueta_td;

        Etiquetas_Model _Etiqueta_textbox;

        public void Instanciacion_de_etiquetas ()
        {
            _Etiqueta_header = new Etiquetas_Model("<header>", "</header>");
            _Etiqueta_nav = new Etiquetas_Model("<nav>", "</nav>");
            _Etiqueta_aside = new Etiquetas_Model("<aside", "</aside>");
            _Etiqueta_section = new Etiquetas_Model("<section>", "</section>");
            _Etiqueta_article = new Etiquetas_Model("<article>", "</article>");
            _Etiqueta_footer = new Etiquetas_Model("<footer>", "</footer>");
            _Etiqueta_div = new Etiquetas_Model("<div>", "</div>");
            _Etiqueta_figure = new Etiquetas_Model("<figure>", "</figure>");
            _Etiqueta_img = new Etiquetas_Model("<img src=\"\" alt=\"\">", "</img>");
            _Etiqueta_video = new Etiquetas_Model("<video src=\"\" controls >", "</video>");

            _Etiqueta_p = new Etiquetas_Model("<p>", "</p>");
            _Etiqueta_b = new Etiquetas_Model("<b>", "</b>");
            _Etiqueta_i = new Etiquetas_Model("<i>", "</i>");
            _Etiqueta_span = new Etiquetas_Model("<span>", "</span>");
            _Etiqueta_em = new Etiquetas_Model("<em>", "</em>");
            _Etiqueta_bdo = new Etiquetas_Model("<bdo>", "</bdo>");
            _Etiqueta_pre = new Etiquetas_Model("<pre>", "</pre>");
            _Etiqueta_strong = new Etiquetas_Model("<strong>", "</strong>");
            _Etiqueta_code = new Etiquetas_Model("<code>", "</code>");
            _Etiqueta_br = new Etiquetas_Model("<br>", "");
            _Etiqueta_hr = new Etiquetas_Model("<hr>", "");

            _Etiqueta_table = new Etiquetas_Model("<table>", "</table>");
            _Etiqueta_thead = new Etiquetas_Model("<thead>", "</thead>");
            _Etiqueta_tbody = new Etiquetas_Model("<tbody>", "</tbody>");
            _Etiqueta_tfoot = new Etiquetas_Model("<tfoot>", "</tfoot>");
            _Etiqueta_th = new Etiquetas_Model("<th>", "</th>");
            _Etiqueta_tr = new Etiquetas_Model("<tr>", "</tr>");
            _Etiqueta_td = new Etiquetas_Model("<td>", "</td>");

            _Etiqueta_textbox = new Etiquetas_Model("", "");
        }
    }
}
