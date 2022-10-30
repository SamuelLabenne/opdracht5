using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Oefening2
{
    public delegate void sendDataHandler(int waarde);
    public partial class MDIForm : Form
    {
        public event sendDataHandler SendData;
        public double waarde { get; set; }
        public MDIForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // als waarde leeg is.
            if (Waarde.Text == "")
            {
                MessageBox.Show("Geef een getal in.");
            }
            else
            {
                waarde = Double.Parse(Waarde.Text);
                Form1.MainForm.listBox1.Items.Add(waarde);
                Waarde.Text = "";

                double listSize = Form1.MainForm.listBox1.Items.Count;
                double total = 0;
                for (int i = 0; i < Form1.MainForm.listBox1.Items.Count; i++)
                {
                    total += (double)Form1.MainForm.listBox1.Items[i];
                }
                double gemiddelde = Math.Round(total / listSize, 2);
                Form1.MainForm.textBox1.Text = gemiddelde.ToString();

                this.Close();
            }


        }
    }
}
