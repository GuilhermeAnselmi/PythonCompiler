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
    }
}