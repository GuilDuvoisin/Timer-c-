namespace WindowsFormsApp6
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Heure = new System.Windows.Forms.TextBox();
            this.second = new System.Windows.Forms.TextBox();
            this.Minutes = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // Heure
            // 
            this.Heure.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heure.Location = new System.Drawing.Point(61, 33);
            this.Heure.Name = "Heure";
            this.Heure.Size = new System.Drawing.Size(53, 49);
            this.Heure.TabIndex = 3;
            this.Heure.Text = "0";
            this.Heure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // second
            // 
            this.second.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second.Location = new System.Drawing.Point(179, 33);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(53, 49);
            this.second.TabIndex = 4;
            this.second.Text = "0";
            this.second.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.second.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Minutes
            // 
            this.Minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minutes.Location = new System.Drawing.Point(120, 33);
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(53, 49);
            this.Minutes.TabIndex = 5;
            this.Minutes.Text = "0";
            this.Minutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(43, 88);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBar1.Size = new System.Drawing.Size(210, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Value = 1000;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 331);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Minutes);
            this.Controls.Add(this.second);
            this.Controls.Add(this.Heure);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Heure;
        private System.Windows.Forms.TextBox second;
        private System.Windows.Forms.TextBox Minutes;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

