using ConfigSerializeDeserialize;
using System.Linq;

namespace NetProg_DZ_6_MulticastChat
{
	public partial class ClientForm : Form
	{
		Random random = new Random();

		List<string> CONTROLMESSAGES = new List<string>()
		{
			"*#ADDME___",
			"*#ClEARME___",
		};

		Client client = ConfigWriteReadJson.ReadConfig<Client>("Config.json");

		ServerModul serverModul;
		ClientModul clientModul;
		public ClientForm()
		{
			client.Name = client.Name + "_" + (random.Next(1000, 9999)).ToString();
			InitializeComponent();
			serverModul = new ServerModul(client);
			clientModul = new ClientModul(client);
			Task.Run(new Action(() => clientModul.Listener()));
			clientModul.AppendTextEvent += UpdateMessages;



			//При первом подключении отправляю запрос на получение списка клиентов
			serverModul.SendMessage(CONTROLMESSAGES[0] + client.Name);
			listBoxClients.Items.Add(client.Name);
		}

		void UpdateMessages(string _message)
		{
			//*#ADDME___
			if (_message.Contains(CONTROLMESSAGES[0]))
			{

				string newClientName = _message.Replace(CONTROLMESSAGES[0], "");

				Invoke(new Action(() => listBoxClients.Items.Add(newClientName)));

			}
			//*#ClEARME___
			else if (_message.Contains(CONTROLMESSAGES[1]))
			{
				Invoke(new Action(() => listBoxClients.Items.Remove(_message.Replace(CONTROLMESSAGES[1], ""))));
			}
			else
			{
				Invoke(new Action(() => richTextBoxMessages.AppendText((_message))));
				Invoke(new Action(() => richTextBoxMessages.AppendText("\n")));
				Invoke(new Action(() => richTextBoxToWrite.Clear()));
			}
			
		}

		string getTimeNow()
		{
			return (DateTime.Now.Date + DateTime.Now.TimeOfDay).ToString();
		}

		private void EditConfigToolStripMenuItem_Click(object sender, EventArgs e)
		{
			EditConfigForm ec = new EditConfigForm(client);
			ec.ShowDialog();
		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void richTextBoxToWrite_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				serverModul.SendMessage(getTimeNow() + '\t' + client.Name + ":\t" + richTextBoxToWrite.Text);
				richTextBoxToWrite.Clear();
			}
		}

		private void ClientForm_Load(object sender, EventArgs e)
		{
			serverModul.SendMessage($"{getTimeNow()}\t{client.Name} вошел в чат");
		}

		private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			serverModul.SendMessage(CONTROLMESSAGES[1] + client.Name);
		}
	}
}
