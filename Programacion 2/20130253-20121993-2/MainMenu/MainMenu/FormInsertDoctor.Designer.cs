namespace MainMenu
{
    partial class FormInsertDoctor
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
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.botonInsertar = new System.Windows.Forms.Button();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.MaskedTxtCedula = new System.Windows.Forms.MaskedTextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxEspecialidad = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbmEspecialidad = new System.Windows.Forms.ComboBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.MaskedTxtFechaNac = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRemoveEspecialidad = new System.Windows.Forms.Button();
            this.buttonAddEspecialidad = new System.Windows.Forms.Button();
            this.listBoxEspecialidadInsert = new System.Windows.Forms.ListBox();
            this.listDoctores = new System.Windows.Forms.ListBox();
            this.checkEspecialidad = new System.Windows.Forms.CheckBox();
            this.listBoxIDEspecialidad = new System.Windows.Forms.ListBox();
            this.cbmIdEspecialidad = new System.Windows.Forms.ComboBox();
            this.listBoxIDsEspecialidadesInsert = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botonLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonLimpiar.Location = new System.Drawing.Point(245, 365);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(92, 37);
            this.botonLimpiar.TabIndex = 31;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            // 
            // botonInsertar
            // 
            this.botonInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botonInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonInsertar.Location = new System.Drawing.Point(147, 365);
            this.botonInsertar.Name = "botonInsertar";
            this.botonInsertar.Size = new System.Drawing.Size(92, 37);
            this.botonInsertar.TabIndex = 30;
            this.botonInsertar.Text = "Insertar";
            this.botonInsertar.UseVisualStyleBackColor = true;
            this.botonInsertar.Click += new System.EventHandler(this.botonInsertar_Click);
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbSexo.Location = new System.Drawing.Point(63, 132);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(123, 28);
            this.cmbSexo.TabIndex = 29;
            // 
            // MaskedTxtCedula
            // 
            this.MaskedTxtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTxtCedula.Location = new System.Drawing.Point(73, 102);
            this.MaskedTxtCedula.Mask = "000-0000000-0";
            this.MaskedTxtCedula.Name = "MaskedTxtCedula";
            this.MaskedTxtCedula.Size = new System.Drawing.Size(123, 26);
            this.MaskedTxtCedula.TabIndex = 27;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(85, 38);
            this.txtApellido.MaxLength = 100;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(192, 26);
            this.txtApellido.TabIndex = 24;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(85, 6);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(192, 26);
            this.txtNombre.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Cedula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre";
            // 
            // listBoxEspecialidad
            // 
            this.listBoxEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxEspecialidad.FormattingEnabled = true;
            this.listBoxEspecialidad.Location = new System.Drawing.Point(259, 46);
            this.listBoxEspecialidad.Name = "listBoxEspecialidad";
            this.listBoxEspecialidad.Size = new System.Drawing.Size(119, 121);
            this.listBoxEspecialidad.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 60;
            this.label8.Text = "Especialidad";
            // 
            // cbmEspecialidad
            // 
            this.cbmEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmEspecialidad.FormattingEnabled = true;
            this.cbmEspecialidad.Location = new System.Drawing.Point(117, 198);
            this.cbmEspecialidad.Name = "cbmEspecialidad";
            this.cbmEspecialidad.Size = new System.Drawing.Size(186, 28);
            this.cbmEspecialidad.TabIndex = 59;
            this.cbmEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cbmEspecialidad_SelectedIndexChanged);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(343, 365);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(92, 37);
            this.buttonCancelar.TabIndex = 62;
            this.buttonCancelar.Text = "Cerrar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // MaskedTxtFechaNac
            // 
            this.MaskedTxtFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTxtFechaNac.Location = new System.Drawing.Point(175, 70);
            this.MaskedTxtFechaNac.Mask = "00/00/0000";
            this.MaskedTxtFechaNac.Name = "MaskedTxtFechaNac";
            this.MaskedTxtFechaNac.Size = new System.Drawing.Size(89, 26);
            this.MaskedTxtFechaNac.TabIndex = 65;
            this.MaskedTxtFechaNac.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 64;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // buttonRemoveEspecialidad
            // 
            this.buttonRemoveEspecialidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRemoveEspecialidad.Location = new System.Drawing.Point(336, 202);
            this.buttonRemoveEspecialidad.Name = "buttonRemoveEspecialidad";
            this.buttonRemoveEspecialidad.Size = new System.Drawing.Size(21, 21);
            this.buttonRemoveEspecialidad.TabIndex = 66;
            this.buttonRemoveEspecialidad.Text = "-";
            this.buttonRemoveEspecialidad.UseVisualStyleBackColor = true;
            this.buttonRemoveEspecialidad.Click += new System.EventHandler(this.buttonRemoveEspecialidad_Click);
            // 
            // buttonAddEspecialidad
            // 
            this.buttonAddEspecialidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddEspecialidad.Location = new System.Drawing.Point(309, 202);
            this.buttonAddEspecialidad.Name = "buttonAddEspecialidad";
            this.buttonAddEspecialidad.Size = new System.Drawing.Size(21, 21);
            this.buttonAddEspecialidad.TabIndex = 63;
            this.buttonAddEspecialidad.Text = "+";
            this.buttonAddEspecialidad.UseVisualStyleBackColor = true;
            this.buttonAddEspecialidad.Click += new System.EventHandler(this.buttonAddEspecialidad_Click);
            // 
            // listBoxEspecialidadInsert
            // 
            this.listBoxEspecialidadInsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxEspecialidadInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEspecialidadInsert.FormattingEnabled = true;
            this.listBoxEspecialidadInsert.ItemHeight = 29;
            this.listBoxEspecialidadInsert.Location = new System.Drawing.Point(14, 231);
            this.listBoxEspecialidadInsert.Name = "listBoxEspecialidadInsert";
            this.listBoxEspecialidadInsert.Size = new System.Drawing.Size(330, 120);
            this.listBoxEspecialidadInsert.TabIndex = 67;
            // 
            // listDoctores
            // 
            this.listDoctores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listDoctores.FormattingEnabled = true;
            this.listDoctores.Location = new System.Drawing.Point(384, 46);
            this.listDoctores.Name = "listDoctores";
            this.listDoctores.Size = new System.Drawing.Size(314, 121);
            this.listDoctores.TabIndex = 68;
            // 
            // checkEspecialidad
            // 
            this.checkEspecialidad.AutoSize = true;
            this.checkEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEspecialidad.Location = new System.Drawing.Point(27, 168);
            this.checkEspecialidad.Name = "checkEspecialidad";
            this.checkEspecialidad.Size = new System.Drawing.Size(179, 24);
            this.checkEspecialidad.TabIndex = 69;
            this.checkEspecialidad.Text = "Agregar Especialidad";
            this.checkEspecialidad.UseVisualStyleBackColor = true;
            this.checkEspecialidad.CheckedChanged += new System.EventHandler(this.checkEspecialidad_CheckedChanged);
            // 
            // listBoxIDEspecialidad
            // 
            this.listBoxIDEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxIDEspecialidad.FormattingEnabled = true;
            this.listBoxIDEspecialidad.Location = new System.Drawing.Point(144, 24);
            this.listBoxIDEspecialidad.Name = "listBoxIDEspecialidad";
            this.listBoxIDEspecialidad.Size = new System.Drawing.Size(119, 121);
            this.listBoxIDEspecialidad.TabIndex = 70;
            // 
            // cbmIdEspecialidad
            // 
            this.cbmIdEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmIdEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmIdEspecialidad.FormattingEnabled = true;
            this.cbmIdEspecialidad.Location = new System.Drawing.Point(148, 210);
            this.cbmIdEspecialidad.Name = "cbmIdEspecialidad";
            this.cbmIdEspecialidad.Size = new System.Drawing.Size(69, 28);
            this.cbmIdEspecialidad.TabIndex = 71;
            // 
            // listBoxIDsEspecialidadesInsert
            // 
            this.listBoxIDsEspecialidadesInsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxIDsEspecialidadesInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxIDsEspecialidadesInsert.FormattingEnabled = true;
            this.listBoxIDsEspecialidadesInsert.ItemHeight = 25;
            this.listBoxIDsEspecialidadesInsert.Location = new System.Drawing.Point(324, 212);
            this.listBoxIDsEspecialidadesInsert.Name = "listBoxIDsEspecialidadesInsert";
            this.listBoxIDsEspecialidadesInsert.Size = new System.Drawing.Size(213, 104);
            this.listBoxIDsEspecialidadesInsert.TabIndex = 72;
            // 
            // FormInsertDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 414);
            this.Controls.Add(this.listBoxIDsEspecialidadesInsert);
            this.Controls.Add(this.cbmIdEspecialidad);
            this.Controls.Add(this.listBoxIDEspecialidad);
            this.Controls.Add(this.checkEspecialidad);
            this.Controls.Add(this.listDoctores);
            this.Controls.Add(this.listBoxEspecialidadInsert);
            this.Controls.Add(this.buttonRemoveEspecialidad);
            this.Controls.Add(this.MaskedTxtFechaNac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAddEspecialidad);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.listBoxEspecialidad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbmEspecialidad);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonInsertar);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.MaskedTxtCedula);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormInsertDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.FormInsertDoctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Button botonInsertar;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.MaskedTextBox MaskedTxtCedula;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxEspecialidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbmEspecialidad;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAddEspecialidad;
        private System.Windows.Forms.MaskedTextBox MaskedTxtFechaNac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRemoveEspecialidad;
        private System.Windows.Forms.ListBox listBoxEspecialidadInsert;
        private System.Windows.Forms.ListBox listDoctores;
        private System.Windows.Forms.CheckBox checkEspecialidad;
        private System.Windows.Forms.ListBox listBoxIDEspecialidad;
        private System.Windows.Forms.ComboBox cbmIdEspecialidad;
        private System.Windows.Forms.ListBox listBoxIDsEspecialidadesInsert;
        }
}