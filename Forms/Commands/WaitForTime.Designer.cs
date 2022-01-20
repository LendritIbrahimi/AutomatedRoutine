namespace AutomatedRoutine
{
    partial class WaitForTime
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
            this.mtxTime = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mtxTime
            // 
            this.mtxTime.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxTime.HidePromptOnLeave = true;
            this.mtxTime.Location = new System.Drawing.Point(64, 10);
            this.mtxTime.Mask = "00000";
            this.mtxTime.Name = "mtxTime";
            this.mtxTime.PromptChar = ' ';
            this.mtxTime.Size = new System.Drawing.Size(100, 20);
            this.mtxTime.TabIndex = 5;
            this.mtxTime.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxTime.ValidatingType = typeof(int);
            this.mtxTime.Leave += new System.EventHandler(this.GiveValues);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Time:";
            // 
            // WaitForTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtxTime);
            this.Controls.Add(this.label3);
            this.Name = "WaitForTime";
            this.Size = new System.Drawing.Size(850, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox mtxTime;
        private System.Windows.Forms.Label label3;
    }
}
