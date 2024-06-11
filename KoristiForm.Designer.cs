namespace Sistemi_Odločanja
{
	partial class KoristiForm
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
			koristTable = new DataGridView();
			label1 = new Label();
			PotrdiKoristi = new Button();
			((System.ComponentModel.ISupportInitialize)koristTable).BeginInit();
			SuspendLayout();
			// 
			// koristTable
			// 
			koristTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			koristTable.Location = new Point(12, 44);
			koristTable.Name = "koristTable";
			koristTable.Size = new Size(499, 586);
			koristTable.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
			label1.ForeColor = Color.Peru;
			label1.Location = new Point(150, 9);
			label1.Name = "label1";
			label1.Size = new Size(195, 32);
			label1.TabIndex = 1;
			label1.Text = "Vpišite koristi";
			// 
			// PotrdiKoristi
			// 
			PotrdiKoristi.BackColor = Color.Peru;
			PotrdiKoristi.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
			PotrdiKoristi.Location = new Point(12, 636);
			PotrdiKoristi.Name = "PotrdiKoristi";
			PotrdiKoristi.Size = new Size(499, 53);
			PotrdiKoristi.TabIndex = 12;
			PotrdiKoristi.Text = "Naslednji Korak";
			PotrdiKoristi.UseVisualStyleBackColor = false;
			PotrdiKoristi.Click += PotrdiKoristi_Click;
			// 
			// KoristiForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(64, 64, 64);
			ClientSize = new Size(523, 697);
			Controls.Add(PotrdiKoristi);
			Controls.Add(label1);
			Controls.Add(koristTable);
			Name = "KoristiForm";
			Text = "KoristiForm";
			((System.ComponentModel.ISupportInitialize)koristTable).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView koristTable;
		private Label label1;
		private Button PotrdiKoristi;
	}
}