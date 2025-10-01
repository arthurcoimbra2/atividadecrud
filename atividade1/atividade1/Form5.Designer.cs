namespace atividade1
{
    partial class formDelete
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
            btConfirmar.Location = new Point(287, 309);
            btConfirmar.Name = "btConfirmar";
            btConfirmar.Size = new Size(224, 55);
            btConfirmar.TabIndex = 21;
            btConfirmar.Text = "CONFIRMAR";
            btConfirmar.UseVisualStyleBackColor = true;
            btConfirmar.Click += btConfirmar_Click;
            // 
            // btAtivar
            // 
            btAtivar.Location = new Point(112, 195);
            btAtivar.Name = "btAtivar";
            btAtivar.Size = new Size(224, 55);
            btAtivar.TabIndex = 18;
            btAtivar.Text = "ATIVAR DELETE";
            btAtivar.UseVisualStyleBackColor = true;
            btAtivar.Click += btAtivar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(181, 265);
            txtId.Name = "txtId";
            txtId.Size = new Size(507, 23);
            txtId.TabIndex = 23;
            txtId.Visible = false;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(145, 266);
            lblId.Name = "lblId";
            lblId.Size = new Size(31, 21);
            lblId.TabIndex = 22;
            lblId.Text = "ID:";
            lblId.Visible = false;
            // 
            // btExibir
            // 
            btExibir.Location = new Point(460, 195);
            btExibir.Name = "btExibir";
            btExibir.Size = new Size(224, 55);
            btExibir.TabIndex = 20;
            btExibir.Text = "EXIBIR DADOS";
            btExibir.UseVisualStyleBackColor = true;
            btExibir.Click += btExibir_Click;
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(112, 32);
            dataGrid.Name = "dataGrid";
            dataGrid.Size = new Size(572, 150);
            dataGrid.TabIndex = 19;
            // 
            // btVoltar
            // 
            btVoltar.Location = new Point(671, 405);
            btVoltar.Name = "btVoltar";
            btVoltar.Size = new Size(117, 33);
            btVoltar.TabIndex = 24;
            btVoltar.Text = "VOLTAR";
            btVoltar.UseVisualStyleBackColor = true;
            btVoltar.Click += btVoltar_Click;
            // 
            // formDelete
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
            Name = "formDelete";
            Text = "DELETE";
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