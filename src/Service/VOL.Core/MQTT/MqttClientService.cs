using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Connecting;
using MQTTnet.Client.Disconnecting;
using MQTTnet.Client.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Micro.Component.MQTT
{
    public class MqttClientService : IMqttClientService
    {
        private IMqttClient mqttClient;
        private IMqttClientOptions options;
       
        public event MessageReceived MessageReceivedHander;

        public MqttClientService()
        {
            mqttClient = new MqttFactory().CreateMqttClient();
            ConfigureMqttClient();
        }

        private void ConfigureMqttClient()
        {
            mqttClient.ConnectedHandler = this;
            mqttClient.DisconnectedHandler = this;
            mqttClient.ApplicationMessageReceivedHandler = this;
        }

        public Task HandleApplicationMessageReceivedAsync(MqttApplicationMessageReceivedEventArgs eventArgs)
        {
            string message = Encoding.UTF8.GetString(eventArgs.ApplicationMessage.Payload);
            MessageReceivedHander?.Invoke(message);
            return default;
        }

        public async Task HandleConnectedAsync(MqttClientConnectedEventArgs eventArgs)
        {
            await mqttClient.SubscribeAsync(new MqttTopicFilterBuilder().WithTopic(options.ClientId).Build());
        }

        public Task HandleDisconnectedAsync(MqttClientDisconnectedEventArgs eventArgs)
        {
            return default;
        }

        public async Task SendMessage(string msg)
        {
            var message = new MqttApplicationMessageBuilder()
                .WithTopic(options.ClientId)
                .WithPayload(msg)
                .WithExactlyOnceQoS()
                .WithRetainFlag()
                .Build();
            await mqttClient.PublishAsync(message, CancellationToken.None);
        }

        public async Task<MqttClientAuthenticateResult> StartAsync(ClientSettings clientSettinigs)
        {
            MqttClientAuthenticateResult result = new MqttClientAuthenticateResult();
            try
            {
                var builder = new MqttClientOptionsBuilder();
                builder.WithCredentials(clientSettinigs.UserName, clientSettinigs.Password)
                   .WithClientId(clientSettinigs.Id)
                   .WithTcpServer("119.29.131.192", 1883);
                options = builder.Build();
                result = await mqttClient.ConnectAsync(options);
                if (!mqttClient.IsConnected)
                    await mqttClient.ReconnectAsync();
                return result;
            }
            catch
            {
                result.ResultCode = MqttClientConnectResultCode.ServerUnavailable;
            }
            return result;
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                var disconnectOption = new MqttClientDisconnectOptions
                {
                    ReasonCode = MqttClientDisconnectReason.NormalDisconnection,
                    ReasonString = "NormalDiconnection"
                };
                await mqttClient.DisconnectAsync(disconnectOption, cancellationToken);
            }
            await mqttClient.DisconnectAsync();
        }
    }
}
