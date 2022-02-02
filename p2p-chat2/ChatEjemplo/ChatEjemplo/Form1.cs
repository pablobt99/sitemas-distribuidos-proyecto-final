using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatEjemplo
{
    public partial class Form1 : Form, IQuickReturnTraderChat
    {
        public Form1()
        {
            InitializeComponent();
            this.InicialServicio();
        }
        private ServiceHost host;
        private IQuickReturnTraderChat channel;
        private ChannelFactory<IQuickReturnTraderChat> channelFactory;
        private void InicialServicio()
        {
            this.host = new ServiceHost(this);
            this.host.Open();
            this.channelFactory = new ChannelFactory<IQuickReturnTraderChat>("QuickTraderChatEndpoint");
            this.channel = this.channelFactory.CreateChannel();
        }
        public void EnviarMensaje(string ElUsuario, string ElMensaje)
        {
            this.richTextBox1.Text += $"El ususario {ElUsuario} ha dicho: {ElMensaje}\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
