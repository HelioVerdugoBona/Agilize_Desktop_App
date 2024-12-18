using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agilize
{
    public partial class NewTask : Form
    {
        BindingList<Tasks> tasksList;
        BindingList<Users> projectsUsers;
        ProjectWindow projectWindow;
        Users user;
        String newTaskName;
        TaskState state;

        /// <summary>
        /// Contructor del form, recibe el projecto que lo ha habierto, la lista de tareas, el usuario que ha iniciado sessión,
        /// el estado donde ha sido creado (Backlog, To Do, etc) y los miembros del proyecto.
        /// </summary>
        public NewTask(ProjectWindow projectWindow, BindingList<Tasks> tasksList, Users user, TaskState state, BindingList<Users> projectsUsers)
        {
            InitializeComponent();
            this.tasksList = new BindingList<Tasks>();
            this.projectsUsers = new BindingList<Users>();
            this.tasksList = tasksList;
            this.projectWindow = projectWindow;
            this.user = user;
            this.state = state;
            this.projectsUsers = projectsUsers;
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
        /// Obtiene el nombre de la nueva task
        /// </summary>
        private void projectNameTxTBox_TextChanged(object sender, EventArgs e)
        {
            newTaskName = projectNameTxTBox.Text;
        }

        /// <summary>
        /// Comprueva que el nombre de la task sea valido y de ser así la crea
        /// </summary>
        private void acceptBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(newTaskName))
            {
                bool dontExists = true;

                foreach (Tasks task in tasksList)
                {
                    if (newTaskName.Equals(task.TaskName))
                    {
                        dontExists = false;
                    }
                }
                if (dontExists)
                {
                    Task task = new Task(projectWindow, tasksList, user, newTaskName, state, projectsUsers);
                    this.Hide();
                    task.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lo siento pero esta tarea ya existe, debes ponerle otro nombre", "Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    projectNameTxTBox.Text = "";
                }

            }
            
            else
            {
                MessageBox.Show("Introduce un Nombre valido","Name Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// Cierra este Form
        /// </summary>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
