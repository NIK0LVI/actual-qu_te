using System.Text;
using System.Windows.Forms;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            // Will purge the default values on event. 
            try
            {
                foreach (var c in this.Controls)
                {
                    if (c is System.Windows.Forms.TextBox)
                    {
                        ((System.Windows.Forms.TextBox)c).Text = String.Empty;
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
                TextWriter txt = new StreamWriter("D:\\qu_te-default.txt");
                txt.WriteLine("Server Name: " + txtServerName.Text);
                txt.WriteLine("Database Name: " + txtDatabaseName.Text);
                txt.WriteLine("Username: " + txtUsername.Text);
                txt.WriteLine("Password: " + txtPassword.Text);
                txt.WriteLine("Parameters " + txtParameters.Text);
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
                    file.WriteLine("Server Name: " + txtServerName.Text);
                    file.WriteLine("Database Name: " + txtDatabaseName.Text);
                    file.WriteLine("Username: " + txtUsername.Text);
                    file.WriteLine("Password: " + txtPassword.Text);
                    file.WriteLine("Parameters " + txtParameters.Text);
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