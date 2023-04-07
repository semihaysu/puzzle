namespace puzzle
{
    partial class Start
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGiris = new System.Windows.Forms.Button();
            this.skorTabloText = new System.Windows.Forms.RichTextBox();
            this.oyuncuAdText = new System.Windows.Forms.TextBox();
            this.oyuncuAdLabel = new System.Windows.Forms.Label();
            this.skorTabloLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGiris
            // 
            this.buttonGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGiris.Location = new System.Drawing.Point(391, 288);
            this.buttonGiris.Name = "buttonGiris";
            this.buttonGiris.Size = new System.Drawing.Size(135, 70);
            this.buttonGiris.TabIndex = 0;
            this.buttonGiris.Text = "Start";
            this.buttonGiris.UseVisualStyleBackColor = true;
            this.buttonGiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // skorTabloText
            // 
            this.skorTabloText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skorTabloText.Location = new System.Drawing.Point(594, 71);
            this.skorTabloText.Name = "skorTabloText";
            this.skorTabloText.Size = new System.Drawing.Size(324, 287);
            this.skorTabloText.TabIndex = 1;
            this.skorTabloText.Text = " ";
            this.skorTabloText.TextChanged += new System.EventHandler(this.skorTabloText_TextChanged);
            // 
            // oyuncuAdText
            // 
            this.oyuncuAdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.oyuncuAdText.Location = new System.Drawing.Point(217, 29);
            this.oyuncuAdText.Name = "oyuncuAdText";
            this.oyuncuAdText.Size = new System.Drawing.Size(209, 40);
            this.oyuncuAdText.TabIndex = 4;
            this.oyuncuAdText.TextChanged += new System.EventHandler(this.oyuncuAdText_TextChanged);
            // 
            // oyuncuAdLabel
            // 
            this.oyuncuAdLabel.AutoSize = true;
            this.oyuncuAdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.oyuncuAdLabel.Location = new System.Drawing.Point(23, 32);
            this.oyuncuAdLabel.Name = "oyuncuAdLabel";
            this.oyuncuAdLabel.Size = new System.Drawing.Size(176, 33);
            this.oyuncuAdLabel.TabIndex = 5;
            this.oyuncuAdLabel.Text = "Oyuncu Adı";
            this.oyuncuAdLabel.Click += new System.EventHandler(this.oyuncuAdLabel_Click);
            // 
            // skorTabloLabel
            // 
            this.skorTabloLabel.AutoSize = true;
            this.skorTabloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.skorTabloLabel.Location = new System.Drawing.Point(658, 32);
            this.skorTabloLabel.Name = "skorTabloLabel";
            this.skorTabloLabel.Size = new System.Drawing.Size(199, 33);
            this.skorTabloLabel.TabIndex = 6;
            this.skorTabloLabel.Text = "Skor Tablosu";
            this.skorTabloLabel.Click += new System.EventHandler(this.skorTabloLabel_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(930, 384);
            this.Controls.Add(this.skorTabloLabel);
            this.Controls.Add(this.oyuncuAdLabel);
            this.Controls.Add(this.oyuncuAdText);
            this.Controls.Add(this.skorTabloText);
            this.Controls.Add(this.buttonGiris);
            this.Name = "Start";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGiris;
        private System.Windows.Forms.RichTextBox skorTabloText;
        private System.Windows.Forms.TextBox oyuncuAdText;
        private System.Windows.Forms.Label oyuncuAdLabel;
        private System.Windows.Forms.Label skorTabloLabel;
    }
}

