using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agilize
{
    public partial class NewProject : Form
    {

        Projects projects;
        Users user;
        String pathToProjectFiles;

        /// <summary>
        /// Contructor del form, recibe el path donde estan los archivos del programa y el usuario que ha iniciado sessión.
        /// </summary>
        public NewProject(Users user, String pathToProjectFiles)
        {
            InitializeComponent();
            projects = new Projects();
            this.user = new Users();
            this.user = user;
            this.pathToProjectFiles = pathToProjectFiles;
            RedondearBoton(acceptBtn);
            RedondearBoton(cancelBtn);
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
        /// Comprueba que el text box tenga como nombre Project Name, si es así lo borra para que el usuario pueda escribir.
        /// Comprueba que el texto no sea Project Name para que pueda funcionar como Hint.
        /// </summary>
        private void projectNameTxTBox_Enter(object sender, EventArgs e)
        {
            if (projectNameTxTBox.Text == "Project Name")
            {
                projectNameTxTBox.Text = "";
                projectNameTxTBox.ForeColor = SystemColors.WindowText; // Cambiar a color normal
            }
        }


        /// <summary>
        /// Guarda el nombre del nuevo proyecto, sino deja el texto de Project Name para indicar que se ha de poner el nombre del nuevo proyecto
        /// funciona como un hint.
        /// </summary>
        private void projectNameTxTBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(projectNameTxTBox.Text))
            {
                projectNameTxTBox.Text = "Project Name";
                projectNameTxTBox.ForeColor = SystemColors.GrayText; // Cambiar a color gris
            }
            else
            {
                projects.projectName = projectNameTxTBox.Text;

            }
            
        }

        /// <summary>
        /// Comprueba que el nombre del Proyecto sea valido, lo crea, lo añade a la lista de proyectos de usuario y lo habre
        /// </summary>
        private void acceptBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(projects.projectName))
            {
                if (comproveProyect())
                {
                    if (user.projectsList == null)
                    {
                        BindingList<String> firstProject = new BindingList<String>();
                        firstProject.Add(projects.projectName);
                        user.projectsList = firstProject;
                    }
                    else
                    {
                        user.projectsList.Add(projects.projectName);
                    }
                    ProjectWindow project = new ProjectWindow(user, pathToProjectFiles, projects.projectName, true);
                    project.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Este proyecto ya existe, por favor usa otro nombre", "Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Introduce un Nombre valido", "Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Comprueba que el nombre del proyecto no exista ya.
        /// </summary>
        private bool comproveProyect()
        {
            if (user.projectsList != null && user.projectsList.Contains(projects.projectName))
            {
                return false;
            }
            else
            {
                if (!File.Exists(pathToProjectFiles + "\\Projects.json"))
                {
                    File.Create(pathToProjectFiles).Close(); // Crea y cierra el archivo
                }
                // Leer usuarios existentes del archivo JSON
                List<Projects> proyectList = new List<Projects>();
                string jsonContent = File.ReadAllText(pathToProjectFiles + "\\Projects.json");
                if (!string.IsNullOrWhiteSpace(jsonContent))
                {
                    proyectList = System.Text.Json.JsonSerializer.Deserialize<List<Projects>>(jsonContent);
                }
                foreach (Projects project in proyectList)
                {
                    if (project.projectName.Equals(projects.projectName))
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        /// <summary>
        /// Cierra el Form
        /// </summary>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
