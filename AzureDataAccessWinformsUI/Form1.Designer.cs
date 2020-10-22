namespace AzureDataAccessWinformsUI
{
    partial class Form1
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
            this.gamesListBox = new System.Windows.Forms.ListBox();
            this.getGamesButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameOfGameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.insertGameButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamesListBox
            // 
            this.gamesListBox.FormattingEnabled = true;
            this.gamesListBox.ItemHeight = 16;
            this.gamesListBox.Location = new System.Drawing.Point(24, 54);
            this.gamesListBox.Name = "gamesListBox";
            this.gamesListBox.Size = new System.Drawing.Size(317, 276);
            this.gamesListBox.TabIndex = 0;
            // 
            // getGamesButton
            // 
            this.getGamesButton.Location = new System.Drawing.Point(108, 349);
            this.getGamesButton.Name = "getGamesButton";
            this.getGamesButton.Size = new System.Drawing.Size(148, 43);
            this.getGamesButton.TabIndex = 1;
            this.getGamesButton.Text = "Get Games";
            this.getGamesButton.UseVisualStyleBackColor = true;
            this.getGamesButton.Click += new System.EventHandler(this.getGamesButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.insertGameButton);
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(this.nameOfGameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(420, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 338);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert Game";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of the game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // nameOfGameTextBox
            // 
            this.nameOfGameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOfGameTextBox.Location = new System.Drawing.Point(9, 55);
            this.nameOfGameTextBox.Name = "nameOfGameTextBox";
            this.nameOfGameTextBox.Size = new System.Drawing.Size(326, 28);
            this.nameOfGameTextBox.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(9, 114);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(326, 162);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // insertGameButton
            // 
            this.insertGameButton.Location = new System.Drawing.Point(187, 289);
            this.insertGameButton.Name = "insertGameButton";
            this.insertGameButton.Size = new System.Drawing.Size(148, 43);
            this.insertGameButton.TabIndex = 4;
            this.insertGameButton.Text = "Insert Game";
            this.insertGameButton.UseVisualStyleBackColor = true;
            this.insertGameButton.Click += new System.EventHandler(this.insertGameButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.getGamesButton);
            this.Controls.Add(this.gamesListBox);
            this.Name = "Form1";
            this.Text = "Azure Data Acess - Games";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox gamesListBox;
        private System.Windows.Forms.Button getGamesButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button insertGameButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox nameOfGameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

