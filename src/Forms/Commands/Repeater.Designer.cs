
namespace CommandUserControl
{
    partial class Loop
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
            this.lnlRepetitions = new System.Windows.Forms.Label();
            this.txtRepeat = new System.Windows.Forms.MaskedTextBox();
            this.lblRepeat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lnlRepetitions
            // 
            this.lnlRepetitions.AutoSize = true;
            this.lnlRepetitions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlRepetitions.Location = new System.Drawing.Point(11, 37);
            this.lnlRepetitions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnlRepetitions.Name = "lnlRepetitions";
            this.lnlRepetitions.Size = new System.Drawing.Size(175, 20);
            this.lnlRepetitions.TabIndex = 8;
            this.lnlRepetitions.Text = "Number of repetitions:";
            // 
            // txtRepeat
            // 
            this.txtRepeat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRepeat.HidePromptOnLeave = true;
            this.txtRepeat.Location = new System.Drawing.Point(194, 35);
            this.txtRepeat.Margin = new System.Windows.Forms.Padding(4);
            this.txtRepeat.Name = "txtRepeat";
            this.txtRepeat.PromptChar = ' ';
            this.txtRepeat.Size = new System.Drawing.Size(164, 22);
            this.txtRepeat.TabIndex = 7;
            this.txtRepeat.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtRepeat.ValidatingType = typeof(int);
            // 
            // lblRepeat
            // 
            this.lblRepeat.AutoSize = true;
            this.lblRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepeat.Location = new System.Drawing.Point(11, 10);
            this.lblRepeat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRepeat.Name = "lblRepeat";
            this.lblRepeat.Size = new System.Drawing.Size(62, 20);
            this.lblRepeat.TabIndex = 6;
            this.lblRepeat.Text = "Repeat";
            // 
            // Loop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lnlRepetitions);
            this.Controls.Add(this.txtRepeat);
            this.Controls.Add(this.lblRepeat);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Loop";
            this.Size = new System.Drawing.Size(715, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lnlRepetitions;
        private System.Windows.Forms.MaskedTextBox txtRepeat;
        private System.Windows.Forms.Label lblRepeat;
    }
}
