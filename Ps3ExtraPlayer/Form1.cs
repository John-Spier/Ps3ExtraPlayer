using System.Diagnostics;
using System.Xml.Linq;

namespace Ps3ExtraPlayer
{
	public partial class Form1 : Form
	{
		public Dictionary<string, string>? Dictionary { get; set; }
		public Form1()
		{
			InitializeComponent();
		}

		private void listView1_DragDrop(object sender, DragEventArgs e)
		{
			//why doesnt this work
		}

		string ParseOneFile(string XmlPath)
		{
			XAttribute SfxKey = new("key", "TITLE");
			XDocument ParamSfx = XDocument.Load(XmlPath);
			XElement ParamSfo = ParamSfx.Element("paramsfo");
			IEnumerable<XElement> ParamTitle =
				from x in ParamSfo.Elements()
				where x.Attribute("key").Value == "TITLE"
				select x;
			return ParamTitle.FirstOrDefault().Value;
		}

		private void listView1_DragEnter(object sender, DragEventArgs e)
		{
			//MessageBox.Show(e.Effect.ToString());
			//e.Effect = DragDropEffects.All;
		}

		private void Form1_DragDrop(object sender, DragEventArgs e)
		{
			//MessageBox.Show("Form Dropped");
		}

		private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
		{

		}

		private void Form1_Click(object sender, EventArgs e)
		{

		}

		private void LoadFilesFromDialog()
		{
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				string fpath = folderBrowserDialog1.SelectedPath;
				Dictionary ??= [];
				string p;

				foreach (string d in Directory.GetFiles(fpath, "PARAM.SFX", SearchOption.AllDirectories))
				{
					try { 
						p = ParseOneFile(d);
						Dictionary.Add(p, Path.GetDirectoryName(d) + "\\DATA000" + Path.GetExtension(p));
						listView1.Items.Add(p);
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}

			}
		}

		private void listView1_ItemActivate(object sender, EventArgs e)
		{
			try
			{
				new Process
				{
					StartInfo = new ProcessStartInfo(Dictionary[listView1.SelectedItems[0].Text])
					{
						UseShellExecute = true
					}
				}.Start();
			}
			catch (Exception f)
			{
				MessageBox.Show(f.Message);
			}
		}

		private void listView1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!e.Handled) 
			{
				switch (e.KeyChar)
				{
					case (char)27:
						listView1.Items.Clear();
						LoadFilesFromDialog();
						break;
					default:
						break;
				}

			}
		}
	}
}
