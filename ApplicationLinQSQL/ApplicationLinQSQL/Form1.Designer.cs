namespace ApplicationLinQSQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.B_Update = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_Album = new System.Windows.Forms.TextBox();
            this.text_Titulo = new System.Windows.Forms.TextBox();
            this.text_Pista = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text_Genero = new System.Windows.Forms.TextBox();
            this.text_Interprete = new System.Windows.Forms.TextBox();
            this.B_Delete = new System.Windows.Forms.Button();
            this.B_Buscar = new System.Windows.Forms.Button();
            this.text_Ano = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.B_Insert_data = new System.Windows.Forms.Button();
            this.text_Num = new System.Windows.Forms.TextBox();
            this.Num = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // B_Update
            // 
            this.B_Update.Image = ((System.Drawing.Image)(resources.GetObject("B_Update.Image")));
            this.B_Update.Location = new System.Drawing.Point(504, 348);
            this.B_Update.Name = "B_Update";
            this.B_Update.Size = new System.Drawing.Size(87, 27);
            this.B_Update.TabIndex = 1;
            this.B_Update.UseVisualStyleBackColor = true;
            this.B_Update.Click += new System.EventHandler(this.B_Update_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Location = new System.Drawing.Point(36, 289);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(39, 13);
            this.Titulo.TabIndex = 2;
            this.Titulo.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Album";
            // 
            // text_Album
            // 
            this.text_Album.Location = new System.Drawing.Point(322, 289);
            this.text_Album.Name = "text_Album";
            this.text_Album.Size = new System.Drawing.Size(161, 20);
            this.text_Album.TabIndex = 4;
            // 
            // text_Titulo
            // 
            this.text_Titulo.Location = new System.Drawing.Point(100, 289);
            this.text_Titulo.Name = "text_Titulo";
            this.text_Titulo.Size = new System.Drawing.Size(152, 20);
            this.text_Titulo.TabIndex = 5;
            // 
            // text_Pista
            // 
            this.text_Pista.Location = new System.Drawing.Point(100, 319);
            this.text_Pista.Name = "text_Pista";
            this.text_Pista.Size = new System.Drawing.Size(152, 20);
            this.text_Pista.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.Size = new System.Drawing.Size(706, 247);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pista";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Interprete";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Genero";
            // 
            // text_Genero
            // 
            this.text_Genero.Location = new System.Drawing.Point(322, 319);
            this.text_Genero.Name = "text_Genero";
            this.text_Genero.Size = new System.Drawing.Size(161, 20);
            this.text_Genero.TabIndex = 11;
            // 
            // text_Interprete
            // 
            this.text_Interprete.Location = new System.Drawing.Point(100, 350);
            this.text_Interprete.Name = "text_Interprete";
            this.text_Interprete.Size = new System.Drawing.Size(152, 20);
            this.text_Interprete.TabIndex = 12;
            // 
            // B_Delete
            // 
            this.B_Delete.Image = ((System.Drawing.Image)(resources.GetObject("B_Delete.Image")));
            this.B_Delete.Location = new System.Drawing.Point(623, 348);
            this.B_Delete.Name = "B_Delete";
            this.B_Delete.Size = new System.Drawing.Size(87, 27);
            this.B_Delete.TabIndex = 13;
            this.B_Delete.UseVisualStyleBackColor = true;
            this.B_Delete.Click += new System.EventHandler(this.B_Delete_Click);
            // 
            // B_Buscar
            // 
            this.B_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("B_Buscar.Image")));
            this.B_Buscar.Location = new System.Drawing.Point(623, 315);
            this.B_Buscar.Name = "B_Buscar";
            this.B_Buscar.Size = new System.Drawing.Size(87, 27);
            this.B_Buscar.TabIndex = 14;
            this.B_Buscar.UseVisualStyleBackColor = true;
            this.B_Buscar.Click += new System.EventHandler(this.B_Buscar_Click);
            // 
            // text_Ano
            // 
            this.text_Ano.Location = new System.Drawing.Point(322, 350);
            this.text_Ano.Name = "text_Ano";
            this.text_Ano.Size = new System.Drawing.Size(161, 20);
            this.text_Ano.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Año";
            // 
            // B_Insert_data
            // 
            this.B_Insert_data.Image = ((System.Drawing.Image)(resources.GetObject("B_Insert_data.Image")));
            this.B_Insert_data.Location = new System.Drawing.Point(504, 315);
            this.B_Insert_data.Name = "B_Insert_data";
            this.B_Insert_data.Size = new System.Drawing.Size(87, 27);
            this.B_Insert_data.TabIndex = 17;
            this.B_Insert_data.UseVisualStyleBackColor = true;
            this.B_Insert_data.Click += new System.EventHandler(this.B_Insert_data_Click);
            // 
            // text_Num
            // 
            this.text_Num.Location = new System.Drawing.Point(594, 286);
            this.text_Num.Name = "text_Num";
            this.text_Num.Size = new System.Drawing.Size(116, 20);
            this.text_Num.TabIndex = 18;
            // 
            // Num
            // 
            this.Num.AutoSize = true;
            this.Num.Location = new System.Drawing.Point(553, 289);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(32, 13);
            this.Num.TabIndex = 19;
            this.Num.Text = "Num";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = ".";
            this.label6.UseMnemonic = false;
            this.label6.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(770, 396);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Num);
            this.Controls.Add(this.text_Num);
            this.Controls.Add(this.B_Insert_data);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_Ano);
            this.Controls.Add(this.B_Buscar);
            this.Controls.Add(this.B_Delete);
            this.Controls.Add(this.text_Interprete);
            this.Controls.Add(this.text_Genero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.text_Pista);
            this.Controls.Add(this.text_Titulo);
            this.Controls.Add(this.text_Album);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.B_Update);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "Form1";
            this.Text = "Project LinQToSql \"Francisco Guerrero\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button B_Update;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_Album;
        private System.Windows.Forms.TextBox text_Titulo;
        private System.Windows.Forms.TextBox text_Pista;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_Genero;
        private System.Windows.Forms.TextBox text_Interprete;
        private System.Windows.Forms.Button B_Delete;
        private System.Windows.Forms.Button B_Buscar;
        private System.Windows.Forms.TextBox text_Ano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_Insert_data;
        private System.Windows.Forms.TextBox text_Num;
        private System.Windows.Forms.Label Num;
        private System.Windows.Forms.Label label6;
    }
}

