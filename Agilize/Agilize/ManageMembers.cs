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
using System.Windows.Forms;

namespace Agilize
{
    public partial class ManageMembers : Form
    {
        Users newUser = new Users();
        Users user;
        Projects projects;
        String pathToProjectFiles;
        List<Users> totalUsers;

        /// <summary>
        /// Contructor del form, recibe el path donde estan los archivos del programa, el usuario que ha iniciado sessión.
        /// y el proyecto en el que estamos.
        /// </summary>
        public ManageMembers(Users user, String pathToProjectFiles,Projects projects)
        {
            InitializeComponent();
            if (projects.arrayProjectUsers != null)
            {
                totalUsers = projects.arrayProjectUsers.Select(item => item.Clone()).ToList();
            }
            
            this.projects = new Projects();
            this.projects = projects;
            this.user = user;
            this.pathToProjectFiles = pathToProjectFiles;
            setAll();

        }

        /// <summary>
        /// Settea todo el apartado visual del form
        /// </summary>
        private void setAll()
        {
            setListsBoxs();
            RedondearBoton(retunBTN);
            RedondearBoton(createMemberBtn);
            RedondearBoton(addMemberBtn);
            RedondearBoton(deleteMemberbtn);
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
        /// Settea todas las lists boxs con sus contendidos
        /// </summary>
        private void setListsBoxs()
        {

            if (!File.Exists(pathToProjectFiles + "\\Users.json"))
            {
                File.Create(pathToProjectFiles + "\\Users.json").Close(); // Crea y cierra el archivo
            }
            else
            {
                List<Users> usersList = new List<Users>();
                string jsonContent = File.ReadAllText(pathToProjectFiles + "\\Users.json");
                if (!string.IsNullOrWhiteSpace(jsonContent))
                {
                    usersList = System.Text.Json.JsonSerializer.Deserialize<List<Users>>(jsonContent);
                }
                if (projects.arrayProjectUsers != null)
                {
                    foreach (Users user in usersList)
                    {
                        if (!user.nickname.Equals(this.user.nickname) && !projects.arrayProjectUsers.Contains(user))
                        {
                            membersofAgilize.Items.Add(user);
                        }
                    }
                    foreach (var projectMember in projects.arrayProjectUsers)
                    {
                        projectMembers.Items.Add(projectMember);
                    }
                }
                else
                {
                    foreach (Users user in usersList)
                    {
                        if (!user.nickname.Equals(this.user.nickname))
                        {
                            membersofAgilize.Items.Add(user);
                        }
                    }
                }
            } 
        }

        /// <summary>
        /// Crea un nuevo miembro y lo añade al proyecto y a la lista de usuarios de la aplicación (así podran iniciar sessión en la aplicación movil)
        /// </summary>
        private void createMemberBtn_Click(object sender, EventArgs e)
        {
            if (ValidateNewUser())
            {
                Users userToAdd = new Users
                {
                    nickname = newUser.nickname,
                    email = newUser.email,
                    password = EncryptPassword(newUser.password)
                };

                projectMembers.Items.Add(userToAdd);

                if (projects.arrayProjectUsers != null)
                {
                    projects.arrayProjectUsers.Add(userToAdd);
                }
                else
                {
                    projects.arrayProjectUsers = new BindingList<Users> { userToAdd };
                }

                newUser.email = null;
                newUser.nickname = null;
                newUser.password = null;

                mailTxtBox.Text = "Email";
                NicknameTxtBox.Text = "Nickname";
                PaswordTxtBox.Text = "Password";
            }
            else
            {
                MessageBox.Show("Error, los parametros no son correctos para un usuario", "Creating Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
           
        }

        /// <summary>
        /// Añade el miembro seleccionado si el valido al proyecto.
        /// </summary>
        private void addMemberBtn_Click(object sender, EventArgs e)
        {
            Users addedUsers = (Users)membersofAgilize.SelectedItem;
            if (addedUsers != null)
            {
                projectMembers.Items.Add(addedUsers);
                projects.arrayProjectUsers.Add(addedUsers);
                membersofAgilize.Items.Remove(addedUsers);
            }
            else
            {
                MessageBox.Show("Error, no se ha selecciconado miembro a añadir", "Selecting Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Elimina si es valido al miembro seleccionado del proyecto
        /// </summary>
        private void deleteMemberbtn_Click(object sender, EventArgs e)
        {
            Users deletedUser = (Users)projectMembers.SelectedItem;
            if (deletedUser != null)
            {
                membersofAgilize.Items.Add(deletedUser);
                projectMembers.Items.Remove(deletedUser);
                projects.arrayProjectUsers.Remove(deletedUser);
            }
            else
            {
                MessageBox.Show("Error, no se ha selecciconado miembro a eliminar", "Selecting Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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
                mailTxtBox.ForeColor = SystemColors.WindowText; // Cambiar a color normal
            }
        }

        /// <summary>
        /// Obtiene el mail del nuevo usuario
        /// </summary>
        private void mailTxtBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mailTxtBox.Text))
            {
                mailTxtBox.Text = "Email";
                mailTxtBox.ForeColor = SystemColors.GrayText; // Cambiar a color gris
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
                NicknameTxtBox.ForeColor = SystemColors.WindowText; // Cambiar a color normal
            }
        }

        /// <summary>
        /// Obtiene el nickname del nuevo usuario
        /// </summary>
        private void NicknameTxtBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NicknameTxtBox.Text))
            {
                NicknameTxtBox.Text = "Nickname";
                NicknameTxtBox.ForeColor = SystemColors.GrayText; // Cambiar a color gris
            }
            else
            {
                newUser.nickname = NicknameTxtBox.Text;
            }
        }

        /// <summary>
        /// Obtiene el mail del nuevo usuario
        /// </summary>
        private void PaswordTxtBox_Enter(object sender, EventArgs e)
        {
            if (PaswordTxtBox.Text == "Password")
            {
                PaswordTxtBox.Text = "";
                PaswordTxtBox.ForeColor = SystemColors.WindowText; // Cambiar a color normal
            }
        }

        /// <summary>
        /// Obtiene el password del nuevo usuario
        /// </summary>
        private void PaswordTxtBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PaswordTxtBox.Text))
            {
                PaswordTxtBox.Text = "Password";
                PaswordTxtBox.ForeColor = SystemColors.GrayText; // Cambiar a color gris
            }
            else
            {
                newUser.password = PaswordTxtBox.Text;
            }
        }

        /// <summary>
        /// Vuelve
        /// </summary>
        private void retunBTN_Click(object sender, EventArgs e)
        {
            saveNewUsers();
            this.Close();
        }

        /// <summary>
        /// Guarda los nuevos Usuarios en la lista de proyectos, de ser nuevos usuarios o de ser nuevos Usuarios ñadidos
        /// les guarda el proyecto es su lista personal de proyectos para que puedan acceder en la aplicación movil.
        /// </summary>
        private void saveNewUsers()
        {
            if (!File.Exists(pathToProjectFiles + "\\Users.json"))
            {
                File.Create(pathToProjectFiles + "\\Users.json").Close(); // Crea y cierra el archivo
            }
            else
            {
                List<Users> usersList = new List<Users>();
                string jsonContent = File.ReadAllText(pathToProjectFiles + "\\Users.json");
                if (!string.IsNullOrWhiteSpace(jsonContent))
                {
                    usersList = System.Text.Json.JsonSerializer.Deserialize<List<Users>>(jsonContent);
                }
                BindingList<Users> deletedUsers = obtainDeletedUsers();

                if (deletedUsers.Count > 0 && deletedUsers != null)
                {
                    foreach (Users user in deletedUsers) 
                    {
                        if (usersList.Contains(user))
                        {
                            usersList.Remove(user);
                            user.projectsList.Remove(projects.projectName);
                            usersList.Add(user);
                        }
                    }
                }
                foreach (Users user in projects.arrayProjectUsers)
                {
                    if (!usersList.Contains(user) || !user.projectsList.Contains(projects.projectName))
                    {
                        if (user.projectsList == null)
                        {
                            user.projectsList = new BindingList<string>() { projects.projectName };
                        }
                        else
                        {
                            usersList.Remove(user);
                            user.projectsList.Add(projects.projectName);
                            usersList.Add(user);
                        }
                    }
                }
                string newJsonContent = System.Text.Json.JsonSerializer.Serialize(usersList, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(pathToProjectFiles + "\\Users.json", newJsonContent);
            }
        }

        /// <summary>
        /// Obtiene los usuarios eliminados para luego poder eliminar el proyecto 
        /// de su lista de proyectos personales a cada uno
        /// </summary>
        private BindingList<Users> obtainDeletedUsers()
        {
            BindingList <Users> deledUsers = new BindingList<Users>();
            foreach (var user in totalUsers)
            {
                if (!projects.arrayProjectUsers.Contains(user))
                {
                    deledUsers.Add(user);
                }
            }
            return deledUsers;
        }

        /// <summary>
        /// Valida que el usuario nuevo no tenga un valor nulo o un espacio en blanco.
        /// </summary>
        private bool ValidateNewUser()
        {
            return !string.IsNullOrWhiteSpace(newUser.email) &&
                   !string.IsNullOrWhiteSpace(newUser.nickname) &&
                   !string.IsNullOrWhiteSpace(newUser.password);
        }

        /// <summary>
        /// Encrypta la contraseña usando BlowFish con una clave.
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
    }
}
