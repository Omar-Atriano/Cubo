namespace Cubo
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonRx = new System.Windows.Forms.Button();
            this.buttonRy = new System.Windows.Forms.Button();
            this.buttonRz = new System.Windows.Forms.Button();
            this.buttonRt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(24, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 341);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(736, 338);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonRx
            // 
            this.buttonRx.Location = new System.Drawing.Point(256, 392);
            this.buttonRx.Name = "buttonRx";
            this.buttonRx.Size = new System.Drawing.Size(130, 23);
            this.buttonRx.TabIndex = 1;
            this.buttonRx.Text = "Rotate Over X";
            this.buttonRx.UseVisualStyleBackColor = true;
            this.buttonRx.Click += new System.EventHandler(this.buttonRx_Click);
            // 
            // buttonRy
            // 
            this.buttonRy.Location = new System.Drawing.Point(434, 392);
            this.buttonRy.Name = "buttonRy";
            this.buttonRy.Size = new System.Drawing.Size(130, 23);
            this.buttonRy.TabIndex = 2;
            this.buttonRy.Text = "Rotate Over Y";
            this.buttonRy.UseVisualStyleBackColor = true;
            this.buttonRy.Click += new System.EventHandler(this.buttonRy_Click);
            // 
            // buttonRz
            // 
            this.buttonRz.Location = new System.Drawing.Point(614, 392);
            this.buttonRz.Name = "buttonRz";
            this.buttonRz.Size = new System.Drawing.Size(130, 23);
            this.buttonRz.TabIndex = 3;
            this.buttonRz.Text = "Rotate Over Z";
            this.buttonRz.UseVisualStyleBackColor = true;
            this.buttonRz.Click += new System.EventHandler(this.buttonRz_Click);
            // 
            // buttonRt
            // 
            this.buttonRt.Location = new System.Drawing.Point(60, 392);
            this.buttonRt.Name = "buttonRt";
            this.buttonRt.Size = new System.Drawing.Size(130, 23);
            this.buttonRt.TabIndex = 4;
            this.buttonRt.Text = "Rotate Over All";
            this.buttonRt.UseVisualStyleBackColor = true;
            this.buttonRt.Click += new System.EventHandler(this.buttonRt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRt);
            this.Controls.Add(this.buttonRz);
            this.Controls.Add(this.buttonRy);
            this.Controls.Add(this.buttonRx);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonRx;
        private System.Windows.Forms.Button buttonRy;
        private System.Windows.Forms.Button buttonRz;
        private System.Windows.Forms.Button buttonRt;
    }
}

