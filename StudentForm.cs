using Sagum_Justine_ACT_GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sagum_Justine_ACT_GUI
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            // Mock Student Data
            StudentNameLabel.Text = "Justine Ray Sagum";
            StudentAgeLabel.Text = "20";
            StudentAddressLabel.Text = "Poponto Bautista Pangasinan";
            StudentContactLabel.Text = "09876543212";
            StudentEmailLabel.Text = "22bgu1228_ms@psu.edu.ph";
            StudentCourseYearLabel.Text = "BSIT Third";
            ParentNameLabel.Text = "N/A";
            ParentContactLabel.Text = "N/A";
            HobbiesLabel.Text = "Reading, Watching and Walking";
            NicknameLabel.Text = "Tine";
        }

        private void AddImageBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Image functionality is not implemented.", "Feature Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChangeImageBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Change Image functionality is not implemented.", "Feature Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditUpdateBtn_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(this);
            this.Hide();
            editForm.Show();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        public void UpdateStudentInfo(UserProfile userProfile)
        {
            StudentNameLabel.Text = userProfile.Name;
            StudentAgeLabel.Text = userProfile.Age.ToString();
            StudentAddressLabel.Text = userProfile.Address;
            StudentContactLabel.Text = userProfile.ContactNumber;
            StudentEmailLabel.Text = userProfile.Email;
            StudentCourseYearLabel.Text = $"{userProfile.Course} {userProfile.Year}";
            ParentNameLabel.Text = userProfile.ParentName;
            ParentContactLabel.Text = userProfile.ParentContact;
            HobbiesLabel.Text = userProfile.Hobbies;
            NicknameLabel.Text = userProfile.Nickname;
        }
    }
}