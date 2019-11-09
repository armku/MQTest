using MQTest.Config;
using System;
using System.Net;
using uPLibrary.Networking.M2Mqtt;

namespace ConsoleApp1
{
    class Program
    {
        /// <summary>
        /// MQTT客户端
        /// </summary>
        private static MqttClient client;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(PortCfg.Current.Server);

            var ips = IPAddress.Parse("127.0.0.1");
            if (IPAddress.TryParse(PortCfg.Current.Server, out ips))
            {
                //主机为IP时  
                client = new MqttClient(ips);
            }
            else
            {
                //当主机地址为域名时  
                client = new MqttClient(PortCfg.Current.Server);
            }

            // 注册消息接收处理事件，还可以注册消息订阅成功、取消订阅成功、与服务器断开等事件处理函数  
            client.MqttMsgPublishReceived += Client_MqttMsgPublishReceived; ;


            //生成客户端ID并连接服务器  
            string clientId = PortCfg.Current.ClientID;// Guid.NewGuid().ToString();
            //string clientId = "21122111222";
            try
            {
                client.Connect(clientId);
            }
            catch
            {
              Console.WriteLine("服务器异常，请确认设置正确\r\n");
                return;
            }

            var aa= Console.ReadKey();
        }

        private static void Client_MqttMsgPublishReceived(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {
            Console.WriteLine("rcv");
        }
    }
}
