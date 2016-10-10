namespace MiniPaint.WinForms
{
    partial class frmMain
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
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoLineBresenham = new System.Windows.Forms.RadioButton();
            this.rdoLineDda = new System.Windows.Forms.RadioButton();
            this.rdoLineNaive = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCanvas.BackColor = System.Drawing.Color.White;
            this.pnlCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCanvas.Location = new System.Drawing.Point(13, 12);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(568, 476);
            this.pnlCanvas.TabIndex = 0;
            this.pnlCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCanvas_Paint);
            this.pnlCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseDown);
            this.pnlCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rdoLineBresenham);
            this.groupBox1.Controls.Add(this.rdoLineDda);
            this.groupBox1.Controls.Add(this.rdoLineNaive);
            this.groupBox1.Location = new System.Drawing.Point(587, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(239, 116);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Line generator algorithm to use";
            // 
            // rdoLineBresenham
            // 
            this.rdoLineBresenham.AutoSize = true;
            this.rdoLineBresenham.Location = new System.Drawing.Point(13, 82);
            this.rdoLineBresenham.Name = "rdoLineBresenham";
            this.rdoLineBresenham.Size = new System.Drawing.Size(173, 21);
            this.rdoLineBresenham.TabIndex = 2;
            this.rdoLineBresenham.Text = "Bresenham\'s algorithm";
            this.rdoLineBresenham.UseVisualStyleBackColor = true;
            this.rdoLineBresenham.CheckedChanged += new System.EventHandler(this.allLineRadioBox_CheckedChanged);
            // 
            // rdoLineDda
            // 
            this.rdoLineDda.AutoSize = true;
            this.rdoLineDda.Location = new System.Drawing.Point(13, 55);
            this.rdoLineDda.Name = "rdoLineDda";
            this.rdoLineDda.Size = new System.Drawing.Size(146, 21);
            this.rdoLineDda.TabIndex = 1;
            this.rdoLineDda.Text = "DDA line algorithm";
            this.rdoLineDda.UseVisualStyleBackColor = true;
            this.rdoLineDda.CheckedChanged += new System.EventHandler(this.allLineRadioBox_CheckedChanged);
            // 
            // rdoLineNaive
            // 
            this.rdoLineNaive.AutoSize = true;
            this.rdoLineNaive.Checked = true;
            this.rdoLineNaive.Location = new System.Drawing.Point(13, 28);
            this.rdoLineNaive.Name = "rdoLineNaive";
            this.rdoLineNaive.Size = new System.Drawing.Size(153, 21);
            this.rdoLineNaive.TabIndex = 0;
            this.rdoLineNaive.TabStop = true;
            this.rdoLineNaive.Text = "Naive line algorithm";
            this.rdoLineNaive.UseVisualStyleBackColor = true;
            this.rdoLineNaive.CheckedChanged += new System.EventHandler(this.allLineRadioBox_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 500);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlCanvas);
            this.Name = "frmMain";
            this.Text = "MiniPaint";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoLineBresenham;
        private System.Windows.Forms.RadioButton rdoLineDda;
        private System.Windows.Forms.RadioButton rdoLineNaive;
    }
}

