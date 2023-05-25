using EasyTask.ViewModel;
using VMTask = EasyTask.ViewModel;

namespace EasyTask
{
    public partial class Frm_Task : Form
    {
        private VMTask.TaskViewModel taskViewModel;
        private Model.Task Task;
        public Frm_Task()
        {
            InitializeComponent();
            taskViewModel = new TaskViewModel();
            //    dataGridViewTask.DataSource = taskViewModel.Tasks;
            foreach (var task in taskViewModel.Tasks)
            {
                dataGridViewTask.Rows.Add(task.Id, task.Title, task.Description, task.IsCompleted);
            }
            
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            var task = new Model.Task();
            task.Title = txtTitle.Text;
            task.Description = txtDescription.Text;
            task.IsCompleted = chkTermine.Checked;
            taskViewModel.SelectedTask = task;
            taskViewModel.AddTask();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            /* Todo 
                1-  Lorsque la ligne du tableau des taches est selectionn�e
                    Afficher les informations dans le formulaire.
                2-  Si une donn�e du formulaire change et que l'utilisateur clique sur le bouton
                    Modifier ou modifiera l'�l�ment.
             */
            taskViewModel.UpdateTask();
        }

        private void Btn_Del_Click(object sender, EventArgs e)
        {
            /* Todo 
                1-  Lorsque la ligne du tableau des taches est selectionn�e
                    Afficher les informations dans le formulaire.
                2-  On supprime l'�l�ment selectionn�.
             */
            taskViewModel.DeleteTask();
        }

        private void Frm_Task_Load(object sender, EventArgs e)
        {

        }
    }
}