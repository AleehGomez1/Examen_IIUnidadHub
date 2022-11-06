namespace Vista
{
    partial class Tipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tipos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SoporteCelularButton = new System.Windows.Forms.Button();
            this.SoporteComputoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Magneto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(31, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Soporte de Celular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Magneto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(412, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soporte de Computo";
            // 
            // SoporteCelularButton
            // 
            this.SoporteCelularButton.Image = ((System.Drawing.Image)(resources.GetObject("SoporteCelularButton.Image")));
            this.SoporteCelularButton.Location = new System.Drawing.Point(50, 112);
            this.SoporteCelularButton.Name = "SoporteCelularButton";
            this.SoporteCelularButton.Size = new System.Drawing.Size(303, 301);
            this.SoporteCelularButton.TabIndex = 4;
            this.SoporteCelularButton.UseVisualStyleBackColor = true;
            this.SoporteCelularButton.Click += new System.EventHandler(this.SoporteCelularButton_Click);
            // 
            // SoporteComputoButton
            // 
            this.SoporteComputoButton.Image = ((System.Drawing.Image)(resources.GetObject("SoporteComputoButton.Image")));
            this.SoporteComputoButton.Location = new System.Drawing.Point(451, 112);
            this.SoporteComputoButton.Name = "SoporteComputoButton";
            this.SoporteComputoButton.Size = new System.Drawing.Size(303, 301);
            this.SoporteComputoButton.TabIndex = 5;
            this.SoporteComputoButton.UseVisualStyleBackColor = true;
            this.SoporteComputoButton.Click += new System.EventHandler(this.SoporteComputoButton_Click);
            // 
            // Tipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.SoporteComputoButton);
            this.Controls.Add(this.SoporteCelularButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Tipos";
            this.Text = "Tipos";
            this.Load += new System.EventHandler(this.Tipos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Button SoporteCelularButton;
        private Button SoporteComputoButton;
    }
}