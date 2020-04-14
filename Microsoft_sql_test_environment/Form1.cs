using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;
using Microsoft_sql_test_environment.Entities;
using Microsoft_sql_test_environment.Services;

namespace Microsoft_sql_test_environment
{
    public partial class Form1 : Form
    {
        UserServices userServices = new UserServices();
        string provider = ConfigurationManager.AppSettings["provider"];
        string connectionString = ConfigurationManager.AppSettings["connectionString"];
        string connectionStringTestDatabase = ConfigurationManager.AppSettings["connectionStringTestDatabase"];
        public Form1()
        {
            InitializeComponent();


        }

        private void Button_ReadJson_Click(object sender, EventArgs e)
        {
            JsonToObject reader = new JsonToObject();
            string path = "Data.json";
            List<User> users = reader.JsonToUsersList(path);
            userServices.addUsers(users);
        }

        private async void Button_GetTop_Click(object sender, EventArgs e)
        {
            List<User> users = await userServices.GetTop10000FromUsers();
            Console.WriteLine("Users: " + users.Count);
            //UpdateUsersTable(users);
        }

        private async void Button_GetRowCount_Click(object sender, EventArgs e)
        {
            List<User> users = await userServices.GetSetRowCount50000FromUsers();
            Console.WriteLine("Users: " + users.Count);
        }
        private async void Button_GetDivisionResult_Click(object sender, EventArgs e)
        {
            List<int> usersSecondNumberDivisionResults = await userServices.GetDivisionResultFromUsers();
            Console.WriteLine("Users: " + usersSecondNumberDivisionResults.Count);
        }

        private async void Button_GetConcatenationResult_Click(object sender, EventArgs e)
        {
            List<string> usersStrings = await userServices.GetConcatenationResultFromUsers();
            Console.WriteLine("Users: " + usersStrings.Count);
        }

        private async void Button_SelectExcept_Click(object sender, EventArgs e)
        {
            List<User> users = await userServices.GetExceptFromUsers();
            Console.WriteLine("Users: " + users.Count);
        }

        private async void Button_SelectReplace_Click(object sender, EventArgs e)
        {
            List<User> users = await userServices.GetReplaceFromUsers();
            Console.WriteLine("Users: " + users.Count);
        }


        //Interface
        public void UpdateUsersTable(List<User> usersToAdd)
        {
            
            Table_Users.SuspendLayout();
            emptyTable(Table_Users);
            Table_Users.ResumeLayout();

            Table_Users.Hide();
            Table_Users.RowCount = usersToAdd.Count;
            for (int i = 0; i < usersToAdd.Count - 1; i++)
            {
                Table_Users.RowStyles.Add(new RowStyle(SizeType.Absolute));
                if (i % 10000 == 0)
                {
                    Console.WriteLine("Rows added: " + i);
                }
            }
            TableLayoutRowStyleCollection styles =
            Table_Users.RowStyles;
            for (int i=0;i<styles.Count;i++)
            {
                if (i % 10000 == 0)
                {
                    Console.WriteLine("Styled: " + i);
                }
                // Set the row height to 20 pixels.
                styles[i].SizeType = SizeType.Absolute;
                styles[i].Height = 40;
            }
           
            for (int i = 0; i < usersToAdd.Count; i++)
            {
                if(i%10000 == 0)
                {
                    Console.WriteLine("Written: " + i);
                }
                addEventToEventTableRow(usersToAdd[i], i);
            }
            Table_Users.Show();
            
        }
        public void addEventToEventTableRow(User user, int rowNumber)
        {

            Label label_UserId = new Label();
            label_UserId.Text = user.UserId.ToString();
            label_UserId.Width = 100;


            Label label_FullName = new Label();
            label_FullName.Text = user.FullName;
            label_FullName.Width = 100;

            Label label_Country = new Label();
            label_Country.Text = user.Country;
            label_Country.Width = 100;

            Label label_Email = new Label();
            label_Email.Text = user.Email;
            label_Email.Width = 100;


            Label label_CreatedAt = new Label();
            label_CreatedAt.Text = user.CreatedAt;
            label_CreatedAt.Width = 200;


            Table_Users.Controls.Add(label_UserId, 0, rowNumber);
            Table_Users.Controls.Add(label_FullName, 1, rowNumber);
            Table_Users.Controls.Add(label_Country, 2, rowNumber);
            Table_Users.Controls.Add(label_Email, 3, rowNumber);
            Table_Users.Controls.Add(label_CreatedAt, 4, rowNumber);
           

        }
        public void emptyTable(TableLayoutPanel table)
        {
            table.RowCount = 1;
            table.Hide();
            table.Controls.Clear();
            table.Show();

        }

       
    }
}
