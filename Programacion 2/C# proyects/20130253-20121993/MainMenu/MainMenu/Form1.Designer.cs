namespace MainMenu
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirfaltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centroDeSaludfaltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNSERTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorfaltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEspecialidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesfaltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadfaltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patologiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasfaltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasYReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosGeneralesPacientesfaltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesConChicufaltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadorafaltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorDeTextofaltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navegadorWebfaltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mP3PlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diccionarioDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagramaEntidadRelacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.mantenimientoToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.consultasYReportesToolStripMenuItem,
            this.utilidadesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(523, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirfaltaToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem1.Text = "Archivo";
            // 
            // salirfaltaToolStripMenuItem
            // 
            this.salirfaltaToolStripMenuItem.Name = "salirfaltaToolStripMenuItem";
            this.salirfaltaToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.salirfaltaToolStripMenuItem.Text = "Salir ";
            this.salirfaltaToolStripMenuItem.Click += new System.EventHandler(this.salirfaltaToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centroDeSaludfaltaToolStripMenuItem,
            this.iNSERTToolStripMenuItem,
            this.doctorfaltaToolStripMenuItem,
            this.pacientesfaltaToolStripMenuItem,
            this.especialidadfaltaToolStripMenuItem,
            this.patologiaToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // centroDeSaludfaltaToolStripMenuItem
            // 
            this.centroDeSaludfaltaToolStripMenuItem.Name = "centroDeSaludfaltaToolStripMenuItem";
            this.centroDeSaludfaltaToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.centroDeSaludfaltaToolStripMenuItem.Text = "Agregar Centro de salud";
            this.centroDeSaludfaltaToolStripMenuItem.Click += new System.EventHandler(this.centroDeSaludToolStripMenuItem_Click);
            // 
            // iNSERTToolStripMenuItem
            // 
            this.iNSERTToolStripMenuItem.Name = "iNSERTToolStripMenuItem";
            this.iNSERTToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.iNSERTToolStripMenuItem.Text = "Agregar  Habitación";
            this.iNSERTToolStripMenuItem.Click += new System.EventHandler(this.iNSERTToolStripMenuItem_Click);
            // 
            // doctorfaltaToolStripMenuItem
            // 
            this.doctorfaltaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarDoctorToolStripMenuItem,
            this.agregarEspecialidadToolStripMenuItem});
            this.doctorfaltaToolStripMenuItem.Name = "doctorfaltaToolStripMenuItem";
            this.doctorfaltaToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.doctorfaltaToolStripMenuItem.Text = "Doctor";
            // 
            // agregarDoctorToolStripMenuItem
            // 
            this.agregarDoctorToolStripMenuItem.Name = "agregarDoctorToolStripMenuItem";
            this.agregarDoctorToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.agregarDoctorToolStripMenuItem.Text = "Agregar Doctor";
            this.agregarDoctorToolStripMenuItem.Click += new System.EventHandler(this.agregarDoctorToolStripMenuItem_Click);
            // 
            // agregarEspecialidadToolStripMenuItem
            // 
            this.agregarEspecialidadToolStripMenuItem.Name = "agregarEspecialidadToolStripMenuItem";
            this.agregarEspecialidadToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.agregarEspecialidadToolStripMenuItem.Text = "Agregar Especialidad a Doctor";
            this.agregarEspecialidadToolStripMenuItem.Click += new System.EventHandler(this.agregarEspecialidadToolStripMenuItem_Click);
            // 
            // pacientesfaltaToolStripMenuItem
            // 
            this.pacientesfaltaToolStripMenuItem.Name = "pacientesfaltaToolStripMenuItem";
            this.pacientesfaltaToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.pacientesfaltaToolStripMenuItem.Text = "Agregar Pacientes";
            this.pacientesfaltaToolStripMenuItem.Click += new System.EventHandler(this.pacientesToolStripMenuItem_Click);
            // 
            // especialidadfaltaToolStripMenuItem
            // 
            this.especialidadfaltaToolStripMenuItem.Name = "especialidadfaltaToolStripMenuItem";
            this.especialidadfaltaToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.especialidadfaltaToolStripMenuItem.Text = "Agregar Nueva Especialidad ";
            this.especialidadfaltaToolStripMenuItem.Click += new System.EventHandler(this.especialidadToolStripMenuItem_Click);
            // 
            // patologiaToolStripMenuItem
            // 
            this.patologiaToolStripMenuItem.Name = "patologiaToolStripMenuItem";
            this.patologiaToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.patologiaToolStripMenuItem.Text = "Agregar Nueva Patologia ";
            this.patologiaToolStripMenuItem.Click += new System.EventHandler(this.patologiaToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasfaltaToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            this.procesosToolStripMenuItem.Click += new System.EventHandler(this.procesosToolStripMenuItem_Click);
            // 
            // consultasfaltaToolStripMenuItem
            // 
            this.consultasfaltaToolStripMenuItem.Name = "consultasfaltaToolStripMenuItem";
            this.consultasfaltaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.consultasfaltaToolStripMenuItem.Text = "Hacer Consulta ";
            this.consultasfaltaToolStripMenuItem.Click += new System.EventHandler(this.consultasfaltaToolStripMenuItem_Click);
            // 
            // consultasYReportesToolStripMenuItem
            // 
            this.consultasYReportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosGeneralesPacientesfaltaToolStripMenuItem,
            this.pacientesConChicufaltaToolStripMenuItem,
            this.reporteToolStripMenuItem});
            this.consultasYReportesToolStripMenuItem.Name = "consultasYReportesToolStripMenuItem";
            this.consultasYReportesToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.consultasYReportesToolStripMenuItem.Text = "Consultas y reportes";
            this.consultasYReportesToolStripMenuItem.Click += new System.EventHandler(this.consultasYReportesToolStripMenuItem_Click);
            // 
            // datosGeneralesPacientesfaltaToolStripMenuItem
            // 
            this.datosGeneralesPacientesfaltaToolStripMenuItem.Name = "datosGeneralesPacientesfaltaToolStripMenuItem";
            this.datosGeneralesPacientesfaltaToolStripMenuItem.Size = new System.Drawing.Size(304, 22);
            this.datosGeneralesPacientesfaltaToolStripMenuItem.Text = "Datos generales de consulta segun paciente";
            this.datosGeneralesPacientesfaltaToolStripMenuItem.Click += new System.EventHandler(this.datosGeneralesPacientesfaltaToolStripMenuItem_Click);
            // 
            // pacientesConChicufaltaToolStripMenuItem
            // 
            this.pacientesConChicufaltaToolStripMenuItem.Name = "pacientesConChicufaltaToolStripMenuItem";
            this.pacientesConChicufaltaToolStripMenuItem.Size = new System.Drawing.Size(304, 22);
            this.pacientesConChicufaltaToolStripMenuItem.Text = "Pacientes con Chikungunya";
            this.pacientesConChicufaltaToolStripMenuItem.Click += new System.EventHandler(this.pacientesConChicufaltaToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(304, 22);
            this.reporteToolStripMenuItem.Text = "Reporte Patologia";
            this.reporteToolStripMenuItem.Click += new System.EventHandler(this.reporteToolStripMenuItem_Click);
            // 
            // utilidadesToolStripMenuItem
            // 
            this.utilidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadorafaltaToolStripMenuItem,
            this.editorDeTextofaltaToolStripMenuItem,
            this.navegadorWebfaltaToolStripMenuItem,
            this.mP3PlayerToolStripMenuItem});
            this.utilidadesToolStripMenuItem.Name = "utilidadesToolStripMenuItem";
            this.utilidadesToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.utilidadesToolStripMenuItem.Text = "Utilidades";
            // 
            // calculadorafaltaToolStripMenuItem
            // 
            this.calculadorafaltaToolStripMenuItem.Name = "calculadorafaltaToolStripMenuItem";
            this.calculadorafaltaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.calculadorafaltaToolStripMenuItem.Text = "Calculadora";
            this.calculadorafaltaToolStripMenuItem.Click += new System.EventHandler(this.calculadorafaltaToolStripMenuItem_Click);
            // 
            // editorDeTextofaltaToolStripMenuItem
            // 
            this.editorDeTextofaltaToolStripMenuItem.Name = "editorDeTextofaltaToolStripMenuItem";
            this.editorDeTextofaltaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.editorDeTextofaltaToolStripMenuItem.Text = "Editor de texto";
            this.editorDeTextofaltaToolStripMenuItem.Click += new System.EventHandler(this.editorDeTextofaltaToolStripMenuItem_Click);
            // 
            // navegadorWebfaltaToolStripMenuItem
            // 
            this.navegadorWebfaltaToolStripMenuItem.Name = "navegadorWebfaltaToolStripMenuItem";
            this.navegadorWebfaltaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.navegadorWebfaltaToolStripMenuItem.Text = "Navegador Web";
            this.navegadorWebfaltaToolStripMenuItem.Click += new System.EventHandler(this.navegadorWebfaltaToolStripMenuItem_Click);
            // 
            // mP3PlayerToolStripMenuItem
            // 
            this.mP3PlayerToolStripMenuItem.Name = "mP3PlayerToolStripMenuItem";
            this.mP3PlayerToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.mP3PlayerToolStripMenuItem.Text = "MP3Player";
            this.mP3PlayerToolStripMenuItem.Click += new System.EventHandler(this.mP3PlayerToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.diccionarioDeDatosToolStripMenuItem,
            this.diagramaEntidadRelacionToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // diccionarioDeDatosToolStripMenuItem
            // 
            this.diccionarioDeDatosToolStripMenuItem.Name = "diccionarioDeDatosToolStripMenuItem";
            this.diccionarioDeDatosToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.diccionarioDeDatosToolStripMenuItem.Text = "Diccionario de datos";
            this.diccionarioDeDatosToolStripMenuItem.Click += new System.EventHandler(this.diccionarioDeDatosToolStripMenuItem_Click);
            // 
            // diagramaEntidadRelacionToolStripMenuItem
            // 
            this.diagramaEntidadRelacionToolStripMenuItem.Name = "diagramaEntidadRelacionToolStripMenuItem";
            this.diagramaEntidadRelacionToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.diagramaEntidadRelacionToolStripMenuItem.Text = "Diagrama Entidad Relacion";
            this.diagramaEntidadRelacionToolStripMenuItem.Click += new System.EventHandler(this.diagramaEntidadRelacionToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(523, 327);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesfaltaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorfaltaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centroDeSaludfaltaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasfaltaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasYReportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosGeneralesPacientesfaltaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesConChicufaltaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadorafaltaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorDeTextofaltaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navegadorWebfaltaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirfaltaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNSERTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialidadfaltaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patologiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEspecialidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mP3PlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diccionarioDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagramaEntidadRelacionToolStripMenuItem;
    }
}

