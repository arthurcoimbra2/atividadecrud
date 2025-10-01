namespace atividade1
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
            Button btSimples;
            dataGrid = new DataGridView();
            btGeral = new Button();
            btVoltar = new Button();
            btSimples = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // btSimples
            // 
            btSimples.Location = new Point(122, 188);
            btSimples.Name = "btSimples";
            btSimples.Size = new Size(224, 55);
            btSimples.TabIndex = 0;
            btSimples.Text = "CONSULTA SIMPLES";
            btSimples.UseVisualStyleBackColor = true;
            btSimples.Click += btSimples_Click;
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(122, 25);
            dataGrid.Name = "dataGrid";
            dataGrid.Size = new Size(572, 150);
            dataGrid.TabIndex = 1;
            // 
            // btGeral
            // 
            btGeral.Location = new Point(470, 188);
            btGeral.Name = "btGeral";
            btGeral.Size = new Size(224, 55);
            btGeral.TabIndex = 2;
            btGeral.Text = "CONSULTA GERAL";
            btGeral.UseVisualStyleBackColor = true;
            btGeral.Click += btGeral_Click;
            // 
            // btVoltar
            // 
            btVoltar.Location = new Point(656, 405);
            btVoltar.Name = "btVoltar";
            btVoltar.Size = new Size(117, 33);
            btVoltar.TabIndex = 6;
            btVoltar.Text = "VOLTAR";
            btVoltar.UseVisualStyleBackColor = true;
            btVoltar.Click += btVoltar_Click;
            // 
            // FormConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btVoltar);
            Controls.Add(btGeral);
            Controls.Add(dataGrid);
            Controls.Add(btSimples);
            Name = "FormConsulta";
            Text = "CONSULTA";
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGrid;
        private Button btGeral;
        private Button btVoltar;
    }
}