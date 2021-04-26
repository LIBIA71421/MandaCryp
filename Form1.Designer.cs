
namespace MandaCry_0._2
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
            this.btn_Algoritmos = new System.Windows.Forms.Button();
            this.btn_SALIR = new System.Windows.Forms.Button();
            this.btn_Validacion = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Algoritmos
            // 
            this.btn_Algoritmos.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Algoritmos.Font = new System.Drawing.Font("Ravie", 12.75F, System.Drawing.FontStyle.Italic);
            this.btn_Algoritmos.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Algoritmos.Location = new System.Drawing.Point(358, 363);
            this.btn_Algoritmos.Name = "btn_Algoritmos";
            this.btn_Algoritmos.Size = new System.Drawing.Size(189, 41);
            this.btn_Algoritmos.TabIndex = 144;
            this.btn_Algoritmos.Text = "ALGORITMOS";
            this.btn_Algoritmos.UseVisualStyleBackColor = false;
            this.btn_Algoritmos.Click += new System.EventHandler(this.btn_Algoritmos_Click);
            // 
            // btn_SALIR
            // 
            this.btn_SALIR.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_SALIR.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Italic);
            this.btn_SALIR.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_SALIR.Location = new System.Drawing.Point(201, 364);
            this.btn_SALIR.Name = "btn_SALIR";
            this.btn_SALIR.Size = new System.Drawing.Size(151, 41);
            this.btn_SALIR.TabIndex = 143;
            this.btn_SALIR.Text = "SALIR";
            this.btn_SALIR.UseVisualStyleBackColor = false;
            this.btn_SALIR.Click += new System.EventHandler(this.btn_SALIR_Click);
            // 
            // btn_Validacion
            // 
            this.btn_Validacion.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_Validacion.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Italic);
            this.btn_Validacion.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Validacion.Location = new System.Drawing.Point(553, 363);
            this.btn_Validacion.Name = "btn_Validacion";
            this.btn_Validacion.Size = new System.Drawing.Size(158, 41);
            this.btn_Validacion.TabIndex = 142;
            this.btn_Validacion.Text = "SIGUIENTE";
            this.btn_Validacion.UseVisualStyleBackColor = false;
            this.btn_Validacion.Click += new System.EventHandler(this.btn_Validacion_Click);
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_name.Font = new System.Drawing.Font("Ravie", 8.25F);
            this.txt_name.Location = new System.Drawing.Point(201, 169);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(494, 48);
            this.txt_name.TabIndex = 140;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkRed;
            this.label3.Font = new System.Drawing.Font("Ravie", 15.25F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(97, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 30);
            this.label3.TabIndex = 139;
            this.label3.Text = "PASSWORD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Font = new System.Drawing.Font("Ravie", 15.25F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(97, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 30);
            this.label2.TabIndex = 138;
            this.label2.Text = "USUARIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(157, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 60);
            this.label1.TabIndex = 137;
            this.label1.Text = "Aplicacion de Mensajeria Instantanea\r\n                  MANDACRYP";
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Password.Font = new System.Drawing.Font("Ravie", 8.25F);
            this.txt_Password.Location = new System.Drawing.Point(201, 288);
            this.txt_Password.Multiline = true;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(494, 48);
            this.txt_Password.TabIndex = 145;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::MandaCry_0._2.Properties.Resources.Encriptar_datos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.btn_Algoritmos);
            this.Controls.Add(this.btn_SALIR);
            this.Controls.Add(this.btn_Validacion);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Algoritmos;
        private System.Windows.Forms.Button btn_SALIR;
        private System.Windows.Forms.Button btn_Validacion;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Password;
    }
}

