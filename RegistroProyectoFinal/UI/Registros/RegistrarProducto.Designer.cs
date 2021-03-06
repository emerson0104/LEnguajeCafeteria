﻿namespace RegistroProyectoFinal.UI.Registro
{
    partial class RegistrarProducto
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
            this.InventarioTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PctGananciaTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CostoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductoIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProductoIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // InventarioTextBox
            // 
            this.InventarioTextBox.Location = new System.Drawing.Point(273, 206);
            this.InventarioTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.InventarioTextBox.Name = "InventarioTextBox";
            this.InventarioTextBox.Size = new System.Drawing.Size(85, 22);
            this.InventarioTextBox.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 68;
            this.label6.Text = "Inventario";
            // 
            // PctGananciaTextBox
            // 
            this.PctGananciaTextBox.Location = new System.Drawing.Point(273, 164);
            this.PctGananciaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PctGananciaTextBox.Name = "PctGananciaTextBox";
            this.PctGananciaTextBox.ReadOnly = true;
            this.PctGananciaTextBox.Size = new System.Drawing.Size(85, 22);
            this.PctGananciaTextBox.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 66;
            this.label5.Text = "%Ganancia";
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(88, 206);
            this.PrecioTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(103, 22);
            this.PrecioTextBox.TabIndex = 65;
            this.PrecioTextBox.TextChanged += new System.EventHandler(this.PrecioTextBox_TextChanged);
            this.PrecioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecioTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 64;
            this.label4.Text = "Precio";
            // 
            // CostoTextBox
            // 
            this.CostoTextBox.Location = new System.Drawing.Point(88, 164);
            this.CostoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CostoTextBox.Name = "CostoTextBox";
            this.CostoTextBox.Size = new System.Drawing.Size(103, 22);
            this.CostoTextBox.TabIndex = 63;
            this.CostoTextBox.TextChanged += new System.EventHandler(this.CostoTextBox_TextChanged);
            this.CostoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CostoTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 62;
            this.label3.Text = "Costo";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(125, 122);
            this.DescripcionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(233, 22);
            this.DescripcionTextBox.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 60;
            this.label2.Text = "Descripción";
            // 
            // ProductoIdNumericUpDown
            // 
            this.ProductoIdNumericUpDown.Location = new System.Drawing.Point(119, 31);
            this.ProductoIdNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.ProductoIdNumericUpDown.Name = "ProductoIdNumericUpDown";
            this.ProductoIdNumericUpDown.Size = new System.Drawing.Size(100, 22);
            this.ProductoIdNumericUpDown.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 58;
            this.label1.Text = "ProductoId";
            // 
            // BuscarButton
            // 
            this.BuscarButton.BackgroundImage = global::RegistroProyectoFinal.Properties.Resources.Search_16px;
            this.BuscarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BuscarButton.Location = new System.Drawing.Point(239, 27);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(4);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(119, 28);
            this.BuscarButton.TabIndex = 57;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.CustomFormat = "dd/MM/yy";
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(191, 79);
            this.FechaDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(167, 22);
            this.FechaDateTimePicker.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 17);
            this.label7.TabIndex = 70;
            this.label7.Text = "Fecha de Vencimiento";
            // 
            // EliminarButton
            // 
            this.EliminarButton.BackgroundImage = global::RegistroProyectoFinal.Properties.Resources.Delete_16px;
            this.EliminarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EliminarButton.Location = new System.Drawing.Point(272, 263);
            this.EliminarButton.Margin = new System.Windows.Forms.Padding(4);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(107, 28);
            this.EliminarButton.TabIndex = 74;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.BackgroundImage = global::RegistroProyectoFinal.Properties.Resources.Save_16px;
            this.GuardarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GuardarButton.Location = new System.Drawing.Point(141, 263);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(4);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(100, 28);
            this.GuardarButton.TabIndex = 73;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.BackgroundImage = global::RegistroProyectoFinal.Properties.Resources.Edit_Property_16px;
            this.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NuevoButton.Location = new System.Drawing.Point(16, 263);
            this.NuevoButton.Margin = new System.Windows.Forms.Padding(4);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(97, 28);
            this.NuevoButton.TabIndex = 72;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // RegistrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(395, 315);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.InventarioTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PctGananciaTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CostoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductoIdNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BuscarButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegistrarProducto";
            this.Text = "Registrar Producto";
            this.Load += new System.EventHandler(this.RegistrarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductoIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InventarioTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PctGananciaTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CostoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ProductoIdNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}