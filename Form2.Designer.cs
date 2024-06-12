namespace Sistemi_Odločanja
{
	partial class RezultatiForm
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			avg_val = new Label();
			min_val_name = new Label();
			max_val_name = new Label();
			min_val = new Label();
			max_val = new Label();
			Vizualizacija = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
			label1.Location = new Point(12, 30);
			label1.Name = "label1";
			label1.Size = new Size(177, 24);
			label1.TabIndex = 0;
			label1.Text = "Največja vrednost";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
			label2.Location = new Point(276, 30);
			label2.Name = "label2";
			label2.Size = new Size(168, 24);
			label2.TabIndex = 1;
			label2.Text = "Najnižja vrednost";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
			label3.Location = new Point(511, 30);
			label3.Name = "label3";
			label3.Size = new Size(280, 24);
			label3.TabIndex = 2;
			label3.Text = "Povprečna vrednost drevesa";
			// 
			// avg_val
			// 
			avg_val.AutoSize = true;
			avg_val.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
			avg_val.Location = new Point(612, 145);
			avg_val.Name = "avg_val";
			avg_val.Size = new Size(83, 24);
			avg_val.TabIndex = 3;
			avg_val.Text = "avg_val";
			// 
			// min_val_name
			// 
			min_val_name.AutoSize = true;
			min_val_name.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
			min_val_name.Location = new Point(290, 145);
			min_val_name.Name = "min_val_name";
			min_val_name.Size = new Size(144, 24);
			min_val_name.TabIndex = 4;
			min_val_name.Text = "min_val_name";
			// 
			// max_val_name
			// 
			max_val_name.AutoSize = true;
			max_val_name.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
			max_val_name.Location = new Point(23, 145);
			max_val_name.Name = "max_val_name";
			max_val_name.Size = new Size(150, 24);
			max_val_name.TabIndex = 5;
			max_val_name.Text = "max_val_name";
			// 
			// min_val
			// 
			min_val.AutoSize = true;
			min_val.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
			min_val.Location = new Point(328, 202);
			min_val.Name = "min_val";
			min_val.Size = new Size(81, 24);
			min_val.TabIndex = 6;
			min_val.Text = "min_val";
			// 
			// max_val
			// 
			max_val.AutoSize = true;
			max_val.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
			max_val.Location = new Point(62, 202);
			max_val.Name = "max_val";
			max_val.Size = new Size(87, 24);
			max_val.TabIndex = 7;
			max_val.Text = "max_val";
			// 
			// Vizualizacija
			// 
			Vizualizacija.BackColor = Color.Peru;
			Vizualizacija.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
			Vizualizacija.Location = new Point(577, 369);
			Vizualizacija.Name = "Vizualizacija";
			Vizualizacija.Size = new Size(190, 53);
			Vizualizacija.TabIndex = 12;
			Vizualizacija.Text = "Vizualizacija";
			Vizualizacija.UseVisualStyleBackColor = false;
			Vizualizacija.Click += Vizualizacija_Click;
			// 
			// RezultatiForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(Vizualizacija);
			Controls.Add(max_val);
			Controls.Add(min_val);
			Controls.Add(max_val_name);
			Controls.Add(min_val_name);
			Controls.Add(avg_val);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "RezultatiForm";
			Text = "Rezultati";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label avg_val;
		private Label min_val_name;
		private Label max_val_name;
		private Label min_val;
		private Label max_val;
		private Button Vizualizacija;
	}
}