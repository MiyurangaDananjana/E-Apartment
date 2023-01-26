
namespace E_Apartments.UI_Forms
{
    partial class RentalPay
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
            this.txtCustomername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtrental = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnrent = new System.Windows.Forms.Button();
            this.cmbpaymentmethod = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtleaseID = new System.Windows.Forms.TextBox();
            this.lblrental = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCustomername
            // 
            this.txtCustomername.Enabled = false;
            this.txtCustomername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomername.Location = new System.Drawing.Point(138, 69);
            this.txtCustomername.Name = "txtCustomername";
            this.txtCustomername.Size = new System.Drawing.Size(148, 23);
            this.txtCustomername.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "CUSTOMER NAME:";
            // 
            // txtrental
            // 
            this.txtrental.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrental.Location = new System.Drawing.Point(138, 111);
            this.txtrental.Name = "txtrental";
            this.txtrental.Size = new System.Drawing.Size(148, 23);
            this.txtrental.TabIndex = 3;
            this.txtrental.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtrental.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrental_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "RENTAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "PAYMENT TYPE";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(292, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 24);
            this.button2.TabIndex = 1;
            this.button2.Text = "SELECT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnprint.Image = global::E_Apartments.Properties.Resources.printer;
            this.btnprint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprint.Location = new System.Drawing.Point(74, 364);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(174, 39);
            this.btnprint.TabIndex = 6;
            this.btnprint.Text = "     PRINT INVOICE";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnrent
            // 
            this.btnrent.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnrent.Image = global::E_Apartments.Properties.Resources.check;
            this.btnrent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrent.Location = new System.Drawing.Point(254, 364);
            this.btnrent.Name = "btnrent";
            this.btnrent.Size = new System.Drawing.Size(102, 39);
            this.btnrent.TabIndex = 5;
            this.btnrent.Text = "      PAY";
            this.btnrent.UseVisualStyleBackColor = false;
            this.btnrent.Click += new System.EventHandler(this.btnrent_Click);
            // 
            // cmbpaymentmethod
            // 
            this.cmbpaymentmethod.FormattingEnabled = true;
            this.cmbpaymentmethod.Location = new System.Drawing.Point(138, 153);
            this.cmbpaymentmethod.Name = "cmbpaymentmethod";
            this.cmbpaymentmethod.Size = new System.Drawing.Size(148, 21);
            this.cmbpaymentmethod.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 28);
            this.panel1.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 68;
            this.label4.Text = "LEASE ID:";
            // 
            // txtleaseID
            // 
            this.txtleaseID.Enabled = false;
            this.txtleaseID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtleaseID.Location = new System.Drawing.Point(138, 27);
            this.txtleaseID.Name = "txtleaseID";
            this.txtleaseID.Size = new System.Drawing.Size(148, 23);
            this.txtleaseID.TabIndex = 0;
            this.txtleaseID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtleaseID_KeyPress);
            // 
            // lblrental
            // 
            this.lblrental.AutoSize = true;
            this.lblrental.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrental.ForeColor = System.Drawing.Color.Black;
            this.lblrental.Location = new System.Drawing.Point(289, 114);
            this.lblrental.Name = "lblrental";
            this.lblrental.Size = new System.Drawing.Size(57, 17);
            this.lblrental.TabIndex = 70;
            this.lblrental.Text = "0000000";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel2.Controls.Add(this.btnrent);
            this.panel2.Controls.Add(this.lblrental);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtleaseID);
            this.panel2.Controls.Add(this.txtCustomername);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtrental);
            this.panel2.Controls.Add(this.cmbpaymentmethod);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnprint);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(13, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 413);
            this.panel2.TabIndex = 71;
            // 
            // RentalPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(394, 457);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RentalPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentalPay";
            this.Load += new System.EventHandler(this.RentalPay_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtrental;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnrent;
        private System.Windows.Forms.ComboBox cmbpaymentmethod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtleaseID;
        private System.Windows.Forms.Label lblrental;
        private System.Windows.Forms.Panel panel2;
    }
}