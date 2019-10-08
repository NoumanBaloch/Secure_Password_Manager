using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using FYP.App_Code.DomainClasses;

namespace FYP.App_Code.DBContext
{
    class clsAccountSetting
    {
        public static void DeleteAccount(clsUserDB userObj, clsPasswordManagerDB passObj)
        { 
            
            SqlConnection con = new SqlConnection(Variables.ConStr);
            SqlCommand cmd = new SqlCommand("usp_DeleteAccount", con);
            cmd.Parameters.Add("@FKUsername", SqlDbType.VarChar, 100).Value = passObj.FKUsername;
            cmd.Parameters.Add("@Username", SqlDbType.VarChar, 100).Value = userObj.Username;
            cmd.Parameters.Add("@Password", SqlDbType.Char, 60).Value = userObj.Password;
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
            
        }

        public void ChangeingPassword(clsUserDB userObj)
        {

            SqlConnection con = new SqlConnection(Variables.ConStr);
            SqlCommand cmd = new SqlCommand("usp_ChangePassword", con);
            cmd.Parameters.Add("@Username", SqlDbType.Char, 100).Value = userObj.Username;
            cmd.Parameters.Add("@Password", SqlDbType.Char, 60).Value = userObj.Password;

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

        }
    }
}