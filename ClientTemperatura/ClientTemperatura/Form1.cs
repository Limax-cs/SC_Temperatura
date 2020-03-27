using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace ClientTemperatura
{
    public partial class Form1 : Form
    {
        Socket server;
        public Form1()
        {
            InitializeComponent();
        }

        private void TempInici_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Envia_btn_Click(object sender, EventArgs e)
        {
            string missatge = (TempFinal_cb.SelectedIndex + 1) + "/" + (TempInici_cb.SelectedIndex + 1) + "/" + Temperatura_tb.Text;
                //Enviem al servidor un nom de teclat
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(missatge);
                server.Send(msg);

                //Rebem la resposta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                missatge = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show("La temperatura és de: " + missatge);
        }

        private void Connecta_btn_Click(object sender, EventArgs e)
        {
            //Creem un IPEndPoint amb la ip del servidor i el port
            IPAddress direc = IPAddress.Parse("192.168.56.101");
            IPEndPoint ipep = new IPEndPoint(direc, 9070);

            //Creem el socket
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep); //Intentem connectar el socket
                this.BackColor = Color.Green;
                MessageBox.Show("Connectat");
            }
            catch (SocketException ex)
            {
                //Si hi ha l'excepció, imprimim l'error
                MessageBox.Show("No s'ha pogut connectar amb el servidor:" + ex);
                return;
            }
        }

        private void Desconnecta_btn_Click(object sender, EventArgs e)
        {
            //Envia el missatge de voler-se desconnectar
            string missatge = "0/";
            //Enviem al servidor un nom de teclat
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(missatge);
            server.Send(msg);

            //Ens desconnectem
            this.BackColor = Color.Gray;
            server.Shutdown(SocketShutdown.Both);
            server.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TempFinal_cb.SelectedIndex = 1;
            TempInici_cb.SelectedIndex = 1;
        }
    }
}
