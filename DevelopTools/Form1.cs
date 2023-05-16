using LibGit2Sharp;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web;

namespace DevelopTools
{
    public partial class Form1 : Form
    {
        private string WorkingPath=string.Empty;
        private string RamaDestino=string.Empty;
        private RepositoryInformation repositoryInformation;

        public Form1()
        {

            InitializeComponent();
            //cargamos el json
            cargajson();

        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            
        }

        public void EjecutarComando(string command)
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
                WorkingDirectory= WorkingPath

            };

            var cmd = new Process();
            cmd.StartInfo.WorkingDirectory= WorkingPath;
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
               AgregarTextoASalida(" ERROR : " + e.Message);
            }

            if (cmd.ExitCode != 0)
            {
                AgregarTextoASalida(stdError);
            }
            else
            {
                AgregarTextoASalida(output.ToString());
            }
        }


        private string GitPullOrigin(string frombranch)
        {
            return " git pull origin "+ frombranch+ " \r\n ";
        }

        private string GitPull()
        {
            return " git pull " + "\r\n";
        }

        private string GitPush()
        {
            return " git push " + " \r\n ";
        }

        private string GitCheckoutForce(string ToBranch)
        {
            return " git checkout " + ToBranch +" -f";
        }

        private string GitCheckoutPunto()
        {
            return " git checkout . ";
        }

        private void cargajson()
        {
            string pathjsonRepos = "repositorios.json";
            List<RepoObject> Listarepos= RepoService.GetListFromJsonFile<RepoObject>(pathjsonRepos);
            comboRepos.DisplayMember = "Text";
            comboRepos.ValueMember = "value";
            
            foreach(RepoObject obj in Listarepos) 
            { 
                comboRepos.Items.Add(new { Text = obj.Name, Value = obj.RepoPath });
            }
        }

        private void comboRepos_SelectedIndexChanged(object sender, EventArgs e)
        {

            WorkingPath= comboRepos.SelectedItem.GetType().GetProperty("Value").GetValue(comboRepos.SelectedItem, null).ToString();
            var repo = RepositoryInformation.GetRepositoryInformationForPath(WorkingPath);
            AgregarTextoASalida("\r\n Rama actual : " + repo.BranchName);


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultastatus_Click(object sender, EventArgs e)
        {
            var repo = RepositoryInformation.GetRepositoryInformationForPath(WorkingPath);
            if(repo == null)
            {
                MessageBox.Show("Seleccione un repositorio primero");
            }
            else 
            {
                AgregarTextoASalida("\r\n Rama actual : " + repo.BranchName);
                RamaDestino = repo.BranchName;
                txtramadestino.Text = RamaDestino;
                AgregarTextoASalida("Tiene cambios pendientes? : " + ((repo.HasUncommittedChanges) ? "SI" : "NO"));
            }
           
            
        }

        private void btnsincronizar_Click(object sender, EventArgs e)
        {
            var repo = RepositoryInformation.GetRepositoryInformationForPath(WorkingPath);

            //if (!repo.HasUncommittedChanges)
            {
                EjecutarComando(GitPull());
                EjecutarComando(GitPullOrigin(txtramaorigen.Text));

                repo.CommitChangesAllChanges("Sincronización de repos mediante pull origin");
                EjecutarComando(GitPush());
                
            }
            //else
            //{
            //    AgregarTextoASalida("No es posible actualizar la rama porque tienes cambios pendientes por subir");
            //}
           

        }

        private void listaBranches_DoubleClick(object sender, EventArgs e)
        {
            string currentBranch = listaBranches.SelectedItem.ToString();
            EjecutarComando(GitCheckoutForce(currentBranch));
            AgregarTextoASalida("Ahora tu rama actual es: " + currentBranch);
        }

        private void AgregarTextoASalida(string mensaje)
        {
            txtResult.Text += "\r\n" + mensaje;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;
        }

        private void btneliminarcambioslocales_Click(object sender, EventArgs e)
        {
            var respuesta= MessageBox.Show("Realmente deseas eliminar todos los cambios locales????", "Advertencia", MessageBoxButtons.YesNo);
            if(respuesta == DialogResult.Yes)
            {
                EjecutarComando(GitCheckoutPunto());
            }
            else
            {
                //nada
            }
        }

        private void listaBranches_SelectedIndexChanged(object sender, EventArgs e)
        {
            //hacer el checkout a la nueva rama
            string currentBranch = listaBranches.SelectedItem.ToString();
            EjecutarComando(GitCheckoutForce(currentBranch));
            AgregarTextoASalida("Ahora tu rama actual es: " + currentBranch);
            txtramadestino.Text = currentBranch;
        }
    }
}