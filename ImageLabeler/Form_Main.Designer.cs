namespace ImageLabeler
{
    partial class Form_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            label1 = new Label();
            TB_path = new TextBox();
            label2 = new Label();
            label3 = new Label();
            TB_result = new TextBox();
            TB_regex = new TextBox();
            label5 = new Label();
            Btn_Start = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "path";
            // 
            // TB_path
            // 
            TB_path.Location = new Point(64, 38);
            TB_path.Name = "TB_path";
            TB_path.Size = new Size(631, 27);
            TB_path.TabIndex = 1;
            TB_path.TextChanged += TB_path_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(663, 20);
            label2.TabIndex = 2;
            label2.Text = "画像のファイルネームで画像中にラベルを作る　pathにはフォルダの名前がbeforeとafterがあるディレクトリを入力";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 89);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 3;
            label3.Text = "regex";
            // 
            // TB_result
            // 
            TB_result.Location = new Point(64, 137);
            TB_result.Multiline = true;
            TB_result.Name = "TB_result";
            TB_result.RightToLeft = RightToLeft.No;
            TB_result.ScrollBars = ScrollBars.Both;
            TB_result.Size = new Size(631, 301);
            TB_result.TabIndex = 5;
            // 
            // TB_regex
            // 
            TB_regex.Location = new Point(64, 86);
            TB_regex.Multiline = true;
            TB_regex.Name = "TB_regex";
            TB_regex.Size = new Size(261, 27);
            TB_regex.TabIndex = 6;
            TB_regex.TextChanged += TB_regex_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 137);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 8;
            label5.Text = "result";
            // 
            // Btn_Start
            // 
            Btn_Start.Location = new Point(331, 86);
            Btn_Start.Name = "Btn_Start";
            Btn_Start.Size = new Size(364, 27);
            Btn_Start.TabIndex = 9;
            Btn_Start.Text = "START";
            Btn_Start.UseVisualStyleBackColor = true;
            Btn_Start.Click += Btn_Start_Click;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 460);
            Controls.Add(Btn_Start);
            Controls.Add(label5);
            Controls.Add(TB_regex);
            Controls.Add(TB_result);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TB_path);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Main";
            Text = "FM_imagelabeler";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TB_path;
        private Label label2;
        private Label label3;
        private TextBox TB_result;
        private TextBox TB_regex;
        private Label label4;
        private Label label5;
        private Button Btn_Start;
    }
}