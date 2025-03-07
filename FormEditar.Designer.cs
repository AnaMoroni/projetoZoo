namespace aplicacaoZoologico
{
    partial class FormEditar
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
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btSalvar2 = new System.Windows.Forms.Button();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(185, 289);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(100, 20);
            this.txtEspecie.TabIndex = 27;
            this.txtEspecie.TextChanged += new System.EventHandler(this.txtEspecie_TextChanged);
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(328, 168);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(100, 20);
            this.txtSexo.TabIndex = 26;
            this.txtSexo.TextChanged += new System.EventHandler(this.txtSexo_TextChanged);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(582, 168);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(168, 20);
            this.txtObservacao.TabIndex = 25;
            this.txtObservacao.TextChanged += new System.EventHandler(this.txtObservacao_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(41, 168);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 23;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(578, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 22;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.label6.Location = new System.Drawing.Point(578, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Observação:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.label5.Location = new System.Drawing.Point(461, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Data de nascimento:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.label4.Location = new System.Drawing.Point(324, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Sexo:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(184, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Especie: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(38, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nome: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(270, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "EDITAR INFORMAÇÕES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(247)))), ((int)(((byte)(215)))));
            this.button2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(89)))), ((int)(((byte)(12)))));
            this.button2.Location = new System.Drawing.Point(677, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btSalvar2
            // 
            this.btSalvar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(247)))), ((int)(((byte)(215)))));
            this.btSalvar2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(89)))), ((int)(((byte)(12)))));
            this.btSalvar2.Location = new System.Drawing.Point(564, 402);
            this.btSalvar2.Name = "btSalvar2";
            this.btSalvar2.Size = new System.Drawing.Size(100, 24);
            this.btSalvar2.TabIndex = 14;
            this.btSalvar2.Text = "SALVAR";
            this.btSalvar2.UseVisualStyleBackColor = false;
            this.btSalvar2.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Location = new System.Drawing.Point(464, 289);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(200, 20);
            this.dtpDataNascimento.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(592, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(592, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.label12.Location = new System.Drawing.Point(324, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 23);
            this.label12.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.label14.Location = new System.Drawing.Point(38, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 23);
            this.label14.TabIndex = 37;
            // 
            // FormEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(89)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.txtEspecie);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btSalvar2);
            this.Name = "FormEditar";
            this.Text = "FormEditar";
            this.Load += new System.EventHandler(this.FormEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btSalvar2;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
    }
}