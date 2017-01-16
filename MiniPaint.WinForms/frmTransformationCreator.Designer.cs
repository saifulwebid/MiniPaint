namespace MiniPaint.WinForms
{
    partial class frmTransformationCreator
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
            this.tbcTransformation = new System.Windows.Forms.TabControl();
            this.tbpTranslation = new System.Windows.Forms.TabPage();
            this.tbpScaling = new System.Windows.Forms.TabPage();
            this.tbpRotation = new System.Windows.Forms.TabPage();
            this.tbpReflection = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTranslationDx = new System.Windows.Forms.TextBox();
            this.txtTranslationDy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtScalingConstant = new System.Windows.Forms.TextBox();
            this.txtRotationAngleInDegrees = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReflectionStartX = new System.Windows.Forms.TextBox();
            this.txtReflectionStartY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReflectionEndX = new System.Windows.Forms.TextBox();
            this.txtReflectionEndY = new System.Windows.Forms.TextBox();
            this.btnTransform = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbcTransformation.SuspendLayout();
            this.tbpTranslation.SuspendLayout();
            this.tbpScaling.SuspendLayout();
            this.tbpRotation.SuspendLayout();
            this.tbpReflection.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcTransformation
            // 
            this.tbcTransformation.Controls.Add(this.tbpTranslation);
            this.tbcTransformation.Controls.Add(this.tbpScaling);
            this.tbcTransformation.Controls.Add(this.tbpRotation);
            this.tbcTransformation.Controls.Add(this.tbpReflection);
            this.tbcTransformation.Location = new System.Drawing.Point(23, 23);
            this.tbcTransformation.Name = "tbcTransformation";
            this.tbcTransformation.SelectedIndex = 0;
            this.tbcTransformation.Size = new System.Drawing.Size(416, 125);
            this.tbcTransformation.TabIndex = 0;
            // 
            // tbpTranslation
            // 
            this.tbpTranslation.Controls.Add(this.txtTranslationDy);
            this.tbpTranslation.Controls.Add(this.txtTranslationDx);
            this.tbpTranslation.Controls.Add(this.label2);
            this.tbpTranslation.Controls.Add(this.label1);
            this.tbpTranslation.Location = new System.Drawing.Point(4, 25);
            this.tbpTranslation.Name = "tbpTranslation";
            this.tbpTranslation.Padding = new System.Windows.Forms.Padding(20);
            this.tbpTranslation.Size = new System.Drawing.Size(408, 96);
            this.tbpTranslation.TabIndex = 0;
            this.tbpTranslation.Text = "Translasi";
            this.tbpTranslation.UseVisualStyleBackColor = true;
            // 
            // tbpScaling
            // 
            this.tbpScaling.Controls.Add(this.txtScalingConstant);
            this.tbpScaling.Controls.Add(this.label3);
            this.tbpScaling.Location = new System.Drawing.Point(4, 25);
            this.tbpScaling.Name = "tbpScaling";
            this.tbpScaling.Padding = new System.Windows.Forms.Padding(20);
            this.tbpScaling.Size = new System.Drawing.Size(408, 96);
            this.tbpScaling.TabIndex = 2;
            this.tbpScaling.Text = "Dilatasi";
            this.tbpScaling.UseVisualStyleBackColor = true;
            // 
            // tbpRotation
            // 
            this.tbpRotation.Controls.Add(this.label4);
            this.tbpRotation.Controls.Add(this.txtRotationAngleInDegrees);
            this.tbpRotation.Location = new System.Drawing.Point(4, 25);
            this.tbpRotation.Name = "tbpRotation";
            this.tbpRotation.Padding = new System.Windows.Forms.Padding(20);
            this.tbpRotation.Size = new System.Drawing.Size(408, 96);
            this.tbpRotation.TabIndex = 3;
            this.tbpRotation.Text = "Rotasi";
            this.tbpRotation.UseVisualStyleBackColor = true;
            // 
            // tbpReflection
            // 
            this.tbpReflection.Controls.Add(this.txtReflectionEndY);
            this.tbpReflection.Controls.Add(this.txtReflectionEndX);
            this.tbpReflection.Controls.Add(this.label8);
            this.tbpReflection.Controls.Add(this.label7);
            this.tbpReflection.Controls.Add(this.label6);
            this.tbpReflection.Controls.Add(this.txtReflectionStartY);
            this.tbpReflection.Controls.Add(this.txtReflectionStartX);
            this.tbpReflection.Controls.Add(this.label5);
            this.tbpReflection.Location = new System.Drawing.Point(4, 25);
            this.tbpReflection.Name = "tbpReflection";
            this.tbpReflection.Padding = new System.Windows.Forms.Padding(20);
            this.tbpReflection.Size = new System.Drawing.Size(408, 96);
            this.tbpReflection.TabIndex = 1;
            this.tbpReflection.Text = "Refleksi";
            this.tbpReflection.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "dx:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "dy:";
            // 
            // txtTranslationDx
            // 
            this.txtTranslationDx.Location = new System.Drawing.Point(72, 23);
            this.txtTranslationDx.Name = "txtTranslationDx";
            this.txtTranslationDx.Size = new System.Drawing.Size(100, 22);
            this.txtTranslationDx.TabIndex = 2;
            // 
            // txtTranslationDy
            // 
            this.txtTranslationDy.Location = new System.Drawing.Point(72, 51);
            this.txtTranslationDy.Name = "txtTranslationDy";
            this.txtTranslationDy.Size = new System.Drawing.Size(100, 22);
            this.txtTranslationDy.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Scale constant:";
            // 
            // txtScalingConstant
            // 
            this.txtScalingConstant.Location = new System.Drawing.Point(151, 23);
            this.txtScalingConstant.Name = "txtScalingConstant";
            this.txtScalingConstant.Size = new System.Drawing.Size(100, 22);
            this.txtScalingConstant.TabIndex = 1;
            // 
            // txtRotationAngleInDegrees
            // 
            this.txtRotationAngleInDegrees.Location = new System.Drawing.Point(173, 23);
            this.txtRotationAngleInDegrees.Name = "txtRotationAngleInDegrees";
            this.txtRotationAngleInDegrees.Size = new System.Drawing.Size(100, 22);
            this.txtRotationAngleInDegrees.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Angle (in degrees):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Start.X:";
            // 
            // txtReflectionStartX
            // 
            this.txtReflectionStartX.Location = new System.Drawing.Point(84, 23);
            this.txtReflectionStartX.Name = "txtReflectionStartX";
            this.txtReflectionStartX.Size = new System.Drawing.Size(100, 22);
            this.txtReflectionStartX.TabIndex = 1;
            // 
            // txtReflectionStartY
            // 
            this.txtReflectionStartY.Location = new System.Drawing.Point(84, 51);
            this.txtReflectionStartY.Name = "txtReflectionStartY";
            this.txtReflectionStartY.Size = new System.Drawing.Size(100, 22);
            this.txtReflectionStartY.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Start.Y:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "End.X:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "End.Y:";
            // 
            // txtReflectionEndX
            // 
            this.txtReflectionEndX.Location = new System.Drawing.Point(265, 23);
            this.txtReflectionEndX.Name = "txtReflectionEndX";
            this.txtReflectionEndX.Size = new System.Drawing.Size(100, 22);
            this.txtReflectionEndX.TabIndex = 6;
            // 
            // txtReflectionEndY
            // 
            this.txtReflectionEndY.Location = new System.Drawing.Point(265, 51);
            this.txtReflectionEndY.Name = "txtReflectionEndY";
            this.txtReflectionEndY.Size = new System.Drawing.Size(100, 22);
            this.txtReflectionEndY.TabIndex = 7;
            // 
            // btnTransform
            // 
            this.btnTransform.Location = new System.Drawing.Point(267, 154);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(87, 23);
            this.btnTransform.TabIndex = 1;
            this.btnTransform.Text = "Transform";
            this.btnTransform.UseVisualStyleBackColor = true;
            this.btnTransform.Click += new System.EventHandler(this.btnTransform_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(360, 154);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmTransformationCreator
            // 
            this.AcceptButton = this.btnTransform;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(465, 208);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTransform);
            this.Controls.Add(this.tbcTransformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTransformationCreator";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transformation editor";
            this.tbcTransformation.ResumeLayout(false);
            this.tbpTranslation.ResumeLayout(false);
            this.tbpTranslation.PerformLayout();
            this.tbpScaling.ResumeLayout(false);
            this.tbpScaling.PerformLayout();
            this.tbpRotation.ResumeLayout(false);
            this.tbpRotation.PerformLayout();
            this.tbpReflection.ResumeLayout(false);
            this.tbpReflection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcTransformation;
        private System.Windows.Forms.TabPage tbpTranslation;
        private System.Windows.Forms.TabPage tbpScaling;
        private System.Windows.Forms.TabPage tbpRotation;
        private System.Windows.Forms.TabPage tbpReflection;
        private System.Windows.Forms.TextBox txtTranslationDy;
        private System.Windows.Forms.TextBox txtTranslationDx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtScalingConstant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRotationAngleInDegrees;
        private System.Windows.Forms.TextBox txtReflectionStartY;
        private System.Windows.Forms.TextBox txtReflectionStartX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReflectionEndY;
        private System.Windows.Forms.TextBox txtReflectionEndX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTransform;
        private System.Windows.Forms.Button btnCancel;
    }
}