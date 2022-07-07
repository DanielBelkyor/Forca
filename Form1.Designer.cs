
namespace Forca
{
    partial class FrmGameForca
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
            this.pnlGame = new System.Windows.Forms.Panel();
            this.BtnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxPalavra = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblRestante = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBxLetra = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblDica = new System.Windows.Forms.Label();
            this.pnlGame.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGame
            // 
            this.pnlGame.Controls.Add(this.groupBox4);
            this.pnlGame.Controls.Add(this.groupBox3);
            this.pnlGame.Controls.Add(this.groupBox2);
            this.pnlGame.Controls.Add(this.groupBox1);
            this.pnlGame.Controls.Add(this.txtBxPalavra);
            this.pnlGame.Controls.Add(this.label1);
            this.pnlGame.Location = new System.Drawing.Point(13, 12);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(911, 251);
            this.pnlGame.TabIndex = 0;
            this.pnlGame.Visible = false;
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnStart.Location = new System.Drawing.Point(604, 269);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(216, 59);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifique a palavra";
            // 
            // txtBxPalavra
            // 
            this.txtBxPalavra.Enabled = false;
            this.txtBxPalavra.Location = new System.Drawing.Point(6, 43);
            this.txtBxPalavra.Multiline = true;
            this.txtBxPalavra.Name = "txtBxPalavra";
            this.txtBxPalavra.Size = new System.Drawing.Size(395, 40);
            this.txtBxPalavra.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(407, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total de tentativas";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(80, 39);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(23, 25);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "5";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblRestante);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(672, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "tantativas restantes";
            // 
            // lblRestante
            // 
            this.lblRestante.AutoSize = true;
            this.lblRestante.Location = new System.Drawing.Point(80, 39);
            this.lblRestante.Name = "lblRestante";
            this.lblRestante.Size = new System.Drawing.Size(23, 25);
            this.lblRestante.TabIndex = 0;
            this.lblRestante.Text = "5";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnConfirmar);
            this.groupBox3.Controls.Add(this.txtBxLetra);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox3.Location = new System.Drawing.Point(407, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Digite a letra:";
            // 
            // txtBxLetra
            // 
            this.txtBxLetra.Location = new System.Drawing.Point(7, 49);
            this.txtBxLetra.MaxLength = 1;
            this.txtBxLetra.Name = "txtBxLetra";
            this.txtBxLetra.Size = new System.Drawing.Size(41, 38);
            this.txtBxLetra.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnConfirmar.Location = new System.Drawing.Point(284, 67);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(110, 33);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblDica);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox4.Location = new System.Drawing.Point(8, 89);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(393, 100);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dica";
            // 
            // lblDica
            // 
            this.lblDica.AutoSize = true;
            this.lblDica.Location = new System.Drawing.Point(6, 26);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(51, 25);
            this.lblDica.TabIndex = 0;
            this.lblDica.Text = "Dica";
            // 
            // FrmGameForca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 329);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.pnlGame);
            this.Name = "FrmGameForca";
            this.Text = "Game to Forca";
            this.pnlGame.ResumeLayout(false);
            this.pnlGame.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.TextBox txtBxPalavra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblRestante;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtBxLetra;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblDica;
    }
}

