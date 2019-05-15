using System.Windows.Forms;

namespace Request_System
{
    /// <summary>
    /// Classe responsavel por traduzir os itens de telas da aplicação
    /// </summary>
    public class Idioma
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="culture"></param>

        private static void AlteraThreadIdioma(string culture)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(culture, true);
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture, true);
        }
        private static void AlteraCultura(LoginValidate frm, System.ComponentModel.ComponentResourceManager resx)
        {
            frm.Text = resx.GetObject("$this.Text", System.Threading.Thread.CurrentThread.CurrentCulture).ToString();

            foreach (Control ctrl in frm.Controls)
                resx.ApplyResources(ctrl, ctrl.Name, System.Threading.Thread.CurrentThread.CurrentCulture);
        }
        /// <summary>
        /// Recebe indicação do idioma utilizado para o usuario e realiza a tradução
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="culture"></param>
        public static void AjustaCultura(LoginValidate frm, string culture)
        {
            AlteraThreadIdioma(culture);

            System.ComponentModel.ComponentResourceManager resx = new System.ComponentModel.ComponentResourceManager(frm.GetType());

            AlteraCultura(frm, resx);
        }
    }
}
