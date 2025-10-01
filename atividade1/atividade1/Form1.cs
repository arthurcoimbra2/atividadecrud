namespace atividade1
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            FormConsulta formConsulta = new FormConsulta();
            formConsulta.ShowDialog();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            formInsert formInsert = new formInsert();
            formInsert.ShowDialog();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            formUpdate formUpdate = new formUpdate();
            formUpdate.ShowDialog();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            formDelete formDelete = new formDelete();
            formDelete.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formID formID = new formID();
            formID.ShowDialog();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
