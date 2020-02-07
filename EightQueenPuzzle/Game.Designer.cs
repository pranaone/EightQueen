namespace EightQueenPuzzle
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.ChessBoardPanel = new System.Windows.Forms.Panel();
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblShowCount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblShowTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ChessBoardPanel
            // 
            this.ChessBoardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ChessBoardPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ChessBoardPanel.Location = new System.Drawing.Point(13, 13);
            this.ChessBoardPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ChessBoardPanel.Name = "ChessBoardPanel";
            this.ChessBoardPanel.Size = new System.Drawing.Size(893, 778);
            this.ChessBoardPanel.TabIndex = 4;
            // 
            // btnSolve
            // 
            this.btnSolve.BackColor = System.Drawing.Color.DimGray;
            this.btnSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolve.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSolve.Location = new System.Drawing.Point(994, 517);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(138, 55);
            this.btnSolve.TabIndex = 6;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = false;
            this.btnSolve.Click += new System.EventHandler(this.BtnSolve_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DimGray;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(996, 687);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 55);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DimGray;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(994, 601);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(138, 55);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear Board";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // lblShowCount
            // 
            this.lblShowCount.AutoSize = true;
            this.lblShowCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblShowCount.Location = new System.Drawing.Point(942, 395);
            this.lblShowCount.Name = "lblShowCount";
            this.lblShowCount.Size = new System.Drawing.Size(0, 17);
            this.lblShowCount.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(996, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblShowTime
            // 
            this.lblShowTime.AutoSize = true;
            this.lblShowTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblShowTime.Location = new System.Drawing.Point(945, 449);
            this.lblShowTime.Name = "lblShowTime";
            this.lblShowTime.Size = new System.Drawing.Size(0, 17);
            this.lblShowTime.TabIndex = 12;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1257, 823);
            this.ControlBox = false;
            this.Controls.Add(this.lblShowTime);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblShowCount);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.ChessBoardPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eight Queen Game";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Panel ChessBoardPanel;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblShowCount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblShowTime;
    }
}

