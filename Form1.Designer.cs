namespace Sistemi_Odločanja
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
			ParameterName = new TextBox();
			label1 = new Label();
			folderBrowserDialog1 = new FolderBrowserDialog();
			openFileDialog1 = new OpenFileDialog();
			saveFileDialog1 = new SaveFileDialog();
			param_dropdown = new ComboBox();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			button1 = new Button();
			theme = new TextBox();
			label5 = new Label();
			treeView1 = new TreeView();
			button2 = new Button();
			SuspendLayout();
			// 
			// ParameterName
			// 
			ParameterName.BackColor = SystemColors.ScrollBar;
			ParameterName.Location = new Point(159, 324);
			ParameterName.Name = "ParameterName";
			ParameterName.Size = new Size(100, 23);
			ParameterName.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.ForeColor = Color.Linen;
			label1.Location = new Point(159, 306);
			label1.Name = "label1";
			label1.Size = new Size(87, 15);
			label1.TabIndex = 1;
			label1.Text = "Ime Parametra:";
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			// 
			// param_dropdown
			// 
			param_dropdown.BackColor = SystemColors.ScrollBar;
			param_dropdown.FormattingEnabled = true;
			param_dropdown.Location = new Point(149, 414);
			param_dropdown.Name = "param_dropdown";
			param_dropdown.Size = new Size(121, 23);
			param_dropdown.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.ForeColor = Color.Linen;
			label2.Location = new Point(149, 396);
			label2.Name = "label2";
			label2.Size = new Size(86, 15);
			label2.TabIndex = 3;
			label2.Text = "Nadparameter:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 16F);
			label3.ForeColor = Color.Linen;
			label3.Location = new Point(123, 260);
			label3.Name = "label3";
			label3.Size = new Size(177, 30);
			label3.TabIndex = 4;
			label3.Text = "Dodaj parameter";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Arial", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label4.ForeColor = Color.Peru;
			label4.Location = new Point(68, 32);
			label4.Name = "label4";
			label4.Size = new Size(321, 45);
			label4.TabIndex = 5;
			label4.Text = "MAUT Odločanje";
			// 
			// button1
			// 
			button1.BackColor = Color.Peru;
			button1.Location = new Point(159, 500);
			button1.Name = "button1";
			button1.Size = new Size(97, 38);
			button1.TabIndex = 6;
			button1.Text = "Dodaj parameter";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// theme
			// 
			theme.BackColor = SystemColors.ScrollBar;
			theme.Location = new Point(159, 113);
			theme.Name = "theme";
			theme.Size = new Size(100, 23);
			theme.TabIndex = 7;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.ForeColor = Color.Linen;
			label5.Location = new Point(159, 95);
			label5.Name = "label5";
			label5.Size = new Size(90, 15);
			label5.TabIndex = 8;
			label5.Text = "Tema odločanja";
			// 
			// treeView1
			// 
			treeView1.BackColor = SystemColors.ScrollBar;
			treeView1.Location = new Point(418, 12);
			treeView1.Name = "treeView1";
			treeView1.Size = new Size(783, 572);
			treeView1.TabIndex = 9;
			// 
			// button2
			// 
			button2.BackColor = Color.Peru;
			button2.Location = new Point(159, 194);
			button2.Name = "button2";
			button2.Size = new Size(97, 38);
			button2.TabIndex = 10;
			button2.Text = "Potrdi Ime teme";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(64, 64, 64);
			ClientSize = new Size(1213, 596);
			Controls.Add(button2);
			Controls.Add(treeView1);
			Controls.Add(label5);
			Controls.Add(theme);
			Controls.Add(button1);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(param_dropdown);
			Controls.Add(label1);
			Controls.Add(ParameterName);
			Name = "Form1";
			Text = "MAUT odločanje";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox ParameterName;
		private Label label1;
		private FolderBrowserDialog folderBrowserDialog1;
		private OpenFileDialog openFileDialog1;
		private SaveFileDialog saveFileDialog1;
		private ComboBox param_dropdown;
		private Label label2;
		private Label label3;
		private Label label4;
		private Button button1;
		private TextBox theme;
		private Label label5;
		private TreeView treeView1;
		private Button button2;
	}
}
