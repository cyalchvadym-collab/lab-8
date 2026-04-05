using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab8_ButtonEscaper
{
	public partial class Form1 : Form
	{
		private System.Windows.Forms.Timer moveTimer;
		private float speed = 5f;
		private float acceleration = 1.2f;
		private int targetX, targetY;
		private int margin = 50;
		private int catchCount = 0;
		private int missCount = 0;

		public Form1()
		{
			InitializeComponent();
			InitializeTimer();
		}

		private void InitializeTimer()
		{
			moveTimer = new System.Windows.Forms.Timer();
			moveTimer.Interval = 16;
			moveTimer.Tick += MoveTimer_Tick;
		}

		private void escapeButton_MouseEnter(object sender, EventArgs e)
		{
			if (crazyModeCheck.Checked)
			{
				TeleportButton();
			}
			else
			{
				CalculateEscapePosition();
				if (!moveTimer.Enabled)
				{
					speed = speedTrackBar.Value;
					moveTimer.Start();
				}
			}
		}

		private void escapeButton_Click(object sender, EventArgs e)
		{
			catchCount++;
			UpdateScore();

			MessageBox.Show($"Вітаю! Ви спіймали кнопку!\nВсього спіймано: {catchCount}",
				"Перемога!", MessageBoxButtons.OK, MessageBoxIcon.Information);

			speed = speedTrackBar.Value;
			escapeButton.Location = new Point(400, 300);
		}

		private void TeleportButton()
		{
			Random rand = new Random();
			int newX = rand.Next(margin, this.ClientSize.Width - margin - escapeButton.Width);
			int newY = rand.Next(margin + 100, this.ClientSize.Height - margin - escapeButton.Height);
			escapeButton.Location = new Point(newX, newY);
			missCount++;
			UpdateScore();
		}

		private void CalculateEscapePosition()
		{
			Point cursorPos = this.PointToClient(Cursor.Position);
			Point buttonCenter = new Point(
				escapeButton.Location.X + escapeButton.Width / 2,
				escapeButton.Location.Y + escapeButton.Height / 2
			);

			int dx = buttonCenter.X - cursorPos.X;
			int dy = buttonCenter.Y - cursorPos.Y;
			double distance = Math.Sqrt(dx * dx + dy * dy);
			if (distance < 1) distance = 1;

			double escapeDirX = dx / distance;
			double escapeDirY = dy / distance;

			Random rand = new Random();
			escapeDirX += (rand.NextDouble() - 0.5) * 0.5;
			escapeDirY += (rand.NextDouble() - 0.5) * 0.5;

			int escapeDistance = 200 + rand.Next(100);
			targetX = buttonCenter.X + (int)(escapeDirX * escapeDistance);
			targetY = buttonCenter.Y + (int)(escapeDirY * escapeDistance);

			targetX = Math.Max(margin, Math.Min(this.ClientSize.Width - margin - escapeButton.Width, targetX));
			targetY = Math.Max(margin + 100, Math.Min(this.ClientSize.Height - margin - escapeButton.Height, targetY));
		}

		private void MoveTimer_Tick(object sender, EventArgs e)
		{
			int currentX = escapeButton.Location.X;
			int currentY = escapeButton.Location.Y;

			int diffX = targetX - currentX;
			int diffY = targetY - currentY;
			double distance = Math.Sqrt(diffX * diffX + diffY * diffY);

			if (distance < 5)
			{
				moveTimer.Stop();
				speed = speedTrackBar.Value;
				return;
			}

			speed = Math.Min(speed * acceleration, 30f);

			double moveRatio = speed / distance;
			int newX = currentX + (int)(diffX * moveRatio);
			int newY = currentY + (int)(diffY * moveRatio);

			escapeButton.Location = new Point(newX, newY);
		}

		private void resetButton_Click(object sender, EventArgs e)
		{
			catchCount = 0;
			missCount = 0;
			UpdateScore();
			speed = speedTrackBar.Value;
			escapeButton.Location = new Point(400, 300);
		}

		private void difficultyButton_Click(object sender, EventArgs e)
		{
			if (acceleration == 1.2f)
			{
				acceleration = 1.05f;
				difficultyButton.Text = "Складність: Легко";
				difficultyButton.BackColor = Color.LightGreen;
			}
			else if (acceleration == 1.05f)
			{
				acceleration = 1.3f;
				difficultyButton.Text = "Складність: Складно";
				difficultyButton.BackColor = Color.Orange;
			}
			else
			{
				acceleration = 1.2f;
				difficultyButton.Text = "Складність: Нормально";
				difficultyButton.BackColor = Color.Yellow;
			}
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void speedTrackBar_ValueChanged(object sender, EventArgs e)
		{
			speed = speedTrackBar.Value;
		}

		private void crazyModeCheck_CheckedChanged(object sender, EventArgs e)
		{
			if (crazyModeCheck.Checked)
			{
				escapeButton.BackColor = Color.Purple;
				escapeButton.Text = "ТЕЛЕПОРТ!";
			}
			else
			{
				escapeButton.BackColor = Color.Tomato;
				escapeButton.Text = "Спіймай мене!";
			}
		}

		private void Form1_MouseClick(object sender, MouseEventArgs e)
		{
			missCount++;
			UpdateScore();
		}

		private void UpdateScore()
		{
			scoreLabel.Text = $"Спіймано: {catchCount} | Промахів: {missCount}";
		}
	}
}