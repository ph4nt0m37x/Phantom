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
            this.ButtonOptions = new System.Windows.Forms.Button();
            this.ButtonCredits = new System.Windows.Forms.Button();
            this.ButtonQuit = new System.Windows.Forms.Button();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.lblDialog = new System.Windows.Forms.Label();
            this.dialogueTimer = new System.Windows.Forms.Timer(this.components);
            this.sceneTimer = new System.Windows.Forms.Timer(this.components);
            this.lblCenter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonOptions
            // 
            this.ButtonOptions.BackColor = System.Drawing.Color.Black;
            this.ButtonOptions.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonOptions.FlatAppearance.BorderSize = 0;
            this.ButtonOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.ButtonOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.ButtonOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOptions.Font = new System.Drawing.Font("Unispace", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOptions.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonOptions.Location = new System.Drawing.Point(12, 601);
            this.ButtonOptions.Name = "ButtonOptions";
            this.ButtonOptions.Size = new System.Drawing.Size(146, 40);
            this.ButtonOptions.TabIndex = 2;
            this.ButtonOptions.Text = "options";
            this.ButtonOptions.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ButtonOptions.UseVisualStyleBackColor = false;
            this.ButtonOptions.MouseEnter += new System.EventHandler(this.ButtonOptions_MouseEnter);
            this.ButtonOptions.MouseLeave += new System.EventHandler(this.ButtonOptions_MouseLeave);
            // 
            // ButtonCredits
            // 
            this.ButtonCredits.BackColor = System.Drawing.Color.Black;
            this.ButtonCredits.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonCredits.FlatAppearance.BorderSize = 0;
            this.ButtonCredits.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.ButtonCredits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.ButtonCredits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCredits.Font = new System.Drawing.Font("Unispace", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCredits.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonCredits.Location = new System.Drawing.Point(518, 601);
            this.ButtonCredits.Name = "ButtonCredits";
            this.ButtonCredits.Size = new System.Drawing.Size(172, 35);
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
            this.ButtonQuit.BackColor = System.Drawing.Color.Transparent;
            this.ButtonQuit.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonQuit.FlatAppearance.BorderSize = 0;
            this.ButtonQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonQuit.Font = new System.Drawing.Font("Unispace", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonQuit.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonQuit.Location = new System.Drawing.Point(1030, 601);
            this.ButtonQuit.Name = "ButtonQuit";
            this.ButtonQuit.Size = new System.Drawing.Size(110, 40);
            this.ButtonQuit.TabIndex = 4;
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
            this.ButtonStart.Location = new System.Drawing.Point(430, 373);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(346, 107);
            this.ButtonStart.TabIndex = 5;
            this.ButtonStart.Text = "begin";
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
            this.lblDialog.Location = new System.Drawing.Point(62, 421);
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
            // sceneTimer
            // 
            this.sceneTimer.Interval = 10;
            this.sceneTimer.Tick += new System.EventHandler(this.sceneTimer_Tick);
            // 
            // lblCenter
            // 
            this.lblCenter.BackColor = System.Drawing.Color.Transparent;
            this.lblCenter.Font = new System.Drawing.Font("Unispace", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCenter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCenter.Location = new System.Drawing.Point(62, 263);
            this.lblCenter.Name = "lblCenter";
            this.lblCenter.Size = new System.Drawing.Size(1029, 122);
            this.lblCenter.TabIndex = 8;
            this.lblCenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCenter.Visible = false;
            // 
            // Phantom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Phantom.Properties.Resources.mainMenuGrid;
            this.ClientSize = new System.Drawing.Size(1152, 648);
            this.Controls.Add(this.lblCenter);
            this.Controls.Add(this.lblDialog);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.ButtonQuit);
            this.Controls.Add(this.ButtonCredits);
            this.Controls.Add(this.ButtonOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Phantom";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phantom";
            this.Load += new System.EventHandler(this.Phantom_Load);
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
        private System.Windows.Forms.Timer sceneTimer;
        private System.Windows.Forms.Label lblCenter;
    }
}

