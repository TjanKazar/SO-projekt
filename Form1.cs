namespace Sistemi_Odločanja
{
	public partial class Form1 : Form
	{
		public List<Parameter> parametri;
		public string imeTeme;

		public Form1()
		{
			parametri = new List<Parameter>();
			InitializeComponent();
			ParameterName.Enabled = false;
			param_dropdown.Enabled = false;
			button1.Enabled = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(ParameterName.Text))
			{
				MessageBox.Show("Prosim vstavite ime parametra.");
				return;
			}

			if (parametri.Any(p => p.Ime == ParameterName.Text))
			{
				MessageBox.Show("Parameter s tem imenom že obstaja.");
				return;
			}

			Parameter param = new Parameter()
			{
				Ime = ParameterName.Text,
				Podparametri = new List<Parameter>(),
				Parent = param_dropdown.Text
			};

			if (param.Parent == imeTeme)
			{
				param.baseNode = true;
			}

			TreeNode node = new TreeNode(param.Ime);
			string selectedNodeName = param_dropdown.Text;

			TreeNode selectedNode = FindNodeByName(selectedNodeName, treeView1.Nodes[0]);
			if (selectedNode != null)
			{
				selectedNode.Nodes.Add(node);

				Parameter found = parametri.Find(p => p.Ime == selectedNodeName);
				if (found != null)
				{
					found.Podparametri.Add(param);
				}
			}
			else
			{
				MessageBox.Show("Tega parametra ni v strukturi.");
				return;
			}

			param_dropdown.Items.Add(param.Ime);
			parametri.Add(param);
			ParameterName.Text = "";
			treeView1.ExpandAll();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(theme.Text))
			{
				MessageBox.Show("Prosim vstavite ime teme.");
				return;
			}

			param_dropdown.Items.Add(theme.Text);
			param_dropdown.Text = theme.Text;
			imeTeme = theme.Text;
			TreeNode startNode = new TreeNode(imeTeme + " (base)");
			treeView1.Nodes.Add(startNode);
			button2.Enabled = false;
			ParameterName.Enabled = true;
			param_dropdown.Enabled = true;
			button1.Enabled = true;
			treeView1.ExpandAll(); 
		}

		private TreeNode FindNodeByName(string searchText, TreeNode startNode)
		{
			if (startNode.Text.ToLower().Contains(searchText.ToLower()))
			{
				return startNode;
			}

			foreach (TreeNode childNode in startNode.Nodes)
			{
				TreeNode foundNode = FindNodeByName(searchText, childNode);
				if (foundNode != null)
				{
					return foundNode;
				}
			}
			return null;
		}

		private void PotrdiDrevo_Click(object sender, EventArgs e)
		{
			if (parametri.Count == 0 || treeView1.Nodes.Count == 0)
			{
				MessageBox.Show("Prosimo, da najprej dodate vsaj en parameter.");
				return;
			}

			KoristiForm form = new KoristiForm(parametri);
			form.Show();
		}
	}
}
