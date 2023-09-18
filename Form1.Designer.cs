namespace Desafioboocampquartaedicao
{
    partial class Form1
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
            dgvProdutos = new DataGridView();
            txtId = new TextBox();
            txtNome = new TextBox();
            btnAdicionar = new Button();
            btnRemover = new Button();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(6, 6);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.RowHeadersWidth = 51;
            dgvProdutos.RowTemplate.Height = 29;
            dgvProdutos.Size = new Size(115, 87);
            dgvProdutos.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Location = new Point(149, 19);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(149, 52);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 2;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(317, 17);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(94, 29);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(417, 17);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(94, 29);
            btnRemover.TabIndex = 4;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(517, 17);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditar);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(dgvProdutos);
            Name = "Form1";
            Text = "Adicionar";
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProdutos;
        private TextBox txtId;
        private TextBox txtNome;
        private Button btnAdicionar;
        private Button btnRemover;
        private Button btnEditar;
    }
}