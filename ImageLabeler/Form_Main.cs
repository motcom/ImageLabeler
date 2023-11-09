using System.Text;
using System.Text.RegularExpressions;
namespace ImageLabeler
{
    public partial class Form_Main : Form
    {
        private Dictionary<string, FileInfo> dict_matname_to_filepath;
        private List<FileInfo> src_file_lst;
        private DirectoryInfo? before_dir;
        private DirectoryInfo? after_dir;
        private const float rasio_font_height = 0.038f;
        private const float rasio_region_height = 0.053f;
        private const float rasio_region_postion = 0.917f;
        private const float rasio_font_width = 0.0275f;
        public Form_Main()
        {
            InitializeComponent();
            dict_matname_to_filepath = new Dictionary<string, FileInfo>();
            src_file_lst = new List<FileInfo>();
            TB_regex.Text = @"matPreview_.*?|_v_VR.jpg";

        }

        private void TB_path_TextChanged(object sender, EventArgs e)
        {
            DirectoryInfo? directory = new DirectoryInfo(TB_path.Text);

            if (directory == null) { return; }

            if (!directory.Exists) { return; }

            foreach (var fp in directory.GetDirectories())
            {
                if (fp is not null)
                {
                    if (fp.Name == "before")
                    {
                        before_dir = new DirectoryInfo(fp.FullName);
                    }

                    if (fp.Name == "after")
                    {
                        after_dir = new DirectoryInfo(fp.FullName);
                    }
                }
            }

            if (before_dir == null) return;

            // src_filename_lst_init and dst_filename_lst_init
            src_file_lst.Clear();
            foreach (var file in before_dir.EnumerateFiles())
            {
                src_file_lst.Add(file);
            }

            TB_regex_TextChanged(sender, e);
        }

        private void TB_regex_TextChanged(object sender, EventArgs e)
        {
            // RegexçÏê¨
            dict_matname_to_filepath.Clear();
            foreach (var file in src_file_lst)
            {
                dict_matname_to_filepath[Regex.Replace(file.Name, TB_regex.Text, "")] = file;
            }
            update_TB_result();
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            foreach (var key_mat_name in dict_matname_to_filepath.Keys)
            {
                Image img = Image.FromFile(dict_matname_to_filepath[key_mat_name].FullName);
                var region_pos = (int)(img.Height * rasio_region_postion);
                var region_height = (int)(img.Height * rasio_region_height);
                var font_height = (int)(img.Height * rasio_font_height);
                var font_width = (int)(img.Width * rasio_font_width);

                using (Graphics g = Graphics.FromImage(img))
                {
                    //Å@îºìßñæÇÃãÈå`Çï`Ç≠
                    using (Brush semiTransBrush = new SolidBrush(Color.FromArgb(179, Color.White)))
                    {

                        Rectangle rect = new Rectangle(0, region_pos, img.Width, region_height);
                        g.FillRectangle(semiTransBrush, rect);
                    }

                    // ï∂éöÇèëÇ´çûÇﬁ
                    using (Font font = new Font("Consolas", font_height, FontStyle.Regular, GraphicsUnit.Pixel))
                    {
                        using (Brush brush = new SolidBrush(Color.FromArgb(255, 50, 50, 50)))
                        {
                            int font_size = (int)(rasio_font_height * img.Height);
                            int offset_x = (int)((img.Width / 2) - g.MeasureString(key_mat_name, font).Width / 2);
                            Point str_start_point = new Point(offset_x, region_pos + ((region_height - font_size) / 2));

                            g.DrawString(key_mat_name, font, brush, str_start_point);

                        }
                    }
                }

                if (after_dir != null)
                {
                    img.Save(after_dir.FullName + "\\" + key_mat_name + ".jpg");
                }

            }
            this.Update();

        }

        // Utility------------------------------------------------------------ 
        private void update_TB_result()
        {
            StringBuilder str_build = new StringBuilder();
            foreach (var mat_name in dict_matname_to_filepath.Keys)
            {
                str_build.Append(mat_name + "\r\n");
            }

            TB_result.Text = str_build.ToString();

        }
    }

}