namespace Vista
{
    partial class CrearCliente
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DireccionClienteTextBox = new System.Windows.Forms.TextBox();
            this.IdentidadClienteTextBox = new System.Windows.Forms.TextBox();
            this.NombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.CrearButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailClienteTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TelefonoClienteTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Identidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre Completo:";
            // 
            // DireccionClienteTextBox
            // 
            this.DireccionClienteTextBox.Location = new System.Drawing.Point(602, 141);
            this.DireccionClienteTextBox.Name = "DireccionClienteTextBox";
            this.DireccionClienteTextBox.Size = new System.Drawing.Size(153, 23);
            this.DireccionClienteTextBox.TabIndex = 15;
            // 
            // IdentidadClienteTextBox
            // 
            this.IdentidadClienteTextBox.Location = new System.Drawing.Point(602, 93);
            this.IdentidadClienteTextBox.Name = "IdentidadClienteTextBox";
            this.IdentidadClienteTextBox.Size = new System.Drawing.Size(153, 23);
            this.IdentidadClienteTextBox.TabIndex = 14;
            // 
            // NombreClienteTextBox
            // 
            this.NombreClienteTextBox.Location = new System.Drawing.Point(602, 42);
            this.NombreClienteTextBox.Name = "NombreClienteTextBox";
            this.NombreClienteTextBox.Size = new System.Drawing.Size(160, 23);
            this.NombreClienteTextBox.TabIndex = 13;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(691, 327);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(77, 26);
            this.CancelarButton.TabIndex = 12;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // CrearButton
            // 
            this.CrearButton.Location = new System.Drawing.Point(596, 327);
            this.CrearButton.Name = "CrearButton";
            this.CrearButton.Size = new System.Drawing.Size(75, 26);
            this.CrearButton.TabIndex = 11;
            this.CrearButton.Text = "Crear";
            this.CrearButton.UseVisualStyleBackColor = true;
            this.CrearButton.Click += new System.EventHandler(this.CrearButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Email:";
            // 
            // EmailClienteTextBox
            // 
            this.EmailClienteTextBox.Location = new System.Drawing.Point(602, 190);
            this.EmailClienteTextBox.Name = "EmailClienteTextBox";
            this.EmailClienteTextBox.Size = new System.Drawing.Size(153, 23);
            this.EmailClienteTextBox.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(540, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Telefono:";
            // 
            // TelefonoClienteTextBox
            // 
            this.TelefonoClienteTextBox.Location = new System.Drawing.Point(602, 236);
            this.TelefonoClienteTextBox.Name = "TelefonoClienteTextBox";
            this.TelefonoClienteTextBox.Size = new System.Drawing.Size(153, 23);
            this.TelefonoClienteTextBox.TabIndex = 22;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CrearCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TelefonoClienteTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmailClienteTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DireccionClienteTextBox);
            this.Controls.Add(this.IdentidadClienteTextBox);
            this.Controls.Add(this.NombreClienteTextBox);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.CrearButton);
            this.Name = "CrearCliente";
            this.Text = "CrearCliente";
            this.Load += new System.EventHandler(this.CrearCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox DireccionClienteTextBox;
        private TextBox IdentidadClienteTextBox;
        private TextBox NombreClienteTextBox;
        private Button CancelarButton;
        private Button CrearButton;
        private Label label4;
        private TextBox EmailClienteTextBox;
        private Label label5;
        private TextBox TelefonoClienteTextBox;
        private ErrorProvider errorProvider1;
    }
}