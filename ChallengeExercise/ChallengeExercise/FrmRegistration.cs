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
        static String[] _call_var;

        public FrmRegistration()
        {
            InitializeComponent();
             
        }

        public static string SetFileName { get; private set; }

        public void _info() 
        {
            String getInput_StudentNum = this.txt_StudentNum.Text;
            String getInput_Contact = this.txt_Contact.Text;
            String getInput_LastName = this.txt_LastName.Text;
            String getInput_FirstName = this.txt_FirstName.Text;
            String getInput_MI = this.txt_MI.Text;
            String getInput_Age = this.txt_Age.Text;
            String getInput_Bday = this.Bday_Date.Text;
            String getInput_Gender = this.cb_Gender.Text;
            String getInput_Program = this.cb_Programs.Text;

            SetFileName = getInput_StudentNum.ToString() + ".txt";

            _call_var = new string[] {"Student No. "+ getInput_StudentNum + "\nFullName: " + getInput_LastName + ", " + getInput_FirstName + ", " + getInput_MI
            +"\nProgram: "+getInput_Program+"\nGender: "+getInput_Gender+"\nAge: " + getInput_Age + "\nBirthday: " + getInput_Bday+"\nContact: " + getInput_Contact
            };
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            _info();
            string docPath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,FrmRegistration.SetFileName)))
            {
                foreach (string _Info_ in _call_var) 
                {
                    outputFile.WriteLine(_Info_); 
                }
                Console.WriteLine("Done!");
                
            }


        }
    }
}
