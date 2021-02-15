using System.Windows.Forms;
using System.IO;

namespace Sales_Automation_v._0._0._1
{
    public class Customer
    {
        private static string name;
        public static string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private static string adress;
        public static string Adress
        {
            get
            {
                return adress;
            }
            set
            {
                adress = value;
            }
        }
        //Login Paneli için
        public string userlogin(string userid, string password)
        {
            StreamReader UsersDataText = new StreamReader(System.Windows.Forms.Application.StartupPath + "\\UserData.txt");
            string line = null, trueline = null;
            while ((line = UsersDataText.ReadLine()) != null)
            {
                string getUserID = null, getPassword = null, getLine = line, getName = null, getSurname = null, getAdress = null;
                int plus = 0;
                for (int j = 0; j < getLine.Length; j++)
                {
                    if (getLine[j] == '+')
                    {
                        plus++;
                    }
                    else if (plus == 0)
                    {
                        getName = getName + getLine[j];
                    }
                    else if (plus == 1)
                    {
                        getSurname = getSurname + getLine[j];
                    }
                    else if (plus == 2)
                    {
                        getUserID = getUserID + getLine[j];
                    }
                    else if (plus == 3)
                    {
                        getPassword = getPassword + getLine[j];
                    }
                    else if (plus == 4)
                    {
                        getAdress = getAdress + getLine[j];
                    }
                }
                if (getUserID == userid && getPassword == password)
                {
                    trueline = line;
                    name = getName + " " + getSurname;
                    adress = getAdress;
                }
            }
            UsersDataText.Close();
            return trueline;
        }
        //Register Paneli İçin
        public bool userregister(string userID)
        {
            StreamReader UsersDataText = new StreamReader(System.Windows.Forms.Application.StartupPath + "\\UserData.txt");
            string line = null, getUserID = null;
            bool control = true;
            while ((line = UsersDataText.ReadLine()) != null)
            {
                int plus = 0;
                for (int j = 0; j < line.Length - 1; j++)
                {
                    if (line[j] == '+')
                    {
                        plus++;
                    }
                    else if (plus == 2)
                    {
                        getUserID = getUserID + line[j];
                    }
                }
                if (getUserID == userID)
                {
                    MessageBox.Show("User Already Registered");
                    control = false;
                }
                getUserID = "";
            }
            UsersDataText.Close();
            return control;
        }


    }
}
