using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GarciaFrmBasicThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MyThreadClass threadClass = new MyThreadClass();
            Thread ThreadA = new Thread(threadClass.Thread1);
            ThreadA.Name = "Thread A";
            Thread ThreadB = new Thread(threadClass.Thread1);
            ThreadB.Name = "Thread B";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            Console.WriteLine("-End of Thread-");
            label1.Text = ("-End of Thread-");

        }
       
    }
}
