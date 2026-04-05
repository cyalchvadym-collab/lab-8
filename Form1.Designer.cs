namespace Lab8_ButtonEscaper
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
			escapeButton = new Button();
			infoLabel = new Label();
			scoreLabel = new Label();
			resetButton = new Button();
			difficultyButton = new Button();
			speedTrackBar = new TrackBar();
			crazyModeCheck = new CheckBox();
			exitButton = new Button();
			((System.ComponentModel.ISupportInitialize)speedTrackBar).BeginInit();
			SuspendLayout();
			// 
			// escapeButton
			// 
			escapeButton.Location = new Point(415, 247);
			escapeButton.Name = "escapeButton";
			escapeButton.Size = new Size(150, 46);
			escapeButton.TabIndex = 0;
			escapeButton.Text = "Спіймай мене!";
			escapeButton.UseVisualStyleBackColor = true;
			escapeButton.Click += escapeButton_Click;
			escapeButton.MouseEnter += escapeButton_MouseEnter;
			// 
			// infoLabel
			// 
			infoLabel.AutoSize = true;
			infoLabel.Location = new Point(12, 9);
			infoLabel.Name = "infoLabel";
			infoLabel.Size = new Size(413, 32);
			infoLabel.TabIndex = 1;
			infoLabel.Text = "Наведіть курсор на червону кнопку";
			// 
			// scoreLabel
			// 
			scoreLabel.AutoSize = true;
			scoreLabel.Location = new Point(12, 64);
			scoreLabel.Name = "scoreLabel";
			scoreLabel.Size = new Size(145, 32);
			scoreLabel.TabIndex = 2;
			scoreLabel.Text = "Спіймано: 0";
			// 
			// resetButton
			// 
			resetButton.Location = new Point(7, 111);
			resetButton.Name = "resetButton";
			resetButton.Size = new Size(150, 46);
			resetButton.TabIndex = 3;
			resetButton.Text = "Скинути";
			resetButton.UseVisualStyleBackColor = true;
			resetButton.Click += resetButton_Click;
			// 
			// difficultyButton
			// 
			difficultyButton.Location = new Point(163, 105);
			difficultyButton.Name = "difficultyButton";
			difficultyButton.Size = new Size(150, 72);
			difficultyButton.TabIndex = 4;
			difficultyButton.Text = "Складність: Нормальнo";
			difficultyButton.UseVisualStyleBackColor = true;
			difficultyButton.Click += difficultyButton_Click;
			// 
			// speedTrackBar
			// 
			speedTrackBar.Location = new Point(397, 396);
			speedTrackBar.Name = "speedTrackBar";
			speedTrackBar.Size = new Size(208, 90);
			speedTrackBar.TabIndex = 5;
			speedTrackBar.ValueChanged += speedTrackBar_ValueChanged;
			// 
			// crazyModeCheck
			// 
			crazyModeCheck.AutoSize = true;
			crazyModeCheck.Location = new Point(611, 411);
			crazyModeCheck.Name = "crazyModeCheck";
			crazyModeCheck.Size = new Size(274, 36);
			crazyModeCheck.TabIndex = 6;
			crazyModeCheck.Text = "Божевільний режим";
			crazyModeCheck.UseVisualStyleBackColor = true;
			crazyModeCheck.CheckedChanged += crazyModeCheck_CheckedChanged;
			// 
			// exitButton
			// 
			exitButton.Location = new Point(926, 471);
			exitButton.Name = "exitButton";
			exitButton.Size = new Size(150, 67);
			exitButton.TabIndex = 7;
			exitButton.Text = "Вихід";
			exitButton.UseVisualStyleBackColor = true;
			exitButton.Click += exitButton_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.LightBlue;
			ClientSize = new Size(1095, 547);
			Controls.Add(exitButton);
			Controls.Add(crazyModeCheck);
			Controls.Add(speedTrackBar);
			Controls.Add(difficultyButton);
			Controls.Add(resetButton);
			Controls.Add(scoreLabel);
			Controls.Add(infoLabel);
			Controls.Add(escapeButton);
			Name = "Form1";
			Text = "Варіант 8 - Кнопка-утікачка";
			MouseClick += Form1_MouseClick;
			((System.ComponentModel.ISupportInitialize)speedTrackBar).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button escapeButton;
		private Label infoLabel;
		private Label scoreLabel;
		private Button resetButton;
		private Button difficultyButton;
		private TrackBar speedTrackBar;
		private CheckBox crazyModeCheck;
		private Button exitButton;
	}
}
