using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Agilize
{
    public partial class Login : Form
    {
        Users user;
        String pathToProjectFiles;
        String encryptingKey = "f83jsd74jdue0qnd";// Clave para el ecryptado de blowFish, son letras y numeros aleatoreos

        /// <summary>
        /// Contructor del form, recibe el path donde estan los archivos del programa.
        /// </summary>
        public Login(String pathToProjectFiles) 
        {
            InitializeComponent();
            user  = new Users();
            SetAll();
            this.pathToProjectFiles = pathToProjectFiles;
        }

        /// <summary>
        /// Settea todo el apartado visual del form
        /// </summary>
        private void SetAll()
        {
            SetAllLbls();
            RedondearBoton(LoginBtn);
        }

        /// <summary>
        /// Settea todos los labels del form
        /// </summary>
        private void SetAllLbls()
        {
            singUpLbl.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
        }

        /// <summary>
        /// Redondea los botones
        /// </summary>
        private void RedondearBoton(System.Windows.Forms.Button btn)
        {
            var radio = 8;

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(btn.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(btn.Width - radio, btn.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, btn.Height - radio, radio, radio, 90, 90);
            path.CloseAllFigures();

            btn.Region = new Region(path);
        }

        /// <summary>
        /// Comprueba que los datos introducidos sean iguales a algún usuario del archivo de usuarios, 
        /// de ser así inicia sessión como ese usuario, sino informa de que ese usuario no existe.
        /// </summary>
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            
            if (ValidateUser())
            {
                user.password = EncryptPassword(user.password);
                if (File.Exists(pathToProjectFiles + "\\Users.json"))
                {
                    if (IsUser())
                    {
                        MainHub mainHub = new MainHub(user, pathToProjectFiles);
                        mainHub.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o contraseña incorrectos", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ha habido un error con los archivos de la aplicación",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }   
            }
            else
            {
                MessageBox.Show("Porfavor introduce valores validos", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Comprueba que el usario exista en el archivo
        /// </summary>
        private Boolean IsUser()
        {
            // Leer usuarios existentes del archivo JSON (si es necesario)
            List<Users> usersList = new List<Users>();
            string jsonContent = File.ReadAllText(pathToProjectFiles + "\\Users.json");
            if (!string.IsNullOrWhiteSpace(jsonContent))
            {
                usersList = System.Text.Json.JsonSerializer.Deserialize<List<Users>>(jsonContent);
            }

            foreach (var appUser in usersList)
            {
                if (appUser.nickname.Equals(user.nickname) && appUser.password.Equals(user.password))
                {
                    user = appUser;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Crea el form de Sing Up para crear un Usuario nuevo.
        /// </summary>
        private void SingUpLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp(pathToProjectFiles + "\\Users.json");
            signUp.ShowDialog();
        }

        /// <summary>
        /// Comprueba que el text box tenga como nombre Nickname, si es así lo borra para que el usuario pueda escribir.
        /// Comprueba que el texto no sea Nickname para que pueda funcionar como Hint.
        /// </summary>
        private void usernameTxTBox_Enter(object sender, EventArgs e)
        {
            if (usernameTxTBox.Text == "Nickname")
            {
                usernameTxTBox.Text = "";
                usernameTxTBox.ForeColor = SystemColors.WindowText;
            }
        }

        /// <summary>
        /// Guarda el nickname del nuevo usuario, sino deja el texto de Nickname para indicar que se ha de poner el nickname
        /// funciona como un hint.
        /// </summary>
        private void usernameTxTBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTxTBox.Text))
            {
                usernameTxTBox.Text = "Nickname";
                usernameTxTBox.ForeColor = SystemColors.GrayText;
            }
            else
            {
                user.nickname = usernameTxTBox.Text;
            }

        }


        /// <summary>
        /// Comprueba que el text box tenga como nombre Password, si es así lo borra para que el usuario pueda escribir.
        /// Comprueba que el texto no sea Password para que pueda funcionar como Hint.
        /// </summary>
        private void paswordTxTBox_Enter(object sender, EventArgs e)
        {
            if (paswordTxTBox.Text == "Password")
            {
                paswordTxTBox.Text = "";
                paswordTxTBox.ForeColor = SystemColors.WindowText;
            }

        }

        /// <summary>
        /// Guarda la contraseña del nuevo usuario, sino deja el texto de Password para indicar que se ha de poner la contraseña
        /// funciona como un hint.
        /// </summary>
        private void paswordTxTBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(paswordTxTBox.Text))
            {
                paswordTxTBox.Text = "Password";
                paswordTxTBox.ForeColor = SystemColors.GrayText;
            }
            else
            {
                user.password = paswordTxTBox.Text;
            }
        }

        /// <summary>
        /// Comprueba que los datos del usuario no sean un valor en nulo o que sean solamente un espacio en blanco.
        /// </summary>
        private bool ValidateUser()
        {
            return !string.IsNullOrWhiteSpace(user.nickname) &&
                   !string.IsNullOrWhiteSpace(user.password);
        }

        /// <summary>
        /// Encripta la contraseña con el metodo BlowFish usando una clave, y devuelve un string con el password encryptado
        /// </summary>
        public string EncryptPassword(string pswd)
        {
            var engine = new BlowfishEngine();
            var blockCipher = new PaddedBufferedBlockCipher(engine);
            var keyBytes = Encoding.UTF8.GetBytes(encryptingKey);
            blockCipher.Init(true, new KeyParameter(keyBytes));

            var inputBytes = Encoding.UTF8.GetBytes(pswd);
            var outputBytes = new byte[blockCipher.GetOutputSize(inputBytes.Length)];

            var length = blockCipher.ProcessBytes(inputBytes, 0, inputBytes.Length, outputBytes, 0);
            blockCipher.DoFinal(outputBytes, length);

            return Convert.ToBase64String(outputBytes);
        }
    }
}
