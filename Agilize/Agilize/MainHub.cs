using System;
using System.Drawing;
using System.Windows.Forms;

namespace Agilize
{
    public partial class MainHub : Form
    {

        Users user;
        String pathToProjectFiles;


        /// <summary>
        /// Contructor del form, recibe el path donde estan los archivos del programa y el usuario que ha iniciado sessión.
        /// </summary>
        public MainHub(Users user, String pathToProjectFiles)
        {
            InitializeComponent();
            this.user = new Users();
            this.user = user;
            this.pathToProjectFiles = pathToProjectFiles;
            SetAll();
            
        }

        /// <summary>
        /// Settea todo el apartado visual del form
        /// </summary>
        private void SetAll()
        {
            SetAllLbls();
            if (user.projectsList != null)
            {
                foreach (var project in user.projectsList)
                {
                    ProjectLBox.Items.Add(project);
                }
            }
            RedondearBoton(logOutBtn);
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
        /// Comprueba que se ha seleccionado un nuevo proyecto y lo abre
        /// </summary>
        private void ProjectLBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String projectName = (String)ProjectLBox.SelectedItem;

            if (projectName != null)
            {
                foreach (var existentProject in user.projectsList)
                {
                    if (projectName.Equals(existentProject))
                    {
                        ProjectWindow project = new ProjectWindow(user, pathToProjectFiles, existentProject, false);
                        project.Show();
                        this.Close();
                    }
                }
            }
        }

        /// <summary>
        /// Abre la pestaña de Home (que es esta misma)
        /// </summary>
        private void homeLBL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainHub mainHub = new MainHub(user, pathToProjectFiles);
            mainHub.Show();
            this.Close();
        }

        /// <summary>
        /// Abre la pestaña de Home (que es esta misma)
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
        /// Cierra el Form
        /// </summary>
        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
