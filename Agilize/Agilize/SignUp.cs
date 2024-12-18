
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Agilize
{
    
    public partial class SignUp : Form
    {
        
        Users newUser = new Users();
        String pathToProjectFiles;
        bool validUser = true;
        String encryptingKey = "f83jsd74jdue0qnd";// Clave para el ecryptado de blowFish, son letras y numeros aleatoreos

        /// <summary>
        /// Contructor del form, recibe el path donde estan los archivos del programa.
        /// </summary>
        public SignUp(String pathToProjectFiles)
        {
            InitializeComponent();
            SetAll();
            this.pathToProjectFiles = pathToProjectFiles;
        }

        /// <summary>
        /// Settea todo el apartado visual del form
        /// </summary>
        private void SetAll()
        {
            LoginLbl.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            RedondearBoton(signUpBtn);
        }

        /// <summary>
        /// Redondea los botones
        /// </summary>
        private void RedondearBoton(System.Windows.Forms.Button btn)
        {
            var radio = 15;

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(btn.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(btn.Width - radio, btn.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, btn.Height - radio, radio, radio, 90, 90);
            path.CloseAllFigures();

            btn.Region = new Region(path);
        }

        /// <summary>
        /// Comprueba que el usuario que se intenta registrar sea valido (No tenga información vacia y comprueba que no exista ya),
        /// lo crea y lo añade al Json de Usuarios.
        /// </summary>
        private void signUpBtn_Click(object sender, EventArgs e)
        {
            newUser.password = EncryptPassword(newUser.password);

            if (ValidateNewUser())
            {
                if (!File.Exists(pathToProjectFiles))
                {
                    File.Create(pathToProjectFiles).Close(); // Crea y cierra el archivo
                }

                // Leer usuarios existentes del archivo JSON
                List<Users> usersList = new List<Users>();
                string jsonContent = File.ReadAllText(pathToProjectFiles);
                if (!string.IsNullOrWhiteSpace(jsonContent))
                {
                    usersList = System.Text.Json.JsonSerializer.Deserialize<List<Users>>(jsonContent);
                }

                foreach (Users user in usersList)
                {
                    if (newUser.nickname.Equals(user.nickname))
                    {
                        MessageBox.Show("El Nickname de usuario ya existe, por favor usa otro", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        NicknameTxtBox.Text = "Nickname";
                        validUser = false;
                        break;
                    }
                }
                if (validUser)
                {
                    // Agregar el nuevo usuario a la lista
                    usersList.Add(newUser);

                    string newJsonContent = System.Text.Json.JsonSerializer.Serialize(usersList, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(pathToProjectFiles, newJsonContent);

                    MessageBox.Show("Usuario registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    validUser = true;
                }
            }
            else
            {
                MessageBox.Show("Por favor introduce parametros validos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Cierra el formulario para volver al form de Login
        /// </summary>
        private void LoginLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Comprueba que el text box tenga como nombre Name, si es así lo borra para que el usuario pueda escribir.
        /// Comprueba que el texto no sea Name para que pueda funcionar como Hint.
        /// </summary>
        private void nameTxtBox_Enter(object sender, EventArgs e)
        {
            if (nameTxtBox.Text == "Name")
            {
                nameTxtBox.Text = "";
                nameTxtBox.ForeColor = SystemColors.WindowText;
            }
        }

        /// <summary>
        /// Guarda el nombre del nuevo usuario, sino deja el texto de Name para indicar que se ha de poner el nombre
        /// funciona como un hint.
        /// </summary>
        private void nameTxtBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTxtBox.Text))
            {
                nameTxtBox.Text = "Name";
                nameTxtBox.ForeColor = SystemColors.GrayText;
            }
            else
            {
                newUser.name = nameTxtBox.Text;
            }
        }


        /// <summary>
        /// Comprueba que el text box tenga como nombre Surnames, si es así lo borra para que el usuario pueda escribir.
        /// Comprueba que el texto no sea Surnames para que pueda funcionar como Hint.
        /// </summary>
        private void surnamesTxtBox_Enter(object sender, EventArgs e)
        {
            if (surnamesTxtBox.Text == "Surnames")
            {
                surnamesTxtBox.Text = "";
                surnamesTxtBox.ForeColor = SystemColors.WindowText;
            }
        }

        /// <summary>
        /// Guarda el apellido del nuevo usuario, sino deja el texto de Surnames para indicar que se ha de poner el apellido
        /// funciona como un hint.
        /// </summary>
        private void surnamesTxtBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(surnamesTxtBox.Text))
            {
                surnamesTxtBox.Text = "Surnames";
                surnamesTxtBox.ForeColor = SystemColors.GrayText;
            }
            else
            {
                newUser.surname = surnamesTxtBox.Text;
            }
        }


        /// <summary>
        /// Comprueba que el text box tenga como nombre Email, si es así lo borra para que el usuario pueda escribir.
        /// Comprueba que el texto no sea Email para que pueda funcionar como Hint.
        /// </summary>
        private void mailTxtBox_Enter(object sender, EventArgs e)
        {
            if (mailTxtBox.Text == "Email")
            {
                mailTxtBox.Text = "";
                mailTxtBox.ForeColor = SystemColors.WindowText;
            }
        }

        /// <summary>
        /// Guarda el mail del nuevo usuario, sino deja el texto de Email para indicar que se ha de poner el mail
        /// funciona como un hint.
        /// </summary>
        private void mailTxtBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mailTxtBox.Text))
            {
                mailTxtBox.Text = "Email";
                mailTxtBox.ForeColor = SystemColors.GrayText;
            }
            else
            {
                newUser.email = mailTxtBox.Text;
            }
        }


        /// <summary>
        /// Comprueba que el text box tenga como nombre Nickname, si es así lo borra para que el usuario pueda escribir.
        /// Comprueba que el texto no sea Nickname para que pueda funcionar como Hint.
        /// </summary>
        private void NicknameTxtBox_Enter(object sender, EventArgs e)
        {
            if (NicknameTxtBox.Text == "Nickname")
            {
                NicknameTxtBox.Text = "";
                NicknameTxtBox.ForeColor = SystemColors.WindowText;
            }
        }

        /// <summary>
        /// Guarda el nickname del nuevo usuario, sino deja el texto de Nickname para indicar que se ha de poner el nickname
        /// funciona como un hint.
        /// </summary>
        private void NicknameTxtBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NicknameTxtBox.Text))
            {
                NicknameTxtBox.Text = "Nickname";
                NicknameTxtBox.ForeColor = SystemColors.GrayText;
            }
            else
            {
                newUser.nickname = NicknameTxtBox.Text;
            }
        }


        /// <summary>
        /// Comprueba que el text box tenga como nombre Password, si es así lo borra para que el usuario pueda escribir.
        /// Comprueba que el texto no sea Password para que pueda funcionar como Hint.
        /// </summary>
        private void PaswordTxtBox_Enter(object sender, EventArgs e)
        {
            if (PaswordTxtBox.Text == "Password")
            {
                PaswordTxtBox.Text = "";
                PaswordTxtBox.ForeColor = SystemColors.WindowText;
            }
        }

        /// <summary>
        /// Guarda la contraseña del nuevo usuario, sino deja el texto de Password para indicar que se ha de poner la contraseña
        /// funciona como un hint.
        /// </summary>
        private void PaswordTxtBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PaswordTxtBox.Text))
            {
                PaswordTxtBox.Text = "Password";
                PaswordTxtBox.ForeColor = SystemColors.GrayText;
            }
            else
            {
                newUser.password = PaswordTxtBox.Text;
            }
        }

        /// <summary>
        /// Comprueba que los datos del usuario no sean un valor en nulo o que sean solamente un espacio en blanco.
        /// </summary>
        private bool ValidateNewUser()
        {
            return !string.IsNullOrWhiteSpace(newUser.name) &&
                   !string.IsNullOrWhiteSpace(newUser.surname) &&
                   !string.IsNullOrWhiteSpace(newUser.email) &&
                   !string.IsNullOrWhiteSpace(newUser.nickname) &&
                   !string.IsNullOrWhiteSpace(newUser.password);
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
