namespace Ps3ExtraPlayer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			listView1 = new ListView();
			folderBrowserDialog1 = new FolderBrowserDialog();
			SuspendLayout();
			// 
			// listView1
			// 
			listView1.Activation = ItemActivation.OneClick;
			listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			listView1.HotTracking = true;
			listView1.HoverSelection = true;
			listView1.Location = new Point(12, 12);
			listView1.MultiSelect = false;
			listView1.Name = "listView1";
			listView1.Size = new Size(776, 426);
			listView1.TabIndex = 0;
			listView1.UseCompatibleStateImageBehavior = false;
			listView1.View = View.List;
			listView1.ItemActivate += listView1_ItemActivate;
			listView1.DragDrop += listView1_DragDrop;
			listView1.DragEnter += listView1_DragEnter;
			listView1.KeyPress += listView1_KeyPress;
			listView1.MouseDoubleClick += listView1_MouseDoubleClick;
			// 
			// Form1
			// 
			AllowDrop = true;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(listView1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Form1";
			Text = "PS3 Extra Player";
			Click += Form1_Click;
			DragDrop += Form1_DragDrop;
			DoubleClick += Form1_DoubleClick;
			ResumeLayout(false);
		}

		#endregion

		private ListView listView1;
		private FolderBrowserDialog folderBrowserDialog1;
	}
}
