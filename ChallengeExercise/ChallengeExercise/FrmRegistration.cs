using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChallengeExercise
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        public static string SetFileName { get; private set; }

        private void btn_Register_Click(object sender, EventArgs e)//btn Register Functionality
        {
            //Student Number / Contact Number
            String getInput_StudentNum = this.txt_StudentNum.Text;
            String getInput_Contact = this.txt_Contact.Text;
            //End
            //Last Name / First Name / MI / Age / Birthday
            String getInput_LastName = this.txt_LastName.Text;
            String getInput_FirstName = this.txt_FirstName.Text;
            String getInput_MI = this.txt_MI.Text;
            String getInput_Age = this.txt_Age.Text;
            String getInput_Bday = this.Bday_Date.Text;
            //End
            //Gender
            String getInput_Gender = this.cb_Gender.Text;
            //End
            //Program
            String getInput_Program = this.cb_Programs.Text;
            //End


            SetFileName = getInput_StudentNum.ToString() + ".txt"; // File Name .txt
            //Path Doc
            string docPath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,FrmRegistration.SetFileName)))
            {
                
                //Print Text
                outputFile.WriteLine("Student No.: "+getInput_StudentNum+"\nFullName: "+getInput_LastName+", "+getInput_FirstName+", "+getInput_MI);
                outputFile.WriteLine("Program: "+getInput_Program+"\nGender: "+getInput_Gender);
                outputFile.WriteLine("Age: " + getInput_Age + "\nBirthday: " + getInput_Bday);
                outputFile.WriteLine("Contact: " + getInput_Contact);
                //End
                //Check Console
                Console.WriteLine("Done!");
                
            }


        }
    }
}
