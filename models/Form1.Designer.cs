namespace aplicacaoZoologico.models
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btExcluir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btEditar = new System.Windows.Forms.Button();
            this.dgvAnimal = new System.Windows.Forms.DataGridView();
            this.selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU PRINCIPAL ZOOLÓGICO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "CADASTRAR NOVO ANIMAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "LISTAR ANIMAIS CADASTRADOS";
            // 
            // btCadastrar
            // 
            this.btCadastrar.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(61, 97);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(130, 38);
            this.btCadastrar.TabIndex = 3;
            this.btCadastrar.Text = "CADASTRAR";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 5;
            // 
            // btExcluir
            // 
            this.btExcluir.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Location = new System.Drawing.Point(564, 181);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(93, 26);
            this.btExcluir.TabIndex = 6;
            this.btExcluir.Text = "EXCLUIR";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(528, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 7;
            // 
            // btEditar
            // 
            this.btEditar.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.Location = new System.Drawing.Point(663, 181);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(104, 26);
            this.btEditar.TabIndex = 8;
            this.btEditar.Text = "EDITAR";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // dgvAnimal
            // 
            this.dgvAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selecionar,
            this.id,
            this.nome,
            this.especie,
            this.sexo,
            this.dataNasc,
            this.observacao});
            this.dgvAnimal.Location = new System.Drawing.Point(13, 235);
            this.dgvAnimal.Name = "dgvAnimal";
            this.dgvAnimal.Size = new System.Drawing.Size(744, 183);
            this.dgvAnimal.TabIndex = 9;
            // 
            // selecionar
            // 
            this.selecionar.HeaderText = "Selecionar";
            this.selecionar.Name = "selecionar";
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // especie
            // 
            this.especie.HeaderText = "Espécie";
            this.especie.Name = "especie";
            // 
            // sexo
            // 
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            // 
            // dataNasc
            // 
            this.dataNasc.HeaderText = "Data Nascimento";
            this.dataNasc.Name = "dataNasc";
            // 
            // observacao
            // 
            this.observacao.HeaderText = "Observação";
            this.observacao.Name = "observacao";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAnimal);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.DataGridView dgvAnimal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn especie;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacao;
    }
}