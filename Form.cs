using System;
using Test_Lab_System.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
namespace Test_Lab_System
{
    public partial class Form : System.Windows.Forms.Form
    {

        public Form()
        {
            InitializeComponent();
        }


        private void Form_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(160, 0, 0, 0);
            panel3.BackColor = Color.FromArgb(160, 0, 0, 0);

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
                REGISTRATION Registration = new REGISTRATION();
                Registration.PatientID = PatientID.Text;
                Registration.PatientFirstName = FirstName.Text;
                Registration.PatientLastName = LastName.Text;
                Registration.PatientAge = Age.Text;
                Registration.PatientGender = Gender.Text;   
                Registration.PatientMobilePhone = MobileNumber.Text;    
                Registration.PatientNationalID = NationalID.Text;   
                Registration.PatientAddress = Address.Text; 
                Registration.PatientMaritalStatus = MaritalStatus.Text; 
                Registration.PatientBloodType = BloodType.Text; 
                Registration.PatientNationality = Nationality.Text; 
                Registration.PatientEmail = Email.Text; 
                Registration.PatientDOB = DOB.Text; 
                Registration.PatientJob = Job.Text; 
                Registration.PatientMotherName = MotherName.Text;
                Registration.InsuranceCompany = InsuranceCompany.Text;
                Registration.InsuranceAddress = InsuranceAddress.Text;
                Registration.InsurancePhone = InsuranceNumber.Text;
                Registration.InsuranceSubscriberName = SubscriberName.Text;
                Registration.PatientHomePhone = Home.Text;
                Registration.EmergencyContactName = EmergencyName.Text;
                Registration.EmergencyContactMobile = EmergencyPhone.Text;
                Registration.EmergencyContactRelationshi = EmergencyRelationship.Text;
                Registration.PatientAddress = Address.Text;
            //database insert patient
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
            #region insert into Patient table
            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();
                try
                {
                    //select all query with parameters.
                    SqlCommand command = new SqlCommand("INSERT INTO  PATIENT (PAT_ID,[PAT_NationalID],PAT_FNAME,PAT_LNAME,PAT_DOB,PAT_PHONE)" + " VALUES( @PAT_ID, @PAT_NationalID, @PAT_FNAME, @PAT_LNAME, @PAT_DOB, @PAT_PHONE)", sqlcon);
                    //Add the parameters for the InsertCommand.
                    command.Parameters.Add("@PAT_ID", SqlDbType.NVarChar).Value = patient.PAT_ID.ToString();
                    command.Parameters.Add("@PAT_NationalID", SqlDbType.NVarChar).Value = patient.PAT_NationalID;
                    command.Parameters.Add("@PAT_FNAME", SqlDbType.VarChar).Value = patient.PAT_FNAME;
                    command.Parameters.Add("@PAT_LNAME", SqlDbType.VarChar).Value = patient.PAT_LNAME;
                    command.Parameters.Add("@PAT_PHONE", SqlDbType.VarChar).Value = patient.PAT_PHONE;
                    command.Parameters.Add("@PAT_DOB", SqlDbType.DateTime).Value = patient.PAT_DOB;
                    //pass command to new instance of sqlDataAdapter 
                    SqlDataAdapter adp = new SqlDataAdapter();
                    adp.InsertCommand = command;
                    adp.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("Patient inserted !! ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        #endregion
    }

}
}
