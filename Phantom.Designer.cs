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
            this.ButtonMusic = new System.Windows.Forms.Button();
            this.ButtonCredits = new System.Windows.Forms.Button();
            this.ButtonQuit = new System.Windows.Forms.Button();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.lblDialog = new System.Windows.Forms.Label();
            this.dialogueTimer = new System.Windows.Forms.Timer(this.components);
            this.transitionTimer = new System.Windows.Forms.Timer(this.components);
            this.lblCenter = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.menuTimer = new System.Windows.Forms.Timer(this.components);
            this.creditsTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ButtonMusic
            // 
            this.ButtonMusic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonMusic.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMusic.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonMusic.FlatAppearance.BorderSize = 0;
            this.ButtonMusic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonMusic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMusic.Font = new System.Drawing.Font("Unispace", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMusic.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonMusic.Location = new System.Drawing.Point(12, 551);
            this.ButtonMusic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonMusic.Name = "ButtonMusic";
            this.ButtonMusic.Size = new System.Drawing.Size(147, 39);
            this.ButtonMusic.TabIndex = 2;
            this.ButtonMusic.TabStop = false;
            this.ButtonMusic.Text = "music";
            this.ButtonMusic.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ButtonMusic.UseVisualStyleBackColor = false;
            this.ButtonMusic.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButtonMusic_KeyDown);
            this.ButtonMusic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonMusic_MouseClick);
            this.ButtonMusic.MouseEnter += new System.EventHandler(this.ButtonOptions_MouseEnter);
            this.ButtonMusic.MouseLeave += new System.EventHandler(this.ButtonOptions_MouseLeave);
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
            this.ButtonCredits.Location = new System.Drawing.Point(488, 551);
            this.ButtonCredits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonCredits.Name = "ButtonCredits";
            this.ButtonCredits.Size = new System.Drawing.Size(172, 34);
            this.ButtonCredits.TabIndex = 3;
            this.ButtonCredits.TabStop = false;
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
            this.ButtonQuit.Location = new System.Drawing.Point(1029, 551);
            this.ButtonQuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonQuit.Name = "ButtonQuit";
            this.ButtonQuit.Size = new System.Drawing.Size(109, 39);
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
            this.ButtonStart.Font = new System.Drawing.Font("Unispace", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStart.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonStart.Location = new System.Drawing.Point(399, 281);
            this.ButtonStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(397, 117);
            this.ButtonStart.TabIndex = 5;
            this.ButtonStart.TabStop = false;
            this.ButtonStart.Text = "accept";
            this.ButtonStart.UseVisualStyleBackColor = false;
            this.ButtonStart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonStart_MouseClick);
            this.ButtonStart.MouseEnter += new System.EventHandler(this.ButtonStart_MouseEnter);
            this.ButtonStart.MouseLeave += new System.EventHandler(this.ButtonStart_MouseLeave);
            // 
            // lblDialog
            // 
            this.lblDialog.BackColor = System.Drawing.Color.Transparent;
            this.lblDialog.Font = new System.Drawing.Font("Unispace", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDialog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDialog.Location = new System.Drawing.Point(61, 409);
            this.lblDialog.Name = "lblDialog";
            this.lblDialog.Size = new System.Drawing.Size(1029, 122);
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
            this.lblCenter.Location = new System.Drawing.Point(61, 231);
            this.lblCenter.Name = "lblCenter";
            this.lblCenter.Size = new System.Drawing.Size(1029, 122);
            this.lblCenter.TabIndex = 8;
            this.lblCenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCenter.Visible = false;
            // 
            // lblMenu
            // 
            this.lblMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblMenu.Font = new System.Drawing.Font("Unispace", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMenu.Location = new System.Drawing.Point(289, 82);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(607, 122);
            this.lblMenu.TabIndex = 9;
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuTimer
            // 
            this.menuTimer.Interval = 30;
            this.menuTimer.Tick += new System.EventHandler(this.menuTimer_Tick);
            // 
            // creditsTimer
            // 
            this.creditsTimer.Interval = 30;
            this.creditsTimer.Tick += new System.EventHandler(this.creditsTimer_Tick);
            // 
            // Phantom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1152, 598);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblCenter);
            this.Controls.Add(this.lblDialog);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.ButtonQuit);
            this.Controls.Add(this.ButtonCredits);
            this.Controls.Add(this.ButtonMusic);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Phantom";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phantom";
            this.TopMost = true;
            this.FontChanged += new System.EventHandler(this.Phantom_FontChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Phantom_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Phantom_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonMusic;
        private System.Windows.Forms.Button ButtonCredits;
        private System.Windows.Forms.Button ButtonQuit;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Label lblDialog;
        private System.Windows.Forms.Timer dialogueTimer;
        private System.Windows.Forms.Timer transitionTimer;
        private System.Windows.Forms.Label lblCenter;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Timer menuTimer;
        private System.Windows.Forms.Timer creditsTimer;
    }
}