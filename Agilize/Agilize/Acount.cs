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

namespace Agilize
{
    public partial class Acount : Form
    {
        Users user;
        String pathToProjectFiles;
        String newPswrd;

        /// <summary>
        /// Contructor del form, recibe el path donde estan los archivos del programa y el usuario que ha iniciado sessión.
        /// </summary>
        public Acount(Users user, String pathToProjectFiles)
        {
            InitializeComponent();
            SetAllLbls();
            this.user = user;
            this.pathToProjectFiles = pathToProjectFiles;
            RedondearBoton(saveBTN);
            RedondearBoton(deleteAcountBtn);
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
        /// Settea todos los labels del form
        /// </summary>
        private void SetAllLbls()
        {
            homeLBL.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            newProjectLBL.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            projectFoldersLBL.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            acountLBL.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
        }

        /// <summary>
        /// Abre la pestaña de Home 
        /// </summary>
        private void homeLBL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainHub mainHub = new MainHub(user, pathToProjectFiles);
            mainHub.Show();
            this.Close();
        }

        /// <summary>
        /// Abre la pestaña de Home
        /// </summary>
        private void homeIMG_Click(object sender, EventArgs e)
        {
            MainHub mainHub = new MainHub(user, pathToProjectFiles);
            mainHub.Show();
            this.Close();
        }

        /// <summary>
        /// Abre la pestaña de New Project
        /// </summary>
        private void newProjectLBL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewProject newProject = new NewProject(user, pathToProjectFiles);
            newProject.Show();
            this.Close();
        }

        /// <summary>
        /// Abre la pestaña de New Project
        /// </summary>
        private void newProjectIMG_Click(object sender, EventArgs e)
        {
            NewProject newProject = new NewProject(user, pathToProjectFiles);
            newProject.Show();
            this.Close();
        }

