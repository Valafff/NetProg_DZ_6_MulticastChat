using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NetProg_DZ_6_MulticastChat
{
	public delegate void AppendTextDelegate(string message);
	public class ClientModul
	{

		public event AppendTextDelegate AppendTextEvent;

		Client client;
		public ClientModul(Client _client)
		{
			client = _client;
		}

		public void Listener()
		{
			while (true)
			{
				//Создаю сокет для прослушивания сообщений
				Socket ListenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
				// Не обязательно https://learn.microsoft.com/ru-ru/dotnet/api/system.net.sockets.socket.exclusiveaddressuse?redirectedfrom=MSDN&view=net-7.0
				ListenerSocket.ExclusiveAddressUse = false;
				//Создаю конечную точку откуда слушать
				IPEndPoint FromListenEP = new IPEndPoint(IPAddress.Any, client.Port);
				//Добавляю сокет в группу multicast
				ListenerSocket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(IPAddress.Parse(client.MulticastIP)));
				//Задаю сокету правило прослушивания: ограничиваю прослушивание только с того адреса который вещает
				//https://learn.microsoft.com/ru-ru/dotnet/api/system.net.sockets.socketoptionlevel?view=net-8.0
				//https://learn.microsoft.com/ru-ru/dotnet/api/system.net.sockets.socketoptionname?view=net-8.0
				ListenerSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
				// Не обязательно https://learn.microsoft.com/ru-ru/dotnet/api/system.net.sockets.socket.exclusiveaddressuse?redirectedfrom=MSDN&view=net-7.0
				ListenerSocket.ExclusiveAddressUse = false;
				//Связываю сокет с конечной точкой от куда следует ожидать пакеты
				ListenerSocket.Bind(FromListenEP);
				byte[] buffer = new byte[8192];
				ListenerSocket.Receive(buffer);
				string message = Encoding.UTF8.GetString(buffer);
				message = message.Remove(message.IndexOf('\0'));
				AppendTextEvent(message);
				ListenerSocket.Close();
			}
		}


	}
}
