using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using RabbitMQ.Client;

namespace FUM.BaseBusiness.DBContext
{
    public class FUMBaseDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder); 
            optionsBuilder.LogTo(sendLogToServiceLogger, LogLevel.Information);
        }
            

        private void sendLogToServiceLogger(string message)
        {
            var factory = new ConnectionFactory { HostName = "localhost",  };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();

            channel.QueueDeclare(queue: "logQuery",
                     durable: false,
                     exclusive: false,
                     autoDelete: false,
                     arguments: null);

            var body = Encoding.UTF8.GetBytes(message);

            channel.BasicPublish(exchange: string.Empty,
                                 routingKey: "logQuery",
                                 basicProperties: null,
                                 body: body);

        }
    }
}
