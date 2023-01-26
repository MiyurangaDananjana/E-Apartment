
namespace E_Apartments.UI_Forms
{
    partial class frmComment
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
            this.txtcomment = new System.Windows.Forms.RichTextBox();
            this.btnDashbord = new System.Windows.Forms.Button();
            this.lblmessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtcomment
            // 
            this.txtcomment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcomment.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomment.Location = new System.Drawing.Point(3, 3);
            this.txtcomment.Name = "txtcomment";
            this.txtcomment.Size = new System.Drawing.Size(576, 255);
            this.txtcomment.TabIndex = 0;
            this.txtcomment.Text = "";
            this.txtcomment.TextChanged += new System.EventHandler(this.txtcomment_TextChanged);
            // 
            // btnDashbord
            // 
            this.btnDashbord.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDashbord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashbord.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashbord.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDashbord.Image = global::E_Apartments.Properties.Resources.sent;
            this.btnDashbord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashbord.Location = new System.Drawing.Point(489, 264);
            this.btnDashbord.Name = "btnDashbord";
            this.btnDashbord.Size = new System.Drawing.Size(90, 33);
            this.btnDashbord.TabIndex = 13;
            this.btnDashbord.Text = "      Sent";
            this.btnDashbord.UseVisualStyleBackColor = false;
            this.btnDashbord.Click += new System.EventHandler(this.btnDashbord_Click);
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessage.ForeColor = System.Drawing.Color.Red;
            this.lblmessage.Location = new System.Drawing.Point(8, 269);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(0, 19);
            this.lblmessage.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "200/";
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcount.ForeColor = System.Drawing.Color.White;
            this.lblcount.Location = new System.Drawing.Point(43, 4);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(29, 17);
            this.lblcount.TabIndex = 16;
            this.lblcount.Text = "000";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkViolet;
            this.panel1.Controls.Add(this.lblcount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(399, 268);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(84, 25);
            this.panel1.TabIndex = 17;
            // 
            // frmComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(582, 302);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.btnDashbord);
            this.Controls.Add(this.txtcomment);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmComment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmComment";
            this.Load += new System.EventHandler(this.frmComment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtcomment;
        private System.Windows.Forms.Button btnDashbord;
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcount;
        private System.Windows.Forms.Panel panel1;
    }
}