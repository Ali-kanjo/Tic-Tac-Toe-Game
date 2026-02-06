namespace Tic_Tac_Toe_Game
{
    partial class frmMainGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainGame));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.pb9 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(249, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(722, 105);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic-Tac-toe Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(90, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = "Winner";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(99, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 52);
            this.label3.TabIndex = 2;
            this.label3.Text = "Turn";
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentPlayer.Font = new System.Drawing.Font("Impact", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPlayer.ForeColor = System.Drawing.Color.Gold;
            this.lblCurrentPlayer.Location = new System.Drawing.Point(69, 180);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(166, 53);
            this.lblCurrentPlayer.TabIndex = 3;
            this.lblCurrentPlayer.Text = "Player 1";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblWinner.Font = new System.Drawing.Font("Impact", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Lime;
            this.lblWinner.Location = new System.Drawing.Point(45, 334);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(234, 53);
            this.lblWinner.TabIndex = 4;
            this.lblWinner.Text = "In Progress";
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb9
            // 
            this.pb9.BackColor = System.Drawing.Color.Transparent;
            this.pb9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb9.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb9.Location = new System.Drawing.Point(947, 448);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(135, 112);
            this.pb9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb9.TabIndex = 13;
            this.pb9.TabStop = false;
            this.pb9.Tag = "?";
            this.pb9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxesClick_MouseDown);
            this.pb9.MouseEnter += new System.EventHandler(this.AllPictureBoxes_MouseEnter);
            this.pb9.MouseLeave += new System.EventHandler(this.AllPictureBoxes_MouseLeave);
            // 
            // pb8
            // 
            this.pb8.BackColor = System.Drawing.Color.Transparent;
            this.pb8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb8.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb8.Location = new System.Drawing.Point(751, 448);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(135, 112);
            this.pb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb8.TabIndex = 12;
            this.pb8.TabStop = false;
            this.pb8.Tag = "?";
            this.pb8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxesClick_MouseDown);
            this.pb8.MouseEnter += new System.EventHandler(this.AllPictureBoxes_MouseEnter);
            this.pb8.MouseLeave += new System.EventHandler(this.AllPictureBoxes_MouseLeave);
            // 
            // pb7
            // 
            this.pb7.BackColor = System.Drawing.Color.Transparent;
            this.pb7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb7.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb7.Location = new System.Drawing.Point(555, 448);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(135, 112);
            this.pb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb7.TabIndex = 11;
            this.pb7.TabStop = false;
            this.pb7.Tag = "?";
            this.pb7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxesClick_MouseDown);
            this.pb7.MouseEnter += new System.EventHandler(this.AllPictureBoxes_MouseEnter);
            this.pb7.MouseLeave += new System.EventHandler(this.AllPictureBoxes_MouseLeave);
            // 
            // pb6
            // 
            this.pb6.BackColor = System.Drawing.Color.Transparent;
            this.pb6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb6.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb6.Location = new System.Drawing.Point(947, 296);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(135, 112);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb6.TabIndex = 10;
            this.pb6.TabStop = false;
            this.pb6.Tag = "?";
            this.pb6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxesClick_MouseDown);
            this.pb6.MouseEnter += new System.EventHandler(this.AllPictureBoxes_MouseEnter);
            this.pb6.MouseLeave += new System.EventHandler(this.AllPictureBoxes_MouseLeave);
            // 
            // pb5
            // 
            this.pb5.BackColor = System.Drawing.Color.Transparent;
            this.pb5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb5.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb5.Location = new System.Drawing.Point(751, 296);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(135, 112);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb5.TabIndex = 9;
            this.pb5.TabStop = false;
            this.pb5.Tag = "?";
            this.pb5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxesClick_MouseDown);
            this.pb5.MouseEnter += new System.EventHandler(this.AllPictureBoxes_MouseEnter);
            this.pb5.MouseLeave += new System.EventHandler(this.AllPictureBoxes_MouseLeave);
            // 
            // pb4
            // 
            this.pb4.BackColor = System.Drawing.Color.Transparent;
            this.pb4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb4.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb4.Location = new System.Drawing.Point(555, 296);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(135, 112);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb4.TabIndex = 8;
            this.pb4.TabStop = false;
            this.pb4.Tag = "?";
            this.pb4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxesClick_MouseDown);
            this.pb4.MouseEnter += new System.EventHandler(this.AllPictureBoxes_MouseEnter);
            this.pb4.MouseLeave += new System.EventHandler(this.AllPictureBoxes_MouseLeave);
            // 
            // pb3
            // 
            this.pb3.BackColor = System.Drawing.Color.Transparent;
            this.pb3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb3.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb3.Location = new System.Drawing.Point(947, 144);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(135, 112);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb3.TabIndex = 7;
            this.pb3.TabStop = false;
            this.pb3.Tag = "?";
            this.pb3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxesClick_MouseDown);
            this.pb3.MouseEnter += new System.EventHandler(this.AllPictureBoxes_MouseEnter);
            this.pb3.MouseLeave += new System.EventHandler(this.AllPictureBoxes_MouseLeave);
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.Transparent;
            this.pb2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb2.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb2.Location = new System.Drawing.Point(751, 144);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(135, 112);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 6;
            this.pb2.TabStop = false;
            this.pb2.Tag = "?";
            this.pb2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxesClick_MouseDown);
            this.pb2.MouseEnter += new System.EventHandler(this.AllPictureBoxes_MouseEnter);
            this.pb2.MouseLeave += new System.EventHandler(this.AllPictureBoxes_MouseLeave);
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.Transparent;
            this.pb1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.pb1.Location = new System.Drawing.Point(555, 144);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(135, 112);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 5;
            this.pb1.TabStop = false;
            this.pb1.Tag = "?";
            this.pb1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxesClick_MouseDown);
            this.pb1.MouseEnter += new System.EventHandler(this.AllPictureBoxes_MouseEnter);
            this.pb1.MouseLeave += new System.EventHandler(this.AllPictureBoxes_MouseLeave);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Transparent;
            this.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.FlatAppearance.BorderSize = 5;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.Transparent;
            this.btnRestart.Location = new System.Drawing.Point(36, 428);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(262, 90);
            this.btnRestart.TabIndex = 14;
            this.btnRestart.Text = "Restart Game";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 5;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(36, 524);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(262, 90);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tic_Tac_Toe_Game.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1211, 643);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.pb9);
            this.Controls.Add(this.pb8);
            this.Controls.Add(this.pb7);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblCurrentPlayer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainGame";
            this.Text = "Tic-Tac-Toe Game";
            this.Load += new System.EventHandler(this.frmMainGame_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMainGame_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCurrentPlayer;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.PictureBox pb9;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnClose;
    }
}

