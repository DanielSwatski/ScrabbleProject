
namespace ScrabbleFinalProject
{
    partial class Title
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Title));
            this.txtBoxPlayers = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grpBoxLanguage = new System.Windows.Forms.GroupBox();
            this.radButtonFrench = new System.Windows.Forms.RadioButton();
            this.radButtonEnglish = new System.Windows.Forms.RadioButton();
            this.btnBegin = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtBoxWidth = new System.Windows.Forms.TextBox();
            this.txtBoxHeight = new System.Windows.Forms.TextBox();
            this.lblNumberOfPlayers = new System.Windows.Forms.Label();
            this.radButtonItalian = new System.Windows.Forms.RadioButton();
            this.grpBoxLanguage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxPlayers
            // 
            this.txtBoxPlayers.Location = new System.Drawing.Point(87, 76);
            this.txtBoxPlayers.Name = "txtBoxPlayers";
            this.txtBoxPlayers.Size = new System.Drawing.Size(100, 22);
            this.txtBoxPlayers.TabIndex = 0;
            this.txtBoxPlayers.Text = "3";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // grpBoxLanguage
            // 
            this.grpBoxLanguage.Controls.Add(this.radButtonItalian);
            this.grpBoxLanguage.Controls.Add(this.radButtonFrench);
            this.grpBoxLanguage.Controls.Add(this.radButtonEnglish);
            this.grpBoxLanguage.Location = new System.Drawing.Point(46, 252);
            this.grpBoxLanguage.Name = "grpBoxLanguage";
            this.grpBoxLanguage.Size = new System.Drawing.Size(200, 100);
            this.grpBoxLanguage.TabIndex = 6;
            this.grpBoxLanguage.TabStop = false;
            this.grpBoxLanguage.Text = "Language Choice";
            // 
            // radButtonFrench
            // 
            this.radButtonFrench.AutoSize = true;
            this.radButtonFrench.Location = new System.Drawing.Point(6, 48);
            this.radButtonFrench.Name = "radButtonFrench";
            this.radButtonFrench.Size = new System.Drawing.Size(73, 21);
            this.radButtonFrench.TabIndex = 9;
            this.radButtonFrench.Text = "French";
            this.radButtonFrench.UseVisualStyleBackColor = true;
            // 
            // radButtonEnglish
            // 
            this.radButtonEnglish.AutoSize = true;
            this.radButtonEnglish.Checked = true;
            this.radButtonEnglish.Location = new System.Drawing.Point(6, 21);
            this.radButtonEnglish.Name = "radButtonEnglish";
            this.radButtonEnglish.Size = new System.Drawing.Size(75, 21);
            this.radButtonEnglish.TabIndex = 8;
            this.radButtonEnglish.TabStop = true;
            this.radButtonEnglish.Text = "English";
            this.radButtonEnglish.UseVisualStyleBackColor = true;
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(74, 378);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(110, 39);
            this.btnBegin.TabIndex = 7;
            this.btnBegin.Text = "Begin Game";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(264, 153);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(524, 264);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // txtBoxWidth
            // 
            this.txtBoxWidth.Location = new System.Drawing.Point(87, 179);
            this.txtBoxWidth.Name = "txtBoxWidth";
            this.txtBoxWidth.Size = new System.Drawing.Size(100, 22);
            this.txtBoxWidth.TabIndex = 3;
            this.txtBoxWidth.Text = "15";
            // 
            // txtBoxHeight
            // 
            this.txtBoxHeight.Location = new System.Drawing.Point(87, 138);
            this.txtBoxHeight.Name = "txtBoxHeight";
            this.txtBoxHeight.Size = new System.Drawing.Size(100, 22);
            this.txtBoxHeight.TabIndex = 2;
            this.txtBoxHeight.Text = "15";
            // 
            // lblNumberOfPlayers
            // 
            this.lblNumberOfPlayers.AutoSize = true;
            this.lblNumberOfPlayers.Location = new System.Drawing.Point(84, 45);
            this.lblNumberOfPlayers.Name = "lblNumberOfPlayers";
            this.lblNumberOfPlayers.Size = new System.Drawing.Size(125, 17);
            this.lblNumberOfPlayers.TabIndex = 17;
            this.lblNumberOfPlayers.Text = "Number of Players";
            // 
            // radButtonItalian
            // 
            this.radButtonItalian.AutoSize = true;
            this.radButtonItalian.Location = new System.Drawing.Point(8, 73);
            this.radButtonItalian.Name = "radButtonItalian";
            this.radButtonItalian.Size = new System.Drawing.Size(66, 21);
            this.radButtonItalian.TabIndex = 10;
            this.radButtonItalian.Text = "Italian";
            this.radButtonItalian.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNumberOfPlayers);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.grpBoxLanguage);
            this.Controls.Add(this.txtBoxWidth);
            this.Controls.Add(this.txtBoxHeight);
            this.Controls.Add(this.txtBoxPlayers);
            this.Name = "Title";
            this.Text = "Title";
            this.grpBoxLanguage.ResumeLayout(false);
            this.grpBoxLanguage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxPlayers;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox grpBoxLanguage;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.RadioButton radButtonFrench;
        private System.Windows.Forms.RadioButton radButtonEnglish;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtBoxWidth;
        private System.Windows.Forms.TextBox txtBoxHeight;
        private System.Windows.Forms.Label lblNumberOfPlayers;
        private System.Windows.Forms.RadioButton radButtonItalian;
    }
}

