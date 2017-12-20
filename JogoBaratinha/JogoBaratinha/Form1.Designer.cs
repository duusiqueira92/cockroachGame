namespace JogoBaratinha
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPontos = new System.Windows.Forms.Label();
            this.pgbTempoJogo = new System.Windows.Forms.ProgressBar();
            this.tmrJogo = new System.Windows.Forms.Timer(this.components);
            this.pcbBaratinha = new System.Windows.Forms.PictureBox();
            this.pcbCoracao3 = new System.Windows.Forms.PictureBox();
            this.pcbCoracao2 = new System.Windows.Forms.PictureBox();
            this.pcbCoracao1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBaratinha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCoracao3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCoracao2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCoracao1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(614, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pontos";
            // 
            // lblPontos
            // 
            this.lblPontos.AutoSize = true;
            this.lblPontos.Location = new System.Drawing.Point(660, 0);
            this.lblPontos.Name = "lblPontos";
            this.lblPontos.Size = new System.Drawing.Size(13, 13);
            this.lblPontos.TabIndex = 5;
            this.lblPontos.Text = "0";
            // 
            // pgbTempoJogo
            // 
            this.pgbTempoJogo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pgbTempoJogo.Location = new System.Drawing.Point(0, 135);
            this.pgbTempoJogo.Name = "pgbTempoJogo";
            this.pgbTempoJogo.Size = new System.Drawing.Size(702, 23);
            this.pgbTempoJogo.TabIndex = 6;
            this.pgbTempoJogo.DockChanged += new System.EventHandler(this.Form1_Load);
            // 
            // pcbBaratinha
            // 
            this.pcbBaratinha.Image = global::JogoBaratinha.Properties.Resources.mosca_imagem_animada_0009;
            this.pcbBaratinha.Location = new System.Drawing.Point(146, 66);
            this.pcbBaratinha.Name = "pcbBaratinha";
            this.pcbBaratinha.Size = new System.Drawing.Size(50, 46);
            this.pcbBaratinha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBaratinha.TabIndex = 3;
            this.pcbBaratinha.TabStop = false;
            this.pcbBaratinha.Click += new System.EventHandler(this.pcbBaratinha_Click);
            // 
            // pcbCoracao3
            // 
            this.pcbCoracao3.Location = new System.Drawing.Point(127, 0);
            this.pcbCoracao3.Name = "pcbCoracao3";
            this.pcbCoracao3.Size = new System.Drawing.Size(69, 60);
            this.pcbCoracao3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCoracao3.TabIndex = 2;
            this.pcbCoracao3.TabStop = false;
            // 
            // pcbCoracao2
            // 
            this.pcbCoracao2.Location = new System.Drawing.Point(64, 0);
            this.pcbCoracao2.Name = "pcbCoracao2";
            this.pcbCoracao2.Size = new System.Drawing.Size(63, 60);
            this.pcbCoracao2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCoracao2.TabIndex = 1;
            this.pcbCoracao2.TabStop = false;
            // 
            // pcbCoracao1
            // 
            this.pcbCoracao1.Location = new System.Drawing.Point(0, 0);
            this.pcbCoracao1.Name = "pcbCoracao1";
            this.pcbCoracao1.Size = new System.Drawing.Size(61, 60);
            this.pcbCoracao1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCoracao1.TabIndex = 0;
            this.pcbCoracao1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 158);
            this.Controls.Add(this.pgbTempoJogo);
            this.Controls.Add(this.lblPontos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbBaratinha);
            this.Controls.Add(this.pcbCoracao3);
            this.Controls.Add(this.pcbCoracao2);
            this.Controls.Add(this.pcbCoracao1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBaratinha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCoracao3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCoracao2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCoracao1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbCoracao1;
        private System.Windows.Forms.PictureBox pcbCoracao2;
        private System.Windows.Forms.PictureBox pcbCoracao3;
        private System.Windows.Forms.PictureBox pcbBaratinha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPontos;
        private System.Windows.Forms.ProgressBar pgbTempoJogo;
        private System.Windows.Forms.Timer tmrJogo;
    }
}

