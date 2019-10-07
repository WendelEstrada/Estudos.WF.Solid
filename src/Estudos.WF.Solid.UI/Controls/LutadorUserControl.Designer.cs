namespace Estudos.WF.Solid.UI.Controls
{
    partial class LutadorUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ckbxNomeDoLutador = new System.Windows.Forms.CheckBox();
            this.grpBoxLutador = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblLutas = new System.Windows.Forms.Label();
            this.lblDerrotas = new System.Windows.Forms.Label();
            this.lblVitorias = new System.Windows.Forms.Label();
            this.lblQuantidadeDeArtesMarciais = new System.Windows.Forms.Label();
            this.grpBoxLutador.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckbxNomeDoLutador
            // 
            this.ckbxNomeDoLutador.AutoSize = true;
            this.ckbxNomeDoLutador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbxNomeDoLutador.Location = new System.Drawing.Point(6, 19);
            this.ckbxNomeDoLutador.Name = "ckbxNomeDoLutador";
            this.ckbxNomeDoLutador.Size = new System.Drawing.Size(211, 29);
            this.ckbxNomeDoLutador.TabIndex = 1;
            this.ckbxNomeDoLutador.Text = "Nome do Lutador";
            this.ckbxNomeDoLutador.UseVisualStyleBackColor = true;
            // 
            // grpBoxLutador
            // 
            this.grpBoxLutador.Controls.Add(this.lblQuantidadeDeArtesMarciais);
            this.grpBoxLutador.Controls.Add(this.lblVitorias);
            this.grpBoxLutador.Controls.Add(this.lblDerrotas);
            this.grpBoxLutador.Controls.Add(this.lblLutas);
            this.grpBoxLutador.Controls.Add(this.lblIdade);
            this.grpBoxLutador.Controls.Add(this.label5);
            this.grpBoxLutador.Controls.Add(this.label4);
            this.grpBoxLutador.Controls.Add(this.label3);
            this.grpBoxLutador.Controls.Add(this.label2);
            this.grpBoxLutador.Controls.Add(this.label1);
            this.grpBoxLutador.Controls.Add(this.ckbxNomeDoLutador);
            this.grpBoxLutador.Location = new System.Drawing.Point(18, 20);
            this.grpBoxLutador.Name = "grpBoxLutador";
            this.grpBoxLutador.Size = new System.Drawing.Size(235, 208);
            this.grpBoxLutador.TabIndex = 2;
            this.grpBoxLutador.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Artes Marciais:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vitórias:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Derrotas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lutas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Idade:";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(112, 62);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(34, 13);
            this.lblIdade.TabIndex = 7;
            this.lblIdade.Text = "Idade";
            // 
            // lblLutas
            // 
            this.lblLutas.AutoSize = true;
            this.lblLutas.Location = new System.Drawing.Point(111, 86);
            this.lblLutas.Name = "lblLutas";
            this.lblLutas.Size = new System.Drawing.Size(33, 13);
            this.lblLutas.TabIndex = 7;
            this.lblLutas.Text = "Lutas";
            // 
            // lblDerrotas
            // 
            this.lblDerrotas.AutoSize = true;
            this.lblDerrotas.Location = new System.Drawing.Point(111, 116);
            this.lblDerrotas.Name = "lblDerrotas";
            this.lblDerrotas.Size = new System.Drawing.Size(47, 13);
            this.lblDerrotas.TabIndex = 7;
            this.lblDerrotas.Text = "Derrotas";
            // 
            // lblVitorias
            // 
            this.lblVitorias.AutoSize = true;
            this.lblVitorias.Location = new System.Drawing.Point(111, 143);
            this.lblVitorias.Name = "lblVitorias";
            this.lblVitorias.Size = new System.Drawing.Size(41, 13);
            this.lblVitorias.TabIndex = 7;
            this.lblVitorias.Text = "Vitorias";
            // 
            // lblQuantidadeDeArtesMarciais
            // 
            this.lblQuantidadeDeArtesMarciais.AutoSize = true;
            this.lblQuantidadeDeArtesMarciais.Location = new System.Drawing.Point(111, 175);
            this.lblQuantidadeDeArtesMarciais.Name = "lblQuantidadeDeArtesMarciais";
            this.lblQuantidadeDeArtesMarciais.Size = new System.Drawing.Size(73, 13);
            this.lblQuantidadeDeArtesMarciais.TabIndex = 7;
            this.lblQuantidadeDeArtesMarciais.Text = "Artes Marciais";
            // 
            // LutadorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpBoxLutador);
            this.Name = "LutadorUserControl";
            this.Size = new System.Drawing.Size(267, 241);
            this.grpBoxLutador.ResumeLayout(false);
            this.grpBoxLutador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbxNomeDoLutador;
        private System.Windows.Forms.GroupBox grpBoxLutador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuantidadeDeArtesMarciais;
        private System.Windows.Forms.Label lblVitorias;
        private System.Windows.Forms.Label lblDerrotas;
        private System.Windows.Forms.Label lblLutas;
        private System.Windows.Forms.Label lblIdade;
    }
}
