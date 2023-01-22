
namespace BingoPlayerWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.previousBall = new BingoPlayerWF.BingoBall();
			this.currentBall = new BingoPlayerWF.BingoBall();
			this.lblPrevious = new System.Windows.Forms.Label();
			this.lblCurrent = new System.Windows.Forms.Label();
			this.grpPrevious = new System.Windows.Forms.GroupBox();
			this.btnNewGame = new System.Windows.Forms.Button();
			this.lblNext = new System.Windows.Forms.Label();
			this.btnAuto = new System.Windows.Forms.Button();
			this.txtNext = new System.Windows.Forms.NumericUpDown();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.timerStep = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.txtNext)).BeginInit();
			this.SuspendLayout();
			// 
			// previousBall
			// 
			this.previousBall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.previousBall.Font = new System.Drawing.Font("Bahnschrift", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.previousBall.Location = new System.Drawing.Point(1028, 58);
			this.previousBall.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
			this.previousBall.Name = "previousBall";
			this.previousBall.Size = new System.Drawing.Size(685, 685);
			this.previousBall.TabIndex = 0;
			this.previousBall.Text = "I 16";
			// 
			// currentBall
			// 
			this.currentBall.Font = new System.Drawing.Font("Bahnschrift", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.currentBall.Location = new System.Drawing.Point(16, 58);
			this.currentBall.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
			this.currentBall.Name = "currentBall";
			this.currentBall.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.currentBall.Size = new System.Drawing.Size(685, 685);
			this.currentBall.TabIndex = 2;
			this.currentBall.Text = "B 11";
			// 
			// lblPrevious
			// 
			this.lblPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPrevious.AutoSize = true;
			this.lblPrevious.Location = new System.Drawing.Point(1028, 12);
			this.lblPrevious.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblPrevious.Name = "lblPrevious";
			this.lblPrevious.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblPrevious.Size = new System.Drawing.Size(91, 30);
			this.lblPrevious.TabIndex = 3;
			this.lblPrevious.Text = "Previous";
			// 
			// lblCurrent
			// 
			this.lblCurrent.AutoSize = true;
			this.lblCurrent.Location = new System.Drawing.Point(16, 12);
			this.lblCurrent.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblCurrent.Name = "lblCurrent";
			this.lblCurrent.Size = new System.Drawing.Size(82, 30);
			this.lblCurrent.TabIndex = 4;
			this.lblCurrent.Text = "Current";
			// 
			// grpPrevious
			// 
			this.grpPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpPrevious.Location = new System.Drawing.Point(16, 765);
			this.grpPrevious.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.grpPrevious.Name = "grpPrevious";
			this.grpPrevious.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.grpPrevious.Size = new System.Drawing.Size(1697, 678);
			this.grpPrevious.TabIndex = 6;
			this.grpPrevious.TabStop = false;
			this.grpPrevious.Text = "Previous Balls";
			this.grpPrevious.UseCompatibleTextRendering = true;
			this.grpPrevious.Resize += new System.EventHandler(this.grpPrevious_Resize);
			// 
			// btnNewGame
			// 
			this.btnNewGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNewGame.Location = new System.Drawing.Point(712, 617);
			this.btnNewGame.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.btnNewGame.Name = "btnNewGame";
			this.btnNewGame.Size = new System.Drawing.Size(308, 136);
			this.btnNewGame.TabIndex = 7;
			this.btnNewGame.Text = "New Game";
			this.btnNewGame.UseVisualStyleBackColor = true;
			this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
			// 
			// lblNext
			// 
			this.lblNext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblNext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblNext.Location = new System.Drawing.Point(712, 284);
			this.lblNext.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblNext.Name = "lblNext";
			this.lblNext.Size = new System.Drawing.Size(307, 241);
			this.lblNext.TabIndex = 8;
			this.lblNext.Text = "Next";
			this.lblNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblNext.Click += new System.EventHandler(this.lblNext_Click);
			// 
			// btnAuto
			// 
			this.btnAuto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAuto.Location = new System.Drawing.Point(712, 58);
			this.btnAuto.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.btnAuto.Name = "btnAuto";
			this.btnAuto.Size = new System.Drawing.Size(199, 86);
			this.btnAuto.TabIndex = 9;
			this.btnAuto.Text = "AutoNext";
			this.btnAuto.UseVisualStyleBackColor = true;
			this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
			// 
			// txtNext
			// 
			this.txtNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNext.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtNext.Location = new System.Drawing.Point(920, 58);
			this.txtNext.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.txtNext.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.txtNext.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.txtNext.Name = "txtNext";
			this.txtNext.Size = new System.Drawing.Size(100, 70);
			this.txtNext.TabIndex = 10;
			this.txtNext.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// progressBar1
			// 
			this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar1.Location = new System.Drawing.Point(707, 186);
			this.progressBar1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.progressBar1.Maximum = 1000;
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(299, 60);
			this.progressBar1.Step = 2;
			this.progressBar1.TabIndex = 11;
			// 
			// timerStep
			// 
			this.timerStep.Interval = 250;
			this.timerStep.Tick += new System.EventHandler(this.timerStep_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1728, 1458);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.txtNext);
			this.Controls.Add(this.btnAuto);
			this.Controls.Add(this.lblNext);
			this.Controls.Add(this.btnNewGame);
			this.Controls.Add(this.grpPrevious);
			this.Controls.Add(this.lblCurrent);
			this.Controls.Add(this.lblPrevious);
			this.Controls.Add(this.currentBall);
			this.Controls.Add(this.previousBall);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Name = "Form1";
			this.Text = "Let\'s Play Bingo";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.txtNext)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private BingoBall previousBall;
        private BingoBall currentBall;
        private System.Windows.Forms.Label lblPrevious;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.GroupBox grpPrevious;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.NumericUpDown txtNext;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timerStep;
    }
}

