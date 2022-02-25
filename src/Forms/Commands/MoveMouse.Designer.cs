namespace CommandUserControl
{
    partial class MoveMouse
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
            this.mtxXCord = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxYCord = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxTime = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chbIncrement = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // mtxXCord
            // 
            this.mtxXCord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxXCord.HidePromptOnLeave = true;
            this.mtxXCord.Location = new System.Drawing.Point(41, 35);
            this.mtxXCord.Margin = new System.Windows.Forms.Padding(4);
            this.mtxXCord.Name = "mtxXCord";
            this.mtxXCord.PromptChar = ' ';
            this.mtxXCord.Size = new System.Drawing.Size(67, 22);
            this.mtxXCord.TabIndex = 1;
            this.mtxXCord.Text = "0";
            this.mtxXCord.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxXCord.ValidatingType = typeof(int);
            this.mtxXCord.MouseEnter += new System.EventHandler(this.ClearNotEmpty);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "X:";
            // 
            // mtxYCord
            // 
            this.mtxYCord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxYCord.HidePromptOnLeave = true;
            this.mtxYCord.Location = new System.Drawing.Point(146, 35);
            this.mtxYCord.Margin = new System.Windows.Forms.Padding(4);
            this.mtxYCord.Name = "mtxYCord";
            this.mtxYCord.PromptChar = ' ';
            this.mtxYCord.Size = new System.Drawing.Size(68, 22);
            this.mtxYCord.TabIndex = 3;
            this.mtxYCord.Text = "0";
            this.mtxYCord.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(387, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Time in miliseconds:";
            // 
            // mtxTime
            // 
            this.mtxTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxTime.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxTime.HidePromptOnLeave = true;
            this.mtxTime.Location = new System.Drawing.Point(553, 35);
            this.mtxTime.Margin = new System.Windows.Forms.Padding(4);
            this.mtxTime.Name = "mtxTime";
            this.mtxTime.PromptChar = ' ';
            this.mtxTime.Size = new System.Drawing.Size(137, 22);
            this.mtxTime.TabIndex = 5;
            this.mtxTime.Text = "1000";
            this.mtxTime.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxTime.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(387, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Duration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Position";
            // 
            // chbIncrement
            // 
            this.chbIncrement.AutoSize = true;
            this.chbIncrement.BackColor = System.Drawing.Color.Transparent;
            this.chbIncrement.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chbIncrement.FlatAppearance.BorderSize = 2;
            this.chbIncrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbIncrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbIncrement.Location = new System.Drawing.Point(233, 35);
            this.chbIncrement.Name = "chbIncrement";
            this.chbIncrement.Size = new System.Drawing.Size(114, 24);
            this.chbIncrement.TabIndex = 7;
            this.chbIncrement.Text = "Incremental";
            this.chbIncrement.UseVisualStyleBackColor = false;
            // 
            // MoveMouse
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.chbIncrement);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtxTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtxYCord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtxXCord);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MoveMouse";
            this.Size = new System.Drawing.Size(715, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxXCord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxYCord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbIncrement;
    }
}
