namespace Proyecto12C_
{
    public partial class frmMain : Form
    {
        string ourFileName;
        bool lastFindDown;
        bool lastFindWord;
        bool lastFindMatchCase;

        void DoSave(string filename)
        {
            ourFileName = filename;
            textBox.SaveFile(filename);
        }

        void DoSaveAs()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                DoSave(saveFileDialog1.FileName);
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void archiviToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void desToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Undo();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Cut();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Copy();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Paste();
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain.ActiveForm.Close();
        }

        bool checkChanges()
        {

            return true;
        }

        private void abirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkChanges())
            {

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox.LoadFile(openFileDialog1.FileName);

                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ourFileName))
            {

                DoSaveAs();
            }
            else
            {
                DoSave(ourFileName);
            }
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 find = new Form2();
            find.Show(this);
        }



        private void buscarSiguienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
    
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.SelectAll();
        }
    }
}