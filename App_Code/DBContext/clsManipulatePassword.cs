using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using FYP.App_Code.DomainClasses;

namespace FYP.App_Code.DBContext
{
    class clsManipulatePassword
    {
        public clsPasswordManagerDB AddPassword(clsPasswordManagerDB passObj)
        {
            SqlConnection con = new SqlConnection(Variables.ConStr);
            SqlCommand cmd = new SqlCommand("usp_AddPassword", con);
            cmd.Parameters.Add("@URL", SqlDbType.VarChar).Value = passObj.URL;
            cmd.Parameters.Add("@Name", SqlDbType.VarChar, 100).Value = passObj.Name;
            cmd.Parameters.Add("@Usernames", SqlDbType.VarChar).Value = passObj.Usernames;
            cmd.Parameters.Add("@Passwords", SqlDbType.VarChar).Value = passObj.Passwords;
            cmd.Parameters.Add("@Note", SqlDbType.Text).Value = passObj.Passwords;
            cmd.Parameters.Add("@FKUsername", SqlDbType.VarChar, 100).Value = passObj.FKUsername;

            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception x)
            {
                throw new Exception("Error Occured: " + x.Message);
            }
            return passObj;
        }


        public  int UpdatePassword(clsPasswordManagerDB passObj)
        {
            int output = 0;
            SqlConnection con = new SqlConnection(Variables.ConStr);
            SqlCommand cmd = new SqlCommand("usp_UpdatePassword", con);
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = passObj.ID;
            cmd.Parameters.Add("@URL", SqlDbType.VarChar).Value = passObj.URL;
            cmd.Parameters.Add("@Name", SqlDbType.VarChar, 100).Value = passObj.Name;
            cmd.Parameters.Add("@Usernames", SqlDbType.VarChar).Value = passObj.Usernames;
            cmd.Parameters.Add("@Passwords", SqlDbType.VarChar).Value = passObj.Passwords;
            cmd.Parameters.Add("@Note", SqlDbType.Text).Value = passObj.Passwords;
            cmd.Parameters.Add("@FKUsername", SqlDbType.VarChar, 100).Value = passObj.FKUsername;

            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                con.Open();
                output = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception x)
            {
                throw new Exception("Error Occured: " + x.Message);
            }
            return output;
        }
        public static List<clsPasswordManagerDB> ShowPassword(clsPasswordManagerDB passObj)
        {
            List<clsPasswordManagerDB> lst = new List<clsPasswordManagerDB>();
            SqlConnection con = new SqlConnection(Variables.ConStr);
            SqlCommand cmd = new SqlCommand("usp_ShowPassword", con);
            cmd.Parameters.Add("@FKUsername", SqlDbType.VarChar, 100).Value = passObj.FKUsername;
            
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    clsPasswordManagerDB obj = new clsPasswordManagerDB();
                    obj.ID = Convert.ToInt32(reader["ID"]);
                    obj.URL = reader["URL"].ToString();
                    obj.Name = reader["Name"].ToString();
                    obj.Usernames = reader["Usernames"].ToString();
                    obj.Passwords = reader["Passwords"].ToString();
                    obj.Note = reader["Note"].ToString();
                    lst.Add(obj);
                }
                reader.Close();
            }
            catch (Exception x)
            {
                throw new Exception("Error Occured: " + x.Message);
            }
            return lst;
        }

        public static int DeletePassword(int ID)
        {
            int result;
            SqlConnection con = new SqlConnection(Variables.ConStr);
            SqlCommand cmd = new SqlCommand("usp_DeletePassword", con);
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;

            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                con.Open();
                result = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception x)
            {
                throw new Exception("Error Occured: " + x.Message);
            }
            return result;
        }
    }
}
