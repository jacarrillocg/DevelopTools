using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web;

namespace DevelopTools
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            //cargamos el json
            cargajson();

        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            //EjecutarComando(MoverAldirectorio(txtRuta.Text), txtRuta.Text);
            //EjecutarComando(ObtenerStatus(), txtRuta.Text);
            var repo= RepositoryInformation.GetRepositoryInformationForPath(txtRuta.Text);
            txtResult.Text+= "Tiene cambios sin hacer commit: "+ repo.HasUncommittedChanges.ToString();
            txtResult.Text += "\r\n nombre repo: " + repo.BranchName;
        }

        public void EjecutarComando(string command, string workingDirectory)
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe", // use cmd for example, you can run your own test.bat
                Verb = "runas", // run as administrator
                Arguments = "/C " + command,
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                WorkingDirectory= workingDirectory

            };

            var cmd = new Process();
            cmd.StartInfo.WorkingDirectory= txtRuta.Text;
            cmd.StartInfo = startInfo;

            var output = new StringBuilder();
            // set output hander
            cmd.OutputDataReceived += (sender, args) => output.AppendLine(args.Data);
            string stdError = "";

            try
            {
                cmd.Start();
                // get standard output asynchronously
                cmd.BeginOutputReadLine();
                // get standard error synchronously
                stdError = cmd.StandardError.ReadToEnd();
                cmd.WaitForExit();
            }
            catch (Exception e)
            {
                throw new Exception("OS error while executing: " + e.Message);
            }

            if (cmd.ExitCode != 0)
            {
                txtResult.Text += stdError;
                //throw new Exception("Finished with exit code = " + cmd.ExitCode + ": " + stdError);
            }
            else
            {
                txtResult.Text += output.ToString();
            }
        }

        private string MoverAldirectorio(string directorio)
        {
            return "cd " + directorio;
        }

        private string ObtenerStatus()
        {
            return " git status \r\n";
        }

        private string pullOrigin(string frombranch)
        {
            return " git pull origin "+ frombranch+ " \r\n ";
        }

        private void cargajson()
        {
            string pathjsonRepos = "data/repositorios.json";
            List<RepoObject> Listarepos= RepoService.GetListFromJsonFile<RepoObject>(pathjsonRepos);
            foreach(RepoObject obj in Listarepos) 
            { 
                comboRepos.Items.Add(obj);
            }
        }
    }
}