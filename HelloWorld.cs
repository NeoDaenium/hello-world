using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class HelloWorld : Form
    {
        public static string commandBuilder = @"/K E: cd ";
        public HelloWorld()
        {
            InitializeComponent();
        }

        private void HelloWorld_Load(object sender, EventArgs e)
        {

        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            commitChanges();
        }

        private void commitChanges()
        {

            //Process p = new Process();
            //ProcessStartInfo info = new ProcessStartInfo();
            //info.FileName = "cmd.exe";
            //info.RedirectStandardInput = true;
            //info.UseShellExecute = false;

            //p.StartInfo = info;
            //p.Start();

            string strCmdText;
            strCmdText = "\""+txtFolderDirectory.Text+"\"";
            Process.Start(@"E:\Projects\Hello World\hello-world\helloWorld.bat");
        }
    }
}
