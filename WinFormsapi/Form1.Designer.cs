
namespace WinFormsapi
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
			this.btnview = new System.Windows.Forms.Button();
			this.txtResponse = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// btnview
			// 
			this.btnview.Location = new System.Drawing.Point(372, 18);
			this.btnview.Name = "btnview";
			this.btnview.Size = new System.Drawing.Size(75, 23);
			this.btnview.TabIndex = 1;
			this.btnview.Text = "view";
			this.btnview.UseVisualStyleBackColor = true;
			this.btnview.Click += new System.EventHandler(this.btnview_Click);
			// 
			// txtResponse
			// 
			this.txtResponse.Location = new System.Drawing.Point(12, 47);
			this.txtResponse.Name = "txtResponse";
			this.txtResponse.Size = new System.Drawing.Size(776, 391);
			this.txtResponse.TabIndex = 2;
			this.txtResponse.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtResponse);
			this.Controls.Add(this.btnview);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnview;
		private System.Windows.Forms.RichTextBox txtResponse;
	}
}

