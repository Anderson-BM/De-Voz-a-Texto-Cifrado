namespace ANDERSON_PROJECTO_AI
{
    partial class txtResultado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(txtResultado));
            this.txtResultado2 = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnHaxeo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtResultado2
            // 
            this.txtResultado2.Location = new System.Drawing.Point(34, 214);
            this.txtResultado2.Multiline = true;
            this.txtResultado2.Name = "txtResultado2";
            this.txtResultado2.Size = new System.Drawing.Size(689, 409);
            this.txtResultado2.TabIndex = 0;
            this.txtResultado2.TextChanged += new System.EventHandler(this.txtResultado2_TextChanged);
            // 
            // btnConvertir
            // 
            this.btnConvertir.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnConvertir.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConvertir.Location = new System.Drawing.Point(53, 644);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(320, 52);
            this.btnConvertir.TabIndex = 1;
            this.btnConvertir.Text = "Seleccionar y Covertir";
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnHaxeo
            // 
            this.btnHaxeo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnHaxeo.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHaxeo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHaxeo.Location = new System.Drawing.Point(407, 644);
            this.btnHaxeo.Name = "btnHaxeo";
            this.btnHaxeo.Size = new System.Drawing.Size(212, 52);
            this.btnHaxeo.TabIndex = 2;
            this.btnHaxeo.Text = "Cifrado";
            this.btnHaxeo.UseVisualStyleBackColor = false;
            this.btnHaxeo.Click += new System.EventHandler(this.btnHaxeo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-216, -112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1727, 952);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 733);
            this.Controls.Add(this.btnHaxeo);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtResultado2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "txtResultado";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado2;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnHaxeo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

