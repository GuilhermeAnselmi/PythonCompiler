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

        private void ManifestAdmin(object sender, EventArgs e)
        {
            if (ckbOpenAdmin.Checked)
            {
                txtManifest.Text = "";
                txtManifest.Enabled = false;
                btnManifest.Enabled = false;
            }
            else
            {
                txtManifest.Enabled = true;
                btnManifest.Enabled = true;
            }
        }

        private void Compile(object sender, EventArgs e)
        {
            Run();
        }

        private async Task Run()
        {
            try
            {
                pgbStatus.Value = 0;

                Compile compile = new Compile(txtPath.Text, txtLocalSave.Text)
                {
                    OpenAdmin = ckbOpenAdmin.Checked,
                    ClearCache = ckbClearCache.Checked,
                    NoConsole = ckbNoConsole.Checked,
                    IsDll = rdbDll.Checked,
                    IsSingleFile = rdbSingleFile.Checked,
                };
                if (txtName.Text != "" && txtName.Text != null) compile.Name = txtName.Text;
                if (txtManifest.Text != "" && txtManifest.Text != null) compile.ManifestPath = txtManifest.Text.Replace("/", "\\");

                bool valid = compile.Validate();

                if (valid)
                {
                    btnCompile.Enabled = false;
                    btnPath.Enabled = false;
                    btnLocalSave.Enabled = false;
                    btnManifest.Enabled = false;

                    pgbStatus.Value = 5;

                    await compile.VerifyPyInstaller(pgbStatus);

                    pgbStatus.Value = 20;

                    await compile.Run(pgbStatus);

                    btnCompile.Enabled = true;
                    btnPath.Enabled = true;
                    btnLocalSave.Enabled = true;
                    btnManifest.Enabled = true;

                    MessageBox.Show("Sucesso", "Sucesso", MessageBoxButtons.OK);

                    pgbStatus.Value = 0;
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
    }
}