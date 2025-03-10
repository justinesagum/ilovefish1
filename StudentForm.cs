using Sagum_Justine_Ray;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sagum_Justine_Ray
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            
            StudentNameLabel.Text = "Sagum_Justine_Ray";
            StudentAgeLabel.Text = "20";
            StudentAddressLabel.Text = "Poponto Bautista Pangasinan";
            StudentContactLabel.Text = "0912345678901";
            StudentEmailLabel.Text = "saitamsensei0101@gmail.com";
            StudentCourseYearLabel.Text = "BSIT WMT 3-1";
            ParentNameLabel.Text = "Joyce Sagum";
            ParentContactLabel.Text = "0909876543211";
            HobbiesLabel.Text = "Reading";
            NicknameLabel.Text = "Chandler";
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

    }
}
