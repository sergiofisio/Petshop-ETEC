using MySql.Data.MySqlClient;
using System.Data;
using System.Text;

namespace FormPet
{
    public partial class FormPets : BaseForm
    {
        readonly ClsConexao Conexao = new();
        readonly StringBuilder CmdSql = new();

        private DataSet? DS;
        DataTable DT;

        readonly Color originalBackColorIncluir;
        readonly Color originalForeColorIncluir;

        readonly Color originalBackColorDelete;
        readonly Color originalForeColorDelete;

        public FormPets()
        {
            InitializeComponent();
            RdbMa.Checked = false;
            RdbFem.Checked = false;
            originalBackColorIncluir = btnIncluir.BackColor;
            originalForeColorIncluir = btnIncluir.ForeColor;

            originalBackColorDelete = btnDelete.BackColor;
            originalForeColorDelete = btnDelete.ForeColor;

            txtCod.Text = RandomNumber().ToString();
        }

        private int RandomNumber()
        {
            Random random = new();
            int number = random.Next(1, 9999999);

            CmdSql.Clear();
            CmdSql.Append("SELECT cod FROM pets");

            Conexao.StrSql = CmdSql.ToString();
            DS = Conexao.RetornarDatase();

            if (DS == null || DS.Tables.Count == 0)
            {
                throw new Exception("Nenhum dado retornado.");
            }

            DT = DS.Tables[0];

            foreach (DataRow row in DT.Rows)
            {
                if (Convert.ToInt32(row["cod"]) == number)
                {
                    return RandomNumber();
                }
            }

            return number;
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                CmdSql.Clear();
                CmdSql.Append("select * ");
                CmdSql.Append(" from pets");

                Conexao.StrSql = CmdSql.ToString();

                DS = Conexao.RetornarDatase();
                if (DS == null || DS.Tables.Count == 0)
                {
                    throw new Exception("Nenhum dado retornado.");
                }

                DT = DS.Tables[0];

                if (DT.Rows.Count < 1)
                {
                    throw new Exception("Não há Pets cadastrados no sistema.");
                }

                FormConsulta frmConsulta = new();
                frmConsulta.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = TxtNome.Text.Trim(), especie = TxtEspecie.Text.Trim(), raca = TxtRaca.Text.Trim(), genero = GetGenero();
                int cod = int.Parse(txtCod.Text);

                ValidarCampos(nome, especie, raca, genero);
                InserirPet(cod, nome, especie, raca, genero);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar pet: {ex.Message}");
            }
        }

        private string GetGenero()
        {
            if (RdbMa.Checked)
                return "Macho";
            if (RdbFem.Checked)
                return "Fêmea";

            throw new Exception("Selecione o gênero do pet.");
        }

        private static void ValidarCampos(string nome, string especie, string raca, string genero)
        {
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(raca) || string.IsNullOrEmpty(especie) || string.IsNullOrEmpty(genero))
            {
                throw new Exception("Todos os campos são obrigatórios");
            }
        }

        private void InserirPet(int cod, string nome, string especie, string raca, string genero)
        {
            CmdSql.Clear();
            CmdSql.Append("INSERT INTO pets ");
            CmdSql.Append("(cod, nome, genero, especie, raca) ");
            CmdSql.Append("VALUES (@cod, @nome, @genero, @especie, @raca)");

            using (MySqlConnection conn = new MySqlConnection(Conexao.strconexao))
            {
                using (MySqlCommand cmd = new MySqlCommand(CmdSql.ToString(), conn))
                {
                    cmd.Parameters.AddWithValue("@cod", cod);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@genero", genero);
                    cmd.Parameters.AddWithValue("@especie", especie);
                    cmd.Parameters.AddWithValue("@raca", raca);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Pet inserido com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Erro ao inserir pet: {ex.Message}");
                    }
                }
            }

            txtCod.Text = RandomNumber().ToString();
            TxtNome.Text = "";
            TxtEspecie.Text = "";
            TxtRaca.Text = "";
            RdbMa.Checked = false;
            RdbFem.Checked = false;
        }

        private void BtnIncluir_MouseHover(object sender, EventArgs e)
        {
            btnIncluir.BackColor = Color.White;
            btnIncluir.ForeColor = Color.Blue;
        }

        private void BtnIncluir_MouseLeave(object sender, EventArgs e)
        {
            btnIncluir.BackColor = originalBackColorIncluir;
            btnIncluir.ForeColor = originalForeColorIncluir;
        }

        private void BtnDelete_MouseHover(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.White;
            btnDelete.ForeColor = Color.Red;
        }

        private void BtnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = originalBackColorDelete;
            btnDelete.ForeColor = originalForeColorDelete;
        }

        private void TxtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}