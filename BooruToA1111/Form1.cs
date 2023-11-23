using System.Diagnostics;
using System.Text;

namespace BooruToA1111
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            ConvertBooruTags(true);
        }

        private void ConvertBooruTags(bool escapeBracket)
        {
            if (string.IsNullOrEmpty(tbxBooruTags.Text))
            {
                return;
            }

            string removal = Properties.Resources.removal_list;
            removal = removal.Replace("\r\n", "\n");

            string[] tags = removal.Split(char.Parse("\n"));
            string[] sourceTags = tbxBooruTags.Text.Split(char.Parse(" "));
            //Debug.WriteLine("Source tags count is: " + sourceTags.Length);

            if (checkBox1.Checked)
            {
                for (int i = 0; i < tags.Length; i++)
                {
                    for (int j = 0; j < sourceTags.Length; j++)
                    {
                        if (tags[i] == sourceTags[j] && !string.IsNullOrEmpty(tags[i]))
                        {
                            sourceTags[j] = string.Empty;
                            //Debug.WriteLine("Found a tag to remove: " + tags[i]);
                        }
                    }
                }
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < sourceTags.Length; i++)
            {
                if (!string.IsNullOrEmpty(sourceTags[i]))
                {
                    sb.Append(sourceTags[i]);
                    if (i < sourceTags.Length - 1)
                    {
                        sb.Append(", ");
                    }
                }
            }

            string str = sb.ToString();
            str = str.Replace("_", " ");

            if (escapeBracket)
            {
                str = str.Replace("(", "\\(");
                str = str.Replace(")", "\\)");
            }

            tbxResult.Text = str;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxResult.Text))
            {
                return;
            }
            Clipboard.SetText(tbxResult.Text);
        }

        private void btnRemoveEscape_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(tbxTargetDir.Text))
            {
                return;
            }

            try
            {
                string[] files = Directory.GetFiles(tbxTargetDir.Text);

                foreach (string file in files)
                {
                    string extension = Path.GetExtension(file);
                    if (string.IsNullOrEmpty(extension) || extension != ".txt")
                        continue;
                    string txt = File.ReadAllText(file);
                    txt = txt.Replace("\\", string.Empty);

                    File.WriteAllText(file, txt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errored. \r\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("シャッフルしますか。\r\nこの操作はもとに戻せません。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!Directory.Exists(tbxTargetDir.Text))
                {
                    return;
                }

                string[] files = Directory.GetFiles(tbxTargetDir.Text);
                foreach (string file in files)
                {
                    string extension = Path.GetExtension(file);
                    if (string.IsNullOrEmpty(extension) || extension != ".txt")
                        continue;
                    string txt = File.ReadAllText(file);

                    List<string> tags = new List<string>(txt.Split(", "));



                    if (tags.Count > 0)
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append(tags[0]).Append(", ");
                        tags.RemoveAt(0);

                        tags = tags.OrderBy(a => Guid.NewGuid()).ToList();

                        for (int i = 0; i < tags.Count; i++)
                        {
                            sb.Append(tags[i]);
                            if (i < tags.Count - 1)
                            {
                                sb.Append(", ");
                            }
                        }
                        File.WriteAllText(file, sb.ToString());
                        Debug.WriteLine("Shuffule completed: " + file);
                    }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormStats form = new FormStats();
            form.ShowDialog();
            form.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConvertBooruTags(false);
        }
    }
}