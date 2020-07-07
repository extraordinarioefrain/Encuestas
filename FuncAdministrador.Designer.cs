namespace Encuestas
{
    partial class FuncAdministrador
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesDelAdministradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encuestasRealizadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetearEncuestasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvmodificable = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmodificable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesDelAdministradorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(567, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesDelAdministradorToolStripMenuItem
            // 
            this.opcionesDelAdministradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encuestasRealizadasToolStripMenuItem,
            this.resetearEncuestasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.opcionesDelAdministradorToolStripMenuItem.Name = "opcionesDelAdministradorToolStripMenuItem";
            this.opcionesDelAdministradorToolStripMenuItem.Size = new System.Drawing.Size(167, 20);
            this.opcionesDelAdministradorToolStripMenuItem.Text = "Opciones del Administrador";
            // 
            // encuestasRealizadasToolStripMenuItem
            // 
            this.encuestasRealizadasToolStripMenuItem.Name = "encuestasRealizadasToolStripMenuItem";
            this.encuestasRealizadasToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.encuestasRealizadasToolStripMenuItem.Text = "Encuestas Realizadas";
            // 
            // resetearEncuestasToolStripMenuItem
            // 
            this.resetearEncuestasToolStripMenuItem.Name = "resetearEncuestasToolStripMenuItem";
            this.resetearEncuestasToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.resetearEncuestasToolStripMenuItem.Text = "Resetear Encuestas";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // dgvmodificable
            // 
            this.dgvmodificable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmodificable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvmodificable.Location = new System.Drawing.Point(0, 24);
            this.dgvmodificable.Name = "dgvmodificable";
            this.dgvmodificable.Size = new System.Drawing.Size(567, 265);
            this.dgvmodificable.TabIndex = 2;
            // 
            // FuncAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 289);
            this.Controls.Add(this.dgvmodificable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FuncAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FuncAdministrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmodificable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesDelAdministradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encuestasRealizadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetearEncuestasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvmodificable;
    }
}