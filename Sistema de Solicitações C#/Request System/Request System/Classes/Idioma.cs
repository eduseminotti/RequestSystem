using System.Windows.Forms;

namespace Request_System
{
    public class Idioma
    {
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
        public static void AjustaCultura(LoginValidate frm, string culture)
        {
            AlteraThreadIdioma(culture);

            System.ComponentModel.ComponentResourceManager resx = new System.ComponentModel.ComponentResourceManager(frm.GetType());

            AlteraCultura(frm, resx);
        }
    }
}
