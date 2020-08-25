namespace Blackjack
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.flowLayoutPanelPlayer = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelDealer = new System.Windows.Forms.FlowLayoutPanel();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hitButton = new System.Windows.Forms.Button();
            this.standButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelLoses = new System.Windows.Forms.Label();
            this.labelWin = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dealButton = new System.Windows.Forms.Button();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelPlayer
            // 
            this.flowLayoutPanelPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanelPlayer.AutoSize = true;
            this.flowLayoutPanelPlayer.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelPlayer.Location = new System.Drawing.Point(472, 97);
            this.flowLayoutPanelPlayer.Name = "flowLayoutPanelPlayer";
            this.flowLayoutPanelPlayer.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanelPlayer.TabIndex = 4;
            this.flowLayoutPanelPlayer.TabStop = true;
            // 
            // flowLayoutPanelDealer
            // 
            this.flowLayoutPanelDealer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanelDealer.AutoSize = true;
            this.flowLayoutPanelDealer.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelDealer.Location = new System.Drawing.Point(472, 97);
            this.flowLayoutPanelDealer.Name = "flowLayoutPanelDealer";
            this.flowLayoutPanelDealer.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanelDealer.TabIndex = 3;
            this.flowLayoutPanelDealer.TabStop = true;
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(944, 24);
            this.menuMain.TabIndex = 5;
            this.menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.onNewClicked);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rulesToolStripMenuItem,
            this.authorToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.rulesToolStripMenuItem.Text = "Rules";
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.authorToolStripMenuItem.Text = "Author";
            // 
            // hitButton
            // 
            this.hitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.hitButton.FlatAppearance.BorderSize = 0;
            this.hitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hitButton.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitButton.Location = new System.Drawing.Point(360, 6);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(72, 72);
            this.hitButton.TabIndex = 6;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = false;
            this.hitButton.Click += new System.EventHandler(this.onHitButtonClick);
            // 
            // standButton
            // 
            this.standButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.standButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.standButton.FlatAppearance.BorderSize = 0;
            this.standButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.standButton.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standButton.Location = new System.Drawing.Point(438, 6);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(72, 72);
            this.standButton.TabIndex = 7;
            this.standButton.Text = "Stand";
            this.standButton.UseVisualStyleBackColor = false;
            this.standButton.Click += new System.EventHandler(this.onStandButtonClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(50)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.dealButton);
            this.panel1.Controls.Add(this.labelLoses);
            this.panel1.Controls.Add(this.labelWin);
            this.panel1.Controls.Add(this.standButton);
            this.panel1.Controls.Add(this.hitButton);
            this.panel1.Location = new System.Drawing.Point(0, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 85);
            this.panel1.TabIndex = 8;
            // 
            // labelLoses
            // 
            this.labelLoses.AutoSize = true;
            this.labelLoses.BackColor = System.Drawing.Color.Transparent;
            this.labelLoses.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoses.ForeColor = System.Drawing.Color.White;
            this.labelLoses.Location = new System.Drawing.Point(3, 42);
            this.labelLoses.Name = "labelLoses";
            this.labelLoses.Size = new System.Drawing.Size(91, 32);
            this.labelLoses.TabIndex = 9;
            this.labelLoses.Text = "Loses:0";
            // 
            // labelWin
            // 
            this.labelWin.AutoSize = true;
            this.labelWin.BackColor = System.Drawing.Color.Transparent;
            this.labelWin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWin.ForeColor = System.Drawing.Color.White;
            this.labelWin.Location = new System.Drawing.Point(3, 10);
            this.labelWin.Name = "labelWin";
            this.labelWin.Size = new System.Drawing.Size(85, 32);
            this.labelWin.TabIndex = 8;
            this.labelWin.Text = "Wins:0";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelPlayer, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 223);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(944, 195);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanelDealer, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(944, 195);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // dealButton
            // 
            this.dealButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dealButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dealButton.FlatAppearance.BorderSize = 0;
            this.dealButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dealButton.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealButton.Location = new System.Drawing.Point(516, 6);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(72, 72);
            this.dealButton.TabIndex = 10;
            this.dealButton.Text = "Deal";
            this.dealButton.UseVisualStyleBackColor = false;
            this.dealButton.Click += new System.EventHandler(this.onDealButtonClicked);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.onCloseButtonClicked);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuMain;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.Text = "Blackjack";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPlayer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDealer;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelWin;
        private System.Windows.Forms.Label labelLoses;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

