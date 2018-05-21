namespace GUI
{
    partial class BoardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.boardPanel = new System.Windows.Forms.Panel();
            this.player1Panel = new System.Windows.Forms.Panel();
            this.player1NodeChoiceHeuristicNameLabel = new System.Windows.Forms.Label();
            this.player1NodeChoiceHeuristicLabel = new System.Windows.Forms.Label();
            this.player1GameStateHeuristicNameLabel = new System.Windows.Forms.Label();
            this.player1GameStateHeuristicLabel = new System.Windows.Forms.Label();
            this.player1AlgorithmNameLabel = new System.Windows.Forms.Label();
            this.player1AlgorithmLabel = new System.Windows.Forms.Label();
            this.player1PointsValueLabel = new System.Windows.Forms.Label();
            this.player1PointsLabel = new System.Windows.Forms.Label();
            this.player1Label = new System.Windows.Forms.Label();
            this.player2Panel = new System.Windows.Forms.Panel();
            this.player2NodeChoiceHeuristicNameLabel = new System.Windows.Forms.Label();
            this.player2NodeChoiceHeuristicLabel = new System.Windows.Forms.Label();
            this.player2GameStateHeuristicNameLabel = new System.Windows.Forms.Label();
            this.player2GameStateHeuristicLabel = new System.Windows.Forms.Label();
            this.player2AlgorithmNameLabel = new System.Windows.Forms.Label();
            this.player2AlgorithmLabel = new System.Windows.Forms.Label();
            this.player2PointsValueLabel = new System.Windows.Forms.Label();
            this.player2PointsLabel = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.player1Panel.SuspendLayout();
            this.player2Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // boardPanel
            // 
            this.boardPanel.Location = new System.Drawing.Point(550, 100);
            this.boardPanel.Name = "boardPanel";
            this.boardPanel.Size = new System.Drawing.Size(600, 600);
            this.boardPanel.TabIndex = 1;
            // 
            // player1Panel
            // 
            this.player1Panel.Controls.Add(this.player1NodeChoiceHeuristicNameLabel);
            this.player1Panel.Controls.Add(this.player1NodeChoiceHeuristicLabel);
            this.player1Panel.Controls.Add(this.player1GameStateHeuristicNameLabel);
            this.player1Panel.Controls.Add(this.player1GameStateHeuristicLabel);
            this.player1Panel.Controls.Add(this.player1AlgorithmNameLabel);
            this.player1Panel.Controls.Add(this.player1AlgorithmLabel);
            this.player1Panel.Controls.Add(this.player1PointsValueLabel);
            this.player1Panel.Controls.Add(this.player1PointsLabel);
            this.player1Panel.Controls.Add(this.player1Label);
            this.player1Panel.Location = new System.Drawing.Point(10, 100);
            this.player1Panel.Name = "player1Panel";
            this.player1Panel.Size = new System.Drawing.Size(530, 250);
            this.player1Panel.TabIndex = 2;
            // 
            // player1NodeChoiceHeuristicNameLabel
            // 
            this.player1NodeChoiceHeuristicNameLabel.AutoSize = true;
            this.player1NodeChoiceHeuristicNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1NodeChoiceHeuristicNameLabel.Location = new System.Drawing.Point(300, 155);
            this.player1NodeChoiceHeuristicNameLabel.Name = "player1NodeChoiceHeuristicNameLabel";
            this.player1NodeChoiceHeuristicNameLabel.Size = new System.Drawing.Size(19, 25);
            this.player1NodeChoiceHeuristicNameLabel.TabIndex = 8;
            this.player1NodeChoiceHeuristicNameLabel.Text = "-";
            this.player1NodeChoiceHeuristicNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1NodeChoiceHeuristicLabel
            // 
            this.player1NodeChoiceHeuristicLabel.AutoSize = true;
            this.player1NodeChoiceHeuristicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1NodeChoiceHeuristicLabel.Location = new System.Drawing.Point(10, 155);
            this.player1NodeChoiceHeuristicLabel.Name = "player1NodeChoiceHeuristicLabel";
            this.player1NodeChoiceHeuristicLabel.Size = new System.Drawing.Size(239, 25);
            this.player1NodeChoiceHeuristicLabel.TabIndex = 7;
            this.player1NodeChoiceHeuristicLabel.Text = "Heurystyka wyboru węzła:";
            this.player1NodeChoiceHeuristicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1GameStateHeuristicNameLabel
            // 
            this.player1GameStateHeuristicNameLabel.AutoSize = true;
            this.player1GameStateHeuristicNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1GameStateHeuristicNameLabel.Location = new System.Drawing.Point(300, 120);
            this.player1GameStateHeuristicNameLabel.Name = "player1GameStateHeuristicNameLabel";
            this.player1GameStateHeuristicNameLabel.Size = new System.Drawing.Size(19, 25);
            this.player1GameStateHeuristicNameLabel.TabIndex = 6;
            this.player1GameStateHeuristicNameLabel.Text = "-";
            this.player1GameStateHeuristicNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1GameStateHeuristicLabel
            // 
            this.player1GameStateHeuristicLabel.AutoSize = true;
            this.player1GameStateHeuristicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1GameStateHeuristicLabel.Location = new System.Drawing.Point(10, 120);
            this.player1GameStateHeuristicLabel.Name = "player1GameStateHeuristicLabel";
            this.player1GameStateHeuristicLabel.Size = new System.Drawing.Size(259, 25);
            this.player1GameStateHeuristicLabel.TabIndex = 5;
            this.player1GameStateHeuristicLabel.Text = "Heurystyka oceny stanu gry:";
            this.player1GameStateHeuristicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1AlgorithmNameLabel
            // 
            this.player1AlgorithmNameLabel.AutoSize = true;
            this.player1AlgorithmNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1AlgorithmNameLabel.Location = new System.Drawing.Point(120, 85);
            this.player1AlgorithmNameLabel.Name = "player1AlgorithmNameLabel";
            this.player1AlgorithmNameLabel.Size = new System.Drawing.Size(19, 25);
            this.player1AlgorithmNameLabel.TabIndex = 4;
            this.player1AlgorithmNameLabel.Text = "-";
            this.player1AlgorithmNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1AlgorithmLabel
            // 
            this.player1AlgorithmLabel.AutoSize = true;
            this.player1AlgorithmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1AlgorithmLabel.Location = new System.Drawing.Point(10, 85);
            this.player1AlgorithmLabel.Name = "player1AlgorithmLabel";
            this.player1AlgorithmLabel.Size = new System.Drawing.Size(95, 25);
            this.player1AlgorithmLabel.TabIndex = 3;
            this.player1AlgorithmLabel.Text = "Algorytm:";
            this.player1AlgorithmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1PointsValueLabel
            // 
            this.player1PointsValueLabel.AutoSize = true;
            this.player1PointsValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1PointsValueLabel.Location = new System.Drawing.Point(120, 50);
            this.player1PointsValueLabel.Name = "player1PointsValueLabel";
            this.player1PointsValueLabel.Size = new System.Drawing.Size(23, 25);
            this.player1PointsValueLabel.TabIndex = 2;
            this.player1PointsValueLabel.Text = "0";
            this.player1PointsValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // player1PointsLabel
            // 
            this.player1PointsLabel.AutoSize = true;
            this.player1PointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1PointsLabel.Location = new System.Drawing.Point(10, 50);
            this.player1PointsLabel.Name = "player1PointsLabel";
            this.player1PointsLabel.Size = new System.Drawing.Size(78, 25);
            this.player1PointsLabel.TabIndex = 1;
            this.player1PointsLabel.Text = "Punkty:";
            this.player1PointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1Label
            // 
            this.player1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1Label.Location = new System.Drawing.Point(215, 5);
            this.player1Label.Margin = new System.Windows.Forms.Padding(0);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(100, 25);
            this.player1Label.TabIndex = 0;
            this.player1Label.Text = "Gracz 1";
            this.player1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2Panel
            // 
            this.player2Panel.Controls.Add(this.player2NodeChoiceHeuristicNameLabel);
            this.player2Panel.Controls.Add(this.player2NodeChoiceHeuristicLabel);
            this.player2Panel.Controls.Add(this.player2GameStateHeuristicNameLabel);
            this.player2Panel.Controls.Add(this.player2GameStateHeuristicLabel);
            this.player2Panel.Controls.Add(this.player2AlgorithmNameLabel);
            this.player2Panel.Controls.Add(this.player2AlgorithmLabel);
            this.player2Panel.Controls.Add(this.player2PointsValueLabel);
            this.player2Panel.Controls.Add(this.player2PointsLabel);
            this.player2Panel.Controls.Add(this.player2Label);
            this.player2Panel.Location = new System.Drawing.Point(10, 450);
            this.player2Panel.Name = "player2Panel";
            this.player2Panel.Size = new System.Drawing.Size(530, 250);
            this.player2Panel.TabIndex = 3;
            // 
            // player2NodeChoiceHeuristicNameLabel
            // 
            this.player2NodeChoiceHeuristicNameLabel.AutoSize = true;
            this.player2NodeChoiceHeuristicNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2NodeChoiceHeuristicNameLabel.Location = new System.Drawing.Point(300, 155);
            this.player2NodeChoiceHeuristicNameLabel.Name = "player2NodeChoiceHeuristicNameLabel";
            this.player2NodeChoiceHeuristicNameLabel.Size = new System.Drawing.Size(19, 25);
            this.player2NodeChoiceHeuristicNameLabel.TabIndex = 8;
            this.player2NodeChoiceHeuristicNameLabel.Text = "-";
            this.player2NodeChoiceHeuristicNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2NodeChoiceHeuristicLabel
            // 
            this.player2NodeChoiceHeuristicLabel.AutoSize = true;
            this.player2NodeChoiceHeuristicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2NodeChoiceHeuristicLabel.Location = new System.Drawing.Point(10, 155);
            this.player2NodeChoiceHeuristicLabel.Name = "player2NodeChoiceHeuristicLabel";
            this.player2NodeChoiceHeuristicLabel.Size = new System.Drawing.Size(239, 25);
            this.player2NodeChoiceHeuristicLabel.TabIndex = 7;
            this.player2NodeChoiceHeuristicLabel.Text = "Heurystyka wyboru węzła:";
            this.player2NodeChoiceHeuristicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2GameStateHeuristicNameLabel
            // 
            this.player2GameStateHeuristicNameLabel.AutoSize = true;
            this.player2GameStateHeuristicNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2GameStateHeuristicNameLabel.Location = new System.Drawing.Point(300, 120);
            this.player2GameStateHeuristicNameLabel.Name = "player2GameStateHeuristicNameLabel";
            this.player2GameStateHeuristicNameLabel.Size = new System.Drawing.Size(19, 25);
            this.player2GameStateHeuristicNameLabel.TabIndex = 6;
            this.player2GameStateHeuristicNameLabel.Text = "-";
            this.player2GameStateHeuristicNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2GameStateHeuristicLabel
            // 
            this.player2GameStateHeuristicLabel.AutoSize = true;
            this.player2GameStateHeuristicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2GameStateHeuristicLabel.Location = new System.Drawing.Point(10, 120);
            this.player2GameStateHeuristicLabel.Name = "player2GameStateHeuristicLabel";
            this.player2GameStateHeuristicLabel.Size = new System.Drawing.Size(259, 25);
            this.player2GameStateHeuristicLabel.TabIndex = 5;
            this.player2GameStateHeuristicLabel.Text = "Heurystyka oceny stanu gry:";
            this.player2GameStateHeuristicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2AlgorithmNameLabel
            // 
            this.player2AlgorithmNameLabel.AutoSize = true;
            this.player2AlgorithmNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2AlgorithmNameLabel.Location = new System.Drawing.Point(120, 85);
            this.player2AlgorithmNameLabel.Name = "player2AlgorithmNameLabel";
            this.player2AlgorithmNameLabel.Size = new System.Drawing.Size(19, 25);
            this.player2AlgorithmNameLabel.TabIndex = 4;
            this.player2AlgorithmNameLabel.Text = "-";
            this.player2AlgorithmNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2AlgorithmLabel
            // 
            this.player2AlgorithmLabel.AutoSize = true;
            this.player2AlgorithmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2AlgorithmLabel.Location = new System.Drawing.Point(10, 85);
            this.player2AlgorithmLabel.Name = "player2AlgorithmLabel";
            this.player2AlgorithmLabel.Size = new System.Drawing.Size(95, 25);
            this.player2AlgorithmLabel.TabIndex = 3;
            this.player2AlgorithmLabel.Text = "Algorytm:";
            this.player2AlgorithmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2PointsValueLabel
            // 
            this.player2PointsValueLabel.AutoSize = true;
            this.player2PointsValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2PointsValueLabel.Location = new System.Drawing.Point(120, 50);
            this.player2PointsValueLabel.Name = "player2PointsValueLabel";
            this.player2PointsValueLabel.Size = new System.Drawing.Size(23, 25);
            this.player2PointsValueLabel.TabIndex = 2;
            this.player2PointsValueLabel.Text = "0";
            this.player2PointsValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // player2PointsLabel
            // 
            this.player2PointsLabel.AutoSize = true;
            this.player2PointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2PointsLabel.Location = new System.Drawing.Point(10, 50);
            this.player2PointsLabel.Name = "player2PointsLabel";
            this.player2PointsLabel.Size = new System.Drawing.Size(78, 25);
            this.player2PointsLabel.TabIndex = 1;
            this.player2PointsLabel.Text = "Punkty:";
            this.player2PointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2Label
            // 
            this.player2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2Label.Location = new System.Drawing.Point(215, 5);
            this.player2Label.Margin = new System.Windows.Forms.Padding(0);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(100, 25);
            this.player2Label.TabIndex = 0;
            this.player2Label.Text = "Gracz 2";
            this.player2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.player2Panel);
            this.Controls.Add(this.player1Panel);
            this.Controls.Add(this.boardPanel);
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "BoardForm";
            this.Text = "Stratego";
            this.player1Panel.ResumeLayout(false);
            this.player1Panel.PerformLayout();
            this.player2Panel.ResumeLayout(false);
            this.player2Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel boardPanel;
        private System.Windows.Forms.Panel player1Panel;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label player1NodeChoiceHeuristicNameLabel;
        private System.Windows.Forms.Label player1NodeChoiceHeuristicLabel;
        private System.Windows.Forms.Label player1GameStateHeuristicNameLabel;
        private System.Windows.Forms.Label player1GameStateHeuristicLabel;
        private System.Windows.Forms.Label player1AlgorithmNameLabel;
        private System.Windows.Forms.Label player1AlgorithmLabel;
        private System.Windows.Forms.Label player1PointsValueLabel;
        private System.Windows.Forms.Label player1PointsLabel;
        private System.Windows.Forms.Panel player2Panel;
        private System.Windows.Forms.Label player2NodeChoiceHeuristicNameLabel;
        private System.Windows.Forms.Label player2NodeChoiceHeuristicLabel;
        private System.Windows.Forms.Label player2GameStateHeuristicNameLabel;
        private System.Windows.Forms.Label player2GameStateHeuristicLabel;
        private System.Windows.Forms.Label player2AlgorithmNameLabel;
        private System.Windows.Forms.Label player2AlgorithmLabel;
        private System.Windows.Forms.Label player2PointsValueLabel;
        private System.Windows.Forms.Label player2PointsLabel;
        private System.Windows.Forms.Label player2Label;
    }
}

