namespace WindowsFormsAppEstados
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.cboNorte = new System.Windows.Forms.ComboBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.cboNordeste = new System.Windows.Forms.ComboBox();
            this.btn4 = new System.Windows.Forms.Button();
            this.cboCentroOeste = new System.Windows.Forms.ComboBox();
            this.btn5 = new System.Windows.Forms.Button();
            this.cboSudeste = new System.Windows.Forms.ComboBox();
            this.btn6 = new System.Windows.Forms.Button();
            this.cboSul = new System.Windows.Forms.ComboBox();
            this.lblTd = new System.Windows.Forms.Label();
            this.lblNt = new System.Windows.Forms.Label();
            this.lblNd = new System.Windows.Forms.Label();
            this.lblCo = new System.Windows.Forms.Label();
            this.lblSd = new System.Windows.Forms.Label();
            this.lblSl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Todos os estados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Região Norte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Região Nordeste";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Região Centro-Oeste";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Região Sudeste";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Região Sul";
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cboEstado.Location = new System.Drawing.Point(133, 36);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(121, 21);
            this.cboEstado.TabIndex = 6;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(294, 34);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(23, 23);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "-";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(294, 92);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(23, 23);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "-";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // cboNorte
            // 
            this.cboNorte.FormattingEnabled = true;
            this.cboNorte.Location = new System.Drawing.Point(133, 94);
            this.cboNorte.Name = "cboNorte";
            this.cboNorte.Size = new System.Drawing.Size(121, 21);
            this.cboNorte.TabIndex = 8;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(294, 154);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(23, 23);
            this.btn3.TabIndex = 11;
            this.btn3.Text = "-";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // cboNordeste
            // 
            this.cboNordeste.FormattingEnabled = true;
            this.cboNordeste.Location = new System.Drawing.Point(133, 156);
            this.cboNordeste.Name = "cboNordeste";
            this.cboNordeste.Size = new System.Drawing.Size(121, 21);
            this.cboNordeste.TabIndex = 10;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(294, 216);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(23, 23);
            this.btn4.TabIndex = 13;
            this.btn4.Text = "-";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // cboCentroOeste
            // 
            this.cboCentroOeste.FormattingEnabled = true;
            this.cboCentroOeste.Location = new System.Drawing.Point(133, 218);
            this.cboCentroOeste.Name = "cboCentroOeste";
            this.cboCentroOeste.Size = new System.Drawing.Size(121, 21);
            this.cboCentroOeste.TabIndex = 12;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(294, 272);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(23, 23);
            this.btn5.TabIndex = 15;
            this.btn5.Text = "-";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // cboSudeste
            // 
            this.cboSudeste.FormattingEnabled = true;
            this.cboSudeste.Location = new System.Drawing.Point(133, 274);
            this.cboSudeste.Name = "cboSudeste";
            this.cboSudeste.Size = new System.Drawing.Size(121, 21);
            this.cboSudeste.TabIndex = 14;
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(294, 329);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(23, 23);
            this.btn6.TabIndex = 17;
            this.btn6.Text = "-";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // cboSul
            // 
            this.cboSul.FormattingEnabled = true;
            this.cboSul.Location = new System.Drawing.Point(133, 331);
            this.cboSul.Name = "cboSul";
            this.cboSul.Size = new System.Drawing.Size(121, 21);
            this.cboSul.TabIndex = 16;
            // 
            // lblTd
            // 
            this.lblTd.AutoSize = true;
            this.lblTd.Location = new System.Drawing.Point(378, 39);
            this.lblTd.Name = "lblTd";
            this.lblTd.Size = new System.Drawing.Size(19, 13);
            this.lblTd.TabIndex = 18;
            this.lblTd.Text = "27";
            // 
            // lblNt
            // 
            this.lblNt.AutoSize = true;
            this.lblNt.Location = new System.Drawing.Point(378, 94);
            this.lblNt.Name = "lblNt";
            this.lblNt.Size = new System.Drawing.Size(13, 13);
            this.lblNt.TabIndex = 19;
            this.lblNt.Text = "0";
            // 
            // lblNd
            // 
            this.lblNd.AutoSize = true;
            this.lblNd.Location = new System.Drawing.Point(378, 156);
            this.lblNd.Name = "lblNd";
            this.lblNd.Size = new System.Drawing.Size(13, 13);
            this.lblNd.TabIndex = 20;
            this.lblNd.Text = "0";
            // 
            // lblCo
            // 
            this.lblCo.AutoSize = true;
            this.lblCo.Location = new System.Drawing.Point(378, 218);
            this.lblCo.Name = "lblCo";
            this.lblCo.Size = new System.Drawing.Size(13, 13);
            this.lblCo.TabIndex = 21;
            this.lblCo.Text = "0";
            // 
            // lblSd
            // 
            this.lblSd.AutoSize = true;
            this.lblSd.Location = new System.Drawing.Point(378, 277);
            this.lblSd.Name = "lblSd";
            this.lblSd.Size = new System.Drawing.Size(13, 13);
            this.lblSd.TabIndex = 22;
            this.lblSd.Text = "0";
            // 
            // lblSl
            // 
            this.lblSl.AutoSize = true;
            this.lblSl.Location = new System.Drawing.Point(378, 334);
            this.lblSl.Name = "lblSl";
            this.lblSl.Size = new System.Drawing.Size(13, 13);
            this.lblSl.TabIndex = 23;
            this.lblSl.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSl);
            this.Controls.Add(this.lblSd);
            this.Controls.Add(this.lblCo);
            this.Controls.Add(this.lblNd);
            this.Controls.Add(this.lblNt);
            this.Controls.Add(this.lblTd);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.cboSul);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.cboSudeste);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.cboCentroOeste);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.cboNordeste);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.cboNorte);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.ComboBox cboNorte;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.ComboBox cboNordeste;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.ComboBox cboCentroOeste;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.ComboBox cboSudeste;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.ComboBox cboSul;
        private System.Windows.Forms.Label lblTd;
        private System.Windows.Forms.Label lblNt;
        private System.Windows.Forms.Label lblNd;
        private System.Windows.Forms.Label lblCo;
        private System.Windows.Forms.Label lblSd;
        private System.Windows.Forms.Label lblSl;
    }
}

