namespace MiniPaint.WinForms
{
    partial class frmEditPolyFunc
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtX3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtX4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtX5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtX6 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "y =";
            // 
            // txtX0
            // 
            this.txtX0.Location = new System.Drawing.Point(64, 25);
            this.txtX0.Name = "txtX0";
            this.txtX0.Size = new System.Drawing.Size(46, 22);
            this.txtX0.TabIndex = 1;
            this.txtX0.Text = "0";
            this.txtX0.Validating += new System.ComponentModel.CancelEventHandler(this.txtConstants_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "x^0 +";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "x^1 +";
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(163, 25);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(46, 22);
            this.txtX1.TabIndex = 3;
            this.txtX1.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "x^2 +";
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(262, 25);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(46, 22);
            this.txtX2.TabIndex = 5;
            this.txtX2.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "x^3 +";
            // 
            // txtX3
            // 
            this.txtX3.Location = new System.Drawing.Point(361, 25);
            this.txtX3.Name = "txtX3";
            this.txtX3.Size = new System.Drawing.Size(46, 22);
            this.txtX3.TabIndex = 7;
            this.txtX3.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "x^4 +";
            // 
            // txtX4
            // 
            this.txtX4.Location = new System.Drawing.Point(460, 25);
            this.txtX4.Name = "txtX4";
            this.txtX4.Size = new System.Drawing.Size(46, 22);
            this.txtX4.TabIndex = 9;
            this.txtX4.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(611, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "x^5 +";
            // 
            // txtX5
            // 
            this.txtX5.Location = new System.Drawing.Point(559, 25);
            this.txtX5.Name = "txtX5";
            this.txtX5.Size = new System.Drawing.Size(46, 22);
            this.txtX5.TabIndex = 11;
            this.txtX5.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(710, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "x^6";
            // 
            // txtX6
            // 
            this.txtX6.Location = new System.Drawing.Point(658, 25);
            this.txtX6.Name = "txtX6";
            this.txtX6.Size = new System.Drawing.Size(46, 22);
            this.txtX6.TabIndex = 13;
            this.txtX6.Text = "0";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(583, 62);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(664, 62);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmEditPolyFunc
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(765, 110);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtX6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtX5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtX4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtX3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtX0);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditPolyFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Polynomial function editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtX0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtX3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtX4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtX5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtX6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}