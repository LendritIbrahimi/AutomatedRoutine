
partial class EntryPoint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryPoint));
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlRepetitions = new System.Windows.Forms.Panel();
            this.txtRepetitions = new System.Windows.Forms.TextBox();
            this.pnlCheckbox = new System.Windows.Forms.Panel();
            this.chbRepetitionType = new System.Windows.Forms.ComboBox();
            this.lblRepetitions = new System.Windows.Forms.Label();
            this.pnlFinished = new System.Windows.Forms.Panel();
            this.pnlFinishedCheck = new System.Windows.Forms.Panel();
            this.chbFinished = new System.Windows.Forms.ComboBox();
            this.lblFinished = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBetweenSteps = new System.Windows.Forms.Label();
            this.txtStepTime = new System.Windows.Forms.TextBox();
            this.lblExtension = new System.Windows.Forms.Label();
            this.pnlContainer.SuspendLayout();
            this.pnlRepetitions.SuspendLayout();
            this.pnlCheckbox.SuspendLayout();
            this.pnlFinished.SuspendLayout();
            this.pnlFinishedCheck.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContainer.SetFlowBreak(this.label2, true);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Steps";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.SeaGreen;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(13, 547);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(164, 52);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.BackColor = System.Drawing.Color.White;
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContainer.Controls.Add(this.label2);
            this.pnlContainer.Location = new System.Drawing.Point(13, 47);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(6);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.pnlContainer.Size = new System.Drawing.Size(1060, 405);
            this.pnlContainer.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(913, 547);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 38);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "+ Add Another";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlRepetitions
            // 
            this.pnlRepetitions.BackColor = System.Drawing.Color.White;
            this.pnlRepetitions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRepetitions.Controls.Add(this.txtRepetitions);
            this.pnlRepetitions.Controls.Add(this.pnlCheckbox);
            this.pnlRepetitions.Controls.Add(this.lblRepetitions);
            this.pnlRepetitions.Location = new System.Drawing.Point(13, 462);
            this.pnlRepetitions.Margin = new System.Windows.Forms.Padding(6);
            this.pnlRepetitions.Name = "pnlRepetitions";
            this.pnlRepetitions.Padding = new System.Windows.Forms.Padding(8, 8, 4, 4);
            this.pnlRepetitions.Size = new System.Drawing.Size(364, 75);
            this.pnlRepetitions.TabIndex = 8;
            // 
            // txtRepetitions
            // 
            this.txtRepetitions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRepetitions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepetitions.Location = new System.Drawing.Point(205, 36);
            this.txtRepetitions.Name = "txtRepetitions";
            this.txtRepetitions.Size = new System.Drawing.Size(121, 24);
            this.txtRepetitions.TabIndex = 16;
            this.txtRepetitions.Text = "1";
            // 
            // pnlCheckbox
            // 
            this.pnlCheckbox.BackColor = System.Drawing.Color.DarkGray;
            this.pnlCheckbox.Controls.Add(this.chbRepetitionType);
            this.pnlCheckbox.Location = new System.Drawing.Point(11, 35);
            this.pnlCheckbox.Name = "pnlCheckbox";
            this.pnlCheckbox.Size = new System.Drawing.Size(188, 26);
            this.pnlCheckbox.TabIndex = 15;
            // 
            // chbRepetitionType
            // 
            this.chbRepetitionType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chbRepetitionType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbRepetitionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chbRepetitionType.Enabled = false;
            this.chbRepetitionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbRepetitionType.FormattingEnabled = true;
            this.chbRepetitionType.Items.AddRange(new object[] {
            "Number of repetitions",
            "Infinite repetition"});
            this.chbRepetitionType.Location = new System.Drawing.Point(0, 0);
            this.chbRepetitionType.Name = "chbRepetitionType";
            this.chbRepetitionType.Size = new System.Drawing.Size(188, 26);
            this.chbRepetitionType.TabIndex = 13;
            this.chbRepetitionType.Tag = "";
            this.chbRepetitionType.SelectedIndexChanged += new System.EventHandler(this.chbRepetitionType_SelectedIndexChanged);
            // 
            // lblRepetitions
            // 
            this.lblRepetitions.AutoSize = true;
            this.lblRepetitions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRepetitions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepetitions.Location = new System.Drawing.Point(8, 8);
            this.lblRepetitions.Margin = new System.Windows.Forms.Padding(4);
            this.lblRepetitions.Name = "lblRepetitions";
            this.lblRepetitions.Size = new System.Drawing.Size(93, 20);
            this.lblRepetitions.TabIndex = 3;
            this.lblRepetitions.Text = "Repetitions";
            // 
            // pnlFinished
            // 
            this.pnlFinished.BackColor = System.Drawing.Color.White;
            this.pnlFinished.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFinished.Controls.Add(this.pnlFinishedCheck);
            this.pnlFinished.Controls.Add(this.lblFinished);
            this.pnlFinished.Location = new System.Drawing.Point(773, 462);
            this.pnlFinished.Margin = new System.Windows.Forms.Padding(6);
            this.pnlFinished.Name = "pnlFinished";
            this.pnlFinished.Padding = new System.Windows.Forms.Padding(8, 8, 4, 4);
            this.pnlFinished.Size = new System.Drawing.Size(299, 75);
            this.pnlFinished.TabIndex = 9;
            // 
            // pnlFinishedCheck
            // 
            this.pnlFinishedCheck.BackColor = System.Drawing.Color.DarkGray;
            this.pnlFinishedCheck.Controls.Add(this.chbFinished);
            this.pnlFinishedCheck.Location = new System.Drawing.Point(12, 35);
            this.pnlFinishedCheck.Name = "pnlFinishedCheck";
            this.pnlFinishedCheck.Size = new System.Drawing.Size(230, 26);
            this.pnlFinishedCheck.TabIndex = 16;
            // 
            // chbFinished
            // 
            this.chbFinished.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chbFinished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbFinished.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chbFinished.Enabled = false;
            this.chbFinished.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFinished.FormattingEnabled = true;
            this.chbFinished.Items.AddRange(new object[] {
            "No Action",
            "Close Application",
            "Close & Save Application",
            "Clear Steps",
            "Shutdown"});
            this.chbFinished.Location = new System.Drawing.Point(0, 0);
            this.chbFinished.Name = "chbFinished";
            this.chbFinished.Size = new System.Drawing.Size(230, 26);
            this.chbFinished.TabIndex = 13;
            // 
            // lblFinished
            // 
            this.lblFinished.AutoSize = true;
            this.lblFinished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFinished.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinished.Location = new System.Drawing.Point(8, 8);
            this.lblFinished.Margin = new System.Windows.Forms.Padding(4);
            this.lblFinished.Name = "lblFinished";
            this.lblFinished.Size = new System.Drawing.Size(117, 20);
            this.lblFinished.TabIndex = 3;
            this.lblFinished.Text = "After Finishing";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOpen,
            this.tsSave,
            this.tsExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsOpen
            // 
            this.tsOpen.Name = "tsOpen";
            this.tsOpen.Size = new System.Drawing.Size(128, 26);
            this.tsOpen.Text = "Open";
            this.tsOpen.Click += new System.EventHandler(this.tsOpen_Click);
            // 
            // tsSave
            // 
            this.tsSave.Image = global::AutomatedRoutine.Properties.Resources.save;
            this.tsSave.Name = "tsSave";
            this.tsSave.Size = new System.Drawing.Size(128, 26);
            this.tsSave.Text = "Save";
            this.tsSave.Click += new System.EventHandler(this.tsSave_Click);
            // 
            // tsExit
            // 
            this.tsExit.Name = "tsExit";
            this.tsExit.Size = new System.Drawing.Size(128, 26);
            this.tsExit.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1087, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblBetweenSteps);
            this.panel1.Controls.Add(this.txtStepTime);
            this.panel1.Controls.Add(this.lblExtension);
            this.panel1.Location = new System.Drawing.Point(389, 462);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8, 8, 4, 4);
            this.panel1.Size = new System.Drawing.Size(372, 75);
            this.panel1.TabIndex = 17;
            // 
            // lblBetweenSteps
            // 
            this.lblBetweenSteps.AutoSize = true;
            this.lblBetweenSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetweenSteps.Location = new System.Drawing.Point(8, 37);
            this.lblBetweenSteps.Margin = new System.Windows.Forms.Padding(4);
            this.lblBetweenSteps.Name = "lblBetweenSteps";
            this.lblBetweenSteps.Size = new System.Drawing.Size(216, 20);
            this.lblBetweenSteps.TabIndex = 17;
            this.lblBetweenSteps.Text = "Miliseconds between steps:";
            // 
            // txtStepTime
            // 
            this.txtStepTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStepTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStepTime.Location = new System.Drawing.Point(226, 36);
            this.txtStepTime.Name = "txtStepTime";
            this.txtStepTime.Size = new System.Drawing.Size(107, 24);
            this.txtStepTime.TabIndex = 16;
            this.txtStepTime.Text = "250";
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblExtension.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtension.Location = new System.Drawing.Point(8, 8);
            this.lblExtension.Margin = new System.Windows.Forms.Padding(4);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(91, 20);
            this.lblExtension.TabIndex = 3;
            this.lblExtension.Text = "Extensions";
            // 
            // EntryPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1087, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlFinished);
            this.Controls.Add(this.pnlRepetitions);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "EntryPoint";
            this.Text = "AutomatedRoutine";
            this.Load += new System.EventHandler(this.EntryPoint_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EntryPoint_KeyDown);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.pnlRepetitions.ResumeLayout(false);
            this.pnlRepetitions.PerformLayout();
            this.pnlCheckbox.ResumeLayout(false);
            this.pnlFinished.ResumeLayout(false);
            this.pnlFinished.PerformLayout();
            this.pnlFinishedCheck.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.FlowLayoutPanel pnlContainer;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Panel pnlRepetitions;
    private System.Windows.Forms.Label lblRepetitions;
    private System.Windows.Forms.Panel pnlFinished;
    private System.Windows.Forms.Label lblFinished;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem tsOpen;
    private System.Windows.Forms.ToolStripMenuItem tsSave;
    private System.Windows.Forms.ToolStripMenuItem tsExit;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.Panel pnlCheckbox;
    private System.Windows.Forms.ComboBox chbRepetitionType;
    private System.Windows.Forms.TextBox txtRepetitions;
    private System.Windows.Forms.Panel pnlFinishedCheck;
    private System.Windows.Forms.ComboBox chbFinished;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label lblExtension;
    private System.Windows.Forms.Label lblBetweenSteps;
    private System.Windows.Forms.TextBox txtStepTime;
}

