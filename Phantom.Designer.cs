namespace Phantom
{
    partial class Phantom
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phantom));
            this.ButtonOptions = new System.Windows.Forms.Button();
            this.ButtonCredits = new System.Windows.Forms.Button();
            this.ButtonQuit = new System.Windows.Forms.Button();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.lblDialog = new System.Windows.Forms.Label();
            this.dialogueTimer = new System.Windows.Forms.Timer(this.components);
            this.transitionTimer = new System.Windows.Forms.Timer(this.components);
            this.lblCenter = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.genericTimer = new System.Windows.Forms.Timer(this.components);
            this.creditsTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ButtonOptions
            // 
            this.ButtonOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonOptions.BackColor = System.Drawing.Color.Black;
            this.ButtonOptions.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonOptions.FlatAppearance.BorderSize = 0;
            this.ButtonOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.ButtonOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.ButtonOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOptions.Font = new System.Drawing.Font("Unispace", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOptions.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonOptions.Location = new System.Drawing.Point(9, 448);
            this.ButtonOptions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonOptions.Name = "ButtonOptions";
            this.ButtonOptions.Size = new System.Drawing.Size(110, 32);
            this.ButtonOptions.TabIndex = 2;
            this.ButtonOptions.Text = "options";
            this.ButtonOptions.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ButtonOptions.UseVisualStyleBackColor = false;
            this.ButtonOptions.MouseEnter += new System.EventHandler(this.ButtonOptions_MouseEnter);
            this.ButtonOptions.MouseLeave += new System.EventHandler(this.ButtonOptions_MouseLeave);
            // 
            // ButtonCredits
            // 
            this.ButtonCredits.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonCredits.BackColor = System.Drawing.Color.Black;
            this.ButtonCredits.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonCredits.FlatAppearance.BorderSize = 0;
            this.ButtonCredits.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.ButtonCredits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.ButtonCredits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCredits.Font = new System.Drawing.Font("Unispace", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCredits.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonCredits.Location = new System.Drawing.Point(366, 448);
            this.ButtonCredits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonCredits.Name = "ButtonCredits";
            this.ButtonCredits.Size = new System.Drawing.Size(129, 28);
            this.ButtonCredits.TabIndex = 3;
            this.ButtonCredits.Text = "credits";
            this.ButtonCredits.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonCredits.UseVisualStyleBackColor = false;
            this.ButtonCredits.Click += new System.EventHandler(this.ButtonCredits_Click);
            this.ButtonCredits.MouseEnter += new System.EventHandler(this.ButtonCredits_MouseEnter);
            this.ButtonCredits.MouseLeave += new System.EventHandler(this.ButtonCredits_MouseLeave);
            // 
            // ButtonQuit
            // 
            this.ButtonQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonQuit.BackColor = System.Drawing.Color.Transparent;
            this.ButtonQuit.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonQuit.FlatAppearance.BorderSize = 0;
            this.ButtonQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonQuit.Font = new System.Drawing.Font("Unispace", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonQuit.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonQuit.Location = new System.Drawing.Point(772, 448);
            this.ButtonQuit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonQuit.Name = "ButtonQuit";
            this.ButtonQuit.Size = new System.Drawing.Size(82, 32);
            this.ButtonQuit.TabIndex = 4;
            this.ButtonQuit.TabStop = false;
            this.ButtonQuit.Text = "quit";
            this.ButtonQuit.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.ButtonQuit.UseVisualStyleBackColor = false;
            this.ButtonQuit.Click += new System.EventHandler(this.ButtonQuit_Click);
            this.ButtonQuit.MouseEnter += new System.EventHandler(this.ButtonQuit_MouseEnter);
            this.ButtonQuit.MouseLeave += new System.EventHandler(this.ButtonQuit_MouseLeave);
            // 
            // ButtonStart
            // 
            this.ButtonStart.BackColor = System.Drawing.Color.Transparent;
            this.ButtonStart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonStart.FlatAppearance.BorderSize = 0;
            this.ButtonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.ButtonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.ButtonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStart.Font = new System.Drawing.Font("Unispace", 50F, System.Drawing.FontStyle.Bold);
            this.ButtonStart.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonStart.Location = new System.Drawing.Point(299, 228);
            this.ButtonStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(298, 95);
            this.ButtonStart.TabIndex = 5;
            this.ButtonStart.Text = "accept";
            this.ButtonStart.UseVisualStyleBackColor = false;
            this.ButtonStart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonStart_MouseClick);
            this.ButtonStart.MouseEnter += new System.EventHandler(this.ButtonStart_MouseEnter);
            this.ButtonStart.MouseLeave += new System.EventHandler(this.ButtonStart_MouseLeave);
            // 
            // lblDialog
            // 
            this.lblDialog.BackColor = System.Drawing.Color.Transparent;
            this.lblDialog.Font = new System.Drawing.Font("Unispace", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDialog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDialog.Location = new System.Drawing.Point(46, 332);
            this.lblDialog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDialog.Name = "lblDialog";
            this.lblDialog.Size = new System.Drawing.Size(772, 99);
            this.lblDialog.TabIndex = 7;
            this.lblDialog.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblDialog_MouseClick);
            // 
            // dialogueTimer
            // 
            this.dialogueTimer.Interval = 20;
            this.dialogueTimer.Tick += new System.EventHandler(this.dialogueTimer_Tick);
            // 
            // transitionTimer
            // 
            this.transitionTimer.Interval = 10;
            this.transitionTimer.Tick += new System.EventHandler(this.sceneTimer_Tick);
            // 
            // lblCenter
            // 
            this.lblCenter.BackColor = System.Drawing.Color.Transparent;
            this.lblCenter.Font = new System.Drawing.Font("Unispace", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCenter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCenter.Location = new System.Drawing.Point(46, 188);
            this.lblCenter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCenter.Name = "lblCenter";
            this.lblCenter.Size = new System.Drawing.Size(772, 99);
            this.lblCenter.TabIndex = 8;
            this.lblCenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCenter.Visible = false;
            // 
            // lblMenu
            // 
            this.lblMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblMenu.Font = new System.Drawing.Font("Unispace", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMenu.Location = new System.Drawing.Point(217, 67);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(455, 99);
            this.lblMenu.TabIndex = 9;
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genericTimer
            // 
            this.genericTimer.Interval = 30;
            this.genericTimer.Tick += new System.EventHandler(this.menuTimer_Tick);
            // 
            // creditsTimer
            // 
            this.creditsTimer.Interval = 30;
            this.creditsTimer.Tick += new System.EventHandler(this.creditsTimer_Tick);
            // 
            // Phantom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(864, 486);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblCenter);
            this.Controls.Add(this.lblDialog);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.ButtonQuit);
            this.Controls.Add(this.ButtonCredits);
            this.Controls.Add(this.ButtonOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Phantom";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phantom";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Phantom_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Phantom_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonOptions;
        private System.Windows.Forms.Button ButtonCredits;
        private System.Windows.Forms.Button ButtonQuit;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Label lblDialog;
        private System.Windows.Forms.Timer dialogueTimer;
        private System.Windows.Forms.Timer transitionTimer;
        private System.Windows.Forms.Label lblCenter;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Timer genericTimer;
        private System.Windows.Forms.Timer creditsTimer;
    }
}