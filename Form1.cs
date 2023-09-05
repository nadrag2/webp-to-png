using Microsoft.VisualBasic.ApplicationServices;
using System.IO;

namespace Webp_to_PNG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lb1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void lb1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                lb1.Items.Add(file);
            }
        }

        private void btComecar_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = lb1.Items.Count;
            int index = 0;
            foreach (string file in lb1.Items)
            {
                byte[] imageBytes = File.ReadAllBytes(file);
                string imageName = Path.GetFileNameWithoutExtension(file);
                string imagePath = Path.GetDirectoryName(file);
                try
                {
                    File.WriteAllBytes(imagePath + "/" + imageName + ".png", imageBytes);
                    progressBar1.Value = index += 1;
                }
                catch (Exception)
                {
                    throw;
                }

            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();
            progressBar1.Value = 0;
        }

        private void lb1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int selectedIndex = lb1.SelectedIndex;
                if (lb1.SelectedIndex < 0)
                {
                    return;
                }
                lb1.Items.RemoveAt(lb1.SelectedIndex);

                if (selectedIndex == lb1.Items.Count)
                {
                    lb1.SelectedIndex = selectedIndex - 1;
                    return;
                }
                lb1.SelectedIndex = selectedIndex;
            }
        }
    }
}