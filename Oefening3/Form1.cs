namespace Oefening3
{
    public partial class Form1 : Form
    {
        List<Rechthoek> rechthoeken = new List<Rechthoek>();
        int locationX = 15;
        int locationY = 45;
        Graphics gc;

        public Form1()
        {
            InitializeComponent();
            gc = this.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rechthoek rechthoek = new Rechthoek(locationX, locationY, 90, 90);
            rechthoeken.Add(rechthoek);

            locationX += 90 + 10;

            foreach (Rechthoek r in rechthoeken)
            {

                Pen pen = new Pen(Color.Black);
                gc.DrawRectangle(pen, new Rectangle(r.x, r.y, 90, 90));
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            gc.Clear(Color.White);
            rechthoeken.RemoveAt(rechthoeken.Count - 1);

            foreach (Rechthoek r in rechthoeken)
            {
                Graphics gc = this.CreateGraphics();
                Pen pen = new Pen(Color.Black);
                gc.DrawRectangle(pen, new Rectangle(r.x, r.y, 90, 90));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            //Kleur kleur = new Kleur();
            //kleur.MdiParent = Form1.ActiveForm;
            //kleur.StartPosition = FormStartPosition.CenterScreen;
            //kleur.Show();
        }
    }
}