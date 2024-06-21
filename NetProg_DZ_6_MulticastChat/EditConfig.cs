using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetProg_DZ_6_MulticastChat
{
	public partial class EditConfigForm : Form
	{
		Client client = new Client();
		public EditConfigForm(Client _client)
		{
			client = _client;
			InitializeComponent();

			textBox_ID.Text = client.Id.ToString();
			textBox_Name.Text = client.Name;
			textBox_IPMulticast.Text = client.MulticastIP;
			textBox_Port.Text = client.Port.ToString();
		}

		private void button_Exit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button_Save_Click(object sender, EventArgs e)
		{
			try
			{
				client.Id = Int32.Parse(textBox_ID.Text);
				client.Name = textBox_Name.Text;
				client.MulticastIP = textBox_IPMulticast.Text;
				client.Port = Int32.Parse(textBox_Port.Text);
				ConfigSerializeDeserialize.ConfigWriteReadJson.ReWriteConfig(client, "Config.json");
				MessageBox.Show("Настройки сохранены");
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}


		}
	}
}
