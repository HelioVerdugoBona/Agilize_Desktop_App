using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agilize
{
    public class Tasks
    {

        public String TaskName {  get; set; }

        public String Description { get; set; }

        public String DateCreation {  get; set; }

        public String DeadLine { get; set; }

        public TaskState CurrentState { get; set; }

        public int Sprint {  get; set; }

        public String EstimatedTime { get; set; }

        public BindingList<Users> TaskMembers { get; set; }

        public Tasks()
        {
            TaskMembers = new BindingList<Users>();
        }

        public Tasks(String taskName, String description, String dateCreation, String deadLine, TaskState currentState, int sprint, string estimatedTime, BindingList<Users> taskMembers)
        {
            TaskMembers = new BindingList<Users>();
            this.TaskName = taskName;
            this.Description = description;
            this.DateCreation = dateCreation;
            this.DeadLine = deadLine;
            this.CurrentState = currentState;
            this.Sprint = sprint;
            this.EstimatedTime = estimatedTime;
            this.TaskMembers = taskMembers;
        }


        override public String ToString()
        {
            return TaskName.ToString();
        }

    }
    public enum TaskState
    {
        BackLog,
        ToDo,
        Doing,
        Pending_Confirmation,
        Done

    }
}
