

using System.Drawing.Text;
using System.Text;

namespace TestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            StringBuilder str_build = new StringBuilder();
            using (InstalledFontCollection fontsCollection = new InstalledFontCollection())
            {
                FontFamily[] fontFamilies = fontsCollection.Families;

                foreach (FontFamily font in fontFamilies)
                {
                    str_build.Append(font.Name + "\r\n");
                }
            }

            textBox1.Text = str_build.ToString();

        }
    }
}