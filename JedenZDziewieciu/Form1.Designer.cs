namespace JedenZDziewieciu
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
            this.btnLos = new System.Windows.Forms.Button();
            this.lblKategorioa = new System.Windows.Forms.Label();
            this.lblNumer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLos
            // 
            this.btnLos.BackColor = System.Drawing.Color.Transparent;
            this.btnLos.FlatAppearance.BorderSize = 0;
            this.btnLos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLos.Font = new System.Drawing.Font("Verdana", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLos.ForeColor = System.Drawing.Color.Black;
            this.btnLos.Location = new System.Drawing.Point(27, 222);
            this.btnLos.Name = "btnLos";
            this.btnLos.Size = new System.Drawing.Size(225, 68);
            this.btnLos.TabIndex = 0;
            this.btnLos.UseVisualStyleBackColor = false;
            this.btnLos.Click += new System.EventHandler(this.btnLos_Click);
            // 
            // lblKategorioa
            // 
            this.lblKategorioa.AutoSize = true;
            this.lblKategorioa.BackColor = System.Drawing.Color.Transparent;
            this.lblKategorioa.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKategorioa.ForeColor = System.Drawing.Color.Black;
            this.lblKategorioa.Location = new System.Drawing.Point(141, 384);
            this.lblKategorioa.Name = "lblKategorioa";
            this.lblKategorioa.Size = new System.Drawing.Size(153, 54);
            this.lblKategorioa.TabIndex = 1;
            this.lblKategorioa.Text = "label1";
            // 
            // lblNumer
            // 
            this.lblNumer.AutoSize = true;
            this.lblNumer.BackColor = System.Drawing.Color.Transparent;
            this.lblNumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNumer.ForeColor = System.Drawing.Color.Black;
            this.lblNumer.Location = new System.Drawing.Point(264, 569);
            this.lblNumer.Name = "lblNumer";
            this.lblNumer.Size = new System.Drawing.Size(153, 54);
            this.lblNumer.TabIndex = 2;
            this.lblNumer.Text = "label2";
            this.lblNumer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Verdana", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(295, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 68);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JedenZDziewieciu.Properties.Resources.NACISNIJ_ABY_ZASIAC_ROZPIERDOL1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 791);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNumer);
            this.Controls.Add(this.lblKategorioa);
            this.Controls.Add(this.btnLos);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLos;
        private System.Windows.Forms.Label lblKategorioa;
        private System.Windows.Forms.Label lblNumer;
        private System.Windows.Forms.Button button1;
    }
}

