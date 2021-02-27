using System;
using System.Windows.Forms;

namespace lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FileWorker fw = new FileWorker();
            try
            {
                string[] fileContent = fw.ProccesFile(fFilename.Text);
                if (doCopy.Checked)
                {
                    fw.CopyContent(gFilename.Text, fileContent);
                }
                else
                {
                    string toDisplay = string.Join(Environment.NewLine, fileContent);
                    MessageBox.Show(toDisplay);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
