namespace atividade1
{
    partial class formUpdate
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
            Button btConfirmar;
            Button btAtivar;
            txtNome = new TextBox();
            txtId = new TextBox();
            lblNome = new Label();
            lblId = new Label();
            btExibir = new Button();
            dataGrid = new DataGridView();
            txtEmail = new TextBox();
            lblEmail = new Label();
            btVoltar = new Button();
            btConfirmar = new Button();
            btAtivar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // btConfirmar
            // 
            btConfirmar.Location = new Point(287, 376);
            btConfirmar.Name = "btConfirmar";
            btConfirmar.Size = new Size(224, 55);
            btConfirmar.TabIndex = 14;
            btConfirmar.Text = "CONFIRMAR";
            btConfirmar.UseVisualStyleBackColor = true;
            btConfirmar.Click += btConfirmar_Click;
            // 
            // btAtivar
            // 
            btAtivar.Location = new Point(112, 198);
            btAtivar.Name = "btAtivar";
            btAtivar.Size = new Size(224, 55);
            btAtivar.TabIndex = 11;
            btAtivar.Text = "ATIVAR UPDATE";
            btAtivar.UseVisualStyleBackColor = true;
            btAtivar.Click += btAtivar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(181, 303);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(507, 23);
            txtNome.TabIndex = 18;
            txtNome.Visible = false;
            // 
            // txtId
            // 
            txtId.Location = new Point(181, 268);
            txtId.Name = "txtId";
            txtId.Size = new Size(507, 23);
            txtId.TabIndex = 17;
            txtId.Visible = false;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(121, 304);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(63, 21);
            lblNome.TabIndex = 16;
            lblNome.Text = "NOME:";
            lblNome.Visible = false;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(145, 269);
            lblId.Name = "lblId";
            lblId.Size = new Size(31, 21);
            lblId.TabIndex = 15;
            lblId.Text = "ID:";
            lblId.Visible = false;
            // 
            // btExibir
            // 
            btExibir.Location = new Point(460, 198);
            btExibir.Name = "btExibir";
            btExibir.Size = new Size(224, 55);
            btExibir.TabIndex = 13;
            btExibir.Text = "EXIBIR DADOS";
            btExibir.UseVisualStyleBackColor = true;
            btExibir.Click += btExibir_Click;
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(112, 35);
            dataGrid.Name = "dataGrid";
            dataGrid.Size = new Size(572, 150);
            dataGrid.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(181, 337);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(507, 23);
            txtEmail.TabIndex = 20;
            txtEmail.Visible = false;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(121, 338);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(62, 21);
            lblEmail.TabIndex = 19;
            lblEmail.Text = "EMAIL:";
            lblEmail.Visible = false;
            // 
            // btVoltar
            // 
            btVoltar.Location = new Point(671, 405);
            btVoltar.Name = "btVoltar";
            btVoltar.Size = new Size(117, 33);
            btVoltar.TabIndex = 21;
            btVoltar.Text = "VOLTAR";
            btVoltar.UseVisualStyleBackColor = true;
            btVoltar.Click += btVoltar_Click;
            // 
            // formUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btVoltar);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            Controls.Add(btConfirmar);
            Controls.Add(btExibir);
            Controls.Add(dataGrid);
            Controls.Add(btAtivar);
            Name = "formUpdate";
            Text = "UPDATE";
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtId;
        private Label lblNome;
        private Label lblId;
        private Button btExibir;
        private DataGridView dataGrid;
        private TextBox txtEmail;
        private Label lblEmail;
        private Button btVoltar;
    }
}