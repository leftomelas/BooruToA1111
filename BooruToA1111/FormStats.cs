using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.VisualBasic.FileIO;

namespace BooruToA1111
{
    public partial class FormStats : Form
    {
        public FormStats()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(tbxSrc.Text) || !Directory.Exists(tbxDest.Text))
            {
                MessageBox.Show("ディレクトリが見つかりません", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("開始します。よろしいですか。", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (!Directory.Exists(tbxDest.Text + "\\images"))
                {
                    Directory.CreateDirectory(tbxDest.Text + "\\images");
                }
                if (!Directory.Exists(tbxDest.Text + "\\captions"))
                {
                    Directory.CreateDirectory(tbxDest.Text + "\\captions");
                }
                label3.Visible = true;
                string[] dirs = Directory.GetDirectories(tbxSrc.Text);
                foreach (string dir in dirs)
                {
                    string[] files = Directory.GetFiles(dir);
                    foreach (string file in files)
                    {
                        string ext = Path.GetExtension(file).ToLower();
                        if (ext != ".txt")
                        {
                            if (ext == ".mp4" || ext == ".gif")
                            {
                                string path = Path.GetDirectoryName(file) + "\\";
                                string captionFile = Path.GetFileNameWithoutExtension(file);
                                //Debug.WriteLine("Found a mp4/gif file. md5 hash is: " + file);
                                if (File.Exists(path + captionFile + ".txt"))
                                    FileSystem.DeleteFile(path + captionFile + ".txt", UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                                FileSystem.DeleteFile(file, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                            }
                            else if (ext == ".png" || ext == ".jpg" || ext == ".jpeg")
                            {
                                string path = Path.GetDirectoryName(file) + "\\";
                                string captionFile = Path.GetFileNameWithoutExtension(file);
                                if (File.Exists(path + captionFile + ".txt") && !File.Exists(tbxDest.Text + "\\captions\\" + captionFile + ".txt"))
                                {
                                    File.Move(path + captionFile + ".txt", tbxDest.Text + "\\captions\\" + captionFile + ".txt");
                                }

                                string imageFile = Path.GetFileName(file);
                                if (!File.Exists(tbxDest.Text + "\\images\\" + imageFile))
                                    File.Move(file, tbxDest.Text + "\\images\\" + imageFile);

                            }
                        }
                    }
                }
                label3.Visible = false;
            }
        }

        private void FormStats_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
        }
    }
}
