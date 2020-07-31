namespace ExportPDF
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.importar_metroTile = new MetroFramework.Controls.MetroTile();
            this.exportar_pdf_metroTile = new MetroFramework.Controls.MetroTile();
            this.habilitar_fondo_blanco_metroCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.titulo_metroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.titulo_metroLabel = new MetroFramework.Controls.MetroLabel();
            this.cargando_metroProgressSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.cantidad_imagenes_metroLabel = new MetroFramework.Controls.MetroLabel();
            this.cantidad_imagenes_mostrar_metroLabel = new MetroFramework.Controls.MetroLabel();
            this.porciento_metroLabel = new MetroFramework.Controls.MetroLabel();
            this.eliminar_metroTile = new MetroFramework.Controls.MetroTile();
            this.imagenes_metroGrid = new MetroFramework.Controls.MetroGrid();
            this.calidad_metroLabel = new MetroFramework.Controls.MetroLabel();
            this.calidad_metroComboBox = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagenes_metroGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // importar_metroTile
            // 
            this.importar_metroTile.ActiveControl = null;
            this.importar_metroTile.AutoSize = true;
            this.importar_metroTile.Location = new System.Drawing.Point(23, 63);
            this.importar_metroTile.Name = "importar_metroTile";
            this.importar_metroTile.Size = new System.Drawing.Size(135, 75);
            this.importar_metroTile.Style = MetroFramework.MetroColorStyle.Teal;
            this.importar_metroTile.TabIndex = 1;
            this.importar_metroTile.Text = "Importar imagenes";
            this.importar_metroTile.UseSelectable = true;
            this.importar_metroTile.Click += new System.EventHandler(this.importar_metroTile_Click);
            // 
            // exportar_pdf_metroTile
            // 
            this.exportar_pdf_metroTile.ActiveControl = null;
            this.exportar_pdf_metroTile.Location = new System.Drawing.Point(164, 63);
            this.exportar_pdf_metroTile.Name = "exportar_pdf_metroTile";
            this.exportar_pdf_metroTile.Size = new System.Drawing.Size(110, 75);
            this.exportar_pdf_metroTile.TabIndex = 2;
            this.exportar_pdf_metroTile.Text = "Exportar a PDF";
            this.exportar_pdf_metroTile.UseSelectable = true;
            this.exportar_pdf_metroTile.Click += new System.EventHandler(this.exportar_pdf_metroTile_Click);
            // 
            // habilitar_fondo_blanco_metroCheckBox
            // 
            this.habilitar_fondo_blanco_metroCheckBox.AutoSize = true;
            this.habilitar_fondo_blanco_metroCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.habilitar_fondo_blanco_metroCheckBox.Location = new System.Drawing.Point(385, 92);
            this.habilitar_fondo_blanco_metroCheckBox.Name = "habilitar_fondo_blanco_metroCheckBox";
            this.habilitar_fondo_blanco_metroCheckBox.Size = new System.Drawing.Size(160, 19);
            this.habilitar_fondo_blanco_metroCheckBox.TabIndex = 4;
            this.habilitar_fondo_blanco_metroCheckBox.Text = "Habilitar fondo blanco";
            this.habilitar_fondo_blanco_metroCheckBox.UseSelectable = true;
            // 
            // titulo_metroTextBox
            // 
            // 
            // 
            // 
            this.titulo_metroTextBox.CustomButton.Image = null;
            this.titulo_metroTextBox.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.titulo_metroTextBox.CustomButton.Name = "";
            this.titulo_metroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.titulo_metroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.titulo_metroTextBox.CustomButton.TabIndex = 1;
            this.titulo_metroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.titulo_metroTextBox.CustomButton.UseSelectable = true;
            this.titulo_metroTextBox.CustomButton.Visible = false;
            this.titulo_metroTextBox.Lines = new string[0];
            this.titulo_metroTextBox.Location = new System.Drawing.Point(445, 63);
            this.titulo_metroTextBox.MaxLength = 32767;
            this.titulo_metroTextBox.Name = "titulo_metroTextBox";
            this.titulo_metroTextBox.PasswordChar = '\0';
            this.titulo_metroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.titulo_metroTextBox.SelectedText = "";
            this.titulo_metroTextBox.SelectionLength = 0;
            this.titulo_metroTextBox.SelectionStart = 0;
            this.titulo_metroTextBox.ShortcutsEnabled = true;
            this.titulo_metroTextBox.Size = new System.Drawing.Size(142, 23);
            this.titulo_metroTextBox.TabIndex = 5;
            this.titulo_metroTextBox.UseSelectable = true;
            this.titulo_metroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.titulo_metroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // titulo_metroLabel
            // 
            this.titulo_metroLabel.AutoSize = true;
            this.titulo_metroLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titulo_metroLabel.Location = new System.Drawing.Point(385, 60);
            this.titulo_metroLabel.Name = "titulo_metroLabel";
            this.titulo_metroLabel.Size = new System.Drawing.Size(54, 25);
            this.titulo_metroLabel.TabIndex = 6;
            this.titulo_metroLabel.Text = "Título";
            // 
            // cargando_metroProgressSpinner
            // 
            this.cargando_metroProgressSpinner.Location = new System.Drawing.Point(671, 42);
            this.cargando_metroProgressSpinner.Maximum = 100;
            this.cargando_metroProgressSpinner.Name = "cargando_metroProgressSpinner";
            this.cargando_metroProgressSpinner.Size = new System.Drawing.Size(69, 68);
            this.cargando_metroProgressSpinner.TabIndex = 7;
            this.cargando_metroProgressSpinner.UseSelectable = true;
            // 
            // cantidad_imagenes_metroLabel
            // 
            this.cantidad_imagenes_metroLabel.AutoSize = true;
            this.cantidad_imagenes_metroLabel.Location = new System.Drawing.Point(23, 150);
            this.cantidad_imagenes_metroLabel.Name = "cantidad_imagenes_metroLabel";
            this.cantidad_imagenes_metroLabel.Size = new System.Drawing.Size(144, 19);
            this.cantidad_imagenes_metroLabel.TabIndex = 8;
            this.cantidad_imagenes_metroLabel.Text = "Cantidad de imágenes:";
            // 
            // cantidad_imagenes_mostrar_metroLabel
            // 
            this.cantidad_imagenes_mostrar_metroLabel.AutoSize = true;
            this.cantidad_imagenes_mostrar_metroLabel.Location = new System.Drawing.Point(170, 150);
            this.cantidad_imagenes_mostrar_metroLabel.Name = "cantidad_imagenes_mostrar_metroLabel";
            this.cantidad_imagenes_mostrar_metroLabel.Size = new System.Drawing.Size(0, 0);
            this.cantidad_imagenes_mostrar_metroLabel.TabIndex = 9;
            // 
            // porciento_metroLabel
            // 
            this.porciento_metroLabel.AutoSize = true;
            this.porciento_metroLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.porciento_metroLabel.Location = new System.Drawing.Point(686, 118);
            this.porciento_metroLabel.Name = "porciento_metroLabel";
            this.porciento_metroLabel.Size = new System.Drawing.Size(38, 25);
            this.porciento_metroLabel.TabIndex = 10;
            this.porciento_metroLabel.Text = "asd";
            // 
            // eliminar_metroTile
            // 
            this.eliminar_metroTile.ActiveControl = null;
            this.eliminar_metroTile.Location = new System.Drawing.Point(280, 62);
            this.eliminar_metroTile.Name = "eliminar_metroTile";
            this.eliminar_metroTile.Size = new System.Drawing.Size(99, 76);
            this.eliminar_metroTile.Style = MetroFramework.MetroColorStyle.Red;
            this.eliminar_metroTile.TabIndex = 11;
            this.eliminar_metroTile.Text = "Eliminar todo";
            this.eliminar_metroTile.UseSelectable = true;
            this.eliminar_metroTile.Click += new System.EventHandler(this.Eliminar_metroTile_Click);
            // 
            // imagenes_metroGrid
            // 
            this.imagenes_metroGrid.AllowUserToAddRows = false;
            this.imagenes_metroGrid.AllowUserToDeleteRows = false;
            this.imagenes_metroGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagenes_metroGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.imagenes_metroGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.imagenes_metroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.imagenes_metroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imagenes_metroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.imagenes_metroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.imagenes_metroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.imagenes_metroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.imagenes_metroGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.imagenes_metroGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.imagenes_metroGrid.EnableHeadersVisualStyles = false;
            this.imagenes_metroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.imagenes_metroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.imagenes_metroGrid.Location = new System.Drawing.Point(23, 172);
            this.imagenes_metroGrid.Name = "imagenes_metroGrid";
            this.imagenes_metroGrid.ReadOnly = true;
            this.imagenes_metroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.imagenes_metroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.imagenes_metroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.imagenes_metroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.imagenes_metroGrid.Size = new System.Drawing.Size(717, 401);
            this.imagenes_metroGrid.TabIndex = 12;
            // 
            // calidad_metroLabel
            // 
            this.calidad_metroLabel.AutoSize = true;
            this.calidad_metroLabel.Location = new System.Drawing.Point(385, 114);
            this.calidad_metroLabel.Name = "calidad_metroLabel";
            this.calidad_metroLabel.Size = new System.Drawing.Size(57, 19);
            this.calidad_metroLabel.TabIndex = 13;
            this.calidad_metroLabel.Text = "Calidad:";
            // 
            // calidad_metroComboBox
            // 
            this.calidad_metroComboBox.FormattingEnabled = true;
            this.calidad_metroComboBox.ItemHeight = 23;
            this.calidad_metroComboBox.Items.AddRange(new object[] {
            "Alta",
            "Baja"});
            this.calidad_metroComboBox.Location = new System.Drawing.Point(445, 114);
            this.calidad_metroComboBox.Name = "calidad_metroComboBox";
            this.calidad_metroComboBox.Size = new System.Drawing.Size(142, 29);
            this.calidad_metroComboBox.TabIndex = 14;
            this.calidad_metroComboBox.UseSelectable = true;
            this.calidad_metroComboBox.SelectedIndexChanged += new System.EventHandler(this.calidad_metroComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 596);
            this.Controls.Add(this.calidad_metroComboBox);
            this.Controls.Add(this.calidad_metroLabel);
            this.Controls.Add(this.imagenes_metroGrid);
            this.Controls.Add(this.eliminar_metroTile);
            this.Controls.Add(this.porciento_metroLabel);
            this.Controls.Add(this.cantidad_imagenes_mostrar_metroLabel);
            this.Controls.Add(this.cantidad_imagenes_metroLabel);
            this.Controls.Add(this.cargando_metroProgressSpinner);
            this.Controls.Add(this.titulo_metroLabel);
            this.Controls.Add(this.titulo_metroTextBox);
            this.Controls.Add(this.habilitar_fondo_blanco_metroCheckBox);
            this.Controls.Add(this.exportar_pdf_metroTile);
            this.Controls.Add(this.importar_metroTile);
            this.Name = "Form1";
            this.Text = "ExportPDF";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagenes_metroGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile importar_metroTile;
        private MetroFramework.Controls.MetroTile exportar_pdf_metroTile;
        private MetroFramework.Controls.MetroCheckBox habilitar_fondo_blanco_metroCheckBox;
        private MetroFramework.Controls.MetroTextBox titulo_metroTextBox;
        private MetroFramework.Controls.MetroLabel titulo_metroLabel;
        private MetroFramework.Controls.MetroProgressSpinner cargando_metroProgressSpinner;
        private MetroFramework.Controls.MetroLabel cantidad_imagenes_metroLabel;
        private MetroFramework.Controls.MetroLabel cantidad_imagenes_mostrar_metroLabel;
        private MetroFramework.Controls.MetroLabel porciento_metroLabel;
        private MetroFramework.Controls.MetroTile eliminar_metroTile;
        private MetroFramework.Controls.MetroGrid imagenes_metroGrid;
        private MetroFramework.Controls.MetroLabel calidad_metroLabel;
        private MetroFramework.Controls.MetroComboBox calidad_metroComboBox;
    }
}

