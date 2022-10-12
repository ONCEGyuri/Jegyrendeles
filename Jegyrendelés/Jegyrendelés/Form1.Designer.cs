
namespace Jegyrendelés
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
            this.cim = new System.Windows.Forms.Label();
            this.mtavolsag = new System.Windows.Forms.Label();
            this.osztaly = new System.Windows.Forms.Label();
            this.kedvezmeny = new System.Windows.Forms.Label();
            this.fizetendo = new System.Windows.Forms.Label();
            this.txKm = new System.Windows.Forms.TextBox();
            this.txF = new System.Windows.Forms.TextBox();
            this.cBOsztaly = new System.Windows.Forms.ComboBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.bSzamolas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cim
            // 
            this.cim.AutoSize = true;
            this.cim.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cim.Location = new System.Drawing.Point(262, 38);
            this.cim.Name = "cim";
            this.cim.Size = new System.Drawing.Size(251, 31);
            this.cim.TabIndex = 0;
            this.cim.Text = "Vasúti jegyrendelés";
            this.cim.Click += new System.EventHandler(this.cim_Click);
            // 
            // mtavolsag
            // 
            this.mtavolsag.AutoSize = true;
            this.mtavolsag.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.mtavolsag.Location = new System.Drawing.Point(81, 102);
            this.mtavolsag.Name = "mtavolsag";
            this.mtavolsag.Size = new System.Drawing.Size(120, 18);
            this.mtavolsag.TabIndex = 1;
            this.mtavolsag.Text = "Megtett távolság:";
            // 
            // osztaly
            // 
            this.osztaly.AutoSize = true;
            this.osztaly.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.osztaly.Location = new System.Drawing.Point(81, 144);
            this.osztaly.Name = "osztaly";
            this.osztaly.Size = new System.Drawing.Size(62, 18);
            this.osztaly.TabIndex = 2;
            this.osztaly.Text = "Osztály:";
            // 
            // kedvezmeny
            // 
            this.kedvezmeny.AutoSize = true;
            this.kedvezmeny.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.kedvezmeny.Location = new System.Drawing.Point(81, 187);
            this.kedvezmeny.Name = "kedvezmeny";
            this.kedvezmeny.Size = new System.Drawing.Size(97, 18);
            this.kedvezmeny.TabIndex = 3;
            this.kedvezmeny.Text = "Kedvezmény:";
            // 
            // fizetendo
            // 
            this.fizetendo.AutoSize = true;
            this.fizetendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.fizetendo.Location = new System.Drawing.Point(81, 302);
            this.fizetendo.Name = "fizetendo";
            this.fizetendo.Size = new System.Drawing.Size(77, 18);
            this.fizetendo.TabIndex = 4;
            this.fizetendo.Text = "Fizetendő:";
            // 
            // txKm
            // 
            this.txKm.Location = new System.Drawing.Point(267, 100);
            this.txKm.Name = "txKm";
            this.txKm.Size = new System.Drawing.Size(246, 20);
            this.txKm.TabIndex = 5;
            // 
            // txF
            // 
            this.txF.Enabled = false;
            this.txF.Location = new System.Drawing.Point(266, 300);
            this.txF.Name = "txF";
            this.txF.Size = new System.Drawing.Size(246, 20);
            this.txF.TabIndex = 6;
            this.txF.TextChanged += new System.EventHandler(this.txF_TextChanged);
            // 
            // cBOsztaly
            // 
            this.cBOsztaly.FormattingEnabled = true;
            this.cBOsztaly.Items.AddRange(new object[] {
            "1. osztály",
            "2. osztály"});
            this.cBOsztaly.Location = new System.Drawing.Point(267, 141);
            this.cBOsztaly.Name = "cBOsztaly";
            this.cBOsztaly.Size = new System.Drawing.Size(245, 21);
            this.cBOsztaly.TabIndex = 7;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rb1.Location = new System.Drawing.Point(267, 183);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(151, 22);
            this.rb1.TabIndex = 8;
            this.rb1.TabStop = true;
            this.rb1.Text = "Nincs kedvezmény";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rb2.Location = new System.Drawing.Point(267, 211);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(55, 22);
            this.rb2.TabIndex = 9;
            this.rb2.TabStop = true;
            this.rb2.Text = "50%";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rb3.Location = new System.Drawing.Point(267, 239);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(55, 22);
            this.rb3.TabIndex = 10;
            this.rb3.TabStop = true;
            this.rb3.Text = "90%";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // bSzamolas
            // 
            this.bSzamolas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bSzamolas.Location = new System.Drawing.Point(581, 100);
            this.bSzamolas.Name = "bSzamolas";
            this.bSzamolas.Size = new System.Drawing.Size(170, 220);
            this.bSzamolas.TabIndex = 11;
            this.bSzamolas.Text = "Számolás";
            this.bSzamolas.UseVisualStyleBackColor = true;
            this.bSzamolas.Click += new System.EventHandler(this.bSzamolas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bSzamolas);
            this.Controls.Add(this.rb3);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.cBOsztaly);
            this.Controls.Add(this.txF);
            this.Controls.Add(this.txKm);
            this.Controls.Add(this.fizetendo);
            this.Controls.Add(this.kedvezmeny);
            this.Controls.Add(this.osztaly);
            this.Controls.Add(this.mtavolsag);
            this.Controls.Add(this.cim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cim;
        private System.Windows.Forms.Label mtavolsag;
        private System.Windows.Forms.Label osztaly;
        private System.Windows.Forms.Label kedvezmeny;
        private System.Windows.Forms.Label fizetendo;
        private System.Windows.Forms.TextBox txKm;
        private System.Windows.Forms.TextBox txF;
        private System.Windows.Forms.ComboBox cBOsztaly;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.Button bSzamolas;
    }
}

