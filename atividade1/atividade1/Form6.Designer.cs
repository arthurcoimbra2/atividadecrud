namespace atividade1
{
    partial class formID
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
            txtId = new TextBox();
            lblId = new Label();
            btExibir = new Button();
            dataGrid = new DataGridView();
            btVoltar = new Button();
            btConfirmar = new Button();
            btAtivar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // btConfirmar
            // 
            btConfirmar.Location = new Point(287, 305);
            btConfirmar.Name = "btConfirmar";
            btConfirmar.Size = new Size(224, 55);
            btConfirmar.TabIndex = 27;
            btConfirmar.Text = "CONFIRMAR";
            btConfirmar.UseVisualStyleBackColor = true;
            btConfirmar.Click += btConfirmar_Click;
            // 
            // btAtivar
            // 
            btAtivar.Location = new Point(112, 191);
            btAtivar.Name = "btAtivar";
            btAtivar.Size = new Size(224, 55);
            btAtivar.TabIndex = 24;
            btAtivar.Text = "ATIVAR CONSULTA";
            btAtivar.UseVisualStyleBackColor = true;
            btAtivar.Click += btAtivar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(181, 261);
            txtId.Name = "txtId";
            txtId.Size = new Size(507, 23);
            txtId.TabIndex = 29;
            txtId.Visible = false;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(145, 262);
            lblId.Name = "lblId";
            lblId.Size = new Size(31, 21);
            lblId.TabIndex = 28;
            lblId.Text = "ID:";
            lblId.Visible = false;
            lblId.Click += lblId_Click;
            // 
            // btExibir
            // 
            btExibir.Location = new Point(460, 191);
            btExibir.Name = "btExibir";
            btExibir.Size = new Size(224, 55);
            btExibir.TabIndex = 26;
            btExibir.Text = "EXIBIR DADOS";
            btExibir.UseVisualStyleBackColor = true;
            btExibir.Click += btExibir_Click;
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(112, 28);
            dataGrid.Name = "dataGrid";
            dataGrid.Size = new Size(572, 150);
            dataGrid.TabIndex = 25;
            // 
            // btVoltar
            // 
            btVoltar.Location = new Point(671, 405);
            btVoltar.Name = "btVoltar";
            btVoltar.Size = new Size(117, 33);
            btVoltar.TabIndex = 30;
            btVoltar.Text = "VOLTAR";
            btVoltar.UseVisualStyleBackColor = true;
            btVoltar.Click += btVoltar_Click;
            // 
            // formID
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btVoltar);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(btConfirmar);
            Controls.Add(btExibir);
            Controls.Add(dataGrid);
            Controls.Add(btAtivar);
            Name = "formID";
            Text = "CONSULTA - ID";
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label lblId;
        private Button btExibir;
        private DataGridView dataGrid;
        private Button btVoltar;
    }
}