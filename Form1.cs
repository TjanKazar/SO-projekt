namespace Sistemi_Odločanja
{
	public partial class Form1 : Form
	{
		public List<Parameter> parametri;
		public string imeAlternative;

		public Form1()
		{
			parametri = new List<Parameter>();
			InitializeComponent();
			ParameterName.Enabled = false;
			param_dropdown.Enabled = false;
			button1.Enabled = false;
		}

		private void ParameterName_TextChanged(object sender, EventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(ParameterName.Text))
			{
				MessageBox.Show("Prosim vstavite ime parametra.");
				return;
			}

			Parameter param = new()
			{
				Ime = ParameterName.Text,
				Podparametri = []
			};

			TreeNode node = new TreeNode(param.Ime);
			string selectedNodeName = param_dropdown.Text;

			TreeNode selectedNode = FindNodeByName(selectedNodeName, treeView1.Nodes[0]);
			if (selectedNode != null)
			{
				selectedNode.Nodes.Add(node);
			}
			else
			{
				MessageBox.Show("Tega parametra ni v strukturi.");
				return;
			}

			param_dropdown.Items.Add(param.Ime);
		}


		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			param_dropdown.Items.Add(theme.Text);
			param_dropdown.Text = theme.Text;
			imeAlternative = theme.Text;
			TreeNode startNode = new(imeAlternative);
			treeView1.Nodes.Add(startNode);
			button2.Enabled = false;
			ParameterName.Enabled = true;
			param_dropdown.Enabled = true;
			button1.Enabled = true;
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


	}
}