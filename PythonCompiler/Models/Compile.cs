using KlusterG.Essentials;
using System.Text.RegularExpressions;

namespace PythonCompiler.Models
{
    public class Compile
    {
        public string CodePath { get; set; }
        public string SavePath { get; set; }
        public string? Name { get; set; }
        public string? Version { get; set; }
        public string? ManifestPath { get; set; }
        public bool ClearCache { get; set; }
        public bool NoConsole { get; set; }
        public bool IsDll { get; set; }
        public bool IsSingleFile { get; set; }
        public bool IsZipFile { get; set; }
        public string? Error { get; private set; }
        public int Status { get; set; }

        public Compile(string codePath, string savePath, 
            bool clearCache = false, bool noConsole = false, 
            bool isDll = true, bool isSingleFile = false, bool isZipFile = false)
        {
            CodePath = codePath;
            SavePath = savePath;
            ClearCache = clearCache;
            NoConsole = noConsole;
            IsDll = isDll;
            IsSingleFile = isSingleFile;
            IsZipFile = isZipFile;
            Status = 0;
        }

        public bool Validate()
        {
            Essent essent = new Essent();

            try
            {
                if (!File.Exists(CodePath))
                {
                    Error = "Arquivo de código não encontrado";
                    return false;
                }

                if (!Directory.Exists(SavePath))
                {
                    Error = "Local para salvar compilado não encontrado";
                    return false;
                }

                if (Name != default && !essent.IsTextNumeric(Name))
                {
                    Error = "Nome do compilado só pode conter letras, numeros e espaço";
                    return false;
                }

                if (Version != default)
                {
                    if (!Regex.IsMatch(Version, $"^[0-9][0-9.]*[0-9]+$"))
                    {
                        Error = "Numero da versão deve seguir o padrão. Exemplo: 1.0.0";
                        return false;
                    }

                    Version.Replace("..", ".");
                }

                if (ManifestPath != default && !File.Exists(ManifestPath))
                {
                    Error = "Arquivo de manifesto não encontrado";
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return false;
            }
        }

        public void Run()
        {
            Status = 50;
        }
    }
}
