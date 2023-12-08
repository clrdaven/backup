using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto.Macs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Anytimefit
{
    public class Backbone
    {
        FuncConnect Func = new FuncConnect();

        // Admin 
        public void Admin(int adminuserid, string adminpassword)
        {




            // Check if the entered username and password match the predefined values
            if (CheckCredentials(adminuserid, adminpassword))
            {
                MessageBox.Show("Login successful!");
                HomePage homePage = new HomePage();

                homePage.Show();

            }
            else
            {
                MessageBox.Show("Login failed. Please check your username and password.");
            }
        }

        private bool CheckCredentials(int adminuserid, string adminpassword)
        {
            try
            {
                Func.OpenCon();
                string query = "SELECT * FROM admin WHERE adminuserid = @adminuserid AND adminpassword = @adminpassword;";
                MySqlCommand cmd = new MySqlCommand(query, Func.GetCon());
                cmd.Parameters.AddWithValue("@adminuserid", adminuserid);
                cmd.Parameters.AddWithValue("@adminpassword", adminpassword);
                MySqlDataReader reader = cmd.ExecuteReader();



                if (reader.HasRows)
                {
                    reader.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                Func.CloseCon();
            }
        }


        //Addmember
        public void AddMember(string MemberName, string PhoneNum, string Age, string Gender, int coachid)
        {
            if (MemberName == "" || PhoneNum == "" || Age == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Func.OpenCon();
                    string query = $"INSERT INTO member ( membername, contactinfo, age, gender, coachid)  VALUES ('{MemberName}','{PhoneNum}','{Age}','{Gender}','{coachid}');";

                    MySqlCommand cmd = new MySqlCommand(query, Func.GetCon());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Successfully Added");
                    Func.CloseCon();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Func.CloseCon();
                }

            }
        }
        // refresh in addmember
        public void refreshmem()
        {
            try
            {
                Func.OpenCon();
                string query = "UPDATE membership AS c " +
                               "JOIN (SELECT membershipid, " +
                               "ROW_NUMBER() OVER(ORDER BY membershipid) AS new_membership_id " +
                               "FROM membership) AS rc ON c.membershipid = rc.membershipid " +
                               "SET c.membershipid = rc.new_membership_id";

                MySqlCommand cmd = new MySqlCommand(query, Func.GetCon());
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Func.CloseCon();
            }
        }

        // Viewlist member

        public void ViewList(string searchQuery, DataGridView dtv)
        {     //Search button

            if (!string.IsNullOrEmpty(searchQuery))
            {
                try
                {
                    string query = "SELECT memberid, membername, contactinfo, age, gender, coachid FROM member WHERE membername LIKE @SearchQuery";

                    Func.OpenCon();

                    using (MySqlCommand command = new MySqlCommand(query, Func.GetCon()))
                    {
                        command.Parameters.AddWithValue("@SearchQuery", $"%{searchQuery}%");

                        DataTable dt = new DataTable();
                        MySqlDataAdapter adapt = new MySqlDataAdapter(command);
                        adapt.Fill(dt);
                        dtv.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Func.CloseCon();
                }
            }
            else
            {
                MessageBox.Show("Please enter a search query.");
            }
        }
        //REFRESH FOR DISPLAY and delete
        public void RefreshForDisplay(DataGridView dataGridView)
        {
            try
            {
                Func.OpenCon();
                string query = "UPDATE member AS ot " +
                               "JOIN (SELECT memberid, ROW_NUMBER() OVER (ORDER BY memberid) AS new_member_id FROM member) AS rot " +
                               "ON ot.memberid = rot.memberid " +
                               "SET ot.memberid = rot.new_member_id";

                MySqlCommand cmd = new MySqlCommand(query, Func.GetCon());
                cmd.ExecuteNonQuery();


                dataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Func.CloseCon();
            }
        }


        //delete in member

        public void Delete(string MembernameD)
        {
            try
            {
                Func.OpenCon();
                string query = $"DELETE FROM member WHERE membername = '{MembernameD}';";
                MySqlCommand cmd = new MySqlCommand(query, Func.GetCon());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Func.CloseCon();
            }
        }

        //refresh in refresh button
        public void RefreshDataGridView(DataGridView dataGridView)
        {
            try
            {
                Func.OpenCon();
                string query = "UPDATE member AS ot " +
                               "JOIN (SELECT memberid, ROW_NUMBER() OVER (ORDER BY memberid) AS new_member_id FROM member) AS rot " +
                               "ON ot.memberid = rot.memberid " +
                               "SET ot.memberid = rot.new_member_id";

                MySqlCommand cmd = new MySqlCommand(query, Func.GetCon());
                cmd.ExecuteNonQuery();


                dataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Func.CloseCon();
            }
        }
        //display show in member
        public void DisplayMemberData(DataGridView dataGridView)
        {
            try
            {
                Func.OpenCon();

                string query = "SELECT memberid, coachid, membername, gender, contactinfo, age FROM member";
                MySqlCommand cmd = new MySqlCommand(query, Func.GetCon());

                DataTable dataTable = new DataTable();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }

                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Func.CloseCon();
            }
        }

        public void DeleteResfresh()
        {
            try
            {
                Func.OpenCon();
                string query = "SELECT * FROM member";
                MySqlCommand cmd = new MySqlCommand(query, Func.GetCon());
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Func.CloseCon();
            }

        }

        // membership --------------------
        //refresh in button of membership 
        public void refreshmemberships()

        {
            try
            {
                Func.OpenCon();
                string query = "UPDATE member AS ot " +
                               "JOIN (SELECT memberid, ROW_NUMBER() OVER (ORDER BY memberid) AS new_member_id FROM member) AS rot " +
                               "ON ot.memberid = rot.memberid " +
                               "SET ot.memberid = rot.new_member_id";

                MySqlCommand cmd = new MySqlCommand(query, Func.GetCon());
                cmd.ExecuteNonQuery();
              

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Func.CloseCon();
            }
        }
        
        //membership form
        public void Membership(int MemId, string Membershiptye, DateTime Enddate)
        {
            int membershipDuration = 0;

            
            switch (Membershiptye.ToLower())
            {
                case "day":
                    membershipDuration = 1;
                    SharedVariable.total = 50;
                    break;
                case "weekly":
                    membershipDuration = 7;
                    SharedVariable.total = 150;
                    break;
                case "monthly":
                    membershipDuration = 30; // Assuming a month is considered 30 days
                    SharedVariable.total = 500;
                    break;
                default:
                    throw new ArgumentException("Invalid membershiptype");
            }

            try
            {
                Func.OpenCon();

                // Calculate the end date by adding the membership duration to the provided Enddate
                DateTime calculatedEndDate = Enddate.AddDays(membershipDuration);

                // Format the DateTime object to a string in MySQL format
                string formattedEndDate = calculatedEndDate.ToString("yyyy-MM-dd HH:mm:ss");

                string query = $"INSERT INTO membership (memberid, membershiptype, end_date) " +
                               $"VALUES ({MemId}, '{Membershiptye}', '{formattedEndDate}');";

                MySqlCommand cmd = new MySqlCommand(query, Func.GetCon());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Membership Successfully Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Func.CloseCon();
            }
        }

        // refresh membership
        public void RefreshMembership()
        {
            try
            {
                Func.OpenCon();
                string query = "UPDATE membership AS c " +
                               "JOIN (SELECT membershipid, " +
                               "ROW_NUMBER() OVER(ORDER BY membershipid) AS new_membership_id " +
                               "FROM membership) AS rc ON c.membershipid = rc.membershipid " +
                               "SET c.membershipid = rc.new_membership_id";

                MySqlCommand cmd = new MySqlCommand(query, Func.GetCon());
                cmd.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Func.CloseCon();
            }
        }

        // refresh in payment cash
        public void RefreshOther()
        {

            try
            {
                Func.OpenCon();
                string query = "UPDATE membership AS c " +
                               "JOIN (SELECT membershipid, " +
                               "ROW_NUMBER() OVER(ORDER BY membershipid) AS new_membership_id " +
                               "FROM membership) AS rc ON c.membershipid = rc.membershipid " +
                               "SET c.membershipid = rc.new_membership_id";

                MySqlCommand cmd = new MySqlCommand(query, Func.GetCon());
                cmd.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Func.CloseCon();
            }
        }

        public void ViewlistMembership(string searchQuery, DataGridView dataGridView)
        {
            try
            {
                Func.OpenCon();

                string query = "SELECT * FROM membership WHERE membershipid LIKE @SearchQuery";

                using (MySqlCommand command = new MySqlCommand(query, Func.GetCon()))
                {
                    command.Parameters.AddWithValue("@SearchQuery", $"%{searchQuery}%");

                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapt = new MySqlDataAdapter(command);
                    adapt.Fill(dt);

                    // Set the DataSource of the provided DataGridView
                    dataGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                Func.CloseCon();
            }
        }
        public void DeleteMembership(int membershipId, DataGridView dataGridView)
        {
            try
            {
                Func.OpenCon();

                string query = $"DELETE FROM membership WHERE membershipid = {membershipId}";

                MySqlCommand command = new MySqlCommand(query, Func.GetCon());
                command.ExecuteNonQuery();
                MessageBox.Show("Membership Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                Func.CloseCon();
            }


        }
        // Display membership
        public void DisplayMembershipData(DataGridView dataGridView)
        {
            try
            {
                Func.OpenCon();

                string query = "SELECT membershipid, memberid, membershiptype, date, end_date FROM membership";
                MySqlCommand cmd = new MySqlCommand(query, Func.GetCon());

                DataTable dataTable = new DataTable();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }

                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Func.CloseCon();
            }
        }
        // Transaction 
        public void transaction()
        {
            try
            {
                Func.OpenCon();

                string query = "INSERT INTO transaction (membershipid, total, amount, `change`, paymentmethod) " +
                               "VALUES (@membershipid, @total, @amount, @change, @paymentmethod)";

                MySqlCommand cmd = new MySqlCommand(query, Func.GetCon());

                // Use parameters to prevent SQL injection
                cmd.Parameters.Add("@membershipid", MySqlDbType.VarChar).Value = SharedVariable.memberidT;
                cmd.Parameters.Add("@total", MySqlDbType.Decimal).Value = SharedVariable.total;
                cmd.Parameters.Add("@amount", MySqlDbType.Decimal).Value = SharedVariable.amounth;
                cmd.Parameters.Add("@change", MySqlDbType.Decimal).Value = SharedVariable.Change;
                cmd.Parameters.Add("@paymentmethod", MySqlDbType.VarChar, 255).Value = SharedVariable.Paymenthod;

                cmd.ExecuteNonQuery();
                MessageBox.Show("BAYAD KANA PSSY");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Func.CloseCon();
            }
        }
        public void Program(DataGridView dtv, int categ)
        {
            try
            {
                Func.OpenCon();
                string query = $"Select programid, programname, sets from program Where categid = '{categ}'  ";
                MySqlCommand cmd = new MySqlCommand(query, Func.GetCon());
                DataTable dt = new DataTable();
                MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                adapt.Fill(dt);
                dtv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                Func.CloseCon();
            }
        }
        public void report()
        {

        }
        public void Retriveshet()
        {
            Func.OpenCon();
            string query = $"SELECT membername, age, contactinfo, gender FROM member WHERE memberid = '{SharedVariable.memid}';";
            MySqlCommand cmd = new MySqlCommand(query, Func.GetCon());
            MySqlDataReader reader = cmd.ExecuteReader();
            
            reader.Read();
            SharedVariable.MembernameD = reader.GetString(reader.GetOrdinal("membername"));
            SharedVariable.AgenameD = reader.GetString(reader.GetOrdinal("age"));
            SharedVariable.contactinfo = reader.GetString(reader.GetOrdinal("contactinfo"));
            SharedVariable.GenderD = reader.GetString(reader.GetOrdinal("gender"));

            Func.CloseCon();

        }
        public void Updatename(string name)
        {
            try
            {
                Func.OpenCon();
                string query = $"Update member set membername = '{name}' Where memberid = '{SharedVariable.memid}';";
                MySqlCommand cmd = new MySqlCommand(query, Func.GetCon());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Member Name was update");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                Func.CloseCon();
            }

        }
        public void UpdateAge(string age)
        {
            try
            {
                Func.OpenCon();
                string query = $"Update member set age = '{age}' Where memberid = '{SharedVariable.memid}';";
                MySqlCommand cmd = new MySqlCommand(query, Func.GetCon());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Member age was update");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                Func.CloseCon();
            }

        }
        public void UpdateContact(string contact)
        {
            try
            {
                Func.OpenCon();
                string query = $"Update member set contactinfo = '{contact}' Where memberid = '{SharedVariable.memid}';";
                MySqlCommand cmd = new MySqlCommand(query, Func.GetCon());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Member contact was update");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                Func.CloseCon();
            }

        }
        public void UpdateGender (string gender)
        {
            try
            {
                Func.OpenCon();
                string query = $"Update member set gender = '{gender}' Where memberid = '{SharedVariable.memid}';";
                MySqlCommand cmd = new MySqlCommand(query, Func.GetCon());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Member gender was update");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                Func.CloseCon();
            }

        }
    }
}









