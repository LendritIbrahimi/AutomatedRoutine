namespace AutomatedRoutine
{
    partial class ColorSelect
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colMain = new System.Windows.Forms.ColorDialog();
            this.btnShowColor = new System.Windows.Forms.Button();
            this.pnlShowColor = new System.Windows.Forms.Panel();
            this.mtxSkips = new System.Windows.Forms.MaskedTextBox();
            this.lblSkipLoop = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbX = new System.Windows.Forms.CheckBox();
            this.ckbY = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // colMain
            // 
            this.colMain.AnyColor = true;
            this.colMain.Color = System.Drawing.Color.DodgerBlue;
            // 
            // btnShowColor
            // 
            this.btnShowColor.Location = new System.Drawing.Point(20, 11);
            this.btnShowColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowColor.Name = "btnShowColor";
            this.btnShowColor.Size = new System.Drawing.Size(171, 28);
            this.btnShowColor.TabIndex = 0;
            this.btnShowColor.Text = "Open Color Palette";
            this.btnShowColor.UseVisualStyleBackColor = true;
            this.btnShowColor.Click += new System.EventHandler(this.BtnShowColor_Click);
            // 
            // pnlShowColor
            // 
            this.pnlShowColor.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlShowColor.Location = new System.Drawing.Point(352, 11);
            this.pnlShowColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlShowColor.Name = "pnlShowColor";
            this.pnlShowColor.Size = new System.Drawing.Size(41, 28);
            this.pnlShowColor.TabIndex = 1;
            // 
            // mtxSkips
            // 
            this.mtxSkips.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxSkips.HidePromptOnLeave = true;
            this.mtxSkips.Location = new System.Drawing.Point(645, 16);
            this.mtxSkips.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxSkips.Mask = "00000";
            this.mtxSkips.Name = "mtxSkips";
            this.mtxSkips.PromptChar = ' ';
            this.mtxSkips.Size = new System.Drawing.Size(132, 22);
            this.mtxSkips.TabIndex = 7;
            this.mtxSkips.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxSkips.ValidatingType = typeof(int);
            this.mtxSkips.Leave += new System.EventHandler(this.MtxSkips_Leave);
            // 
            // lblSkipLoop
            // 
            this.lblSkipLoop.AutoSize = true;
            this.lblSkipLoop.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkipLoop.Location = new System.Drawing.Point(448, 11);
            this.lblSkipLoop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSkipLoop.Name = "lblSkipLoop";
            this.lblSkipLoop.Size = new System.Drawing.Size(182, 29);
            this.lblSkipLoop.TabIndex = 6;
            this.lblSkipLoop.Text = "Command Skips:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Color:";
            // 
            // ckbX
            // 
            this.ckbX.AutoSize = true;
            this.ckbX.Location = new System.Drawing.Point(794, 11);
            this.ckbX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbX.Name = "ckbX";
            this.ckbX.Size = new System.Drawing.Size(36, 21);
            this.ckbX.TabIndex = 8;
            this.ckbX.Text = "x";
            this.ckbX.UseVisualStyleBackColor = true;
            this.ckbX.CheckedChanged += new System.EventHandler(this.CkbX_CheckedChanged);
            // 
            // ckbY
            // 
            this.ckbY.AutoSize = true;
            this.ckbY.Location = new System.Drawing.Point(838, 11);
            this.ckbY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbY.Name = "ckbY";
            this.ckbY.Size = new System.Drawing.Size(37, 21);
            this.ckbY.TabIndex = 9;
            this.ckbY.Text = "y";
            this.ckbY.UseVisualStyleBackColor = true;
            this.ckbY.CheckedChanged += new System.EventHandler(this.CkbY_CheckedChanged);
            // 
            // ColorSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ckbY);
            this.Controls.Add(this.ckbX);
            this.Controls.Add(this.mtxSkips);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSkipLoop);
            this.Controls.Add(this.pnlShowColor);
            this.Controls.Add(this.btnShowColor);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ColorSelect";
            this.Size = new System.Drawing.Size(1133, 49);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colMain;
        private System.Windows.Forms.Button btnShowColor;
        private System.Windows.Forms.Panel pnlShowColor;
        private System.Windows.Forms.MaskedTextBox mtxSkips;
        private System.Windows.Forms.Label lblSkipLoop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbX;
        private System.Windows.Forms.CheckBox ckbY;
    }
}
