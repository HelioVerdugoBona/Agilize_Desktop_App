using Org.BouncyCastle.Asn1.X509;
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
    public partial class ProjectFolders : Form
    {
        DirectoryInfo actualDirectory;
        List<FichDir> subDirectories = new List<FichDir>();
        List<FichDir> files = new List<FichDir>();
        String pathToProjectFiles;
        String newfolderPathTxtBox;
        Users user;

        /// <summary>
        /// Contructor del form, recibe el path donde estan los archivos del programa y el usuario que ha iniciado sessión.
        /// </summary>
        public ProjectFolders(Users user,String pathToProjectFiles)
        {
            InitializeComponent();
            SetAllLbls();
            getAll(user, pathToProjectFiles);
            RedondearBoton(saveBTN);
        }

        /// <summary>
        /// Settea todo el apartado visual del form
        /// </summary>
        private void getAll(Users user, String pathToProjectFiles)
        {
            this.user = user;
            this.pathToProjectFiles = pathToProjectFiles;
            if (pathToProjectFiles != null)
            {
                folderPathTxtBox.Text = pathToProjectFiles;
            }

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
        /// Abre un buscador de archivos.
        /// </summary>
        private void searchBTN_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.SelectedPath = pathToProjectFiles;
            DialogResult result = folder.ShowDialog();

            if (result == DialogResult.OK)
            {
                folderPathTxtBox.Text = folder.SelectedPath;
                pathToProjectFiles = folder.SelectedPath;
                newfolderPathTxtBox = folder.SelectedPath;
                actualDirectory = new DirectoryInfo(folderPathTxtBox.Text);

                ObtainSubdirectories();
                Obtainfiles();
            }
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
        /// Obtiene los subdirectorios
        /// </summary>
        private void ObtainSubdirectories()
        {
            subDirectories.Clear();
            foreach (DirectoryInfo subDir in actualDirectory.GetDirectories())
            {
                FichDir fichDir = new FichDir();
                fichDir.Name = subDir.Name;
                fichDir.Fullname = subDir.FullName;
                subDirectories.Add(fichDir);

                directorysListBox.DataSource = null;
                directorysListBox.DataSource = subDirectories;
                directorysListBox.DisplayMember = "Name";
            }
        }

        /// <summary>
        /// Obtiene los ficheros
        /// </summary>
        private void Obtainfiles()
        {
            files.Clear();

            foreach (FileInfo file in actualDirectory.GetFiles())
            {
                FichDir fichDir = new FichDir();
                fichDir.Name = file.Name;
                fichDir.Fullname = file.FullName;
                files.Add(fichDir);

                fileListBox.DataSource = null;
                fileListBox.DataSource = files;
                fileListBox.DisplayMember = "Name";
            }
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
        /// Abre la pestaña de Project Folders (que es esta misma)
        /// </summary>
        private void projectFoldersLBL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProjectFolders projectFolders = new ProjectFolders(user, pathToProjectFiles);
            projectFolders.Show();
            this.Close();
        }

        /// <summary>
        /// Abre la pestaña de Project Folders (que es esta misma)
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
        /// Actualiza el path para los proyectos al nuevo path
        /// </summary>
        private void saveBTN_Click(object sender, EventArgs e)
        {
            pathToProjectFiles = newfolderPathTxtBox;
        }

    }
}
