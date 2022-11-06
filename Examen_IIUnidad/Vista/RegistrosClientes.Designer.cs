namespace Vista
{
    partial class RegistrosClientes
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
            this.RegistroClienteDataGridView = new System.Windows.Forms.DataGridView();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TelefonoClienteTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailClienteTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DireccionClienteTextBox = new System.Windows.Forms.TextBox();
            this.IdentidadClienteTextBox = new System.Windows.Forms.TextBox();
            this.NombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RegistroClienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // RegistroClienteDataGridView
            // 
            this.RegistroClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegistroClienteDataGridView.Location = new System.Drawing.Point(12, 184);
            this.RegistroClienteDataGridView.Name = "RegistroClienteDataGridView";
            this.RegistroClienteDataGridView.RowTemplate.Height = 25;
            this.RegistroClienteDataGridView.Size = new System.Drawing.Size(784, 256);
            this.RegistroClienteDataGridView.TabIndex = 51;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(414, 466);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(77, 26);
            this.EliminarButton.TabIndex = 50;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 49;
            this.label5.Text = "Telefono:";
            // 
            // TelefonoClienteTextBox
            // 
            this.TelefonoClienteTextBox.Location = new System.Drawing.Point(509, 141);
            this.TelefonoClienteTextBox.Name = "TelefonoClienteTextBox";
            this.TelefonoClienteTextBox.Size = new System.Drawing.Size(153, 23);
            this.TelefonoClienteTextBox.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 47;
            this.label4.Text = "Email:";
            // 
            // EmailClienteTextBox
            // 
            this.EmailClienteTextBox.Location = new System.Drawing.Point(83, 138);
            this.EmailClienteTextBox.Name = "EmailClienteTextBox";
            this.EmailClienteTextBox.Size = new System.Drawing.Size(339, 23);
            this.EmailClienteTextBox.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "Dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 44;
            this.label2.Text = "Identidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "Nombre Completo:";
            // 
            // DireccionClienteTextBox
            // 
            this.DireccionClienteTextBox.Location = new System.Drawing.Point(83, 86);
            this.DireccionClienteTextBox.Name = "DireccionClienteTextBox";
            this.DireccionClienteTextBox.Size = new System.Drawing.Size(434, 23);
            this.DireccionClienteTextBox.TabIndex = 42;
            // 
            // IdentidadClienteTextBox
            // 
            this.IdentidadClienteTextBox.Location = new System.Drawing.Point(83, 32);
            this.IdentidadClienteTextBox.Name = "IdentidadClienteTextBox";
            this.IdentidadClienteTextBox.Size = new System.Drawing.Size(182, 23);
            this.IdentidadClienteTextBox.TabIndex = 41;
            // 
            // NombreClienteTextBox
            // 
            this.NombreClienteTextBox.Location = new System.Drawing.Point(393, 32);
            this.NombreClienteTextBox.Name = "NombreClienteTextBox";
            this.NombreClienteTextBox.Size = new System.Drawing.Size(269, 23);
            this.NombreClienteTextBox.TabIndex = 40;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(312, 466);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(77, 26);
            this.GuardarButton.TabIndex = 39;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // ModificarButton
            // 
            this.ModificarButton.Location = new System.Drawing.Point(217, 466);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(75, 26);
            this.ModificarButton.TabIndex = 38;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(521, 466);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 26);
            this.CancelarButton.TabIndex = 52;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RegistrosClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.RegistroClienteDataGridView);
            this.Controls.Add(this.EliminarButton);
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
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.ModificarButton);
            this.Name = "RegistrosClientes";
            this.Text = "RegistrosClientes";
            this.Load += new System.EventHandler(this.RegistrosClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RegistroClienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView RegistroClienteDataGridView;
        private Button EliminarButton;
        private Label label5;
        private TextBox TelefonoClienteTextBox;
        private Label label4;
        private TextBox EmailClienteTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox DireccionClienteTextBox;
        private TextBox IdentidadClienteTextBox;
        private TextBox NombreClienteTextBox;
        private Button GuardarButton;
        private Button ModificarButton;
        private Button CancelarButton;
        private ErrorProvider errorProvider1;
    }
}