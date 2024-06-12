namespace Sistemi_Odločanja
{
	partial class Visualisation
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
			saveFileDialog1 = new SaveFileDialog();
			Vizualizacija = new Button();
			SuspendLayout();
			// 
			// Vizualizacija
			// 
			Vizualizacija.BackColor = Color.Peru;
			Vizualizacija.Font = new Font("Segoe UI Semibold", 10.75F, FontStyle.Bold);
			Vizualizacija.Location = new Point(594, 21);
			Vizualizacija.Name = "Vizualizacija";
			Vizualizacija.Size = new Size(180, 79);
			Vizualizacija.TabIndex = 13;
			Vizualizacija.Text = "Shrani Vizualizacijo";
			Vizualizacija.UseVisualStyleBackColor = false;
			Vizualizacija.Click += Vizualizacija_Click;
			// 
			// Visualisation
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(Vizualizacija);
			Name = "Visualisation";
			Text = "Visualisation";
			ResumeLayout(false);
		}

		#endregion

		private SaveFileDialog saveFileDialog1;
		private Button Vizualizacija;
	}
}