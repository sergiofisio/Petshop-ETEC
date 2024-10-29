using System.Data;
using System.Text;

namespace FormPet
{
    public partial class FormConsulta : BaseForm
    {
        int consultaID = 0;
        int consultaFilterId = 0;
        string filtro = "";
        string colunaSelecionada = "*";

        private ClsConexao Conexao = new();
        private StringBuilder CmdSql = new();
        private DataSet? DS;
        private DataTable? DT;

        public FormConsulta()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            CenterForm();
        }

        private void CenterForm()
        {
            int formWidth = Width;
            int formHeight = Height;

            int screenWidth = Screen.PrimaryScreen?.WorkingArea.Width ?? 0;
            int screenHeight = Screen.PrimaryScreen?.WorkingArea.Height ?? 0;

            Location = new Point(screenWidth - formWidth, (screenHeight - formHeight) / 2);
        }

        private void CboxConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            consultaID = int.Parse(CboxConsulta.SelectedIndex.ToString());
            colunaSelecionada = "*";

            if (consultaID == 2)
            {
                colunaSelecionada = "especie";
            }
            else if (consultaID == 3)
            {
                colunaSelecionada = "raca";
            }
            else if (consultaID == 4)
            {
                colunaSelecionada = "genero";
            }

            GridFilterPets.Visible = false;
            if (consultaID > 1)
            {
                SelectFiltroOptions();
            }
        }

        private void SelectFiltroOptions()
        {
            CmdSql.Clear();
            BoxFiltro.Visible = true;

            CmdSql.Append($"SELECT {colunaSelecionada} FROM pets GROUP BY {colunaSelecionada}");
            Conexao.StrSql = CmdSql.ToString();
            DS = Conexao.RetornarDatase();

            CboxFiltro.Items.Clear();
            CboxFiltro.Items.Add("Geral");
            foreach (DataRow row in DS.Tables[0].Rows)
            {
                CboxFiltro.Items.Add(row[colunaSelecionada]?.ToString() ?? string.Empty);
            }
        }

        private void SelectTodosPets()
        {
            CmdSql.Append("SELECT cod as CODIGO, nome as NOME, genero as GENERO, especie as ESPECIE, raca as RACA ");
            CmdSql.Append("FROM pets ");
            CmdSql.Append("ORDER BY especie, raca, nome");
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            CmdSql?.Clear();
            GridFilterPets.DataSource = null;

            try
            {
                if (consultaID == 0)
                {
                    throw new Exception("Selecione um tipo de consulta");
                }

                if (consultaID == 1)
                {
                    SelectTodosPets();
                }
                else
                {
                    ConsultaFiltro(colunaSelecionada, filtro);
                }

                if (colunaSelecionada!="*" && filtro == "")
                {
                    throw new Exception("Selecione a forma de filtro");
                }

                Conexao.StrSql = CmdSql.ToString();
                DS = Conexao.RetornarDatase();
                DT = DS.Tables[0];

                GridFilterPets.DataSource = DT;
                GridFilterPets.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ConsultaFiltro(string selecao, string filtroSelecao)
        {
            CmdSql?.Append(selecao == "*"
                ? "SELECT *, COUNT(*) AS QUANTIDADE "
                : $"SELECT {selecao} as {selecao.ToUpper()}, COUNT(*) AS QUANTIDADE ");
            CmdSql?.Append("FROM pets ");

            if (filtroSelecao!="*")
            {
                CmdSql?.Append($"WHERE {selecao} = '{filtroSelecao}' ");
            }

            CmdSql?.Append($"GROUP BY {selecao}");
        }

        private void CboxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            consultaFilterId = CboxFiltro.SelectedIndex;

            if (consultaFilterId == 0)
            {
                 filtro = "*";
            }
            else
            {
                filtro = CboxFiltro.SelectedItem?.ToString() ?? string.Empty;
            }

        }
    }
}
