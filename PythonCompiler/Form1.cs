using PythonCompiler.Models;
using System.Diagnostics;
using System.Numerics;

namespace PythonCompiler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SearchFile(object sender, EventArgs e)
        {
            openFileCompile.Filter = "Python File (*.py)|*.py";
            openFileCompile.ShowDialog();
            
            txtPath.Text = openFileCompile.FileName;
        }

        private void SearchLocalSave(object sender, EventArgs e)
        {
            openFolderSave.ShowDialog();

            txtLocalSave.Text = openFolderSave.SelectedPath;
        }

        private void SearchManifest(object sender, EventArgs e)
        {
            openFileManifest.Filter = "Manifest File (*.xml)|*.xml";
            openFileManifest.ShowDialog();

            txtManifest.Text = openFileManifest.FileName;
        }

        private void Compile(object sender, EventArgs e)
        {
            try
            {
                Compile compile = new Compile(txtPath.Text, txtLocalSave.Text)
                {
                    ClearCache = ckbClearCache.Checked,
                    NoConsole = ckbNoConsole.Checked,
                    IsDll = rdbDll.Checked,
                    IsSingleFile = rdbSingleFile.Checked,
                    IsZipFile = rdbZip.Checked,
                };
                if (txtName.Text != "" && txtName.Text != null) compile.Name = txtName.Text;
                if (txtVersion.Text != "" && txtVersion.Text != null) compile.Version = txtVersion.Text;
                if (txtManifest.Text != "" && txtManifest.Text != null) compile.ManifestPath = txtManifest.Text;

                bool valid = compile.Validate();

                if (valid)
                {
                    compile.Run();

                    pgbStatus.Value = compile.Status;

                    MessageBox.Show("Sucesso", "Sucesso", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(compile.Error, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenSavePath(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(txtLocalSave.Text))
                {
                    ProcessStartInfo info = new ProcessStartInfo("explorer.exe", txtLocalSave.Text);
                    Process.Start(info);
                }
                else
                {
                    MessageBox.Show("Local para salvar compilado não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}