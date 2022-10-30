namespace Oefening1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            smallToolStripMenuItem.Font = new Font(smallToolStripMenuItem.Font.Name, 5, smallToolStripMenuItem.Font.Style);
            normalToolStripMenuItem.Font = new Font(normalToolStripMenuItem.Font.Name, 9, normalToolStripMenuItem.Font.Style);
            largeToolStripMenuItem.Font = new Font(largeToolStripMenuItem.Font.Name, 18, largeToolStripMenuItem.Font.Style);

            smalToolStripMenuItem.Font = new Font(smalToolStripMenuItem.Font.Name, 5, smalToolStripMenuItem.Font.Style);
            normalToolStripMenuItem1.Font = new Font(normalToolStripMenuItem1.Font.Name, 9, normalToolStripMenuItem1.Font.Style);
            largeToolStripMenuItem1.Font = new Font(largeToolStripMenuItem1.Font.Name, 18, largeToolStripMenuItem1.Font.Style);

            ContextMenuStrip = contextMenuStrip6;
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.Name, 5, textBox1.Font.Style);
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.Name, 9, textBox1.Font.Style);
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.Name, 18, textBox1.Font.Style);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                textBox1.Font = new Font(textBox1.Font.Name, 5, textBox1.Font.Style);
            }

            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.N)
            {
                textBox1.Font = new Font(textBox1.Font.Name, 9, textBox1.Font.Style);
            }

            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.L)
            {
                textBox1.Font = new Font(textBox1.Font.Name, 18, textBox1.Font.Style);
            }

            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.R)
            {
                textBox1.ForeColor = Color.Red;
            }

            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.G)
            {
                textBox1.ForeColor = Color.Green;
            }

            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.B)
            {
                textBox1.ForeColor = Color.Blue;
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void smalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.Name, 5, textBox1.Font.Style);
        }

        private void normalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.Name, 9, textBox1.Font.Style);
        }

        private void largeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.Name, 18, textBox1.Font.Style);
        }

        private void redToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
        }

        private void redToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Blue;
        }

        private void redToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Green;
        }

        private void blueToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Blue;
        }

        private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Green;
        }

        private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Blue;
        }

        private void greenToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Green;
        }

        private void blueToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Blue;
        }
    }
}