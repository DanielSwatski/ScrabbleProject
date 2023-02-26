
namespace ScrabbleFinalProject.View
{
    partial class ScrabbleBoard
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
            this.btnSkipPlay = new System.Windows.Forms.Button();
            this.btnRemovePlayedPieces = new System.Windows.Forms.Button();
            this.txtBoxScore = new System.Windows.Forms.TextBox();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.grpBoxBoard = new System.Windows.Forms.GroupBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.txtBoxPlayerName = new System.Windows.Forms.TextBox();
            this.grpBoxHand = new System.Windows.Forms.GroupBox();
            this.lstBoxRules = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSkipPlay
            // 
            this.btnSkipPlay.Location = new System.Drawing.Point(908, 398);
            this.btnSkipPlay.Name = "btnSkipPlay";
            this.btnSkipPlay.Size = new System.Drawing.Size(134, 43);
            this.btnSkipPlay.TabIndex = 1;
            this.btnSkipPlay.Text = "Skip or Play Tile on Board";
            this.btnSkipPlay.UseVisualStyleBackColor = true;
            this.btnSkipPlay.Click += new System.EventHandler(this.btnSkipPlay_Click);
            // 
            // btnRemovePlayedPieces
            // 
            this.btnRemovePlayedPieces.Location = new System.Drawing.Point(1146, 398);
            this.btnRemovePlayedPieces.Name = "btnRemovePlayedPieces";
            this.btnRemovePlayedPieces.Size = new System.Drawing.Size(131, 43);
            this.btnRemovePlayedPieces.TabIndex = 2;
            this.btnRemovePlayedPieces.Text = "Remove Clicked Pieces";
            this.btnRemovePlayedPieces.UseVisualStyleBackColor = true;
            this.btnRemovePlayedPieces.Click += new System.EventHandler(this.btnRemovePlayedPieces_Click);
            // 
            // txtBoxScore
            // 
            this.txtBoxScore.Location = new System.Drawing.Point(1183, 45);
            this.txtBoxScore.Name = "txtBoxScore";
            this.txtBoxScore.Size = new System.Drawing.Size(139, 22);
            this.txtBoxScore.TabIndex = 3;
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Location = new System.Drawing.Point(1180, 9);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(45, 17);
            this.lblPlayerScore.TabIndex = 4;
            this.lblPlayerScore.Text = "Score";
            // 
            // grpBoxBoard
            // 
            this.grpBoxBoard.Location = new System.Drawing.Point(3, 9);
            this.grpBoxBoard.Name = "grpBoxBoard";
            this.grpBoxBoard.Size = new System.Drawing.Size(814, 733);
            this.grpBoxBoard.TabIndex = 5;
            this.grpBoxBoard.TabStop = false;
            this.grpBoxBoard.Text = "Board";
            this.grpBoxBoard.Enter += new System.EventHandler(this.grpBoxBoard_Enter);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(893, 9);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(48, 17);
            this.lblPlayerName.TabIndex = 8;
            this.lblPlayerName.Text = "Player";
            // 
            // txtBoxPlayerName
            // 
            this.txtBoxPlayerName.Location = new System.Drawing.Point(896, 45);
            this.txtBoxPlayerName.Name = "txtBoxPlayerName";
            this.txtBoxPlayerName.Size = new System.Drawing.Size(146, 22);
            this.txtBoxPlayerName.TabIndex = 9;
            // 
            // grpBoxHand
            // 
            this.grpBoxHand.Location = new System.Drawing.Point(908, 297);
            this.grpBoxHand.Name = "grpBoxHand";
            this.grpBoxHand.Size = new System.Drawing.Size(414, 95);
            this.grpBoxHand.TabIndex = 10;
            this.grpBoxHand.TabStop = false;
            this.grpBoxHand.Text = "Hand";
            // 
            // lstBoxRules
            // 
            this.lstBoxRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxRules.FormattingEnabled = true;
            this.lstBoxRules.ItemHeight = 25;
            this.lstBoxRules.Items.AddRange(new object[] {
            "Select Your Tile In Your Hand First",
            "The lower case x is the free letter",
            "Click on the squares on the board you wish to ",
            "\tplace letters, then click on the letters",
            "\t in your hand that you wish to place.",
            "If you cannot play a move press skip.",
            "If all players skip, then the game ends."});
            this.lstBoxRules.Location = new System.Drawing.Point(842, 87);
            this.lstBoxRules.Name = "lstBoxRules";
            this.lstBoxRules.Size = new System.Drawing.Size(536, 204);
            this.lstBoxRules.TabIndex = 12;
            // 
            // ScrabbleBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1627, 1055);
            this.Controls.Add(this.lstBoxRules);
            this.Controls.Add(this.grpBoxHand);
            this.Controls.Add(this.txtBoxPlayerName);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.grpBoxBoard);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.txtBoxScore);
            this.Controls.Add(this.btnRemovePlayedPieces);
            this.Controls.Add(this.btnSkipPlay);
            this.Name = "ScrabbleBoard";
            this.Text = "V";
            this.Load += new System.EventHandler(this.ScrabbleBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSkipPlay;
        private System.Windows.Forms.Button btnRemovePlayedPieces;
        private System.Windows.Forms.TextBox txtBoxScore;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.GroupBox grpBoxBoard;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.TextBox txtBoxPlayerName;
        private System.Windows.Forms.GroupBox grpBoxHand;
        private System.Windows.Forms.ListBox lstBoxRules;
    }
}