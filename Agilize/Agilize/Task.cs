using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Agilize
{
    public partial class Task : Form
    {
        BindingList<Tasks> tasksList;
        ProjectWindow projectWindow;
        BindingList<Users> projectMembers;
        Users user;
        Tasks task;
        Tasks oldTask;
        Boolean isnewTask;

        /// <summary>
        /// Contructor del form, recibe el projecto que lo ha habierto, la lista de tareas, la tarea seleccionada,
        /// el usuario que ha iniciado sessión y los miembros del proyecto
        /// </summary>
        public Task(ProjectWindow projectWindow, BindingList<Tasks> tasksList,Tasks task, Users user, BindingList<Users> projectMembers)
        {
            InitializeComponent();
            this.task = new Tasks();
            oldTask = new Tasks();
            this.projectMembers = new BindingList<Users>();
            this.projectMembers = projectMembers;
            isnewTask = false;
            this.tasksList = tasksList;
            this.projectWindow = projectWindow;
            this.task = task;
            this.user = user;
            SetAll(false);
        }

        /// <summary>
        /// Contructor del form, recibe el projecto que lo ha habierto, la lista de tareas, la tarea seleccionada,
        /// el usuario que ha iniciado sessión, el estado donde ha sido creado (Backlog, To Do, etc) y los miembros del proyecto.
        /// </summary>
        public Task(ProjectWindow projectWindow, BindingList<Tasks> tasksList, Users user,String taskName,TaskState state, BindingList<Users> projectMembers)
        {
            InitializeComponent();
            task = new Tasks();
            this.tasksList = tasksList;
            this.projectWindow = projectWindow;
            this.projectMembers = new BindingList<Users>();
            this.projectMembers = projectMembers;
            this.user = user;
            isnewTask = true;
            task.CurrentState = state;
            task.TaskName = taskName;
            SetAll(true);
        }

        /// <summary>
        /// Settea todo el apartado visual del form tanto para el caso de 
        /// ser una nueva task como para el caso de ser una ya existente
        /// </summary>
        private void SetAll(Boolean firstTime)
        {
            RedondearBoton(retunBTN);
            RedondearBoton(addMemberBTN);
            RedondearBoton(deleteMemberBtn);
            if (firstTime)
            {
                SetAllLblsFirstTime();
            }
            else
            {
                SetAllLbls();
            }
            SetAllLBox();
        }

        /// <summary>
        /// Settea todo el apartado visual del form
        /// </summary>
        private void SetAllLBox()
        {
            if (projectMembers != null)
            {
                if (task.TaskMembers != null)
                {
                    foreach (var userProject in this.projectMembers)
                    {
                        if (userProject != null && !task.TaskMembers.Contains(userProject))
                        {
                            MembersListBox.Items.Add(userProject);
                        }
                    }
                }
            }
            if (task.TaskMembers != null)
            {
                foreach(var userTask in this.task.TaskMembers)
                {
                    if (userTask != null)
                    {
                        ListedMembersListBox.Items.Add(userTask);
                    }
                }
            }
           
        }

        /// <summary>
        /// Settea todos los labels del form en el caso de ser la primera vez que se crea
        /// </summary>
        private void SetAllLblsFirstTime()
        {
            TaskLBL.Text = task.TaskName;

            currentSateCBox.SelectedIndexChanged -= currentSateCBox_SelectedIndexChanged;

            currentSateCBox.DataSource = Enum.GetValues(typeof(TaskState));
            currentSateCBox.SelectedItem = task.CurrentState;

            currentSateCBox.SelectedIndexChanged += currentSateCBox_SelectedIndexChanged;

            ListedMembersListBox.Items.Clear();
            MembersListBox.Items.Clear();
        }

        /// <summary>
        ///  Settea todos los labels del form para el resto de casos
        /// </summary>
        private void SetAllLbls()
        {
            TaskLBL.Text = task.TaskName;

            currentSateCBox.SelectedIndexChanged -= currentSateCBox_SelectedIndexChanged;

            currentSateCBox.DataSource = Enum.GetValues(typeof(TaskState));
            descriptionTxtBox.Text = task.Description;

            currentSateCBox.SelectedIndexChanged += currentSateCBox_SelectedIndexChanged;
            dateCreationTPicker.Text = task.DateCreation.ToString();
            deadLineTPicker.Text = task.DeadLine.ToString();
            sprintNumUpDown.Text = task.Sprint.ToString();
            currentSateCBox.SelectedItem = task.CurrentState;
            estimatedTimeTxtBox.Text = task.EstimatedTime;
            ListedMembersListBox.Items.Clear();
            MembersListBox.Items.Clear();
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
        /// Compueba que la task sea valida para crearse
        /// </summary>
        private void ValidateTask()
        {
            if (task.Description == null)
            {
                task.Description = " ";
            }
            if (task.DateCreation == null)
            {
                task.DateCreation = dateCreationTPicker.Value.ToString();
            }
            if (task.DeadLine == null)
            {
                task.DeadLine = deadLineTPicker.Value.ToString();
            }
            if (task.EstimatedTime == null)
            {
                task.EstimatedTime = "0h";
            }
            if (task.TaskMembers == null)
            {
                task.TaskMembers.Add(this.user);
            }
        }

        /// <summary>
        /// Obtiene la descripción de la tarea
        /// </summary>
        private void descriptionTxtBox_TextChanged(object sender, EventArgs e)
        {
            task.Description = descriptionTxtBox.Text;
        }

        /// <summary>
        /// Obtiene la fecha de creación
        /// </summary>
        private void dateCreationTPicker_ValueChanged(object sender, EventArgs e)
        {
            task.DateCreation = deadLineTPicker.Value.ToString();
        }

        /// <summary>
        /// Obtiene la fecha limite de la tarea
        /// </summary>
        private void deadLineTPicker_ValueChanged(object sender, EventArgs e)
        {
            task.DeadLine = deadLineTPicker.Value.ToString();
        }

        /// <summary>
        /// Obtiene el estado actual de la tarea
        /// </summary>
        private void currentSateCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            task.CurrentState = (TaskState)currentSateCBox.SelectedItem;
        }

        /// <summary>
        /// Obtiene el sprint
        /// </summary>
        private void sprintNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            task.Sprint = (int) sprintNumUpDown.Value;
        }

        /// <summary>
        /// Obtiene el tiempo estimado para hacer la tarea
        /// </summary>
        private void estimatedTimeTxtBox_TextChanged(object sender, EventArgs e)
        {
            task.EstimatedTime = estimatedTimeTxtBox.Text;
        }

        /// <summary>
        /// Elimina al miembro seleccionado de la tarea
        /// </summary>
        private void deleteMemberBtn_Click(object sender, EventArgs e)
        {
            if (ListedMembersListBox.SelectedItem == null)
            {
                MessageBox.Show("No hay ningun miembro seleccionado","Delete Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                Users deletedUser = (Users)ListedMembersListBox.SelectedItem;
                if (deletedUser != null)
                {
                    MembersListBox.Items.Add(deletedUser);
                    ListedMembersListBox.Items.Remove(deletedUser);
                    task.TaskMembers.Remove(deletedUser);
                }
            }
        }

        /// <summary>
        /// Añade el miembro seleccionado a la taera
        /// </summary>
        private void addMemberBTN_Click(object sender, EventArgs e)
        {
            if (MembersListBox.SelectedItem == null)
            {
                MessageBox.Show("No hay ningun miembro seleccionado", "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Users addedUsers = (Users)MembersListBox.SelectedItem;
                if (addedUsers != null)
                {
                    ListedMembersListBox.Items.Add(addedUsers);
                    MembersListBox.Items.Remove(addedUsers);

                    if (task.TaskMembers == null)
                    {
                        task.TaskMembers = new BindingList<Users> { addedUsers };
                    }
                    else
                    {
                        task.TaskMembers.Add(addedUsers);
                    }
                }
            }
        }

        /// <summary>
        /// Vuelve al Kanban del proyecto
        /// </summary>
        private void retunBTN_Click(object sender, EventArgs e)
        {
            ValidateTask();
            if (tasksList == null)
            {
                tasksList = new BindingList<Tasks> { task };
            }
            else
            {
                if (isnewTask)
                {
                    tasksList.Add(task);
                }
            }
            projectWindow.updateTasks(tasksList);
            this.Close();
        }

        /// <summary>
        /// Comprueba que el text box tenga como nombre Add a description, si es así lo borra para que el usuario pueda escribir.
        /// Comprueba que el texto no sea Add a description para que pueda funcionar como Hint.
        /// </summary>
        private void descriptionTxtBox_Enter(object sender, EventArgs e)
        {
            if (descriptionTxtBox.Text == "Add a description")
            {
                descriptionTxtBox.Text = "";
                descriptionTxtBox.ForeColor = SystemColors.WindowText; // Cambiar a color normal
            }
        }

        /// <summary>
        /// Guarda la decripción de la tarea, sino deja el texto de Add a description para indicar que se ha de poner una descipción
        /// funciona como un hint.
        /// </summary>
        private void descriptionTxtBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(descriptionTxtBox.Text))
            {
                descriptionTxtBox.Text = "Add a description";
                descriptionTxtBox.ForeColor = SystemColors.GrayText; // Cambiar a color gris
            }
        }
    }
}
