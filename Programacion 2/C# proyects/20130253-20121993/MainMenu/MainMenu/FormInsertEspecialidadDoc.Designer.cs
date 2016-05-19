namespace MainMenu
{
    partial class FormInsertEspecialidadDoc
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
            this.cmbNombre = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbmEspecialidad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddEspecialidad = new System.Windows.Forms.Button();
            this.listBoxEspecialidad = new System.Windows.Forms.ListBox();
            this.buttonRemoveEspecialidad = new System.Windows.Forms.Button();
            this.especialidades_doc = new System.Windows.Forms.ListBox();
            this.especialidades_id = new System.Windows.Forms.ListBox();
            this.Especialidades_IdSelected = new System.Windows.Forms.ListBox();
            this.cmbIdEspecialidad = new System.Windows.Forms.ComboBox();
            this.botonInsertar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listDoctores = new System.Windows.Forms.ListBox();
            this.clinicaDataBaseDataSet = new MainMenu.ClinicaDataBaseDataSet();
            this.eSPECIALIDADBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSPECIALIDADTableAdapter = new MainMenu.ClinicaDataBaseDataSetTableAdapters.ESPECIALIDADTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSPECIALIDADBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbNombre
            // 
            this.cmbNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNombre.FormattingEnabled = true;
            this.cmbNombre.Location = new System.Drawing.Point(122, 19);
            this.cmbNombre.Name = "cmbNombre";
            this.cmbNombre.Size = new System.Drawing.Size(317, 28);
            this.cmbNombre.TabIndex = 15;
            this.cmbNombre.SelectedIndexChanged += new System.EventHandler(this.cmbNombre_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nombre";
            // 
            // cbmEspecialidad
            // 
            this.cbmEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmEspecialidad.FormattingEnabled = true;
            this.cbmEspecialidad.Location = new System.Drawing.Point(122, 53);
            this.cbmEspecialidad.Name = "cbmEspecialidad";
            this.cbmEspecialidad.Size = new System.Drawing.Size(317, 28);
            this.cbmEspecialidad.TabIndex = 17;
            this.cbmEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cbmEspecialidad_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Especialidad";
            // 
            // buttonAddEspecialidad
            // 
            this.buttonAddEspecialidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddEspecialidad.Location = new System.Drawing.Point(445, 19);
            this.buttonAddEspecialidad.Name = "buttonAddEspecialidad";
            this.buttonAddEspecialidad.Size = new System.Drawing.Size(62, 62);
            this.buttonAddEspecialidad.TabIndex = 64;
            this.buttonAddEspecialidad.Text = "+";
            this.buttonAddEspecialidad.UseVisualStyleBackColor = true;
            this.buttonAddEspecialidad.Click += new System.EventHandler(this.buttonAddEspecialidad_Click);
            // 
            // listBoxEspecialidad
            // 
            this.listBoxEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxEspecialidad.FormattingEnabled = true;
            this.listBoxEspecialidad.Location = new System.Drawing.Point(21, 87);
            this.listBoxEspecialidad.Name = "listBoxEspecialidad";
            this.listBoxEspecialidad.Size = new System.Drawing.Size(554, 147);
            this.listBoxEspecialidad.TabIndex = 65;
            this.listBoxEspecialidad.SelectedIndexChanged += new System.EventHandler(this.listBoxEspecialidad_SelectedIndexChanged);
            // 
            // buttonRemoveEspecialidad
            // 
            this.buttonRemoveEspecialidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRemoveEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveEspecialidad.Location = new System.Drawing.Point(513, 19);
            this.buttonRemoveEspecialidad.Name = "buttonRemoveEspecialidad";
            this.buttonRemoveEspecialidad.Size = new System.Drawing.Size(62, 62);
            this.buttonRemoveEspecialidad.TabIndex = 66;
            this.buttonRemoveEspecialidad.Text = "-";
            this.buttonRemoveEspecialidad.UseVisualStyleBackColor = true;
            this.buttonRemoveEspecialidad.Click += new System.EventHandler(this.buttonRemoveEspecialidad_Click);
            // 
            // especialidades_doc
            // 
            this.especialidades_doc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.especialidades_doc.FormattingEnabled = true;
            this.especialidades_doc.Location = new System.Drawing.Point(5, 10);
            this.especialidades_doc.Name = "especialidades_doc";
            this.especialidades_doc.Size = new System.Drawing.Size(179, 95);
            this.especialidades_doc.TabIndex = 67;
            // 
            // especialidades_id
            // 
            this.especialidades_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.especialidades_id.FormattingEnabled = true;
            this.especialidades_id.Location = new System.Drawing.Point(190, 10);
            this.especialidades_id.Name = "especialidades_id";
            this.especialidades_id.Size = new System.Drawing.Size(48, 95);
            this.especialidades_id.TabIndex = 69;
            // 
            // Especialidades_IdSelected
            // 
            this.Especialidades_IdSelected.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Especialidades_IdSelected.FormattingEnabled = true;
            this.Especialidades_IdSelected.Location = new System.Drawing.Point(308, 41);
            this.Especialidades_IdSelected.Name = "Especialidades_IdSelected";
            this.Especialidades_IdSelected.Size = new System.Drawing.Size(41, 56);
            this.Especialidades_IdSelected.TabIndex = 70;
            // 
            // cmbIdEspecialidad
            // 
            this.cmbIdEspecialidad.FormattingEnabled = true;
            this.cmbIdEspecialidad.Location = new System.Drawing.Point(295, 14);
            this.cmbIdEspecialidad.Name = "cmbIdEspecialidad";
            this.cmbIdEspecialidad.Size = new System.Drawing.Size(84, 21);
            this.cmbIdEspecialidad.TabIndex = 71;
            // 
            // botonInsertar
            // 
            this.botonInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botonInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonInsertar.Location = new System.Drawing.Point(483, 300);
            this.botonInsertar.Name = "botonInsertar";
            this.botonInsertar.Size = new System.Drawing.Size(92, 37);
            this.botonInsertar.TabIndex = 72;
            this.botonInsertar.Text = "Insertar";
            this.botonInsertar.UseVisualStyleBackColor = true;
            this.botonInsertar.Click += new System.EventHandler(this.botonInsertar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listDoctores);
            this.groupBox1.Controls.Add(this.Especialidades_IdSelected);
            this.groupBox1.Controls.Add(this.especialidades_doc);
            this.groupBox1.Controls.Add(this.cmbIdEspecialidad);
            this.groupBox1.Controls.Add(this.especialidades_id);
            this.groupBox1.Location = new System.Drawing.Point(21, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 111);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // listDoctores
            // 
            this.listDoctores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listDoctores.FormattingEnabled = true;
            this.listDoctores.Location = new System.Drawing.Point(248, 10);
            this.listDoctores.Name = "listDoctores";
            this.listDoctores.Size = new System.Drawing.Size(41, 95);
            this.listDoctores.TabIndex = 74;
            // 
            // clinicaDataBaseDataSet
            // 
            this.clinicaDataBaseDataSet.DataSetName = "ClinicaDataBaseDataSet";
            this.clinicaDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eSPECIALIDADBindingSource
            // 
            this.eSPECIALIDADBindingSource.DataMember = "ESPECIALIDAD";
            this.eSPECIALIDADBindingSource.DataSource = this.clinicaDataBaseDataSet;
            // 
            // eSPECIALIDADTableAdapter
            // 
            this.eSPECIALIDADTableAdapter.ClearBeforeFill = true;
            // 
            // FormInsertEspecialidadDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 349);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botonInsertar);
            this.Controls.Add(this.buttonRemoveEspecialidad);
            this.Controls.Add(this.listBoxEspecialidad);
            this.Controls.Add(this.buttonAddEspecialidad);
            this.Controls.Add(this.cbmEspecialidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbNombre);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormInsertEspecialidadDoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInsertEspecialidad";
            this.Load += new System.EventHandler(this.FormInsertEspecialidad_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSPECIALIDADBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbmEspecialidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddEspecialidad;
        private System.Windows.Forms.ListBox listBoxEspecialidad;
        private System.Windows.Forms.Button buttonRemoveEspecialidad;
        private ClinicaDataBaseDataSet clinicaDataBaseDataSet;
        private System.Windows.Forms.BindingSource eSPECIALIDADBindingSource;
        private ClinicaDataBaseDataSetTableAdapters.ESPECIALIDADTableAdapter eSPECIALIDADTableAdapter;
        private System.Windows.Forms.ListBox especialidades_doc;
        private System.Windows.Forms.ListBox especialidades_id;
        private System.Windows.Forms.ListBox Especialidades_IdSelected;
        private System.Windows.Forms.ComboBox cmbIdEspecialidad;
        private System.Windows.Forms.Button botonInsertar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listDoctores;
    }
}