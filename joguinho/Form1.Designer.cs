namespace joguinho
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
            this.btJogar = new System.Windows.Forms.Button();
            this.lbPalavra = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbChances = new System.Windows.Forms.Label();
            this.lbLetrasUtilizadas = new System.Windows.Forms.Label();
            this.tbLetra = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btJogar
            // 
            this.btJogar.Location = new System.Drawing.Point(22, 162);
            this.btJogar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btJogar.Name = "btJogar";
            this.btJogar.Size = new System.Drawing.Size(333, 37);
            this.btJogar.TabIndex = 0;
            this.btJogar.Text = "Jogar";
            this.btJogar.UseVisualStyleBackColor = true;
            this.btJogar.Click += new System.EventHandler(this.btJogar_Click);
            this.btJogar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btJogar_KeyDown);
            // 
            // lbPalavra
            // 
            this.lbPalavra.AutoSize = true;
            this.lbPalavra.Location = new System.Drawing.Point(109, 32);
            this.lbPalavra.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbPalavra.Name = "lbPalavra";
            this.lbPalavra.Size = new System.Drawing.Size(100, 21);
            this.lbPalavra.TabIndex = 1;
            this.lbPalavra.Text = "_ _ _ _ _";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbPalavra);
            this.panel1.Location = new System.Drawing.Point(22, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 81);
            this.panel1.TabIndex = 2;
            // 
            // lbChances
            // 
            this.lbChances.AutoSize = true;
            this.lbChances.Location = new System.Drawing.Point(18, 213);
            this.lbChances.Name = "lbChances";
            this.lbChances.Size = new System.Drawing.Size(171, 21);
            this.lbChances.TabIndex = 3;
            this.lbChances.Text = "Quantidade de Vida: ";
            // 
            // lbLetrasUtilizadas
            // 
            this.lbLetrasUtilizadas.AutoSize = true;
            this.lbLetrasUtilizadas.Location = new System.Drawing.Point(18, 250);
            this.lbLetrasUtilizadas.Name = "lbLetrasUtilizadas";
            this.lbLetrasUtilizadas.Size = new System.Drawing.Size(153, 21);
            this.lbLetrasUtilizadas.TabIndex = 4;
            this.lbLetrasUtilizadas.Text = "Letras Utilizadas: ";
            // 
            // tbLetra
            // 
            this.tbLetra.Location = new System.Drawing.Point(22, 126);
            this.tbLetra.Name = "tbLetra";
            this.tbLetra.Size = new System.Drawing.Size(333, 28);
            this.tbLetra.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Proxima Palavra";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 34);
            this.button2.TabIndex = 8;
            this.button2.Text = "Reiniciar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(22, 293);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(62, 21);
            this.lbStatus.TabIndex = 9;
            this.lbStatus.Text = "Status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 379);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbLetra);
            this.Controls.Add(this.lbLetrasUtilizadas);
            this.Controls.Add(this.lbChances);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btJogar);
            this.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btJogar;
        private System.Windows.Forms.Label lbPalavra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbChances;
        private System.Windows.Forms.Label lbLetrasUtilizadas;
        private System.Windows.Forms.TextBox tbLetra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbStatus;
    }
}

