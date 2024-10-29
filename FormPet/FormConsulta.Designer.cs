namespace FormPet
{
    partial class FormConsulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GridFilterPets = new DataGridView();
            CboxConsulta = new ComboBox();
            lblTitleConsulta = new Label();
            label1 = new Label();
            BtnConsultar = new Button();
            CboxFiltro = new ComboBox();
            label2 = new Label();
            BoxFiltro = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)GridFilterPets).BeginInit();
            BoxFiltro.SuspendLayout();
            SuspendLayout();
            // 
            // GridFilterPets
            // 
            GridFilterPets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridFilterPets.Location = new Point(20, 269);
            GridFilterPets.Name = "GridFilterPets";
            GridFilterPets.Size = new Size(471, 202);
            GridFilterPets.TabIndex = 0;
            GridFilterPets.Visible = false;
            // 
            // CboxConsulta
            // 
            CboxConsulta.AutoCompleteCustomSource.AddRange(new string[] { "Selecione o tipo de consulta", "Geral", "Espécie", "Raça", "Gênero" });
            CboxConsulta.FormattingEnabled = true;
            CboxConsulta.Items.AddRange(new object[] { "Selecione um tipo de consulta", "Geral", "Espécie", "Raça", "Gênero" });
            CboxConsulta.Location = new Point(177, 105);
            CboxConsulta.Name = "CboxConsulta";
            CboxConsulta.Size = new Size(306, 33);
            CboxConsulta.TabIndex = 1;
            CboxConsulta.Text = "Selecione um tipo de consulta";
            CboxConsulta.SelectedIndexChanged += CboxConsulta_SelectedIndexChanged;
            // 
            // lblTitleConsulta
            // 
            lblTitleConsulta.Dock = DockStyle.Top;
            lblTitleConsulta.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleConsulta.Location = new Point(0, 10);
            lblTitleConsulta.Name = "lblTitleConsulta";
            lblTitleConsulta.Size = new Size(511, 92);
            lblTitleConsulta.TabIndex = 2;
            lblTitleConsulta.Text = "Pesquisar";
            lblTitleConsulta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 108);
            label1.Name = "label1";
            label1.Size = new Size(151, 25);
            label1.TabIndex = 3;
            label1.Text = "Tipo de consulta";
            // 
            // BtnConsultar
            // 
            BtnConsultar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnConsultar.Location = new Point(179, 222);
            BtnConsultar.Name = "BtnConsultar";
            BtnConsultar.Size = new Size(157, 41);
            BtnConsultar.TabIndex = 4;
            BtnConsultar.Text = "Consultar";
            BtnConsultar.UseVisualStyleBackColor = true;
            BtnConsultar.Click += BtnConsultar_Click;
            // 
            // CboxFiltro
            // 
            CboxFiltro.FormattingEnabled = true;
            CboxFiltro.Location = new Point(157, 32);
            CboxFiltro.Name = "CboxFiltro";
            CboxFiltro.Size = new Size(306, 33);
            CboxFiltro.TabIndex = 5;
            CboxFiltro.SelectedIndexChanged += CboxFiltro_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 35);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 6;
            label2.Text = "Filtro";
            // 
            // BoxFiltro
            // 
            BoxFiltro.Controls.Add(CboxFiltro);
            BoxFiltro.Controls.Add(label2);
            BoxFiltro.Location = new Point(20, 141);
            BoxFiltro.Name = "BoxFiltro";
            BoxFiltro.Size = new Size(463, 75);
            BoxFiltro.TabIndex = 7;
            BoxFiltro.TabStop = false;
            BoxFiltro.Visible = false;
            // 
            // FormConsulta
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 485);
            Controls.Add(BoxFiltro);
            Controls.Add(BtnConsultar);
            Controls.Add(label1);
            Controls.Add(lblTitleConsulta);
            Controls.Add(CboxConsulta);
            Controls.Add(GridFilterPets);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "FormConsulta";
            Padding = new Padding(0, 10, 0, 0);
            Text = "FormConsulta";
            ((System.ComponentModel.ISupportInitialize)GridFilterPets).EndInit();
            BoxFiltro.ResumeLayout(false);
            BoxFiltro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GridFilterPets;
        private ComboBox CboxConsulta;
        private Label lblTitleConsulta;
        private Label label1;
        private Button BtnConsultar;
        private ComboBox CboxFiltro;
        private Label label2;
        private GroupBox BoxFiltro;
    }
}