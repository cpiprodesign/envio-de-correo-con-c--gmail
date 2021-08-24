using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Configuration;

using System.Net.Configuration;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void enviar()
        {
            MailMessage correo = new MailMessage();
            correo.From = new MailAddress("cristiansinlimite@gmail.com", "Cpiprodesign", System.Text.Encoding.UTF8);//Correo de salida
            correo.To.Add(txtdestino.Text); //Correo destino?
            correo.Subject = txtasunto.Text; //Asunto
            correo.Body = txtcuerpo.Text; //Mensaje del correo
            correo.IsBodyHtml = true;
            correo.Priority = MailPriority.Normal;
            SmtpClient smtp = new SmtpClient();
            smtp.UseDefaultCredentials = false;
            smtp.Host = "smtp.gmail.com"; //Host del servidor de correo
            smtp.Port = 25; //Puerto de salida
            smtp.Credentials = new System.Net.NetworkCredential("cristiansinlimite@gmail.com", "lac199024");//Cuenta de correo
            ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
            smtp.EnableSsl = true;//True si el servidor de correo permite ssl
            smtp.Send(correo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enviar();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            enviar();
        }
    }
}
