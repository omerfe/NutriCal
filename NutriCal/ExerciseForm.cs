using NutriCal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriCal
{
    public partial class ExerciseForm : Form
    {
        NutriCalDbContext db = new NutriCalDbContext();

        Exercise selectedExercise;
        User loggedUser;
        public ExerciseForm()
        {
            loggedUser = db.Users.ToList()[0];
            InitializeComponent();
            CreateExerciseList();
            GetTheMostRecentExercises();
        }

        private void GetTheMostRecentExercises()
        {
            var exerciseList = db.UserExercises.OrderByDescending(d => d.ExerciseAddedTime).Where(x => x.UserId == loggedUser.UserId).ToList();
            dgvMostRecents.DataSource = exerciseList.Select(x => new
            {
                x.Exercise.ExerciseName,
                BurnedEnergy = $"-{x.Exercise.BurnedEnergy} kcal",
                x.ExerciseAddedTime
            }).ToList();
            //TODO: Column'ları kendin ver. Burdaki default değere bırakma.
        }

        private void CreateExerciseList()
        {
            List<Exercise> exercises = db.Exercises.Where(x => x.ExerciseRole == "A").ToList();
            for (int i = 0; i < exercises.Count; i++)
            {
                string exerciseName = exercises[i].ExerciseName;
                ListViewItem lvi = new ListViewItem(exerciseName);
                lvi.ImageKey = exerciseName;
                lsvExercises.Items.Add(lvi);
            }
        }
        private void btnAddCustomExercise_Click(object sender, EventArgs e)
        {
            new ExerciseEditForm(selectedExercise, db, loggedUser).ShowDialog();
        }
        private void lsvExercises_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string exerciseName = lsvExercises.SelectedItems[0].Text;
            selectedExercise = db.Exercises.FirstOrDefault(x => x.ExerciseName == exerciseName);
            new ExerciseEditForm(selectedExercise, db, loggedUser).ShowDialog();
            selectedExercise = null;
            GetTheMostRecentExercises();
        }

    }
}
