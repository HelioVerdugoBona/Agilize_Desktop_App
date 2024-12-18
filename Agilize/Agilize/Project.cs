using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agilize
{
    public partial class ProjectWindow : Form
    {
        Users user;
        String pathToProjectFiles;
        String thisProjectFolder;
        Projects projects;

        /// <summary>
        /// Contructor del form, recibe el path donde estan los archivos del programa y el usuario que ha iniciado sessión.
        /// </summary>
        public ProjectWindow(Users user, String pathToProjectFiles, String projectName,Boolean newProject)
        {
            InitializeComponent();
            this.projects = new Projects();
            this.user = new Users();
            this.user = user;
            this.projects.projectName = projectName;
            this.projects.projectOwner = user.nickname;
            thisProjectFolder = pathToProjectFiles + "\\" + projectName;
            this.pathToProjectFiles = pathToProjectFiles;
            if (newProject){ IsNewProject(); }
            else {  IsNotNewProject(); }

            SetAll(user, pathToProjectFiles);
        }

        /// <summary>
        /// Settea todo el apartado visual del form
        /// </summary>
        private void SetAll(Users user, String pathToProjectFiles)
        {
            this.user = user;
            this.pathToProjectFiles = pathToProjectFiles;
            SetAllLbls();
            SetAllLBoxs();
            RedondearBoton(saveBTN);
        }

        /// <summary>
        /// Settea todos los labels del form y las taks del form
        /// </summary>
        private void SetAllLBoxs()
        {
            BackLogLBox.Items.Clear();
            ToDoLBox.Items.Clear();
            DoingLBox.Items.Clear();
            PendingConfirmationLBox.Items.Clear();
            DoneLBox.Items.Clear();
            if (projects.arrayTasks != null)
            {
                foreach (var task in projects.arrayTasks)
                {
                    switch (task.CurrentState)
                    {
                        case TaskState.BackLog:
                            BackLogLBox.Items.Add(task);
                            break;
                        case TaskState.ToDo:
                            ToDoLBox.Items.Add(task);
                            break;
                        case TaskState.Doing:
                            DoingLBox.Items.Add(task);
                            break;
                        case TaskState.Pending_Confirmation:
                            PendingConfirmationLBox.Items.Add(task);
                            break;
                        case TaskState.Done:
                            DoneLBox.Items.Add(task);
                            break;
                    }
                }
            }
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
        /// Si el proyecto es nuevo añade el creador al array de miembros del proyectos y crea una carpeta para guardar los archivos.
        /// </summary>
        private void IsNewProject()
        {
            if (projects.arrayProjectUsers == null)
            {
                projects.arrayProjectUsers = new BindingList<Users> { user };
            }
            else
            {
                projects.arrayProjectUsers.Add(user);
            }
            ChangeJSONProperties();
            Directory.CreateDirectory(thisProjectFolder);
        }

        /// <summary>
        /// Si no es un proyecto nuevo abre la carpeta donde se guarda la información del proyecto y los usa para obtener la información del proyecto.
        /// </summary>
        private void IsNotNewProject()
        {

            if (!File.Exists(thisProjectFolder + "\\" + this.projects.projectName + ".json"))
            {
                File.Create(thisProjectFolder + "\\" + this.projects.projectName + ".json").Close(); // Crea y cierra el archivo
            }
            else { 
                string jsonContent = File.ReadAllText(thisProjectFolder + "\\" + this.projects.projectName + ".json");
                if (!string.IsNullOrWhiteSpace(jsonContent))
                {
                    projects = System.Text.Json.JsonSerializer.Deserialize<Projects>(jsonContent);
                }
            }
        }

        /// <summary>
        /// Actualiza el usuario del archivo de usuarios para que contemple que tiene un nuevo proyecto
        /// </summary>
        private void ChangeJSONProperties()
        {
            List<Users> usersList = new List<Users>();
            string jsonContent = File.ReadAllText(pathToProjectFiles + "\\Users.json");
            if (!string.IsNullOrWhiteSpace(jsonContent))
            {
                usersList = System.Text.Json.JsonSerializer.Deserialize<List<Users>>(jsonContent);
            }

            foreach (Users user in usersList)
            {
                if (this.user.nickname.Equals(user.nickname))
                {
                    user.projectsList = this.user.projectsList;
                }
            }

            string newJsonContent = System.Text.Json.JsonSerializer.Serialize(usersList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(pathToProjectFiles + "\\Users.json", newJsonContent);
        }

        /// <summary>
        /// Settea todos los labels del form
        /// </summary>
        private void SetAllLbls()
        {
            homeLBL.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            manageMembersLBL.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            projectFoldersLBL.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            acountLBL.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;

            projectNameLBL.Text = projects.projectName;
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
        /// Abre la pestaña de Manage Members
        /// </summary>
        private void manageMembersLBL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManageMembers manageMembers = new ManageMembers(user, pathToProjectFiles,projects);
            manageMembers.ShowDialog();
        }

        /// <summary>
        /// Abre la pestaña de Manage Members
        /// </summary>
        private void manageMembersIMG_Click(object sender, EventArgs e)
        {
            ManageMembers manageMembers = new ManageMembers(user, pathToProjectFiles, projects);
            manageMembers.ShowDialog();
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
        /// Abre la pestaña de Acount
        /// </summary>
        private void acountLBL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Acount acount = new Acount(user, pathToProjectFiles);
            acount.Show();
            this.Close();
        }

        /// <summary>
        /// Abre la pestaña de Acount
        /// </summary>
        private void acountIMG_Click(object sender, EventArgs e)
        {
            Acount acount = new Acount(user, pathToProjectFiles);
            acount.Show();
            this.Close();
        }

        /// <summary>
        /// Crea una task directamente en BackLog
        /// </summary>
        private void backLogLBL_Click(object sender, EventArgs e)
        {
            NewTask newtask = new NewTask(this, projects.arrayTasks, user, TaskState.BackLog, projects.arrayProjectUsers);
            newtask.ShowDialog();
        }

        /// <summary>
        /// Crea una task directamente en To Do
        /// </summary>
        private void toDoLBL_Click(object sender, EventArgs e)
        {
            NewTask newtask = new NewTask(this, projects.arrayTasks, user, TaskState.ToDo, projects.arrayProjectUsers);
            newtask.ShowDialog();
        }

        /// <summary>
        /// Crea una task directamente en Doing
        /// </summary>
        private void doingLBL_Click(object sender, EventArgs e)
        {
            NewTask newtask = new NewTask(this, projects.arrayTasks, user, TaskState.Doing, projects.arrayProjectUsers);
            newtask.ShowDialog();
        }

        /// <summary>
        /// Crea una task directamente en Pending Confirmation
        /// </summary>
        private void pendingConfirmationLBL_Click(object sender, EventArgs e)
        {
            NewTask newtask = new NewTask(this, projects.arrayTasks, user, TaskState.Pending_Confirmation, projects.arrayProjectUsers);
            newtask.ShowDialog();
        }

        /// <summary>
        /// Crea una task directamente en Done
        /// </summary>
        private void doneLBL_Click(object sender, EventArgs e)
        {
            NewTask newtask = new NewTask(this, projects.arrayTasks, user, TaskState.Done, projects.arrayProjectUsers);
            newtask.ShowDialog();
        }

        /// <summary>
        /// Guarda la información del proyecto en el archivo
        /// </summary>
        private void saveBTN_Click(object sender, EventArgs e)
        {
            if (!File.Exists(thisProjectFolder + "\\" + this.projects.projectName + ".json"))
            {
                File.Create(thisProjectFolder + "\\" + this.projects.projectName + ".json").Close(); // Crea y cierra el archivo
            }
   
            string newJsonContent = System.Text.Json.JsonSerializer.Serialize(projects, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(thisProjectFolder + "\\" + this.projects.projectName + ".json", newJsonContent);

            MessageBox.Show("Proyecto guardado con exito.", "Guardado éxitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Al actualizar una task es llamado para que se actualize en esta pantalla
        /// </summary>
        public void updateTasks(BindingList<Tasks> actualTasks)
        {
            projects.arrayTasks = actualTasks;
            SetAllLBoxs();
        }

        /// <summary>
        /// Al hacer click en una task valida se abre esa task
        /// </summary>
        private void BackLogLBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectTask(BackLogLBox);
        }

        /// <summary>
        /// Al hacer click en una task valida se abre esa task
        /// </summary>
        private void ToDoLBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectTask(ToDoLBox);
        }
        /// <summary>
        /// Al hacer click en una task valida se abre esa task
        /// </summary>

        private void DoingLBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectTask(DoingLBox);
        }

        /// <summary>
        /// Al hacer click en una task valida se abre esa task
        /// </summary>
        private void PendingConfirmationLBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectTask(PendingConfirmationLBox);
        }

        /// <summary>
        /// Al hacer click en una task valida se abre esa task
        /// </summary>
        private void DoneLBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectTask(DoneLBox);
        }

        /// <summary>
        ///  Comprueba que la task seleccionada sea valida y la abre.
        /// </summary>
        private void SelectTask(ListBox selectedListBox)
        {
            Tasks selectedTask = (Tasks)selectedListBox.SelectedItem;
            if (selectedTask != null)
            {
                Task task = new Task(this, projects.arrayTasks, selectedTask, user,projects.arrayProjectUsers);
                task.ShowDialog();
            }
        }
    }
}
