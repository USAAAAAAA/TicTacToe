namespace TicTacToe
{
    partial class TicTacToeForm
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
            buttonPlayer = new Button();
            panelButtons = new Panel();
            labelPlayer = new Label();
            SuspendLayout();
            // 
            // buttonPlayer
            // 
            buttonPlayer.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPlayer.Location = new Point(664, 100);
            buttonPlayer.Margin = new Padding(4);
            buttonPlayer.Name = "buttonPlayer";
            buttonPlayer.Size = new Size(133, 123);
            buttonPlayer.TabIndex = 0;
            buttonPlayer.Text = "X";
            buttonPlayer.UseVisualStyleBackColor = true;
            // 
            // panelButtons
            // 
            panelButtons.Location = new Point(35, 31);
            panelButtons.Margin = new Padding(4);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(600, 554);
            panelButtons.TabIndex = 1;
            // 
            // labelPlayer
            // 
            labelPlayer.AutoSize = true;
            labelPlayer.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPlayer.Location = new Point(664, 65);
            labelPlayer.Margin = new Padding(4, 0, 4, 0);
            labelPlayer.Name = "labelPlayer";
            labelPlayer.Size = new Size(112, 37);
            labelPlayer.TabIndex = 2;
            labelPlayer.Text = "Player";
            // 
            // TicTacToeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 608);
            Controls.Add(labelPlayer);
            Controls.Add(panelButtons);
            Controls.Add(buttonPlayer);
            Name = "TicTacToeForm";
            Text = "Tic Tac Toe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPlayer;
        private Panel panelButtons;
        private Label labelPlayer;
    }
}
