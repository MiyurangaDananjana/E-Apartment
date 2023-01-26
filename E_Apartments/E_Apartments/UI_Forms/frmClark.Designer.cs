
namespace E_Apartments.UI_Forms
{
    partial class frmClark
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClark));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UC_Pnal = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnWatingList = new System.Windows.Forms.Button();
            this.btnapartment = new System.Windows.Forms.Button();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.UC_Pnal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(841, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "User Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(929, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // UC_Pnal
            // 
            this.UC_Pnal.BackColor = System.Drawing.Color.White;
            this.UC_Pnal.Controls.Add(this.pictureBox2);
            this.UC_Pnal.Controls.Add(this.pictureBox1);
            this.UC_Pnal.Location = new System.Drawing.Point(4, 44);
            this.UC_Pnal.Name = "UC_Pnal";
            this.UC_Pnal.Size = new System.Drawing.Size(1178, 664);
            this.UC_Pnal.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::E_Apartments.Properties.Resources.Logo1;
            this.pictureBox2.Location = new System.Drawing.Point(374, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(383, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::E_Apartments.Properties.Resources.backgroun;
            this.pictureBox1.Location = new System.Drawing.Point(550, 259);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(625, 402);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnWatingList
            // 
            this.btnWatingList.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnWatingList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWatingList.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWatingList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnWatingList.Image = global::E_Apartments.Properties.Resources.waiting;
            this.btnWatingList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWatingList.Location = new System.Drawing.Point(334, 5);
            this.btnWatingList.Name = "btnWatingList";
            this.btnWatingList.Size = new System.Drawing.Size(139, 33);
            this.btnWatingList.TabIndex = 16;
            this.btnWatingList.Text = "   Waiting List";
            this.btnWatingList.UseVisualStyleBackColor = false;
            this.btnWatingList.Click += new System.EventHandler(this.btnWatingList_Click);
            // 
            // btnapartment
            // 
            this.btnapartment.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnapartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnapartment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnapartment.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnapartment.Image = global::E_Apartments.Properties.Resources.flat;
            this.btnapartment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnapartment.Location = new System.Drawing.Point(163, 5);
            this.btnapartment.Name = "btnapartment";
            this.btnapartment.Size = new System.Drawing.Size(165, 33);
            this.btnapartment.TabIndex = 9;
            this.btnapartment.Text = "      Apartment Detail";
            this.btnapartment.UseVisualStyleBackColor = false;
            this.btnapartment.Click += new System.EventHandler(this.btnapartment_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNewUser.Image = global::E_Apartments.Properties.Resources.profile;
            this.btnNewUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewUser.Location = new System.Drawing.Point(4, 5);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(153, 33);
            this.btnNewUser.TabIndex = 15;
            this.btnNewUser.Text = "      Customer Details";
            this.btnNewUser.UseVisualStyleBackColor = false;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = global::E_Apartments.Properties.Resources.check_out;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1082, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "     Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Image = global::E_Apartments.Properties.Resources.pay;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(479, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 33);
            this.button2.TabIndex = 17;
            this.button2.Text = "   Rental Pay";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmClark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnWatingList);
            this.Controls.Add(this.btnapartment);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UC_Pnal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClark";
            this.Load += new System.EventHandler(this.frmClark_Load);
            this.UC_Pnal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel UC_Pnal;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Button btnapartment;
        private System.Windows.Forms.Button btnWatingList;
        private System.Windows.Forms.Button button2;
    }
}