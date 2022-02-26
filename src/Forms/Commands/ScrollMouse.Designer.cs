
namespace CommandUserControl
{
    partial class ScrollMouse
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
            this.lblY = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.MaskedTextBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(13, 37);
            this.lblY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(24, 20);
            this.lblY.TabIndex = 8;
            this.lblY.Text = "Y:";
            // 
            // txtDistance
            // 
            this.txtDistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDistance.HidePromptOnLeave = true;
            this.txtDistance.Location = new System.Drawing.Point(41, 35);
            this.txtDistance.Margin = new System.Windows.Forms.Padding(4);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.PromptChar = ' ';
            this.txtDistance.Size = new System.Drawing.Size(89, 22);
            this.txtDistance.TabIndex = 7;
            this.txtDistance.Text = "-25";
            this.txtDistance.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtDistance.ValidatingType = typeof(int);
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistance.Location = new System.Drawing.Point(11, 10);
            this.lblDistance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(76, 20);
            this.lblDistance.TabIndex = 6;
            this.lblDistance.Text = "Distance";
            // 
            // ScrollMouse
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.lblDistance);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ScrollMouse";
            this.Size = new System.Drawing.Size(715, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.MaskedTextBox txtDistance;
        private System.Windows.Forms.Label lblDistance;
    }
}
