namespace GUI
{
    partial class MenuForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.player1Panel = new System.Windows.Forms.Panel();
            this.player1NodeChoiceHeuristicChoice = new System.Windows.Forms.ComboBox();
            this.player1NodeChoiceHeuristicLabel = new System.Windows.Forms.Label();
            this.player1GameStateHeuristicChoice = new System.Windows.Forms.ComboBox();
            this.player1AlgorithmLabel = new System.Windows.Forms.Label();
            this.player1GameStateHeuristicLabel = new System.Windows.Forms.Label();
            this.player1AlgorithmChoice = new System.Windows.Forms.ComboBox();
            this.player1TreeDepthChoice = new System.Windows.Forms.NumericUpDown();
            this.player1TreeDepthLabel = new System.Windows.Forms.Label();
            this.player1AICheckbox = new System.Windows.Forms.CheckBox();
            this.player1Label = new System.Windows.Forms.Label();
            this.boardSizeChoice = new System.Windows.Forms.NumericUpDown();
            this.boardSizeLabel = new System.Windows.Forms.Label();
            this.player2Panel = new System.Windows.Forms.Panel();
            this.player2NodeChoiceHeuristicChoice = new System.Windows.Forms.ComboBox();
            this.player2NodeChoiceHeuristicLabel = new System.Windows.Forms.Label();
            this.player2GameStateHeuristicChoice = new System.Windows.Forms.ComboBox();
            this.player2AlgorithmLabel = new System.Windows.Forms.Label();
            this.player2GameStateHeuristicLabel = new System.Windows.Forms.Label();
            this.player2AlgorithmChoice = new System.Windows.Forms.ComboBox();
            this.player2TreeDepthChoice = new System.Windows.Forms.NumericUpDown();
            this.player2TreeDepthLabel = new System.Windows.Forms.Label();
            this.player2AICheckbox = new System.Windows.Forms.CheckBox();
            this.player2Label = new System.Windows.Forms.Label();
            this.startGameButton = new System.Windows.Forms.Button();
            this.player1Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player1TreeDepthChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardSizeChoice)).BeginInit();
            this.player2Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player2TreeDepthChoice)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.Location = new System.Drawing.Point(475, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(250, 50);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Ustawienia gry";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1Panel
            // 
            this.player1Panel.Controls.Add(this.player1NodeChoiceHeuristicChoice);
            this.player1Panel.Controls.Add(this.player1NodeChoiceHeuristicLabel);
            this.player1Panel.Controls.Add(this.player1GameStateHeuristicChoice);
            this.player1Panel.Controls.Add(this.player1AlgorithmLabel);
            this.player1Panel.Controls.Add(this.player1GameStateHeuristicLabel);
            this.player1Panel.Controls.Add(this.player1AlgorithmChoice);
            this.player1Panel.Controls.Add(this.player1TreeDepthChoice);
            this.player1Panel.Controls.Add(this.player1TreeDepthLabel);
            this.player1Panel.Controls.Add(this.player1AICheckbox);
            this.player1Panel.Controls.Add(this.player1Label);
            this.player1Panel.Location = new System.Drawing.Point(100, 150);
            this.player1Panel.Name = "player1Panel";
            this.player1Panel.Size = new System.Drawing.Size(400, 500);
            this.player1Panel.TabIndex = 1;
            // 
            // player1NodeChoiceHeuristicChoice
            // 
            this.player1NodeChoiceHeuristicChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1NodeChoiceHeuristicChoice.FormattingEnabled = true;
            this.player1NodeChoiceHeuristicChoice.Location = new System.Drawing.Point(60, 385);
            this.player1NodeChoiceHeuristicChoice.Name = "player1NodeChoiceHeuristicChoice";
            this.player1NodeChoiceHeuristicChoice.Size = new System.Drawing.Size(295, 30);
            this.player1NodeChoiceHeuristicChoice.TabIndex = 9;
            // 
            // player1NodeChoiceHeuristicLabel
            // 
            this.player1NodeChoiceHeuristicLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player1NodeChoiceHeuristicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1NodeChoiceHeuristicLabel.Location = new System.Drawing.Point(55, 340);
            this.player1NodeChoiceHeuristicLabel.Name = "player1NodeChoiceHeuristicLabel";
            this.player1NodeChoiceHeuristicLabel.Size = new System.Drawing.Size(303, 30);
            this.player1NodeChoiceHeuristicLabel.TabIndex = 8;
            this.player1NodeChoiceHeuristicLabel.Text = "Heurystyka wyboru węzła";
            this.player1NodeChoiceHeuristicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // player1GameStateHeuristicChoice
            // 
            this.player1GameStateHeuristicChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1GameStateHeuristicChoice.FormattingEnabled = true;
            this.player1GameStateHeuristicChoice.Location = new System.Drawing.Point(60, 295);
            this.player1GameStateHeuristicChoice.Name = "player1GameStateHeuristicChoice";
            this.player1GameStateHeuristicChoice.Size = new System.Drawing.Size(295, 30);
            this.player1GameStateHeuristicChoice.TabIndex = 8;
            // 
            // player1AlgorithmLabel
            // 
            this.player1AlgorithmLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player1AlgorithmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1AlgorithmLabel.Location = new System.Drawing.Point(55, 160);
            this.player1AlgorithmLabel.Name = "player1AlgorithmLabel";
            this.player1AlgorithmLabel.Size = new System.Drawing.Size(180, 30);
            this.player1AlgorithmLabel.TabIndex = 6;
            this.player1AlgorithmLabel.Text = "Algorytm";
            this.player1AlgorithmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // player1GameStateHeuristicLabel
            // 
            this.player1GameStateHeuristicLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player1GameStateHeuristicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1GameStateHeuristicLabel.Location = new System.Drawing.Point(55, 250);
            this.player1GameStateHeuristicLabel.Name = "player1GameStateHeuristicLabel";
            this.player1GameStateHeuristicLabel.Size = new System.Drawing.Size(300, 30);
            this.player1GameStateHeuristicLabel.TabIndex = 7;
            this.player1GameStateHeuristicLabel.Text = "Heurystyka oceny stanu planszy";
            this.player1GameStateHeuristicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // player1AlgorithmChoice
            // 
            this.player1AlgorithmChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1AlgorithmChoice.FormattingEnabled = true;
            this.player1AlgorithmChoice.Location = new System.Drawing.Point(60, 205);
            this.player1AlgorithmChoice.Name = "player1AlgorithmChoice";
            this.player1AlgorithmChoice.Size = new System.Drawing.Size(295, 30);
            this.player1AlgorithmChoice.TabIndex = 5;
            // 
            // player1TreeDepthChoice
            // 
            this.player1TreeDepthChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1TreeDepthChoice.Location = new System.Drawing.Point(250, 110);
            this.player1TreeDepthChoice.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.player1TreeDepthChoice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.player1TreeDepthChoice.Name = "player1TreeDepthChoice";
            this.player1TreeDepthChoice.Size = new System.Drawing.Size(55, 30);
            this.player1TreeDepthChoice.TabIndex = 5;
            this.player1TreeDepthChoice.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // player1TreeDepthLabel
            // 
            this.player1TreeDepthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player1TreeDepthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1TreeDepthLabel.Location = new System.Drawing.Point(55, 110);
            this.player1TreeDepthLabel.Name = "player1TreeDepthLabel";
            this.player1TreeDepthLabel.Size = new System.Drawing.Size(190, 30);
            this.player1TreeDepthLabel.TabIndex = 5;
            this.player1TreeDepthLabel.Text = "Głębokość drzewa";
            this.player1TreeDepthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // player1AICheckbox
            // 
            this.player1AICheckbox.Checked = true;
            this.player1AICheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.player1AICheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1AICheckbox.Location = new System.Drawing.Point(60, 60);
            this.player1AICheckbox.Name = "player1AICheckbox";
            this.player1AICheckbox.Size = new System.Drawing.Size(150, 30);
            this.player1AICheckbox.TabIndex = 3;
            this.player1AICheckbox.Text = "Komputer";
            this.player1AICheckbox.UseVisualStyleBackColor = true;
            this.player1AICheckbox.CheckedChanged += new System.EventHandler(this.Player1AICheckboxCheckedChanged);
            // 
            // player1Label
            // 
            this.player1Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1Label.Location = new System.Drawing.Point(75, 0);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(250, 30);
            this.player1Label.TabIndex = 2;
            this.player1Label.Text = "Gracz 1";
            this.player1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boardSizeChoice
            // 
            this.boardSizeChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.boardSizeChoice.Location = new System.Drawing.Point(655, 100);
            this.boardSizeChoice.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.boardSizeChoice.Name = "boardSizeChoice";
            this.boardSizeChoice.Size = new System.Drawing.Size(70, 30);
            this.boardSizeChoice.TabIndex = 2;
            this.boardSizeChoice.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // boardSizeLabel
            // 
            this.boardSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boardSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.boardSizeLabel.Location = new System.Drawing.Point(475, 100);
            this.boardSizeLabel.Name = "boardSizeLabel";
            this.boardSizeLabel.Size = new System.Drawing.Size(180, 30);
            this.boardSizeLabel.TabIndex = 4;
            this.boardSizeLabel.Text = "Rozmiar planszy";
            this.boardSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // player2Panel
            // 
            this.player2Panel.Controls.Add(this.player2NodeChoiceHeuristicChoice);
            this.player2Panel.Controls.Add(this.player2NodeChoiceHeuristicLabel);
            this.player2Panel.Controls.Add(this.player2GameStateHeuristicChoice);
            this.player2Panel.Controls.Add(this.player2AlgorithmLabel);
            this.player2Panel.Controls.Add(this.player2GameStateHeuristicLabel);
            this.player2Panel.Controls.Add(this.player2AlgorithmChoice);
            this.player2Panel.Controls.Add(this.player2TreeDepthChoice);
            this.player2Panel.Controls.Add(this.player2TreeDepthLabel);
            this.player2Panel.Controls.Add(this.player2AICheckbox);
            this.player2Panel.Controls.Add(this.player2Label);
            this.player2Panel.Location = new System.Drawing.Point(700, 150);
            this.player2Panel.Name = "player2Panel";
            this.player2Panel.Size = new System.Drawing.Size(400, 500);
            this.player2Panel.TabIndex = 5;
            // 
            // player2NodeChoiceHeuristicChoice
            // 
            this.player2NodeChoiceHeuristicChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2NodeChoiceHeuristicChoice.FormattingEnabled = true;
            this.player2NodeChoiceHeuristicChoice.Location = new System.Drawing.Point(60, 385);
            this.player2NodeChoiceHeuristicChoice.Name = "player2NodeChoiceHeuristicChoice";
            this.player2NodeChoiceHeuristicChoice.Size = new System.Drawing.Size(295, 30);
            this.player2NodeChoiceHeuristicChoice.TabIndex = 9;
            // 
            // player2NodeChoiceHeuristicLabel
            // 
            this.player2NodeChoiceHeuristicLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player2NodeChoiceHeuristicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2NodeChoiceHeuristicLabel.Location = new System.Drawing.Point(55, 340);
            this.player2NodeChoiceHeuristicLabel.Name = "player2NodeChoiceHeuristicLabel";
            this.player2NodeChoiceHeuristicLabel.Size = new System.Drawing.Size(303, 30);
            this.player2NodeChoiceHeuristicLabel.TabIndex = 8;
            this.player2NodeChoiceHeuristicLabel.Text = "Heurystyka wyboru węzła";
            this.player2NodeChoiceHeuristicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // player2GameStateHeuristicChoice
            // 
            this.player2GameStateHeuristicChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2GameStateHeuristicChoice.FormattingEnabled = true;
            this.player2GameStateHeuristicChoice.Location = new System.Drawing.Point(60, 295);
            this.player2GameStateHeuristicChoice.Name = "player2GameStateHeuristicChoice";
            this.player2GameStateHeuristicChoice.Size = new System.Drawing.Size(295, 30);
            this.player2GameStateHeuristicChoice.TabIndex = 8;
            // 
            // player2AlgorithmLabel
            // 
            this.player2AlgorithmLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player2AlgorithmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2AlgorithmLabel.Location = new System.Drawing.Point(55, 160);
            this.player2AlgorithmLabel.Name = "player2AlgorithmLabel";
            this.player2AlgorithmLabel.Size = new System.Drawing.Size(180, 30);
            this.player2AlgorithmLabel.TabIndex = 6;
            this.player2AlgorithmLabel.Text = "Algorytm";
            this.player2AlgorithmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // player2GameStateHeuristicLabel
            // 
            this.player2GameStateHeuristicLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player2GameStateHeuristicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2GameStateHeuristicLabel.Location = new System.Drawing.Point(55, 250);
            this.player2GameStateHeuristicLabel.Name = "player2GameStateHeuristicLabel";
            this.player2GameStateHeuristicLabel.Size = new System.Drawing.Size(300, 30);
            this.player2GameStateHeuristicLabel.TabIndex = 7;
            this.player2GameStateHeuristicLabel.Text = "Heurystyka oceny stanu planszy";
            this.player2GameStateHeuristicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // player2AlgorithmChoice
            // 
            this.player2AlgorithmChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2AlgorithmChoice.FormattingEnabled = true;
            this.player2AlgorithmChoice.Location = new System.Drawing.Point(60, 205);
            this.player2AlgorithmChoice.Name = "player2AlgorithmChoice";
            this.player2AlgorithmChoice.Size = new System.Drawing.Size(295, 30);
            this.player2AlgorithmChoice.TabIndex = 5;
            // 
            // player2TreeDepthChoice
            // 
            this.player2TreeDepthChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2TreeDepthChoice.Location = new System.Drawing.Point(250, 110);
            this.player2TreeDepthChoice.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.player2TreeDepthChoice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.player2TreeDepthChoice.Name = "player2TreeDepthChoice";
            this.player2TreeDepthChoice.Size = new System.Drawing.Size(55, 30);
            this.player2TreeDepthChoice.TabIndex = 5;
            this.player2TreeDepthChoice.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // player2TreeDepthLabel
            // 
            this.player2TreeDepthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player2TreeDepthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2TreeDepthLabel.Location = new System.Drawing.Point(55, 110);
            this.player2TreeDepthLabel.Name = "player2TreeDepthLabel";
            this.player2TreeDepthLabel.Size = new System.Drawing.Size(190, 30);
            this.player2TreeDepthLabel.TabIndex = 5;
            this.player2TreeDepthLabel.Text = "Głębokość drzewa";
            this.player2TreeDepthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // player2AICheckbox
            // 
            this.player2AICheckbox.Checked = true;
            this.player2AICheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.player2AICheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2AICheckbox.Location = new System.Drawing.Point(60, 60);
            this.player2AICheckbox.Name = "player2AICheckbox";
            this.player2AICheckbox.Size = new System.Drawing.Size(150, 30);
            this.player2AICheckbox.TabIndex = 3;
            this.player2AICheckbox.Text = "Komputer";
            this.player2AICheckbox.UseVisualStyleBackColor = true;
            this.player2AICheckbox.CheckedChanged += new System.EventHandler(this.Player2AICheckboxCheckedChanged);
            // 
            // player2Label
            // 
            this.player2Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2Label.Location = new System.Drawing.Point(75, 0);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(250, 30);
            this.player2Label.TabIndex = 2;
            this.player2Label.Text = "Gracz 2";
            this.player2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startGameButton
            // 
            this.startGameButton.AutoSize = true;
            this.startGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startGameButton.Location = new System.Drawing.Point(950, 679);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(150, 35);
            this.startGameButton.TabIndex = 6;
            this.startGameButton.Text = "Rozpocznij grę";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.StartGameButtonClick);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.player2Panel);
            this.Controls.Add(this.boardSizeLabel);
            this.Controls.Add(this.boardSizeChoice);
            this.Controls.Add(this.player1Panel);
            this.Controls.Add(this.titleLabel);
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "MenuForm";
            this.Text = "Stratego";
            this.player1Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player1TreeDepthChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardSizeChoice)).EndInit();
            this.player2Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player2TreeDepthChoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel player1Panel;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.NumericUpDown boardSizeChoice;
        private System.Windows.Forms.Label boardSizeLabel;
        private System.Windows.Forms.Label player1TreeDepthLabel;
        private System.Windows.Forms.NumericUpDown player1TreeDepthChoice;
        private System.Windows.Forms.CheckBox player1AICheckbox;
        private System.Windows.Forms.Label player1AlgorithmLabel;
        private System.Windows.Forms.Label player1GameStateHeuristicLabel;
        private System.Windows.Forms.ComboBox player1AlgorithmChoice;
        private System.Windows.Forms.Label player1NodeChoiceHeuristicLabel;
        private System.Windows.Forms.ComboBox player1GameStateHeuristicChoice;
        private System.Windows.Forms.ComboBox player1NodeChoiceHeuristicChoice;
        private System.Windows.Forms.Panel player2Panel;
        private System.Windows.Forms.ComboBox player2NodeChoiceHeuristicChoice;
        private System.Windows.Forms.Label player2NodeChoiceHeuristicLabel;
        private System.Windows.Forms.ComboBox player2GameStateHeuristicChoice;
        private System.Windows.Forms.Label player2AlgorithmLabel;
        private System.Windows.Forms.Label player2GameStateHeuristicLabel;
        private System.Windows.Forms.ComboBox player2AlgorithmChoice;
        private System.Windows.Forms.NumericUpDown player2TreeDepthChoice;
        private System.Windows.Forms.Label player2TreeDepthLabel;
        private System.Windows.Forms.CheckBox player2AICheckbox;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Button startGameButton;
    }
}