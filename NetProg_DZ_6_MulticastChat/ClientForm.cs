using ConfigSerializeDeserialize;
using System.Linq;

namespace NetProg_DZ_6_MulticastChat
{
	public partial class ClientForm : Form
	{
		Random random = new Random();
		bool flag = true;

		List<string> CONTROLMESSAGES = new List<string>()
		{
			"*#ADDME___",
			"*#ClEARME___",
			"*#ClEARMETO___",
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
			if (flag)
			{
				//*#ADDME___
				if (_message.Contains(CONTROLMESSAGES[0]))
				{
					try
					{
						string newClientName = _message.Replace(CONTROLMESSAGES[0], "");
						Invoke(new Action(() => listBoxClients.Items.Add(newClientName)));
						Invoke(new Action(() => serverModul.SendMessage(CONTROLMESSAGES[2]+client.Name+ CONTROLMESSAGES[2]+newClientName)));
					}
					catch (Exception ex)
					{

						MessageBox.Show(ex.Message);
					}
				}
				//*#ClEARME___
				else if (_message.Contains(CONTROLMESSAGES[1]))
				{
					try
					{
						Invoke(new Action(() => listBoxClients.Items.Remove(_message.Replace(CONTROLMESSAGES[1], ""))));
					}
					catch (Exception ex)
					{

						MessageBox.Show(ex.Message);
					}
				}
				else if (_message.Contains(CONTROLMESSAGES[2]))
				{
					//Invoke(new Action(() => MessageBox.Show("!!!")));
					Invoke(new Action(() =>
					{
						string[] words = _message.Split($"{CONTROLMESSAGES[2]}", StringSplitOptions.RemoveEmptyEntries);
						//MessageBox.Show($"{words[0]}   {words[1]}");
						if (client.Name  == words[1])
						{
							listBoxClients.Items.Add(words[0]);
						}
					}));

				}
				else
				{
					try
					{
						if (_message != null)
						{
							Invoke(new Action(() => richTextBoxMessages.AppendText(_message)));
							Invoke(new Action(() => richTextBoxMessages.AppendText("\n")));
							Invoke(new Action(() => richTextBoxToWrite.Clear()));
						}
					}
					catch (Exception ex)
					{

						MessageBox.Show(ex.Message);
					}

				}
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
			flag = false;
			serverModul.SendMessage(CONTROLMESSAGES[1] + client.Name);
		}
	}
}
