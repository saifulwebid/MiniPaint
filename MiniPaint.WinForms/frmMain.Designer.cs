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
            this.cboNaive = new System.Windows.Forms.CheckBox();
            this.cboDDA = new System.Windows.Forms.CheckBox();
            this.cboBresenham = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCanvas.Location = new System.Drawing.Point(13, 40);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(813, 448);
            this.pnlCanvas.TabIndex = 0;
            this.pnlCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCanvas_Paint);
            this.pnlCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseDown);
            this.pnlCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseUp);
            // 
            // cboNaive
            // 
            this.cboNaive.AutoSize = true;
            this.cboNaive.Location = new System.Drawing.Point(13, 13);
            this.cboNaive.Name = "cboNaive";
            this.cboNaive.Size = new System.Drawing.Size(128, 21);
            this.cboNaive.TabIndex = 1;
            this.cboNaive.Text = "Naive algorithm";
            this.cboNaive.UseVisualStyleBackColor = true;
            this.cboNaive.CheckedChanged += new System.EventHandler(this.allComboBox_CheckedChanged);
            // 
            // cboDDA
            // 
            this.cboDDA.AutoSize = true;
            this.cboDDA.Location = new System.Drawing.Point(148, 13);
            this.cboDDA.Name = "cboDDA";
            this.cboDDA.Size = new System.Drawing.Size(121, 21);
            this.cboDDA.TabIndex = 2;
            this.cboDDA.Text = "DDA algorithm";
            this.cboDDA.UseVisualStyleBackColor = true;
            this.cboDDA.CheckedChanged += new System.EventHandler(this.allComboBox_CheckedChanged);
            // 
            // cboBresenham
            // 
            this.cboBresenham.AutoSize = true;
            this.cboBresenham.Location = new System.Drawing.Point(276, 13);
            this.cboBresenham.Name = "cboBresenham";
            this.cboBresenham.Size = new System.Drawing.Size(174, 21);
            this.cboBresenham.TabIndex = 3;
            this.cboBresenham.Text = "Bresenham\'s algorithm";
            this.cboBresenham.UseVisualStyleBackColor = true;
            this.cboBresenham.CheckedChanged += new System.EventHandler(this.allComboBox_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 500);
            this.Controls.Add(this.cboBresenham);
            this.Controls.Add(this.cboDDA);
            this.Controls.Add(this.cboNaive);
            this.Controls.Add(this.pnlCanvas);
            this.Name = "frmMain";
            this.Text = "MiniPaint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.CheckBox cboNaive;
        private System.Windows.Forms.CheckBox cboDDA;
        private System.Windows.Forms.CheckBox cboBresenham;
    }
}

