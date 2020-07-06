using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controller;

namespace View
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            //Limpa todas as Texts Boxs
            TxtEmail.Clear();
            TxtName.Clear();
            TxtPassword.Clear();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //Instancia um novo User 
            User user = new User();

            //Puxando os Valores do Formulário 
            user.Name = TxtName.Text;
            user.Email = TxtEmail.Text;
            user.Pass = TxtPassword.Text;

            //Instancia um novo Controller
            UserController ucontroler = new UserController();

            //Adiciona o usuário com os dados do formulário
            ucontroler.Add(user);
            
            //Mensagem de sucesso
            MetroFramework.MetroMessageBox.Show(this, "Cadastrado com sucesso!", "Sucesso");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
