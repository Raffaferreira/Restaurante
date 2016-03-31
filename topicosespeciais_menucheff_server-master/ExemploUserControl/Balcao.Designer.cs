namespace ExemploUserControl
{
	partial class Balcao
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
			this.Panel1 = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// Panel1
			// 
			this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Panel1.AutoScroll = true;
			this.Panel1.Location = new System.Drawing.Point(12, 12);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(616, 237);
			this.Panel1.TabIndex = 0;
			// 
			// Balcao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(639, 261);
			this.Controls.Add(this.Panel1);
			this.Name = "Balcao";
			this.Text = "Balcao";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel Panel1;
	}
}