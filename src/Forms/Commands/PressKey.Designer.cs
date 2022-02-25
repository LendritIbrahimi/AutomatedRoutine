namespace CommandUserControl
{
    partial class PressKey
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKey1 = new System.Windows.Forms.ComboBox();
            this.pnlCheckbox1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pnlCheckbox2 = new System.Windows.Forms.Panel();
            this.cmbKey2 = new System.Windows.Forms.ComboBox();
            this.pnlCheckbox3 = new System.Windows.Forms.Panel();
            this.cmbKey3 = new System.Windows.Forms.ComboBox();
            this.pnlCheckbox1.SuspendLayout();
            this.pnlCheckbox2.SuspendLayout();
            this.pnlCheckbox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Key Combination";
            // 
            // cmbKey1
            // 
            this.cmbKey1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbKey1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbKey1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKey1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKey1.FormattingEnabled = true;
            this.cmbKey1.Location = new System.Drawing.Point(0, 0);
            this.cmbKey1.Name = "cmbKey1";
            this.cmbKey1.Size = new System.Drawing.Size(131, 24);
            this.cmbKey1.TabIndex = 13;
            // 
            // pnlCheckbox1
            // 
            this.pnlCheckbox1.BackColor = System.Drawing.Color.DarkGray;
            this.pnlCheckbox1.Controls.Add(this.cmbKey1);
            this.pnlCheckbox1.Location = new System.Drawing.Point(22, 36);
            this.pnlCheckbox1.Name = "pnlCheckbox1";
            this.pnlCheckbox1.Size = new System.Drawing.Size(131, 24);
            this.pnlCheckbox1.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(546, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 31);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "+ Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRemove.Location = new System.Drawing.Point(617, 29);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(89, 31);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "- Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // pnlCheckbox2
            // 
            this.pnlCheckbox2.BackColor = System.Drawing.Color.DarkGray;
            this.pnlCheckbox2.Controls.Add(this.cmbKey2);
            this.pnlCheckbox2.Location = new System.Drawing.Point(159, 36);
            this.pnlCheckbox2.Name = "pnlCheckbox2";
            this.pnlCheckbox2.Size = new System.Drawing.Size(131, 24);
            this.pnlCheckbox2.TabIndex = 14;
            this.pnlCheckbox2.Visible = false;
            // 
            // cmbKey2
            // 
            this.cmbKey2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbKey2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbKey2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKey2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKey2.FormattingEnabled = true;
            this.cmbKey2.Location = new System.Drawing.Point(0, 0);
            this.cmbKey2.Name = "cmbKey2";
            this.cmbKey2.Size = new System.Drawing.Size(131, 24);
            this.cmbKey2.TabIndex = 13;
            // 
            // pnlCheckbox3
            // 
            this.pnlCheckbox3.BackColor = System.Drawing.Color.DarkGray;
            this.pnlCheckbox3.Controls.Add(this.cmbKey3);
            this.pnlCheckbox3.Location = new System.Drawing.Point(296, 36);
            this.pnlCheckbox3.Name = "pnlCheckbox3";
            this.pnlCheckbox3.Size = new System.Drawing.Size(131, 24);
            this.pnlCheckbox3.TabIndex = 14;
            this.pnlCheckbox3.Visible = false;
            // 
            // cmbKey3
            // 
            this.cmbKey3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbKey3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbKey3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKey3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKey3.FormattingEnabled = true;
            this.cmbKey3.Location = new System.Drawing.Point(0, 0);
            this.cmbKey3.Name = "cmbKey3";
            this.cmbKey3.Size = new System.Drawing.Size(131, 24);
            this.cmbKey3.TabIndex = 13;
            // 
            // PressKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnlCheckbox1);
            this.Controls.Add(this.pnlCheckbox2);
            this.Controls.Add(this.pnlCheckbox3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PressKey";
            this.Size = new System.Drawing.Size(715, 70);
            this.pnlCheckbox1.ResumeLayout(false);
            this.pnlCheckbox2.ResumeLayout(false);
            this.pnlCheckbox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKey1;
        private System.Windows.Forms.Panel pnlCheckbox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel pnlCheckbox2;
        private System.Windows.Forms.ComboBox cmbKey2;
        private System.Windows.Forms.Panel pnlCheckbox3;
        private System.Windows.Forms.ComboBox cmbKey3;
    }
}
