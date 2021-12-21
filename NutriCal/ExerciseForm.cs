﻿using NutriCal.Models;
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
        UserExercise userExercise;
        Exercise selectedExercise;
        User loggedUser;
        List<UserExercise> exerciseList;
        public ExerciseForm()
        {
            loggedUser = db.Users.ToList()[0];
            InitializeComponent();
            CreateExerciseList();
            GetTheMostRecentExercises();
        }

        private void GetTheMostRecentExercises()
        {
            exerciseList = db.UserExercises.OrderByDescending(d => d.ExerciseAddedTime).Where(x => x.UserId == loggedUser.UserId).ToList();
            dgvMostRecents.DataSource = exerciseList.Select(x => new
            {
                x.Exercise.ExerciseName,
                BurnedEnergy = $"-{x.Exercise.BurnedEnergy} kcal / {x.Exercise.Duration} min",
                x.ExerciseAddedTime
            }).ToList();
            //TODO: Column'ları kendin ver. Burdaki default değere bırakma.
            GetTotalBurnedEnergy();
        }

        private void GetTotalBurnedEnergy()
        {
            lblTotalBurnedEnergy.Text = exerciseList.Sum(x => x.Exercise.BurnedEnergy).ToString();
        }

        private void CreateExerciseList()
        {
            List<Exercise> exercises = null;
            lsvExercises.Clear();
            string searchedText = txtSearch.Text.Trim();
            if (searchedText == string.Empty)
            {
                exercises = db.Exercises.Where(x => x.ExerciseRole == "A").ToList();
            }
            else
            {
                exercises = db.Exercises.Where(x => x.ExerciseRole == "A" && x.ExerciseName.Contains(searchedText)).ToList();
            }
            for (int i = 0; i < exercises.Count; i++)
            {
                string exerciseName = exercises[i].ExerciseName;
                ListViewItem lvi = new ListViewItem(exerciseName);
                lvi.Tag = exercises[i];
                lvi.ImageKey = exerciseName;
                lsvExercises.Items.Add(lvi);
            }
        }
        private void btnAddCustomExercise_Click(object sender, EventArgs e)
        {
            new ExerciseEditForm(new Exercise(), db, loggedUser).ShowDialog();
            GetTheMostRecentExercises();
        }
        private void lsvExercises_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string exerciseName = lsvExercises.SelectedItems[0].Text;
            selectedExercise = db.Exercises.FirstOrDefault(x => x.ExerciseName == exerciseName);
            new ExerciseEditForm(selectedExercise, db, loggedUser).ShowDialog();
            selectedExercise = null;
            GetTheMostRecentExercises();
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            tcExercises.SelectedIndex = 1;
            txtSearch.Focus();
            CreateExerciseList();
        }

        private void dgvMostRecents_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                string selectedRecentExercise = dgvMostRecents.SelectedRows[0].Cells[0].Value.ToString();
                userExercise = exerciseList.FirstOrDefault(x => x.Exercise.ExerciseName == selectedRecentExercise);
                var position = dgvMostRecents.HitTest(e.X, e.Y).RowIndex;
                if (position >= 0)
                {
                    cmsRecentExercises.Show(dgvMostRecents, new Point(e.X, e.Y));
                    dgvMostRecents.Rows[position].Selected = true;
                }
            }
        }

        private void updateExerciseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExerciseEditForm exerciseEditForm = new ExerciseEditForm(userExercise, db, loggedUser);
            exerciseEditForm.ShowDialog();
            GetTheMostRecentExercises();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSelectedUserExercise();
        }

        private void DeleteSelectedUserExercise()
        {
            DialogResult dr = MessageBox.Show($"Are you sure delete {userExercise.Exercise.ExerciseName}?", "Warning", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                db.UserExercises.Remove(userExercise);
                db.SaveChanges();
                GetTheMostRecentExercises();
            }

        }
    }
}