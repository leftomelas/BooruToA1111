namespace BooruToA1111
{
    partial class FormStats
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            tbxSrc = new TextBox();
            tbxDest = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(389, 257);
            button2.Name = "button2";
            button2.Size = new Size(151, 41);
            button2.TabIndex = 2;
            button2.Text = "実行";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tbxSrc
            // 
            tbxSrc.Location = new Point(156, 55);
            tbxSrc.Name = "tbxSrc";
            tbxSrc.Size = new Size(709, 34);
            tbxSrc.TabIndex = 3;
            // 
            // tbxDest
            // 
            tbxDest.Location = new Point(156, 118);
            tbxDest.Name = "tbxDest";
            tbxDest.Size = new Size(709, 34);
            tbxDest.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 58);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 4;
            label1.Text = "ソース";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 127);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 5;
            label2.Text = "出力先";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("源真ゴシックP Regular", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(417, 181);
            label3.Name = "label3";
            label3.Size = new Size(98, 31);
            label3.TabIndex = 6;
            label3.Text = "処理中...";
            // 
            // FormStats
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 327);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbxDest);
            Controls.Add(tbxSrc);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormStats";
            Text = "FormStats";
            Load += FormStats_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private TextBox tbxSrc;
        private TextBox tbxDest;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}