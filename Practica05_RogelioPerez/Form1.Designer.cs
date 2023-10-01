namespace Practica05_RogelioPerez
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellidos = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_estatura = new System.Windows.Forms.Label();
            this.lbl_edad = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellidos = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.txt_Estatura = new System.Windows.Forms.TextBox();
            this.txt_Edad = new System.Windows.Forms.TextBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.gbox_Genero = new System.Windows.Forms.GroupBox();
            this.rbtn_Mujer = new System.Windows.Forms.RadioButton();
            this.rbtn_hombre = new System.Windows.Forms.RadioButton();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbox_Genero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(12, 28);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(100, 27);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre ";
            // 
            // lbl_apellidos
            // 
            this.lbl_apellidos.AutoSize = true;
            this.lbl_apellidos.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidos.Location = new System.Drawing.Point(12, 70);
            this.lbl_apellidos.Name = "lbl_apellidos";
            this.lbl_apellidos.Size = new System.Drawing.Size(115, 27);
            this.lbl_apellidos.TabIndex = 1;
            this.lbl_apellidos.Text = "Apellidos ";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.Location = new System.Drawing.Point(12, 109);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(103, 27);
            this.lbl_telefono.TabIndex = 2;
            this.lbl_telefono.Text = "Telefono";
            // 
            // lbl_estatura
            // 
            this.lbl_estatura.AutoSize = true;
            this.lbl_estatura.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estatura.Location = new System.Drawing.Point(12, 149);
            this.lbl_estatura.Name = "lbl_estatura";
            this.lbl_estatura.Size = new System.Drawing.Size(101, 27);
            this.lbl_estatura.TabIndex = 3;
            this.lbl_estatura.Text = "Estatura";
            // 
            // lbl_edad
            // 
            this.lbl_edad.AutoSize = true;
            this.lbl_edad.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edad.Location = new System.Drawing.Point(12, 188);
            this.lbl_edad.Name = "lbl_edad";
            this.lbl_edad.Size = new System.Drawing.Size(65, 27);
            this.lbl_edad.TabIndex = 4;
            this.lbl_edad.Text = "Edad";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(136, 31);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(151, 24);
            this.txt_Nombre.TabIndex = 5;
            // 
            // txt_Apellidos
            // 
            this.txt_Apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apellidos.Location = new System.Drawing.Point(136, 73);
            this.txt_Apellidos.Name = "txt_Apellidos";
            this.txt_Apellidos.Size = new System.Drawing.Size(151, 24);
            this.txt_Apellidos.TabIndex = 6;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Telefono.Location = new System.Drawing.Point(136, 112);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(151, 24);
            this.txt_Telefono.TabIndex = 7;
            // 
            // txt_Estatura
            // 
            this.txt_Estatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Estatura.Location = new System.Drawing.Point(136, 152);
            this.txt_Estatura.Name = "txt_Estatura";
            this.txt_Estatura.Size = new System.Drawing.Size(151, 24);
            this.txt_Estatura.TabIndex = 8;
            // 
            // txt_Edad
            // 
            this.txt_Edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Edad.Location = new System.Drawing.Point(136, 191);
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.Size = new System.Drawing.Size(151, 24);
            this.txt_Edad.TabIndex = 9;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Location = new System.Drawing.Point(5, 403);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(110, 35);
            this.btn_Guardar.TabIndex = 10;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(168, 403);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(119, 35);
            this.btn_Cancelar.TabIndex = 11;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // gbox_Genero
            // 
            this.gbox_Genero.Controls.Add(this.rbtn_Mujer);
            this.gbox_Genero.Controls.Add(this.rbtn_hombre);
            this.gbox_Genero.Location = new System.Drawing.Point(45, 233);
            this.gbox_Genero.Name = "gbox_Genero";
            this.gbox_Genero.Size = new System.Drawing.Size(200, 77);
            this.gbox_Genero.TabIndex = 12;
            this.gbox_Genero.TabStop = false;
            this.gbox_Genero.Text = "GÉNERO";
            // 
            // rbtn_Mujer
            // 
            this.rbtn_Mujer.AutoSize = true;
            this.rbtn_Mujer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Mujer.Location = new System.Drawing.Point(124, 28);
            this.rbtn_Mujer.Name = "rbtn_Mujer";
            this.rbtn_Mujer.Size = new System.Drawing.Size(57, 19);
            this.rbtn_Mujer.TabIndex = 1;
            this.rbtn_Mujer.TabStop = true;
            this.rbtn_Mujer.Text = "Mujer";
            this.rbtn_Mujer.UseVisualStyleBackColor = true;
            // 
            // rbtn_hombre
            // 
            this.rbtn_hombre.AutoSize = true;
            this.rbtn_hombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_hombre.Location = new System.Drawing.Point(6, 28);
            this.rbtn_hombre.Name = "rbtn_hombre";
            this.rbtn_hombre.Size = new System.Drawing.Size(70, 19);
            this.rbtn_hombre.TabIndex = 0;
            this.rbtn_hombre.TabStop = true;
            this.rbtn_hombre.Text = "Hombre";
            this.rbtn_hombre.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(79, 339);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(119, 35);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Practica05_RogelioPerez.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(331, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gbox_Genero);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.txt_Edad);
            this.Controls.Add(this.txt_Estatura);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.txt_Apellidos);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lbl_edad);
            this.Controls.Add(this.lbl_estatura);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.lbl_apellidos);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRACTICA ";
            this.gbox_Genero.ResumeLayout(false);
            this.gbox_Genero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellidos;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_estatura;
        private System.Windows.Forms.Label lbl_edad;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Apellidos;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.TextBox txt_Estatura;
        private System.Windows.Forms.TextBox txt_Edad;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.GroupBox gbox_Genero;
        private System.Windows.Forms.RadioButton rbtn_Mujer;
        private System.Windows.Forms.RadioButton rbtn_hombre;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

