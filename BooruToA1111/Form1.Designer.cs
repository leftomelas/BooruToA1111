namespace BooruToA1111
{
    partial class Form1
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
            tbxBooruTags = new TextBox();
            btnConvert = new Button();
            tbxResult = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnCopy = new Button();
            btnRemoveEscape = new Button();
            tbxTargetDir = new TextBox();
            button1 = new Button();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // tbxBooruTags
            // 
            tbxBooruTags.AcceptsReturn = true;
            tbxBooruTags.Location = new Point(30, 38);
            tbxBooruTags.Multiline = true;
            tbxBooruTags.Name = "tbxBooruTags";
            tbxBooruTags.ScrollBars = ScrollBars.Vertical;
            tbxBooruTags.Size = new Size(1133, 139);
            tbxBooruTags.TabIndex = 0;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(1005, 183);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(158, 42);
            btnConvert.TabIndex = 1;
            btnConvert.Text = "Convert(1111)";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // tbxResult
            // 
            tbxResult.AcceptsReturn = true;
            tbxResult.Location = new Point(30, 256);
            tbxResult.Multiline = true;
            tbxResult.Name = "tbxResult";
            tbxResult.ScrollBars = ScrollBars.Vertical;
            tbxResult.Size = new Size(1133, 145);
            tbxResult.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 2;
            label1.Text = "Danbooru Tags";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 228);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 2;
            label2.Text = "Result";
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(1037, 419);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(126, 46);
            btnCopy.TabIndex = 3;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnRemoveEscape
            // 
            btnRemoveEscape.Location = new Point(30, 562);
            btnRemoveEscape.Name = "btnRemoveEscape";
            btnRemoveEscape.Size = new Size(222, 43);
            btnRemoveEscape.TabIndex = 4;
            btnRemoveEscape.Text = "カッコのエスケープを削除";
            btnRemoveEscape.UseVisualStyleBackColor = true;
            btnRemoveEscape.Click += btnRemoveEscape_Click;
            // 
            // tbxTargetDir
            // 
            tbxTargetDir.Location = new Point(30, 522);
            tbxTargetDir.Name = "tbxTargetDir";
            tbxTargetDir.Size = new Size(536, 31);
            tbxTargetDir.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(258, 562);
            button1.Name = "button1";
            button1.Size = new Size(205, 43);
            button1.TabIndex = 6;
            button1.Text = "先頭以外シャッフル";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 494);
            label3.Name = "label3";
            label3.Size = new Size(321, 25);
            label3.TabIndex = 7;
            label3.Text = "キャプションの修正(ディレクトリのパスを入力)";
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(28, 620);
            button2.Name = "button2";
            button2.Size = new Size(185, 40);
            button2.TabIndex = 8;
            button2.Text = "データセットの処理";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(808, 183);
            button3.Name = "button3";
            button3.Size = new Size(164, 42);
            button3.TabIndex = 9;
            button3.Text = "Convert(NovelAI)";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(578, 196);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(180, 29);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "artistとmetaを削除";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1195, 694);
            Controls.Add(checkBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(tbxTargetDir);
            Controls.Add(btnRemoveEscape);
            Controls.Add(btnCopy);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnConvert);
            Controls.Add(tbxResult);
            Controls.Add(tbxBooruTags);
            Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxBooruTags;
        private Button btnConvert;
        private TextBox tbxResult;
        private Label label1;
        private Label label2;
        private Button btnCopy;
        private Button btnRemoveEscape;
        private TextBox tbxTargetDir;
        private Button button1;
        private Label label3;
        private Button button2;
        private Button button3;
        private CheckBox checkBox1;
    }
}