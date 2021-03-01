using MQTTnet.Client.Connecting;
using MQTTnet.Client.Disconnecting;
using MQTTnet.Client.Receiving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Micro.Component.MQTT
{
    public delegate void MessageReceived(string message);

    public interface IMqttClientService : IMqttClientConnectedHandler,
                                          IMqttClientDisconnectedHandler,
                                          IMqttApplicationMessageReceivedHandler
    {
        event MessageReceived MessageReceivedHander;

        Task<MqttClientAuthenticateResult> StartAsync(ClientSettings clientSettinigs);
        Task StopAsync(CancellationToken cancellationToken);
        Task SendMessage(string msg);
    }
}
