using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Producer
{
    public partial class Form1 : Form
    {

        IConnection connection;
        private bool _isConnectionOpen;
        private bool isConnectionOpen;

        private IModel _channel;
        private IModel channel => _channel ??(_channel = CreateOrGetChannel());
        public Form1()
        {
           
            InitializeComponent();
            Init();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            channel.ExchangeDeclare(txtDeclareExchangeName.Text,cbDeclareExchangeType.Text);
            AddLog("Excahnge Created");
        }

        private IModel CreateOrGetChannel()
        {
            return connection.CreateModel();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isConnectionOpen || connection == null)
                connection = GetConnection();
            else
                connection.Close(); 

            isConnectionOpen = connection.IsOpen;
        }

        private IConnection GetConnection()
        {
            var connectionFactory = new ConnectionFactory()
            {
                Uri = new Uri(txtConnectionString.Text)
            };
            return connectionFactory.CreateConnection();
        }

        private void AddLog(string logStr)
        {
            if (txtLog.InvokeRequired)
            {
                txtLog.Invoke(new Action(() => AddLog(logStr)));
                return;
            }
            logStr = $"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] - {logStr}";
            txtLog.AppendText($"{logStr}\n");

            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.ScrollToCaret();
        }
        private void UpdateConnectionStatus()
        {
            string state = $"{(isConnectionOpen ? "" : "Not ")}Connected";
            tsLblConnectionStatus.Text = $"Connection State: {state}";
            AddLog($"Connection is {state}");
        }

        private void Init()
        {
            cbDeclareExchangeType.Items.Add("direct");
            cbDeclareExchangeType.Items.Add("fanout");
            cbDeclareExchangeType.Items.Add("headers");
            cbDeclareExchangeType.Items.Add("topic");


            cbDeclareExchangeType.SelectedIndex  = 0;
        }

        private void ConnectionStateChanged()
        {
            btnConnect.Text = isConnectionOpen ? "Discount" : "Connect";

            UpdateConnectionStatus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            channel.QueueDeclare(txtDeclareQueueName.Text,false,false,false);
        }

        private void btnBindQueue_Click(object sender, EventArgs e)
        {
            channel.QueueBind(txtDeclareQueueName.Text, txtDeclareExchangeName.Text, txtRoutingName.Text);
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            WriteDataToExchange(txtExchangeName.Text, txtRoutingKey.Text, txtMessage.Text);
        }
        private void WriteDataToExchange(string exhangeName,string routingName,object data)
        {
            var dataArr = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data)); 
            channel.BasicPublish(exhangeName,routingName,null,dataArr);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
