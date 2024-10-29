namespace FormPet
{
    public partial class Form1 : BaseForm
    {
        public Form1()
        {
            InitializeComponent( );
            CriarBancoETabela( );
        }

        private static void CriarBancoETabela()
        {
            try
            {
                var conexao = new ClsConexao( );
                conexao.CriarBancoETabela( );
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao criar banco de dados e tabela: " + ex.Message);
            }
        }

        private void petsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPets frmPets = new( );
            frmPets.ShowDialog( );
        }
    }
}
