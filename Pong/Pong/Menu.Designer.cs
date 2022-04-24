
namespace Pong
{
    partial class Menu
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
            this.btn_NewGame = new System.Windows.Forms.Button();
            this.btn_Options = new System.Windows.Forms.Button();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.lbl_Pong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_NewGame
            // 
            this.btn_NewGame.Location = new System.Drawing.Point(13, 355);
            this.btn_NewGame.Name = "btn_NewGame";
            this.btn_NewGame.Size = new System.Drawing.Size(775, 23);
            this.btn_NewGame.TabIndex = 0;
            this.btn_NewGame.Text = "Start";
            this.btn_NewGame.UseVisualStyleBackColor = true;
            this.btn_NewGame.Click += new System.EventHandler(this.btn_NewGame_Click);
            // 
            // btn_Options
            // 
            this.btn_Options.Location = new System.Drawing.Point(13, 385);
            this.btn_Options.Name = "btn_Options";
            this.btn_Options.Size = new System.Drawing.Size(775, 23);
            this.btn_Options.TabIndex = 1;
            this.btn_Options.Text = "Options";
            this.btn_Options.UseVisualStyleBackColor = true;
            // 
            // btn_Quit
            // 
            this.btn_Quit.Location = new System.Drawing.Point(13, 415);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(775, 23);
            this.btn_Quit.TabIndex = 2;
            this.btn_Quit.Text = "Quit";
            this.btn_Quit.UseVisualStyleBackColor = true;
            // 
            // lbl_Pong
            // 
            this.lbl_Pong.AutoSize = true;
            this.lbl_Pong.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Pong.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pong.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbl_Pong.Location = new System.Drawing.Point(239, 128);
            this.lbl_Pong.Name = "lbl_Pong";
            this.lbl_Pong.Size = new System.Drawing.Size(332, 108);
            this.lbl_Pong.TabIndex = 3;
            this.lbl_Pong.Text = "PONG";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Pong);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.btn_Options);
            this.Controls.Add(this.btn_NewGame);
            this.Name = "Menu";
            this.Text = "PONG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_NewGame;
        private System.Windows.Forms.Button btn_Options;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.Label lbl_Pong;
    }
}