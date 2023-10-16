using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmBasicThreads
{
    public partial class FrmBasicThreads : Form
    {
        public FrmBasicThreads()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Before Stating Thread-");
            ThreadStart thread = new ThreadStart(MyThreadClass.Thread1);
            Thread ThreadA = new Thread(thread);
            Thread ThreadB = new Thread(thread);

            ThreadA.Start();
            ThreadA.Name = "Thread A in Process";

            ThreadB.Start();
            ThreadB.Name = "Thread B in Process";

            ThreadA.Join();
            ThreadB.Join();

            Console.WriteLine("-End of Thread-");

            label1.Text = "-End of Thread-";
        }
    }
}
