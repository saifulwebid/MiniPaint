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
            this.grpLineGeneratorAlgorithm = new System.Windows.Forms.GroupBox();
            this.rdoLineBresenham = new System.Windows.Forms.RadioButton();
            this.rdoLineDda = new System.Windows.Forms.RadioButton();
            this.rdoLineNaive = new System.Windows.Forms.RadioButton();
            this.grpToolbox = new System.Windows.Forms.GroupBox();
            this.rdoToolboxEllipse = new System.Windows.Forms.RadioButton();
            this.rdoToolboxCircle = new System.Windows.Forms.RadioButton();
            this.rdoToolboxLine = new System.Windows.Forms.RadioButton();
            this.btnRedraw = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.grpLineGeneratorAlgorithm.SuspendLayout();
            this.grpToolbox.SuspendLayout();
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
            // grpLineGeneratorAlgorithm
            // 
            this.grpLineGeneratorAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLineGeneratorAlgorithm.Controls.Add(this.rdoLineBresenham);
            this.grpLineGeneratorAlgorithm.Controls.Add(this.rdoLineDda);
            this.grpLineGeneratorAlgorithm.Controls.Add(this.rdoLineNaive);
            this.grpLineGeneratorAlgorithm.Location = new System.Drawing.Point(587, 134);
            this.grpLineGeneratorAlgorithm.Name = "grpLineGeneratorAlgorithm";
            this.grpLineGeneratorAlgorithm.Padding = new System.Windows.Forms.Padding(10);
            this.grpLineGeneratorAlgorithm.Size = new System.Drawing.Size(239, 116);
            this.grpLineGeneratorAlgorithm.TabIndex = 4;
            this.grpLineGeneratorAlgorithm.TabStop = false;
            this.grpLineGeneratorAlgorithm.Text = "Line generator algorithm to use";
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
            // 
            // grpToolbox
            // 
            this.grpToolbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpToolbox.Controls.Add(this.rdoToolboxEllipse);
            this.grpToolbox.Controls.Add(this.rdoToolboxCircle);
            this.grpToolbox.Controls.Add(this.rdoToolboxLine);
            this.grpToolbox.Location = new System.Drawing.Point(587, 12);
            this.grpToolbox.Name = "grpToolbox";
            this.grpToolbox.Padding = new System.Windows.Forms.Padding(10);
            this.grpToolbox.Size = new System.Drawing.Size(239, 116);
            this.grpToolbox.TabIndex = 5;
            this.grpToolbox.TabStop = false;
            this.grpToolbox.Text = "Toolbox";
            // 
            // rdoToolboxEllipse
            // 
            this.rdoToolboxEllipse.AutoSize = true;
            this.rdoToolboxEllipse.Location = new System.Drawing.Point(13, 82);
            this.rdoToolboxEllipse.Name = "rdoToolboxEllipse";
            this.rdoToolboxEllipse.Size = new System.Drawing.Size(70, 21);
            this.rdoToolboxEllipse.TabIndex = 2;
            this.rdoToolboxEllipse.TabStop = true;
            this.rdoToolboxEllipse.Text = "Ellipse";
            this.rdoToolboxEllipse.UseVisualStyleBackColor = true;
            // 
            // rdoToolboxCircle
            // 
            this.rdoToolboxCircle.AutoSize = true;
            this.rdoToolboxCircle.Location = new System.Drawing.Point(13, 55);
            this.rdoToolboxCircle.Name = "rdoToolboxCircle";
            this.rdoToolboxCircle.Size = new System.Drawing.Size(64, 21);
            this.rdoToolboxCircle.TabIndex = 1;
            this.rdoToolboxCircle.TabStop = true;
            this.rdoToolboxCircle.Text = "Circle";
            this.rdoToolboxCircle.UseVisualStyleBackColor = true;
            // 
            // rdoToolboxLine
            // 
            this.rdoToolboxLine.AutoSize = true;
            this.rdoToolboxLine.Checked = true;
            this.rdoToolboxLine.Location = new System.Drawing.Point(13, 28);
            this.rdoToolboxLine.Name = "rdoToolboxLine";
            this.rdoToolboxLine.Size = new System.Drawing.Size(56, 21);
            this.rdoToolboxLine.TabIndex = 0;
            this.rdoToolboxLine.TabStop = true;
            this.rdoToolboxLine.Text = "Line";
            this.rdoToolboxLine.UseVisualStyleBackColor = true;
            this.rdoToolboxLine.CheckedChanged += new System.EventHandler(this.rdoToolboxLine_CheckedChanged);
            // 
            // btnRedraw
            // 
            this.btnRedraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRedraw.Location = new System.Drawing.Point(588, 257);
            this.btnRedraw.Name = "btnRedraw";
            this.btnRedraw.Size = new System.Drawing.Size(75, 23);
            this.btnRedraw.TabIndex = 6;
            this.btnRedraw.Text = "Redraw";
            this.btnRedraw.UseVisualStyleBackColor = true;
            this.btnRedraw.Click += new System.EventHandler(this.btnRedraw_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(669, 257);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUndo.Location = new System.Drawing.Point(750, 257);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 8;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 500);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRedraw);
            this.Controls.Add(this.grpToolbox);
            this.Controls.Add(this.grpLineGeneratorAlgorithm);
            this.Controls.Add(this.pnlCanvas);
            this.Name = "frmMain";
            this.Text = "MiniPaint";
            this.grpLineGeneratorAlgorithm.ResumeLayout(false);
            this.grpLineGeneratorAlgorithm.PerformLayout();
            this.grpToolbox.ResumeLayout(false);
            this.grpToolbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.GroupBox grpLineGeneratorAlgorithm;
        private System.Windows.Forms.RadioButton rdoLineBresenham;
        private System.Windows.Forms.RadioButton rdoLineDda;
        private System.Windows.Forms.RadioButton rdoLineNaive;
        private System.Windows.Forms.GroupBox grpToolbox;
        private System.Windows.Forms.RadioButton rdoToolboxLine;
        private System.Windows.Forms.RadioButton rdoToolboxCircle;
        private System.Windows.Forms.Button btnRedraw;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton rdoToolboxEllipse;
        private System.Windows.Forms.Button btnUndo;
    }
}

