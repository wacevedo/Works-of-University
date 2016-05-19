namespace MainMenu
{
    partial class FormConsultas
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
            this.cmbPatologia = new System.Windows.Forms.ComboBox();
            this.cmbClinica = new System.Windows.Forms.ComboBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbHabitacion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSintomas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTratamiento = new System.Windows.Forms.TextBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.botonInsertar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.MaskedTxtFechaAlta = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxSelectPatologia = new System.Windows.Forms.ListBox();
            this.checkBoxInternar = new System.Windows.Forms.CheckBox();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.botonQuitar = new System.Windows.Forms.Button();
            this.listTodosIDs = new System.Windows.Forms.ListBox();
            this.listTodasPatologias = new System.Windows.Forms.ListBox();
            this.listBoxSelectID = new System.Windows.Forms.ListBox();
            this.checkDetPat = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbIDPat = new System.Windows.Forms.ComboBox();
            this.listaConsulta = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbPatologia
            // 
            this.cmbPatologia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatologia.FormattingEnabled = true;
            this.cmbPatologia.Location = new System.Drawing.Point(87, 18);
            this.cmbPatologia.Name = "cmbPatologia";
            this.cmbPatologia.Size = new System.Drawing.Size(122, 21);
            this.cmbPatologia.TabIndex = 0;
            // 
            // cmbClinica
            // 
            this.cmbClinica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClinica.FormattingEnabled = true;
            this.cmbClinica.Location = new System.Drawing.Point(120, 11);
            this.cmbClinica.Name = "cmbClinica";
            this.cmbClinica.Size = new System.Drawing.Size(338, 21);
            this.cmbClinica.TabIndex = 1;
            this.cmbClinica.SelectedIndexChanged += new System.EventHandler(this.cmbClinica_SelectedIndexChanged);
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(869, 11);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(244, 21);
            this.cmbDoctor.TabIndex = 2;
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(73, 86);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(338, 21);
            this.cmbPaciente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Patología";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Centro Salud";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(806, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Doctor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(205, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Paciente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Habitación";
            // 
            // cmbHabitacion
            // 
            this.cmbHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHabitacion.FormattingEnabled = true;
            this.cmbHabitacion.Location = new System.Drawing.Point(119, 18);
            this.cmbHabitacion.Name = "cmbHabitacion";
            this.cmbHabitacion.Size = new System.Drawing.Size(185, 21);
            this.cmbHabitacion.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Síntomas";
            // 
            // txtSintomas
            // 
            this.txtSintomas.Location = new System.Drawing.Point(12, 161);
            this.txtSintomas.Multiline = true;
            this.txtSintomas.Name = "txtSintomas";
            this.txtSintomas.Size = new System.Drawing.Size(399, 202);
            this.txtSintomas.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(417, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "Tratamiento";
            // 
            // txtTratamiento
            // 
            this.txtTratamiento.Location = new System.Drawing.Point(417, 161);
            this.txtTratamiento.Multiline = true;
            this.txtTratamiento.Name = "txtTratamiento";
            this.txtTratamiento.Size = new System.Drawing.Size(399, 202);
            this.txtTratamiento.TabIndex = 46;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(540, 70);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(233, 37);
            this.labelFecha.TabIndex = 47;
            this.labelFecha.Text = "FechaConsulta";
            // 
            // botonInsertar
            // 
            this.botonInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botonInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonInsertar.Location = new System.Drawing.Point(825, 545);
            this.botonInsertar.Name = "botonInsertar";
            this.botonInsertar.Size = new System.Drawing.Size(92, 37);
            this.botonInsertar.TabIndex = 48;
            this.botonInsertar.Text = "Insertar";
            this.botonInsertar.UseVisualStyleBackColor = true;
            this.botonInsertar.Click += new System.EventHandler(this.botonInsertar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(1021, 545);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(92, 37);
            this.buttonCancelar.TabIndex = 49;
            this.buttonCancelar.Text = "Cerrar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botonLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonLimpiar.Location = new System.Drawing.Point(923, 545);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(92, 37);
            this.botonLimpiar.TabIndex = 50;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 52;
            this.label9.Text = "Fecha de alta";
            // 
            // MaskedTxtFechaAlta
            // 
            this.MaskedTxtFechaAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTxtFechaAlta.Location = new System.Drawing.Point(119, 45);
            this.MaskedTxtFechaAlta.Mask = "00/00/0000";
            this.MaskedTxtFechaAlta.Name = "MaskedTxtFechaAlta";
            this.MaskedTxtFechaAlta.Size = new System.Drawing.Size(89, 26);
            this.MaskedTxtFechaAlta.TabIndex = 53;
            this.MaskedTxtFechaAlta.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MaskedTxtFechaAlta);
            this.groupBox1.Controls.Add(this.cmbHabitacion);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(417, 408);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 81);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            // 
            // listBoxSelectPatologia
            // 
            this.listBoxSelectPatologia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxSelectPatologia.FormattingEnabled = true;
            this.listBoxSelectPatologia.Location = new System.Drawing.Point(10, 45);
            this.listBoxSelectPatologia.Name = "listBoxSelectPatologia";
            this.listBoxSelectPatologia.Size = new System.Drawing.Size(172, 121);
            this.listBoxSelectPatologia.TabIndex = 55;
            // 
            // checkBoxInternar
            // 
            this.checkBoxInternar.AutoSize = true;
            this.checkBoxInternar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxInternar.Location = new System.Drawing.Point(417, 378);
            this.checkBoxInternar.Name = "checkBoxInternar";
            this.checkBoxInternar.Size = new System.Drawing.Size(92, 24);
            this.checkBoxInternar.TabIndex = 56;
            this.checkBoxInternar.Text = "Internar";
            this.checkBoxInternar.UseVisualStyleBackColor = true;
            this.checkBoxInternar.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // botonAgregar
            // 
            this.botonAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAgregar.Location = new System.Drawing.Point(330, 19);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(21, 21);
            this.botonAgregar.TabIndex = 64;
            this.botonAgregar.Text = "+";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // botonQuitar
            // 
            this.botonQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonQuitar.Location = new System.Drawing.Point(357, 19);
            this.botonQuitar.Name = "botonQuitar";
            this.botonQuitar.Size = new System.Drawing.Size(21, 21);
            this.botonQuitar.TabIndex = 67;
            this.botonQuitar.Text = "-";
            this.botonQuitar.UseVisualStyleBackColor = true;
            this.botonQuitar.Click += new System.EventHandler(this.botonQuitar_Click);
            // 
            // listTodosIDs
            // 
            this.listTodosIDs.FormattingEnabled = true;
            this.listTodosIDs.Location = new System.Drawing.Point(825, 161);
            this.listTodosIDs.Name = "listTodosIDs";
            this.listTodosIDs.Size = new System.Drawing.Size(253, 108);
            this.listTodosIDs.TabIndex = 68;
            // 
            // listTodasPatologias
            // 
            this.listTodasPatologias.FormattingEnabled = true;
            this.listTodasPatologias.Location = new System.Drawing.Point(822, 281);
            this.listTodasPatologias.Name = "listTodasPatologias";
            this.listTodasPatologias.Size = new System.Drawing.Size(253, 121);
            this.listTodasPatologias.TabIndex = 69;
            // 
            // listBoxSelectID
            // 
            this.listBoxSelectID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxSelectID.FormattingEnabled = true;
            this.listBoxSelectID.Location = new System.Drawing.Point(188, 45);
            this.listBoxSelectID.Name = "listBoxSelectID";
            this.listBoxSelectID.Size = new System.Drawing.Size(190, 121);
            this.listBoxSelectID.TabIndex = 70;
            // 
            // checkDetPat
            // 
            this.checkDetPat.AutoSize = true;
            this.checkDetPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDetPat.Location = new System.Drawing.Point(12, 378);
            this.checkDetPat.Name = "checkDetPat";
            this.checkDetPat.Size = new System.Drawing.Size(196, 24);
            this.checkDetPat.TabIndex = 71;
            this.checkDetPat.Text = "Determinar patología";
            this.checkDetPat.UseVisualStyleBackColor = true;
            this.checkDetPat.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbIDPat);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.listBoxSelectID);
            this.groupBox2.Controls.Add(this.cmbPatologia);
            this.groupBox2.Controls.Add(this.listBoxSelectPatologia);
            this.groupBox2.Controls.Add(this.botonAgregar);
            this.groupBox2.Controls.Add(this.botonQuitar);
            this.groupBox2.Location = new System.Drawing.Point(12, 408);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 182);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            // 
            // cmbIDPat
            // 
            this.cmbIDPat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIDPat.FormattingEnabled = true;
            this.cmbIDPat.Location = new System.Drawing.Point(229, 18);
            this.cmbIDPat.Name = "cmbIDPat";
            this.cmbIDPat.Size = new System.Drawing.Size(95, 21);
            this.cmbIDPat.TabIndex = 71;
            // 
            // listaConsulta
            // 
            this.listaConsulta.FormattingEnabled = true;
            this.listaConsulta.Location = new System.Drawing.Point(822, 405);
            this.listaConsulta.Name = "listaConsulta";
            this.listaConsulta.Size = new System.Drawing.Size(118, 134);
            this.listaConsulta.TabIndex = 73;
            // 
            // FormConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 594);
            this.Controls.Add(this.listaConsulta);
            this.Controls.Add(this.checkDetPat);
            this.Controls.Add(this.listTodasPatologias);
            this.Controls.Add(this.listTodosIDs);
            this.Controls.Add(this.checkBoxInternar);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.botonInsertar);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTratamiento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbPaciente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDoctor);
            this.Controls.Add(this.cmbClinica);
            this.Controls.Add(this.txtSintomas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsultas";
            this.Load += new System.EventHandler(this.FormConsultas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPatologia;
        private System.Windows.Forms.ComboBox cmbClinica;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbHabitacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSintomas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTratamiento;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Button botonInsertar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox MaskedTxtFechaAlta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxSelectPatologia;
        private System.Windows.Forms.CheckBox checkBoxInternar;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Button botonQuitar;
        private System.Windows.Forms.ListBox listTodosIDs;
        private System.Windows.Forms.ListBox listTodasPatologias;
        private System.Windows.Forms.ListBox listBoxSelectID;
        private System.Windows.Forms.CheckBox checkDetPat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbIDPat;
        private System.Windows.Forms.ListBox listaConsulta;
    }
}