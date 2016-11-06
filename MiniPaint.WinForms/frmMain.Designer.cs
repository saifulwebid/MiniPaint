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
            this.grpLineGeneratorAlgorithm = new System.Windows.Forms.GroupBox();
            this.rdoLineBresenham = new System.Windows.Forms.RadioButton();
            this.rdoLineDda = new System.Windows.Forms.RadioButton();
            this.rdoLineNaive = new System.Windows.Forms.RadioButton();
            this.grpToolbox = new System.Windows.Forms.GroupBox();
            this.rdoToolboxStar = new System.Windows.Forms.RadioButton();
            this.rdoToolboxRegularPolygon = new System.Windows.Forms.RadioButton();
            this.rdoToolboxEllipse = new System.Windows.Forms.RadioButton();
            this.rdoToolboxCircle = new System.Windows.Forms.RadioButton();
            this.rdoToolboxLine = new System.Windows.Forms.RadioButton();
            this.btnRedraw = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.grpNGonOptions = new System.Windows.Forms.GroupBox();
            this.txtNGonSkip = new System.Windows.Forms.TextBox();
            this.txtNGonEdges = new System.Windows.Forms.TextBox();
            this.lblNGonSkip = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxCanvas = new System.Windows.Forms.PictureBox();
            this.rdoToolboxPolynomialFunction = new System.Windows.Forms.RadioButton();
            this.grpPolynomialFunction = new System.Windows.Forms.GroupBox();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnEditFunction = new System.Windows.Forms.Button();
            this.grpLineGeneratorAlgorithm.SuspendLayout();
            this.grpToolbox.SuspendLayout();
            this.grpNGonOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCanvas)).BeginInit();
            this.grpPolynomialFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLineGeneratorAlgorithm
            // 
            this.grpLineGeneratorAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLineGeneratorAlgorithm.Controls.Add(this.rdoLineBresenham);
            this.grpLineGeneratorAlgorithm.Controls.Add(this.rdoLineDda);
            this.grpLineGeneratorAlgorithm.Controls.Add(this.rdoLineNaive);
            this.grpLineGeneratorAlgorithm.Location = new System.Drawing.Point(724, 161);
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
            this.grpToolbox.Controls.Add(this.rdoToolboxPolynomialFunction);
            this.grpToolbox.Controls.Add(this.rdoToolboxStar);
            this.grpToolbox.Controls.Add(this.rdoToolboxRegularPolygon);
            this.grpToolbox.Controls.Add(this.rdoToolboxEllipse);
            this.grpToolbox.Controls.Add(this.rdoToolboxCircle);
            this.grpToolbox.Controls.Add(this.rdoToolboxLine);
            this.grpToolbox.Location = new System.Drawing.Point(724, 12);
            this.grpToolbox.Name = "grpToolbox";
            this.grpToolbox.Padding = new System.Windows.Forms.Padding(10);
            this.grpToolbox.Size = new System.Drawing.Size(239, 143);
            this.grpToolbox.TabIndex = 5;
            this.grpToolbox.TabStop = false;
            this.grpToolbox.Text = "Toolbox";
            // 
            // rdoToolboxStar
            // 
            this.rdoToolboxStar.AutoSize = true;
            this.rdoToolboxStar.Location = new System.Drawing.Point(115, 55);
            this.rdoToolboxStar.Name = "rdoToolboxStar";
            this.rdoToolboxStar.Size = new System.Drawing.Size(55, 21);
            this.rdoToolboxStar.TabIndex = 4;
            this.rdoToolboxStar.TabStop = true;
            this.rdoToolboxStar.Text = "Star";
            this.rdoToolboxStar.UseVisualStyleBackColor = true;
            this.rdoToolboxStar.CheckedChanged += new System.EventHandler(this.toolboxNGon_CheckedChanged);
            // 
            // rdoToolboxRegularPolygon
            // 
            this.rdoToolboxRegularPolygon.AutoSize = true;
            this.rdoToolboxRegularPolygon.Location = new System.Drawing.Point(13, 82);
            this.rdoToolboxRegularPolygon.Name = "rdoToolboxRegularPolygon";
            this.rdoToolboxRegularPolygon.Size = new System.Drawing.Size(133, 21);
            this.rdoToolboxRegularPolygon.TabIndex = 3;
            this.rdoToolboxRegularPolygon.TabStop = true;
            this.rdoToolboxRegularPolygon.Text = "Regular polygon";
            this.rdoToolboxRegularPolygon.UseVisualStyleBackColor = true;
            this.rdoToolboxRegularPolygon.CheckedChanged += new System.EventHandler(this.toolboxNGon_CheckedChanged);
            // 
            // rdoToolboxEllipse
            // 
            this.rdoToolboxEllipse.AutoSize = true;
            this.rdoToolboxEllipse.Location = new System.Drawing.Point(115, 28);
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
            this.btnRedraw.Location = new System.Drawing.Point(724, 422);
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
            this.btnClear.Location = new System.Drawing.Point(805, 422);
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
            this.btnUndo.Location = new System.Drawing.Point(886, 422);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 8;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // grpNGonOptions
            // 
            this.grpNGonOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpNGonOptions.Controls.Add(this.txtNGonSkip);
            this.grpNGonOptions.Controls.Add(this.txtNGonEdges);
            this.grpNGonOptions.Controls.Add(this.lblNGonSkip);
            this.grpNGonOptions.Controls.Add(this.label1);
            this.grpNGonOptions.Location = new System.Drawing.Point(724, 283);
            this.grpNGonOptions.Name = "grpNGonOptions";
            this.grpNGonOptions.Padding = new System.Windows.Forms.Padding(10);
            this.grpNGonOptions.Size = new System.Drawing.Size(239, 63);
            this.grpNGonOptions.TabIndex = 5;
            this.grpNGonOptions.TabStop = false;
            this.grpNGonOptions.Text = "n-gon options";
            // 
            // txtNGonSkip
            // 
            this.txtNGonSkip.Location = new System.Drawing.Point(176, 28);
            this.txtNGonSkip.Name = "txtNGonSkip";
            this.txtNGonSkip.Size = new System.Drawing.Size(45, 22);
            this.txtNGonSkip.TabIndex = 3;
            this.txtNGonSkip.Text = "2";
            this.txtNGonSkip.Validating += new System.ComponentModel.CancelEventHandler(this.txtNGonSkip_Validating);
            // 
            // txtNGonEdges
            // 
            this.txtNGonEdges.Location = new System.Drawing.Point(71, 28);
            this.txtNGonEdges.Name = "txtNGonEdges";
            this.txtNGonEdges.Size = new System.Drawing.Size(45, 22);
            this.txtNGonEdges.TabIndex = 2;
            this.txtNGonEdges.Text = "5";
            this.txtNGonEdges.Validating += new System.ComponentModel.CancelEventHandler(this.txtNGonEdges_Validating);
            // 
            // lblNGonSkip
            // 
            this.lblNGonSkip.AutoSize = true;
            this.lblNGonSkip.Location = new System.Drawing.Point(131, 31);
            this.lblNGonSkip.Name = "lblNGonSkip";
            this.lblNGonSkip.Size = new System.Drawing.Size(39, 17);
            this.lblNGonSkip.TabIndex = 1;
            this.lblNGonSkip.Text = "Skip:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edges:";
            // 
            // pbxCanvas
            // 
            this.pbxCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxCanvas.BackColor = System.Drawing.Color.White;
            this.pbxCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxCanvas.Location = new System.Drawing.Point(12, 12);
            this.pbxCanvas.Name = "pbxCanvas";
            this.pbxCanvas.Size = new System.Drawing.Size(706, 476);
            this.pbxCanvas.TabIndex = 9;
            this.pbxCanvas.TabStop = false;
            this.pbxCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCanvas_Paint);
            this.pbxCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseDown);
            this.pbxCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseMove);
            this.pbxCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseUp);
            this.pbxCanvas.Resize += new System.EventHandler(this.pnlCanvas_Resize);
            // 
            // rdoToolboxPolynomialFunction
            // 
            this.rdoToolboxPolynomialFunction.AutoSize = true;
            this.rdoToolboxPolynomialFunction.Location = new System.Drawing.Point(13, 109);
            this.rdoToolboxPolynomialFunction.Name = "rdoToolboxPolynomialFunction";
            this.rdoToolboxPolynomialFunction.Size = new System.Drawing.Size(151, 21);
            this.rdoToolboxPolynomialFunction.TabIndex = 5;
            this.rdoToolboxPolynomialFunction.TabStop = true;
            this.rdoToolboxPolynomialFunction.Text = "Polynomial function";
            this.rdoToolboxPolynomialFunction.UseVisualStyleBackColor = true;
            this.rdoToolboxPolynomialFunction.CheckedChanged += new System.EventHandler(this.rdoToolboxPolynomialFunction_CheckedChanged);
            // 
            // grpPolynomialFunction
            // 
            this.grpPolynomialFunction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPolynomialFunction.Controls.Add(this.btnEditFunction);
            this.grpPolynomialFunction.Controls.Add(this.btnZoomOut);
            this.grpPolynomialFunction.Controls.Add(this.btnZoomIn);
            this.grpPolynomialFunction.Location = new System.Drawing.Point(724, 352);
            this.grpPolynomialFunction.Name = "grpPolynomialFunction";
            this.grpPolynomialFunction.Padding = new System.Windows.Forms.Padding(10);
            this.grpPolynomialFunction.Size = new System.Drawing.Size(239, 64);
            this.grpPolynomialFunction.TabIndex = 10;
            this.grpPolynomialFunction.TabStop = false;
            this.grpPolynomialFunction.Text = "Polynomial function";
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Location = new System.Drawing.Point(80, 28);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(70, 23);
            this.btnZoomIn.TabIndex = 0;
            this.btnZoomIn.Text = "Zoom +";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Location = new System.Drawing.Point(156, 28);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(70, 23);
            this.btnZoomOut.TabIndex = 1;
            this.btnZoomOut.Text = "Zoom -";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnEditFunction
            // 
            this.btnEditFunction.Location = new System.Drawing.Point(13, 28);
            this.btnEditFunction.Name = "btnEditFunction";
            this.btnEditFunction.Size = new System.Drawing.Size(61, 23);
            this.btnEditFunction.TabIndex = 2;
            this.btnEditFunction.Text = "Edit";
            this.btnEditFunction.UseVisualStyleBackColor = true;
            this.btnEditFunction.Click += new System.EventHandler(this.btnEditFunction_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 500);
            this.Controls.Add(this.grpPolynomialFunction);
            this.Controls.Add(this.pbxCanvas);
            this.Controls.Add(this.grpNGonOptions);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRedraw);
            this.Controls.Add(this.grpToolbox);
            this.Controls.Add(this.grpLineGeneratorAlgorithm);
            this.Name = "frmMain";
            this.Text = "MiniPaint";
            this.grpLineGeneratorAlgorithm.ResumeLayout(false);
            this.grpLineGeneratorAlgorithm.PerformLayout();
            this.grpToolbox.ResumeLayout(false);
            this.grpToolbox.PerformLayout();
            this.grpNGonOptions.ResumeLayout(false);
            this.grpNGonOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCanvas)).EndInit();
            this.grpPolynomialFunction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.RadioButton rdoToolboxStar;
        private System.Windows.Forms.RadioButton rdoToolboxRegularPolygon;
        private System.Windows.Forms.GroupBox grpNGonOptions;
        private System.Windows.Forms.TextBox txtNGonSkip;
        private System.Windows.Forms.TextBox txtNGonEdges;
        private System.Windows.Forms.Label lblNGonSkip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxCanvas;
        private System.Windows.Forms.RadioButton rdoToolboxPolynomialFunction;
        private System.Windows.Forms.GroupBox grpPolynomialFunction;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnEditFunction;
    }
}

