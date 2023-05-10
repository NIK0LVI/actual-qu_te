using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Qu_Te
{
    public partial class formMainMenu : Form
    {
        public formMainMenu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            // open the file
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Text = String.Empty;
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                TextWriter txt = new StreamWriter("D:\\qu_te.txt");
                txt.WriteLine(txtServerName.Text);
                txt.WriteLine(txtDatabaseName.Text);
                txt.WriteLine(txtUsername.Text);
                txt.WriteLine(txtPassword.Text);
                txt.WriteLine(txtParameters.Text);
                txt.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileDialog1.FileName.ToString() + ".txt");
                    file.WriteLine(txtServerName.Text);
                    file.WriteLine(txtDatabaseName.Text);
                    file.WriteLine(txtUsername.Text);
                    file.WriteLine(txtPassword.Text);
                    file.WriteLine(txtParameters.Text);
                    file.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}