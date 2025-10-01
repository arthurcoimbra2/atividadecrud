namespace atividade1
{
    partial class FormInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btInsert = new Button();
            btUpdate = new Button();
            btDelete = new Button();
            label1 = new Label();
            btConsulta = new Button();
            btSair = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btInsert
            // 
            btInsert.Location = new Point(62, 178);
            btInsert.Name = "btInsert";
            btInsert.Size = new Size(191, 49);
            btInsert.TabIndex = 0;
            btInsert.Text = "INSERT";
            btInsert.UseVisualStyleBackColor = true;
            btInsert.Click += btInsert_Click;
            // 
            // btUpdate
            // 
            btUpdate.Location = new Point(62, 244);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(191, 49);
            btUpdate.TabIndex = 1;
            btUpdate.Text = "UPDATE";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(62, 310);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(191, 49);
            btDelete.TabIndex = 2;
            btDelete.Text = "DELETE";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(78, 44);
            label1.Name = "label1";
            label1.Size = new Size(150, 32);
            label1.TabIndex = 3;
            label1.Text = "TELA INICIAL";
            // 
            // btConsulta
            // 
            btConsulta.Location = new Point(62, 113);
            btConsulta.Name = "btConsulta";
            btConsulta.Size = new Size(191, 49);
            btConsulta.TabIndex = 4;
            btConsulta.Text = "CONSULTA";
            btConsulta.UseVisualStyleBackColor = true;
            btConsulta.Click += btConsulta_Click;
            // 
            // btSair
            // 
            btSair.Location = new Point(170, 420);
            btSair.Name = "btSair";
            btSair.Size = new Size(117, 33);
            btSair.TabIndex = 5;
            btSair.Text = "SAIR";
            btSair.UseVisualStyleBackColor = true;
            btSair.Click += btSair_Click;
            // 
            // button1
            // 
            button1.Location = new Point(259, 113);
            button1.Name = "button1";
            button1.Size = new Size(54, 49);
            button1.TabIndex = 6;
            button1.Text = "ID";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 465);
            Controls.Add(button1);
            Controls.Add(btSair);
            Controls.Add(btConsulta);
            Controls.Add(label1);
            Controls.Add(btDelete);
            Controls.Add(btUpdate);
            Controls.Add(btInsert);
            Name = "FormInicio";
            Text = "n";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btInsert;
        private Button btUpdate;
        private Button btDelete;
        private Label label1;
        private Button btConsulta;
        private Button btSair;
        private Button button1;
    }
}
