using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebRole2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Create(object sender, EventArgs e)
        {
            if (
                create_StudentID.Text != null &&
                create_CourseNumber.Text != null &&
                create_CoursePeriod.Text != null &&
                create_CourseTitle.Text != null &&
                create_Email.Text != null &&
                create_Grade.Text != null &&
                create_HP.Text != null &&
                create_StudentName != null
                )
            {
                var client = new ServiceReference1.Service1Client();
                client.SaveStudent(
                    int.Parse(create_StudentID.Text),
                    create_CourseNumber.Text,
                    create_CourseTitle.Text,
                    float.Parse(create_HP.Text),
                    create_CoursePeriod.Text,
                    create_StudentName.Text,
                    create_Email.Text,
                    int.Parse(create_Grade.Text)
                );
                create_Error.Text = "Student created";
            } else
            {
                create_Error.Text = "All fields are mandatory";
            }
        }
        protected void Edit(object sender, EventArgs e)
        {
            if (
                edit_StudentID.Text != null &&
                edit_CourseNumber.Text != null && 
                edit_Email.Text != null &&
                edit_Grade != null
                )
            {
                var client = new ServiceReference1.Service1Client();
                var result = client.UpdateStudent(int.Parse(edit_StudentID.Text), edit_CourseNumber.Text, edit_Email.Text, int.Parse(edit_Grade.Text));
                if (result)
                {
                    edit_Error.Text = "User updated";
                } else
                {
                    edit_Error.Text = "Could not update";
                }
            }
            else
            {
                edit_Error.Text = "All fields are mandatory";
            }
        }
        protected void Count(object sender, EventArgs e)
        {
            if (
                count_StudentID.Text != null
                )
            {
                var client = new ServiceReference1.Service1Client();
                var count = client.CoursesCompleted(int.Parse(count_StudentID.Text));
                count_Error.Text = "Total count is: " + count;
            }
            else
            {
                count_Error.Text = "All fields are mandatory";
            }
        }
        protected void Delete(object sender, EventArgs e)
        {
            if (
                delete_StudentID.Text != null &&
                delete_CourseName.Text != null
                )
            {
                var client = new ServiceReference1.Service1Client();
                if (client.DeleteStudent(int.Parse(delete_StudentID.Text), delete_CourseName.Text))
                {
                    delete_Error.Text = "Student deleted";
                } else
                {
                    delete_Error.Text = "Could not find student";
                }
            }
            else
            {
                delete_Error.Text = "All fields are mandatory";
            }
        }
    }
}