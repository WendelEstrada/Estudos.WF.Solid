namespace Estudos.WF.Solid.UI.Forms
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnConnectSignalR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(356, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(198, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Torneio de Luta";
            // 
            // btnGetAll
            // 
            this.btnGetAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetAll.Location = new System.Drawing.Point(351, 415);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(213, 23);
            this.btnGetAll.TabIndex = 1;
            this.btnGetAll.Text = "Obter Todos";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.BtnGetAll_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 66);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(914, 343);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // btnConnectSignalR
            // 
            this.btnConnectSignalR.Location = new System.Drawing.Point(851, 415);
            this.btnConnectSignalR.Name = "btnConnectSignalR";
            this.btnConnectSignalR.Size = new System.Drawing.Size(75, 23);
            this.btnConnectSignalR.TabIndex = 3;
            this.btnConnectSignalR.Text = "Conectar";
            this.btnConnectSignalR.UseVisualStyleBackColor = true;
            this.btnConnectSignalR.Click += new System.EventHandler(this.BtnConnectSignalR_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 450);
            this.Controls.Add(this.btnConnectSignalR);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormPrincipal";
            this.Text = "Torneio de Luta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button btnConnectSignalR;
    }
}

