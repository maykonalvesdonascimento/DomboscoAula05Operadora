namespace Operadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GroupOperadoras = new System.Windows.Forms.GroupBox();
            this.radOi = new System.Windows.Forms.RadioButton();
            this.radTim = new System.Windows.Forms.RadioButton();
            this.radClaro = new System.Windows.Forms.RadioButton();
            this.radVivo = new System.Windows.Forms.RadioButton();
            this.lblDados = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblOperadora = new System.Windows.Forms.Label();
            this.txtOperadora = new System.Windows.Forms.TextBox();
            this.lblDDD = new System.Windows.Forms.Label();
            this.txtDDD = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblRecarga = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtRecarga = new System.Windows.Forms.TextBox();
            this.lblSelecione = new System.Windows.Forms.Label();
            this.btnValor1 = new System.Windows.Forms.Button();
            this.btnValor2 = new System.Windows.Forms.Button();
            this.btnValor3 = new System.Windows.Forms.Button();
            this.btnValor4 = new System.Windows.Forms.Button();
            this.btnValor5 = new System.Windows.Forms.Button();
            this.btnValor6 = new System.Windows.Forms.Button();
            this.btnValor7 = new System.Windows.Forms.Button();
            this.btnValor8 = new System.Windows.Forms.Button();
            this.lblValidade1 = new System.Windows.Forms.Label();
            this.lblValidade2 = new System.Windows.Forms.Label();
            this.lblValidade3 = new System.Windows.Forms.Label();
            this.lblValidade4 = new System.Windows.Forms.Label();
            this.lblValidade5 = new System.Windows.Forms.Label();
            this.lblValidade6 = new System.Windows.Forms.Label();
            this.lblValidade7 = new System.Windows.Forms.Label();
            this.lblValidade8 = new System.Windows.Forms.Label();
            this.PicLogoOperadora = new System.Windows.Forms.PictureBox();
            this.GroupOperadoras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogoOperadora)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupOperadoras
            // 
            this.GroupOperadoras.Controls.Add(this.radOi);
            this.GroupOperadoras.Controls.Add(this.radTim);
            this.GroupOperadoras.Controls.Add(this.radClaro);
            this.GroupOperadoras.Controls.Add(this.radVivo);
            this.GroupOperadoras.Location = new System.Drawing.Point(15, 56);
            this.GroupOperadoras.Name = "GroupOperadoras";
            this.GroupOperadoras.Size = new System.Drawing.Size(197, 251);
            this.GroupOperadoras.TabIndex = 0;
            this.GroupOperadoras.TabStop = false;
            this.GroupOperadoras.Text = "Operadoras";
            // 
            // radOi
            // 
            this.radOi.AutoSize = true;
            this.radOi.Location = new System.Drawing.Point(31, 187);
            this.radOi.Name = "radOi";
            this.radOi.Size = new System.Drawing.Size(35, 17);
            this.radOi.TabIndex = 3;
            this.radOi.Text = "Oi";
            this.radOi.UseVisualStyleBackColor = true;
            this.radOi.CheckedChanged += new System.EventHandler(this.radOi_CheckedChanged);
            // 
            // radTim
            // 
            this.radTim.AutoSize = true;
            this.radTim.Location = new System.Drawing.Point(31, 143);
            this.radTim.Name = "radTim";
            this.radTim.Size = new System.Drawing.Size(42, 17);
            this.radTim.TabIndex = 2;
            this.radTim.Text = "Tim";
            this.radTim.UseVisualStyleBackColor = true;
            this.radTim.CheckedChanged += new System.EventHandler(this.radTim_CheckedChanged);
            // 
            // radClaro
            // 
            this.radClaro.AutoSize = true;
            this.radClaro.Location = new System.Drawing.Point(31, 101);
            this.radClaro.Name = "radClaro";
            this.radClaro.Size = new System.Drawing.Size(49, 17);
            this.radClaro.TabIndex = 1;
            this.radClaro.Text = "Claro";
            this.radClaro.UseVisualStyleBackColor = true;
            this.radClaro.CheckedChanged += new System.EventHandler(this.radClaro_CheckedChanged);
            // 
            // radVivo
            // 
            this.radVivo.AutoSize = true;
            this.radVivo.Location = new System.Drawing.Point(31, 55);
            this.radVivo.Name = "radVivo";
            this.radVivo.Size = new System.Drawing.Size(46, 17);
            this.radVivo.TabIndex = 0;
            this.radVivo.Text = "Vivo";
            this.radVivo.UseVisualStyleBackColor = true;
            this.radVivo.CheckedChanged += new System.EventHandler(this.radVivo_CheckedChanged);
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Enabled = false;
            this.lblDados.Location = new System.Drawing.Point(342, 21);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(97, 13);
            this.lblDados.TabIndex = 1;
            this.lblDados.Text = "Dados da Recarga";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Enabled = false;
            this.lblNome.Location = new System.Drawing.Point(342, 71);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(345, 87);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(265, 20);
            this.txtNome.TabIndex = 3;
            // 
            // lblOperadora
            // 
            this.lblOperadora.AutoSize = true;
            this.lblOperadora.Enabled = false;
            this.lblOperadora.Location = new System.Drawing.Point(342, 124);
            this.lblOperadora.Name = "lblOperadora";
            this.lblOperadora.Size = new System.Drawing.Size(122, 13);
            this.lblOperadora.TabIndex = 4;
            this.lblOperadora.Text = "Operadora Selecionada:";
            // 
            // txtOperadora
            // 
            this.txtOperadora.Enabled = false;
            this.txtOperadora.Location = new System.Drawing.Point(345, 140);
            this.txtOperadora.Name = "txtOperadora";
            this.txtOperadora.Size = new System.Drawing.Size(265, 20);
            this.txtOperadora.TabIndex = 5;
            // 
            // lblDDD
            // 
            this.lblDDD.AutoSize = true;
            this.lblDDD.Enabled = false;
            this.lblDDD.Location = new System.Drawing.Point(342, 183);
            this.lblDDD.Name = "lblDDD";
            this.lblDDD.Size = new System.Drawing.Size(34, 13);
            this.lblDDD.TabIndex = 6;
            this.lblDDD.Text = "DDD:";
            // 
            // txtDDD
            // 
            this.txtDDD.Enabled = false;
            this.txtDDD.Location = new System.Drawing.Point(345, 199);
            this.txtDDD.Name = "txtDDD";
            this.txtDDD.Size = new System.Drawing.Size(35, 20);
            this.txtDDD.TabIndex = 7;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Enabled = false;
            this.lblCelular.Location = new System.Drawing.Point(394, 183);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(82, 13);
            this.lblCelular.TabIndex = 8;
            this.lblCelular.Text = "Número Celular:";
            // 
            // lblRecarga
            // 
            this.lblRecarga.AutoSize = true;
            this.lblRecarga.Enabled = false;
            this.lblRecarga.Location = new System.Drawing.Point(507, 183);
            this.lblRecarga.Name = "lblRecarga";
            this.lblRecarga.Size = new System.Drawing.Size(78, 13);
            this.lblRecarga.TabIndex = 10;
            this.lblRecarga.Text = "Valor Recarga:";
            // 
            // txtCelular
            // 
            this.txtCelular.Enabled = false;
            this.txtCelular.Location = new System.Drawing.Point(397, 199);
            this.txtCelular.Mask = "(99) 99999-9999";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(93, 20);
            this.txtCelular.TabIndex = 11;
            // 
            // txtRecarga
            // 
            this.txtRecarga.Enabled = false;
            this.txtRecarga.Location = new System.Drawing.Point(510, 199);
            this.txtRecarga.Name = "txtRecarga";
            this.txtRecarga.Size = new System.Drawing.Size(100, 20);
            this.txtRecarga.TabIndex = 12;
            // 
            // lblSelecione
            // 
            this.lblSelecione.AutoSize = true;
            this.lblSelecione.Enabled = false;
            this.lblSelecione.Location = new System.Drawing.Point(436, 243);
            this.lblSelecione.Name = "lblSelecione";
            this.lblSelecione.Size = new System.Drawing.Size(149, 13);
            this.lblSelecione.TabIndex = 13;
            this.lblSelecione.Text = "Selecione o Valor da Recarga";
            // 
            // btnValor1
            // 
            this.btnValor1.BackColor = System.Drawing.Color.Transparent;
            this.btnValor1.Enabled = false;
            this.btnValor1.FlatAppearance.BorderSize = 0;
            this.btnValor1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnValor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValor1.Location = new System.Drawing.Point(345, 284);
            this.btnValor1.Name = "btnValor1";
            this.btnValor1.Size = new System.Drawing.Size(59, 23);
            this.btnValor1.TabIndex = 14;
            this.btnValor1.Text = "R$";
            this.btnValor1.UseVisualStyleBackColor = false;
            this.btnValor1.Click += new System.EventHandler(this.btnValor1_Click);
            // 
            // btnValor2
            // 
            this.btnValor2.BackColor = System.Drawing.Color.Transparent;
            this.btnValor2.Enabled = false;
            this.btnValor2.FlatAppearance.BorderSize = 0;
            this.btnValor2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnValor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValor2.Location = new System.Drawing.Point(410, 284);
            this.btnValor2.Name = "btnValor2";
            this.btnValor2.Size = new System.Drawing.Size(59, 23);
            this.btnValor2.TabIndex = 15;
            this.btnValor2.Text = "R$";
            this.btnValor2.UseVisualStyleBackColor = false;
            this.btnValor2.Click += new System.EventHandler(this.btnValor2_Click);
            // 
            // btnValor3
            // 
            this.btnValor3.BackColor = System.Drawing.Color.Transparent;
            this.btnValor3.Enabled = false;
            this.btnValor3.FlatAppearance.BorderSize = 0;
            this.btnValor3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnValor3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValor3.Location = new System.Drawing.Point(475, 284);
            this.btnValor3.Name = "btnValor3";
            this.btnValor3.Size = new System.Drawing.Size(59, 23);
            this.btnValor3.TabIndex = 16;
            this.btnValor3.Text = "R$";
            this.btnValor3.UseVisualStyleBackColor = false;
            this.btnValor3.Click += new System.EventHandler(this.btnValor3_Click);
            // 
            // btnValor4
            // 
            this.btnValor4.BackColor = System.Drawing.Color.Transparent;
            this.btnValor4.Enabled = false;
            this.btnValor4.FlatAppearance.BorderSize = 0;
            this.btnValor4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnValor4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValor4.Location = new System.Drawing.Point(540, 284);
            this.btnValor4.Name = "btnValor4";
            this.btnValor4.Size = new System.Drawing.Size(59, 23);
            this.btnValor4.TabIndex = 17;
            this.btnValor4.Text = "R$";
            this.btnValor4.UseVisualStyleBackColor = false;
            this.btnValor4.Click += new System.EventHandler(this.btnValor4_Click);
            // 
            // btnValor5
            // 
            this.btnValor5.BackColor = System.Drawing.Color.Transparent;
            this.btnValor5.Enabled = false;
            this.btnValor5.FlatAppearance.BorderSize = 0;
            this.btnValor5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnValor5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValor5.Location = new System.Drawing.Point(345, 337);
            this.btnValor5.Name = "btnValor5";
            this.btnValor5.Size = new System.Drawing.Size(59, 23);
            this.btnValor5.TabIndex = 18;
            this.btnValor5.Text = "R$";
            this.btnValor5.UseVisualStyleBackColor = false;
            this.btnValor5.Click += new System.EventHandler(this.btnValor5_Click);
            // 
            // btnValor6
            // 
            this.btnValor6.BackColor = System.Drawing.Color.Transparent;
            this.btnValor6.Enabled = false;
            this.btnValor6.FlatAppearance.BorderSize = 0;
            this.btnValor6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnValor6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValor6.Location = new System.Drawing.Point(410, 337);
            this.btnValor6.Name = "btnValor6";
            this.btnValor6.Size = new System.Drawing.Size(59, 23);
            this.btnValor6.TabIndex = 19;
            this.btnValor6.Text = "R$";
            this.btnValor6.UseVisualStyleBackColor = false;
            this.btnValor6.Click += new System.EventHandler(this.btnValor6_Click);
            // 
            // btnValor7
            // 
            this.btnValor7.BackColor = System.Drawing.Color.Transparent;
            this.btnValor7.Enabled = false;
            this.btnValor7.FlatAppearance.BorderSize = 0;
            this.btnValor7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnValor7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValor7.Location = new System.Drawing.Point(475, 337);
            this.btnValor7.Name = "btnValor7";
            this.btnValor7.Size = new System.Drawing.Size(59, 23);
            this.btnValor7.TabIndex = 20;
            this.btnValor7.Text = "R$";
            this.btnValor7.UseVisualStyleBackColor = false;
            this.btnValor7.Click += new System.EventHandler(this.btnValor7_Click);
            // 
            // btnValor8
            // 
            this.btnValor8.BackColor = System.Drawing.Color.Transparent;
            this.btnValor8.Enabled = false;
            this.btnValor8.FlatAppearance.BorderSize = 0;
            this.btnValor8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnValor8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValor8.Location = new System.Drawing.Point(540, 337);
            this.btnValor8.Name = "btnValor8";
            this.btnValor8.Size = new System.Drawing.Size(59, 23);
            this.btnValor8.TabIndex = 21;
            this.btnValor8.Text = "R$";
            this.btnValor8.UseVisualStyleBackColor = false;
            this.btnValor8.Click += new System.EventHandler(this.btnValor8_Click);
            // 
            // lblValidade1
            // 
            this.lblValidade1.AutoSize = true;
            this.lblValidade1.Enabled = false;
            this.lblValidade1.Location = new System.Drawing.Point(342, 310);
            this.lblValidade1.Name = "lblValidade1";
            this.lblValidade1.Size = new System.Drawing.Size(48, 13);
            this.lblValidade1.TabIndex = 22;
            this.lblValidade1.Text = "Validade";
            // 
            // lblValidade2
            // 
            this.lblValidade2.AutoSize = true;
            this.lblValidade2.Enabled = false;
            this.lblValidade2.Location = new System.Drawing.Point(407, 310);
            this.lblValidade2.Name = "lblValidade2";
            this.lblValidade2.Size = new System.Drawing.Size(48, 13);
            this.lblValidade2.TabIndex = 23;
            this.lblValidade2.Text = "Validade";
            // 
            // lblValidade3
            // 
            this.lblValidade3.AutoSize = true;
            this.lblValidade3.Enabled = false;
            this.lblValidade3.Location = new System.Drawing.Point(472, 310);
            this.lblValidade3.Name = "lblValidade3";
            this.lblValidade3.Size = new System.Drawing.Size(48, 13);
            this.lblValidade3.TabIndex = 24;
            this.lblValidade3.Text = "Validade";
            // 
            // lblValidade4
            // 
            this.lblValidade4.AutoSize = true;
            this.lblValidade4.Enabled = false;
            this.lblValidade4.Location = new System.Drawing.Point(537, 310);
            this.lblValidade4.Name = "lblValidade4";
            this.lblValidade4.Size = new System.Drawing.Size(48, 13);
            this.lblValidade4.TabIndex = 25;
            this.lblValidade4.Text = "Validade";
            // 
            // lblValidade5
            // 
            this.lblValidade5.AutoSize = true;
            this.lblValidade5.Enabled = false;
            this.lblValidade5.Location = new System.Drawing.Point(342, 363);
            this.lblValidade5.Name = "lblValidade5";
            this.lblValidade5.Size = new System.Drawing.Size(48, 13);
            this.lblValidade5.TabIndex = 26;
            this.lblValidade5.Text = "Validade";
            // 
            // lblValidade6
            // 
            this.lblValidade6.AutoSize = true;
            this.lblValidade6.Enabled = false;
            this.lblValidade6.Location = new System.Drawing.Point(407, 363);
            this.lblValidade6.Name = "lblValidade6";
            this.lblValidade6.Size = new System.Drawing.Size(48, 13);
            this.lblValidade6.TabIndex = 27;
            this.lblValidade6.Text = "Validade";
            // 
            // lblValidade7
            // 
            this.lblValidade7.AutoSize = true;
            this.lblValidade7.Enabled = false;
            this.lblValidade7.Location = new System.Drawing.Point(472, 363);
            this.lblValidade7.Name = "lblValidade7";
            this.lblValidade7.Size = new System.Drawing.Size(48, 13);
            this.lblValidade7.TabIndex = 28;
            this.lblValidade7.Text = "Validade";
            // 
            // lblValidade8
            // 
            this.lblValidade8.AutoSize = true;
            this.lblValidade8.Enabled = false;
            this.lblValidade8.Location = new System.Drawing.Point(537, 363);
            this.lblValidade8.Name = "lblValidade8";
            this.lblValidade8.Size = new System.Drawing.Size(48, 13);
            this.lblValidade8.TabIndex = 29;
            this.lblValidade8.Text = "Validade";
            // 
            // PicLogoOperadora
            // 
            this.PicLogoOperadora.Location = new System.Drawing.Point(671, 3);
            this.PicLogoOperadora.Name = "PicLogoOperadora";
            this.PicLogoOperadora.Size = new System.Drawing.Size(117, 115);
            this.PicLogoOperadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogoOperadora.TabIndex = 30;
            this.PicLogoOperadora.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PicLogoOperadora);
            this.Controls.Add(this.lblValidade8);
            this.Controls.Add(this.lblValidade7);
            this.Controls.Add(this.lblValidade6);
            this.Controls.Add(this.lblValidade5);
            this.Controls.Add(this.lblValidade4);
            this.Controls.Add(this.lblValidade3);
            this.Controls.Add(this.lblValidade2);
            this.Controls.Add(this.lblValidade1);
            this.Controls.Add(this.btnValor8);
            this.Controls.Add(this.btnValor7);
            this.Controls.Add(this.btnValor6);
            this.Controls.Add(this.btnValor5);
            this.Controls.Add(this.btnValor4);
            this.Controls.Add(this.btnValor3);
            this.Controls.Add(this.btnValor2);
            this.Controls.Add(this.btnValor1);
            this.Controls.Add(this.lblSelecione);
            this.Controls.Add(this.txtRecarga);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.lblRecarga);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.txtDDD);
            this.Controls.Add(this.lblDDD);
            this.Controls.Add(this.txtOperadora);
            this.Controls.Add(this.lblOperadora);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.GroupOperadoras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Recarga Para Celular";
            this.GroupOperadoras.ResumeLayout(false);
            this.GroupOperadoras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogoOperadora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupOperadoras;
        private System.Windows.Forms.RadioButton radOi;
        private System.Windows.Forms.RadioButton radTim;
        private System.Windows.Forms.RadioButton radClaro;
        private System.Windows.Forms.RadioButton radVivo;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblOperadora;
        private System.Windows.Forms.TextBox txtOperadora;
        private System.Windows.Forms.Label lblDDD;
        private System.Windows.Forms.TextBox txtDDD;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblRecarga;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.TextBox txtRecarga;
        private System.Windows.Forms.Label lblSelecione;
        private System.Windows.Forms.Button btnValor1;
        private System.Windows.Forms.Button btnValor2;
        private System.Windows.Forms.Button btnValor3;
        private System.Windows.Forms.Button btnValor4;
        private System.Windows.Forms.Button btnValor5;
        private System.Windows.Forms.Button btnValor6;
        private System.Windows.Forms.Button btnValor7;
        private System.Windows.Forms.Button btnValor8;
        private System.Windows.Forms.Label lblValidade1;
        private System.Windows.Forms.Label lblValidade2;
        private System.Windows.Forms.Label lblValidade3;
        private System.Windows.Forms.Label lblValidade4;
        private System.Windows.Forms.Label lblValidade5;
        private System.Windows.Forms.Label lblValidade6;
        private System.Windows.Forms.Label lblValidade7;
        private System.Windows.Forms.Label lblValidade8;
        private System.Windows.Forms.PictureBox PicLogoOperadora;
    }
}

