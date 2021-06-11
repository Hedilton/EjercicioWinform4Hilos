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

namespace EjercicioWinform4Hilos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread x = new Thread(metodo1);
            x.Start();
            Thread y = new Thread(metodo2);
            y.Start();
        }
        public void metodo1()
        {
            for (int i =1;i<=40;i++)
            {
                this.listBox1.Items.Add(i);
                Thread.Sleep(200);
            }
        }
        public void metodo2()
        {
            for (int i = 1; i <= 20; i++)
            {
                this.listBox2.Items.Add(i);
                Thread.Sleep(150);
            }
        }
    }
}
