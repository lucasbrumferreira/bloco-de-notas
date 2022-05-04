namespace Lucas.BlocosDeNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void enviarCómentariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lixo_Click(object sender, EventArgs e)
        {
            caixaTexto.Text = "";

        }

        private void anularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caixaTexto.Undo();
        }

        private void novaJanelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caixaTexto.ZoomFactor = +1;

            this.Close();
        }

        private void ampliarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caixaTexto.ZoomFactor = caixaTexto.ZoomFactor + 0.25f;
        }

        private void reduzirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caixaTexto.ZoomFactor = caixaTexto.ZoomFactor - 0.25f;
        }

        private void restaurarZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caixaTexto.ZoomFactor = 1f;
        }
    }
}