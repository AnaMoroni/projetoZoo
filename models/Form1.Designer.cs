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
            this.id_animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo_animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacao_animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(89)))), ((int)(((byte)(12)))));
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(218, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU PRINCIPAL ZOOLÓGICO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(52, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "CADASTRAR NOVO ANIMAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(219, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "LISTAR ANIMAIS CADASTRADOS";
            // 
            // btCadastrar
            // 
            this.btCadastrar.AutoSize = true;
            this.btCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(247)))), ((int)(((byte)(215)))));
            this.btCadastrar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(89)))), ((int)(((byte)(12)))));
            this.btCadastrar.Location = new System.Drawing.Point(55, 134);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(137, 38);
            this.btCadastrar.TabIndex = 3;
            this.btCadastrar.Text = "CADASTRAR";
            this.btCadastrar.UseVisualStyleBackColor = false;
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
            this.btExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(247)))), ((int)(((byte)(215)))));
            this.btExcluir.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.ForeColor = System.Drawing.Color.DarkGreen;
            this.btExcluir.Location = new System.Drawing.Point(708, 235);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(80, 27);
            this.btExcluir.TabIndex = 6;
            this.btExcluir.Text = "EXCLUIR";
            this.btExcluir.UseVisualStyleBackColor = false;
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
            this.btEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(247)))), ((int)(((byte)(215)))));
            this.btEditar.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(89)))), ((int)(((byte)(12)))));
            this.btEditar.Location = new System.Drawing.Point(709, 268);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(79, 29);
            this.btEditar.TabIndex = 8;
            this.btEditar.Text = "EDITAR";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // dgvAnimal
            // 
            this.dgvAnimal.AllowUserToAddRows = false;
            this.dgvAnimal.AllowUserToOrderColumns = true;
            this.dgvAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_animal,
            this.nome_animal,
            this.especie,
            this.dataNascimento,
            this.sexo_animal,
            this.observacao_animal});
            this.dgvAnimal.Location = new System.Drawing.Point(55, 234);
            this.dgvAnimal.Name = "dgvAnimal";
            this.dgvAnimal.Size = new System.Drawing.Size(644, 204);
            this.dgvAnimal.TabIndex = 9;
            this.dgvAnimal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAnimal_CellContentClick_1);
            // 
            // id_animal
            // 
            this.id_animal.DataPropertyName = "id_animal";
            this.id_animal.HeaderText = "id_animal";
            this.id_animal.Name = "id_animal";
            this.id_animal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_animal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nome_animal
            // 
            this.nome_animal.DataPropertyName = "nome_animal";
            this.nome_animal.HeaderText = "nome_animal";
            this.nome_animal.Name = "nome_animal";
            // 
            // especie
            // 
            this.especie.DataPropertyName = "especie";
            this.especie.HeaderText = "especie";
            this.especie.Name = "especie";
            // 
            // dataNascimento
            // 
            this.dataNascimento.DataPropertyName = "dataNascimento";
            this.dataNascimento.HeaderText = "dataNascimento";
            this.dataNascimento.Name = "dataNascimento";
            // 
            // sexo_animal
            // 
            this.sexo_animal.DataPropertyName = "sexo_animal";
            this.sexo_animal.HeaderText = "sexo_animal";
            this.sexo_animal.Name = "sexo_animal";
            // 
            // observacao_animal
            // 
            this.observacao_animal.DataPropertyName = "observacao_animal";
            this.observacao_animal.HeaderText = "observacao_animal";
            this.observacao_animal.Name = "observacao_animal";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(247)))), ((int)(((byte)(215)))));
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(89)))), ((int)(((byte)(12)))));
            this.button1.Location = new System.Drawing.Point(600, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "ATUALIZAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.label6.Location = new System.Drawing.Point(597, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "RECARREGAR GRID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(89)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
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
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id_animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn especie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo_animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacao_animal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}