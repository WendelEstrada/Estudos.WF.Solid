namespace Estudos.WF.Solid.UI.SignalR.Tester
{
    partial class FormPrincipal
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
            this.BtnConectar = new System.Windows.Forms.Button();
            this.TxtMensagem = new System.Windows.Forms.TextBox();
            this.BtnEnviarMensagem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnConectar
            // 
            this.BtnConectar.Location = new System.Drawing.Point(12, 164);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(167, 57);
            this.BtnConectar.TabIndex = 0;
            this.BtnConectar.Text = "Conectar";
            this.BtnConectar.UseVisualStyleBackColor = true;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // TxtMensagem
            // 
            this.TxtMensagem.Location = new System.Drawing.Point(12, 12);
            this.TxtMensagem.Multiline = true;
            this.TxtMensagem.Name = "TxtMensagem";
            this.TxtMensagem.Size = new System.Drawing.Size(340, 146);
            this.TxtMensagem.TabIndex = 1;
            // 
            // BtnEnviarMensagem
            // 
            this.BtnEnviarMensagem.Location = new System.Drawing.Point(185, 164);
            this.BtnEnviarMensagem.Name = "BtnEnviarMensagem";
            this.BtnEnviarMensagem.Size = new System.Drawing.Size(167, 57);
            this.BtnEnviarMensagem.TabIndex = 2;
            this.BtnEnviarMensagem.Text = "Enviar";
            this.BtnEnviarMensagem.UseVisualStyleBackColor = true;
            this.BtnEnviarMensagem.Click += new System.EventHandler(this.BtnEnviarMensagem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 231);
            this.Controls.Add(this.BtnEnviarMensagem);
            this.Controls.Add(this.TxtMensagem);
            this.Controls.Add(this.BtnConectar);
            this.Name = "FormPrincipal";
            this.Text = "SignalR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.TextBox TxtMensagem;
        private System.Windows.Forms.Button BtnEnviarMensagem;
    }
}

