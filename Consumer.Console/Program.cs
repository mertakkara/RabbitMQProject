using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;

namespace Consumer.ConsoleApp
{
    public class Program
    {
        private static string queueName;
        private static IConnection connection;
        private static IModel _channel;
        private static IModel channel => _channel ?? (_channel = CreateOrGetChannel());
        static void Main(string[] args)
        {
            queueName = args.Length > 0 ?  args[0]: "test_queue";    
            connection = GetConnection();
            var consumerEvent = new EventingBasicConsumer(channel);

            consumerEvent.Received += (ch, e) =>
            {
                var byteArr = e.Body.ToArray();
                 var bodyStr = Encoding.UTF8.GetString(byteArr);

                Console.WriteLine($"Received Data { bodyStr }");
            };

            channel.BasicConsume(queueName,true, consumerEvent);

            Console.WriteLine($"{queueName} is listening \n\n");

            Console.ReadLine();
        }

        private static IModel CreateOrGetChannel()
        {
            return connection.CreateModel();
        }

        private static IConnection GetConnection()
        {
            var connectionFactory = new ConnectionFactory()
            {
                Uri = new Uri("amqp://guest:guest@localhost:5672/",UriKind.RelativeOrAbsolute)
            };
            return connectionFactory.CreateConnection();
        }
    }
}
