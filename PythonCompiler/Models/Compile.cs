using KlusterG.Essentials;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace PythonCompiler.Models
{
    public class Compile
    {
        public string CodePath { get; set; }
        public string SavePath { get; set; }
        public string? Name { get; set; }
        public string? ManifestPath { get; set; }
        public bool OpenAdmin { get; set; }
        public bool ClearCache { get; set; }
        public bool NoConsole { get; set; }
        public bool IsDll { get; set; }
        public bool IsSingleFile { get; set; }
        public string? Error { get; private set; }

        public Compile(string codePath, string savePath, 
            bool clearCache = false, bool noConsole = false, 
            bool isDll = true, bool isSingleFile = false)
        {
            CodePath = codePath.Replace("/", "\\");
            SavePath = savePath.Replace("/", "\\");
            ClearCache = clearCache;
            NoConsole = noConsole;
            IsDll = isDll;
            IsSingleFile = isSingleFile;
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

                if (string.IsNullOrEmpty(Name))
                {
                    Error = "Nome do compilado não definido";
                    return false;
                }

                if (Name != default && !essent.IsTextNumeric(Name))
                {
                    Error = "Nome do compilado só pode conter letras, numeros e espaço";
                    return false;
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

        private async Task<string> Command(string command)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo("powershell.exe", $"/c {command}");
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardOutput = true;
            processInfo.RedirectStandardError = true;
            processInfo.CreateNoWindow = true;

            Process process = Process.Start(processInfo);
            await process.WaitForExitAsync();

            string result = process.StandardOutput.ReadToEnd().Replace("\r", "").Replace("\n", "");

            return await Task.FromResult(result);
        }

        public async Task<bool> VerifyPyInstaller(ProgressBar bar)
        {
            try
            {
                string command = "pyinstaller -v";

                string result = await Command(command);

                if (string.IsNullOrEmpty(result))
                {
                    bar.Value = 25;

                    command = "pip3 install pyinstaller";

                    result = await Command(command);

                    if (string.IsNullOrEmpty(result))
                        return await Task.FromResult(false);
                }

                bar.Value = 50;

                return await Task.FromResult(true);
            }
            catch (Exception ex)
            {
                return await Task.FromResult(false);
            }
        }

        public async Task<bool> Run(ProgressBar bar)
        {
            try
            {
                bar.Value = 60;

                string command = "";

                command += $"pyinstaller {CodePath} --name {Name} --noconfirm --distpath \'{SavePath}\' ";

                if (!string.IsNullOrEmpty(ManifestPath) && !OpenAdmin)
                    command += $"--manifest {ManifestPath} ";

                if (OpenAdmin && string.IsNullOrEmpty(ManifestPath))
                    command += $"--uac-admin ";

                if (ClearCache)
                    command += $"--clean ";

                if (NoConsole)
                    command += $"--noconsole ";

                if (IsDll)
                    command += $"--onedir ";

                if (IsSingleFile)
                    command += $"--onefile ";

                string result = await Command(command);

                bar.Value = 100;

                return await Task.FromResult(true);
            }
            catch (Exception ex)
            {
                return await Task.FromResult(false);
            }
        }
    }
}
