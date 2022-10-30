namespace Oefening2
{
    public partial class Form1 : Form
    {
        public static Form1 MainForm;
        public Form1()
        {
            InitializeComponent();
            MainForm = this;
            textBox1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MDIForm mDIForm = new MDIForm();
            mDIForm.MdiParent = Form1.ActiveForm;
            mDIForm.StartPosition = FormStartPosition.CenterScreen;
            mDIForm.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}