using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFLibrary;

namespace WCFHost_Form
{
    public partial class MainForm : Form
    {
        ServiceHost host;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            host = new ServiceHost(typeof(User));

            this.lblState.Text = "WCF中的HTTP监听已启动....";
            //打开宿主
            host.Open();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            host.Close();
        }

    }
}
