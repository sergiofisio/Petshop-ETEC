namespace FormPet
{
    partial class FormPets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPets));
            lblTitle = new Label();
            lblCod = new Label();
            RdbMa = new RadioButton();
            RdbFem = new RadioButton();
            TxtNome = new TextBox();
            lblNome = new Label();
            lblEspecie = new Label();
            TxtEspecie = new TextBox();
            lblRaca = new Label();
            TxtRaca = new TextBox();
            btnIncluir = new Button();
            btnConsulta = new Button();
            btnDelete = new Button();
            BoxGenero = new GroupBox();
            txtCod = new TextBox();
            BoxGenero.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            resources.ApplyResources(lblTitle, "lblTitle");
            lblTitle.Name = "lblTitle";
            // 
            // lblCod
            // 
            resources.ApplyResources(lblCod, "lblCod");
            lblCod.Name = "lblCod";
            // 
            // RdbMa
            // 
            resources.ApplyResources(RdbMa, "RdbMa");
            RdbMa.Name = "RdbMa";
            RdbMa.UseVisualStyleBackColor = true;
            // 
            // RdbFem
            // 
            resources.ApplyResources(RdbFem, "RdbFem");
            RdbFem.Name = "RdbFem";
            RdbFem.UseVisualStyleBackColor = true;
            // 
            // TxtNome
            // 
            resources.ApplyResources(TxtNome, "TxtNome");
            TxtNome.CharacterCasing = CharacterCasing.Upper;
            TxtNome.Name = "TxtNome";
            // 
            // lblNome
            // 
            resources.ApplyResources(lblNome, "lblNome");
            lblNome.Name = "lblNome";
            // 
            // lblEspecie
            // 
            resources.ApplyResources(lblEspecie, "lblEspecie");
            lblEspecie.Name = "lblEspecie";
            // 
            // TxtEspecie
            // 
            resources.ApplyResources(TxtEspecie, "TxtEspecie");
            TxtEspecie.CharacterCasing = CharacterCasing.Upper;
            TxtEspecie.Name = "TxtEspecie";
            // 
            // lblRaca
            // 
            resources.ApplyResources(lblRaca, "lblRaca");
            lblRaca.Name = "lblRaca";
            // 
            // TxtRaca
            // 
            resources.ApplyResources(TxtRaca, "TxtRaca");
            TxtRaca.CharacterCasing = CharacterCasing.Upper;
            TxtRaca.Name = "TxtRaca";
            // 
            // btnIncluir
            // 
            resources.ApplyResources(btnIncluir, "btnIncluir");
            btnIncluir.BackColor = Color.FromArgb(0, 0, 192);
            btnIncluir.ForeColor = Color.White;
            btnIncluir.Name = "btnIncluir";
            btnIncluir.UseVisualStyleBackColor = false;
            btnIncluir.Click += BtnIncluir_Click;
            btnIncluir.MouseLeave += BtnIncluir_MouseLeave;
            btnIncluir.MouseHover += BtnIncluir_MouseHover;
            // 
            // btnConsulta
            // 
            resources.ApplyResources(btnConsulta, "btnConsulta");
            btnConsulta.Name = "btnConsulta";
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += BtnConsulta_Click;
            // 
            // btnDelete
            // 
            resources.ApplyResources(btnDelete, "btnDelete");
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = Color.White;
            btnDelete.Name = "btnDelete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.MouseLeave += BtnDelete_MouseLeave;
            btnDelete.MouseHover += BtnDelete_MouseHover;
            // 
            // BoxGenero
            // 
            resources.ApplyResources(BoxGenero, "BoxGenero");
            BoxGenero.Controls.Add(RdbMa);
            BoxGenero.Controls.Add(RdbFem);
            BoxGenero.Name = "BoxGenero";
            BoxGenero.TabStop = false;
            // 
            // txtCod
            // 
            resources.ApplyResources(txtCod, "txtCod");
            txtCod.Name = "txtCod";
            txtCod.ReadOnly = true;
            txtCod.KeyPress += TxtCod_KeyPress;
            // 
            // FormPets
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtCod);
            Controls.Add(BoxGenero);
            Controls.Add(btnDelete);
            Controls.Add(btnConsulta);
            Controls.Add(btnIncluir);
            Controls.Add(lblRaca);
            Controls.Add(TxtRaca);
            Controls.Add(lblEspecie);
            Controls.Add(TxtEspecie);
            Controls.Add(lblNome);
            Controls.Add(TxtNome);
            Controls.Add(lblCod);
            Controls.Add(lblTitle);
            Name = "FormPets";
            BoxGenero.ResumeLayout(false);
            BoxGenero.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblCod;
        private RadioButton RdbMa;
        private RadioButton RdbFem;
        private TextBox TxtNome;
        private Label lblNome;
        private Label lblEspecie;
        private TextBox TxtEspecie;
        private Label lblRaca;
        private TextBox TxtRaca;
        private Button btnIncluir;
        private Button btnConsulta;
        private Button btnDelete;
        private GroupBox BoxGenero;
        private TextBox txtCod;
    }
}