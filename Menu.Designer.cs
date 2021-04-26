
namespace MandaCry_0._2
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_AES128 = new System.Windows.Forms.RadioButton();
            this.rb_RSA = new System.Windows.Forms.RadioButton();
            this.btn_algoritmos = new System.Windows.Forms.Button();
            this.btn_mensajeria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_saludo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(468, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 95);
            this.label2.TabIndex = 18;
            this.label2.Text = "MandaCryp es una aplicacion \r\ncapaz de mostrarnos incluso \r\nflujos de diagrama do" +
    "nde nos\r\nadiestramos dentro la encritacion \r\ntanto simetrica como asimetrica";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_AES128);
            this.groupBox1.Controls.Add(this.rb_RSA);
            this.groupBox1.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(484, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 76);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NIveles";
            // 
            // rb_AES128
            // 
            this.rb_AES128.AutoSize = true;
            this.rb_AES128.Location = new System.Drawing.Point(6, 45);
            this.rb_AES128.Name = "rb_AES128";
            this.rb_AES128.Size = new System.Drawing.Size(83, 21);
            this.rb_AES128.TabIndex = 3;
            this.rb_AES128.TabStop = true;
            this.rb_AES128.Text = "AES-128";
            this.rb_AES128.UseVisualStyleBackColor = true;
            // 
            // rb_RSA
            // 
            this.rb_RSA.AutoSize = true;
            this.rb_RSA.Location = new System.Drawing.Point(7, 18);
            this.rb_RSA.Name = "rb_RSA";
            this.rb_RSA.Size = new System.Drawing.Size(57, 21);
            this.rb_RSA.TabIndex = 0;
            this.rb_RSA.TabStop = true;
            this.rb_RSA.Text = "RSA";
            this.rb_RSA.UseVisualStyleBackColor = true;
            // 
            // btn_algoritmos
            // 
            this.btn_algoritmos.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_algoritmos.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_algoritmos.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btn_algoritmos.Location = new System.Drawing.Point(506, 377);
            this.btn_algoritmos.Name = "btn_algoritmos";
            this.btn_algoritmos.Size = new System.Drawing.Size(181, 56);
            this.btn_algoritmos.TabIndex = 15;
            this.btn_algoritmos.Text = "Algoritmos";
            this.btn_algoritmos.UseVisualStyleBackColor = false;
            this.btn_algoritmos.Click += new System.EventHandler(this.btn_algoritmos_Click);
            // 
            // btn_mensajeria
            // 
            this.btn_mensajeria.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_mensajeria.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mensajeria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_mensajeria.Location = new System.Drawing.Point(424, 57);
            this.btn_mensajeria.Name = "btn_mensajeria";
            this.btn_mensajeria.Size = new System.Drawing.Size(181, 56);
            this.btn_mensajeria.TabIndex = 14;
            this.btn_mensajeria.Text = "MandaCryp";
            this.btn_mensajeria.UseVisualStyleBackColor = false;
            this.btn_mensajeria.Click += new System.EventHandler(this.btn_mensajeria_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 323);
            this.label1.TabIndex = 13;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // lbl_saludo
            // 
            this.lbl_saludo.AutoSize = true;
            this.lbl_saludo.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saludo.Location = new System.Drawing.Point(19, 9);
            this.lbl_saludo.Name = "lbl_saludo";
            this.lbl_saludo.Size = new System.Drawing.Size(109, 19);
            this.lbl_saludo.TabIndex = 58;
            this.lbl_saludo.Text = "MandaCryp";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MandaCry_0._2.Properties.Resources.Gajo_de_Naranja;
            this.pictureBox1.Location = new System.Drawing.Point(623, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_saludo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_algoritmos);
            this.Controls.Add(this.btn_mensajeria);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_AES128;
        private System.Windows.Forms.RadioButton rb_RSA;
        private System.Windows.Forms.Button btn_algoritmos;
        private System.Windows.Forms.Button btn_mensajeria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_saludo;
    }
}