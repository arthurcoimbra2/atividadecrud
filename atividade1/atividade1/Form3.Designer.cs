
namespace atividade1
{
    partial class formInsert
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
            Button btAtivar;
            Button btConfirmar;
            btExibir = new Button();
            dataGrid = new DataGridView();
            lblNome = new Label();
            lblEmail = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            btVoltar = new Button();
            btAtivar = new Button();
            btConfirmar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // btAtivar
            // 
            btAtivar.Location = new Point(114, 190);
            btAtivar.Name = "btAtivar";
            btAtivar.Size = new Size(224, 55);
            btAtivar.TabIndex = 3;
            btAtivar.Text = "ATIVAR INSERT";
            btAtivar.UseVisualStyleBackColor = true;
            btAtivar.Click += btAtivar_Click;
            // 
            // btConfirmar
            // 
            btConfirmar.Location = new Point(289, 353);
            btConfirmar.Name = "btConfirmar";
            btConfirmar.Size = new Size(224, 55);
            btConfirmar.TabIndex = 6;
            btConfirmar.Text = "CONFIRMAR";
            btConfirmar.UseVisualStyleBackColor = true;
            btConfirmar.Click += btConfirmar_Click;
            // 
            // btExibir
            // 
            btExibir.Location = new Point(462, 190);
            btExibir.Name = "btExibir";
            btExibir.Size = new Size(224, 55);
            btExibir.TabIndex = 5;
            btExibir.Text = "EXIBIR DADOS";
            btExibir.UseVisualStyleBackColor = true;
            btExibir.Click += btExibir_Click;
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(114, 27);
            dataGrid.Name = "dataGrid";
            dataGrid.Size = new Size(572, 150);
            dataGrid.TabIndex = 4;
            dataGrid.CellContentClick += dataGrid_CellContentClick;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(123, 272);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(63, 21);
            lblNome.TabIndex = 7;
            lblNome.Text = "NOME:";
            lblNome.Visible = false;
            lblNome.Click += lblNome_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(123, 307);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(62, 21);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "EMAIL:";
            lblEmail.Visible = false;
            lblEmail.Click += lblEmail_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(183, 271);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(507, 23);
            txtNome.TabIndex = 9;
            txtNome.Visible = false;
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(183, 306);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(507, 23);
            txtEmail.TabIndex = 10;
            txtEmail.Visible = false;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // btVoltar
            // 
            btVoltar.Location = new Point(671, 405);
            btVoltar.Name = "btVoltar";
            btVoltar.Size = new Size(117, 33);
            btVoltar.TabIndex = 11;
            btVoltar.Text = "VOLTAR";
            btVoltar.UseVisualStyleBackColor = true;
            btVoltar.Click += btVoltar_Click;
            // 
            // formInsert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btVoltar);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Controls.Add(btConfirmar);
            Controls.Add(btExibir);
            Controls.Add(dataGrid);
            Controls.Add(btAtivar);
            Name = "formInsert";
            Text = "INSERT";
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btExibir;
        private DataGridView dataGrid;
        private Label lblNome;
        private Label lblEmail;
        private TextBox txtNome;
        private TextBox txtEmail;
        private Button btVoltar;
    }
}