        /// <summary>
        /// Abre la pestaña de Project Folders
        /// </summary>
        private void projectFoldersLBL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProjectFolders projectFolders = new ProjectFolders(user, pathToProjectFiles);
            projectFolders.Show();
            this.Close();
        }

        /// <summary>
        /// Abre la pestaña de Project Folders
        /// </summary>
        private void projectFoldersIMG_Click(object sender, EventArgs e)
        {
            ProjectFolders projectFolders = new ProjectFolders(user, pathToProjectFiles);
            projectFolders.Show();
            this.Close();
        }

        /// <summary>
        /// Abre la pestaña de Acount (que es esta misma)
        /// </summary>
        private void acountLBL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Acount acount = new Acount(user, pathToProjectFiles);
            acount.Show();
            this.Close();
        }

        /// <summary>
        /// Abre la pestaña de Acount (que es esta misma)
        /// </summary>
        private void acountIMG_Click(object sender, EventArgs e)
        {
            Acount acount = new Acount(user, pathToProjectFiles);
            acount.Show();
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
        /// Guarda el nuevo nombre del usuario, sino deja el texto de Name para indicar que se ha de poner el nombre
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
                user.name = nameTxtBox.Text;
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
        /// Guarda el nuevo apellido del usuario, sino deja el texto de Surnames para indicar que se ha de poner el apellido
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
                user.surname = surnamesTxtBox.Text;
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
        /// Guarda el  nuevo mail del usuario, sino deja el texto de Email para indicar que se ha de poner el mail
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
                user.email = mailTxtBox.Text;
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
        /// Guarda la nueva contraseña usuario, sino deja el texto de Password para indicar que se ha de poner la contraseña
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
                newPswrd = PaswordTxtBox.Text;
            }
        }

        /// <summary>
        /// Comprueba que el text box tenga como nombre Password, si es así lo borra para que el usuario pueda escribir.
        /// Comprueba que el texto no sea Password para que pueda funcionar como Hint.
        /// </summary>
        private void confirmPswrdTxtBox_Enter(object sender, EventArgs e)
        {
            if (confirmPswrdTxtBox.Text == "Password")
            {
                confirmPswrdTxtBox.Text = "";
                confirmPswrdTxtBox.ForeColor = SystemColors.WindowText;
            }
        }

        /// <summary>
        /// Guarda la nueva contraseña de usuario, sino deja el texto de Password para indicar que se ha de poner la contraseña
        /// funciona como un hint.
        /// Comprueba que las dos contraseñas sean iguales, de ser así la encripta y la actualiza. Sino avisa de esta mal.
        /// </summary>
        private void confirmPswrdTxtBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(confirmPswrdTxtBox.Text))
            {
                confirmPswrdTxtBox.Text = "Password";
                confirmPswrdTxtBox.ForeColor = SystemColors.GrayText;
            }
            else
            {
                String newPswrdConfirmation = confirmPswrdTxtBox.Text;

                if (newPswrd.Equals(newPswrdConfirmation))
                {
                    user.password = EncryptPassword(newPswrdConfirmation);
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    confirmPswrdTxtBox.Text = "Password";
                    PaswordTxtBox.Text = "Password";
                }

            }
        }

        /// <summary>
        /// Encripta la contraseña con el metodo BlowFish usando una clave, y devuelve un string con el password encryptado
        /// </summary>
        public string EncryptPassword(string pswd)
        {
            var engine = new BlowfishEngine();
            var blockCipher = new PaddedBufferedBlockCipher(engine);
            var keyBytes = Encoding.UTF8.GetBytes("f83jsd74jdue0qnd");
            blockCipher.Init(true, new KeyParameter(keyBytes));

            var inputBytes = Encoding.UTF8.GetBytes(pswd);
            var outputBytes = new byte[blockCipher.GetOutputSize(inputBytes.Length)];

            var length = blockCipher.ProcessBytes(inputBytes, 0, inputBytes.Length, outputBytes, 0);
            blockCipher.DoFinal(outputBytes, length);

            return Convert.ToBase64String(outputBytes);
        }

        /// <summary>
        /// Elimina el usuario, y su participación de cualquier proyecto
        /// </summary>
        private void deleteAcountBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta seguro de querer borrar su cuenta? Esto será PERMANENTE","Borrar Cuenta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (ValidateUser())
                {
                    if (!File.Exists(pathToProjectFiles + "\\Users.json"))
                    {
                        File.Create(pathToProjectFiles + "\\Users.json").Close(); // Crea y cierra el archivo
                    }

                    // Leer usuarios existentes del archivo JSON
                    List<Users> usersList = new List<Users>();
                    string jsonContent = File.ReadAllText(pathToProjectFiles + "\\Users.json");
                    if (!string.IsNullOrWhiteSpace(jsonContent))
                    {
                        usersList = System.Text.Json.JsonSerializer.Deserialize<List<Users>>(jsonContent);
                    }
                    foreach (var user in usersList)
                    {
                        if (user.nickname.Equals(this.user.nickname))
                        {
                            usersList.Remove(user);
                            break;
                        }
                    }

                    string newJsonContent = System.Text.Json.JsonSerializer.Serialize(usersList, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(pathToProjectFiles + "\\Users.json", newJsonContent);

                    MessageBox.Show("Se ha eliminado su cuenta con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor introduce parametros validos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Guarda la nueva infromación de usuario en los archivos.
        /// </summary>
        private void saveBTN_Click(object sender, EventArgs e)
        {
            if (ValidateUser())
            {
                if (!File.Exists(pathToProjectFiles + "\\Users.json"))
                {
                    File.Create(pathToProjectFiles + "\\Users.json").Close(); // Crea y cierra el archivo
                }

                // Leer usuarios existentes del archivo JSON
                List<Users> usersList = new List<Users>();
                string jsonContent = File.ReadAllText(pathToProjectFiles + "\\Users.json");
                if (!string.IsNullOrWhiteSpace(jsonContent))
                {
                    usersList = System.Text.Json.JsonSerializer.Deserialize<List<Users>>(jsonContent);
                }
                foreach (var user in usersList)
                {
                    if (user.nickname.Equals(this.user.nickname))
                    {
                        usersList.Remove(user);
                        usersList.Add(this.user);
                        break;
                    }
                }
 
                string newJsonContent = System.Text.Json.JsonSerializer.Serialize(usersList, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(pathToProjectFiles + "\\Users.json", newJsonContent);

                MessageBox.Show("Datos actualizados con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor introduce parametros validos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Comprueba que si se ha cambiado un usuario, este no sea nulo por casualidad o un espacio en blanco.
        /// </summary>
        private bool ValidateUser()
        {
            return !string.IsNullOrWhiteSpace(user.name) &&
                   !string.IsNullOrWhiteSpace(user.surname) &&
                   !string.IsNullOrWhiteSpace(user.email) &&
                   !string.IsNullOrWhiteSpace(user.nickname) &&
                   !string.IsNullOrWhiteSpace(user.password);
        }
    }
}
