namespace CommandUserControl
{
    partial class ScrollWheel
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
            this.mtxYCord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(10, 6);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(25, 23);
            this.lblY.TabIndex = 4;
            this.lblY.Text = "Y:";
            // 
            // mtxYCord
            // 
            this.mtxYCord.Location = new System.Drawing.Point(41, 9);
            this.mtxYCord.Name = "mtxYCord";
            this.mtxYCord.Size = new System.Drawing.Size(100, 20);
            this.mtxYCord.TabIndex = 6;
            this.mtxYCord.Leave += new System.EventHandler(this.MtxYCord_Leave);
            // 
            // ScrollWheel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtxYCord);
            this.Controls.Add(this.lblY);
            this.Name = "ScrollWheel";
            this.Size = new System.Drawing.Size(850, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox mtxYCord;
    }
}
