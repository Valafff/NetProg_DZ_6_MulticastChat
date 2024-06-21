using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetProg_DZ_6_MulticastChat
{
	public class ServerModul
	{
		Client client;
		public ServerModul(Client _client)
		{
			client = _client;
		}
		public void SendMessage(string _messege)
		{
			//IP адрес для рассылки multicast
			IPAddress MultiCastIP = IPAddress.Parse(client.MulticastIP);
			//Создаю сокет для отправки на адресс рассылки
			Socket SenderSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
			//Добавляю сокет в группу рассылки
			SenderSocket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(MultiCastIP));
			//Устанавливаю количество сегментов сети, который проходит пакет до его уничтожения
			SenderSocket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.MulticastTimeToLive, 2);
			//Создаю конечную точку для установления соединения
			IPEndPoint ep = new IPEndPoint(MultiCastIP, client.Port);
			SenderSocket.Connect(ep);
			//Отправляю на конечную точку сообщение
			SenderSocket.Send(Encoding.Default.GetBytes(_messege));
			//SenderSocket.SendTo(Encoding.Default.GetBytes(_messege), ep);
			SenderSocket.Close();
		}
	}
}
