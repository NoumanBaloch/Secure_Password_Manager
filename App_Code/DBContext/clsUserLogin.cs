using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using FYP.App_Code.DomainClasses;

namespace FYP.App_Code
{
    class clsUserLogin
    {
        public static int FetchingSalt(clsUserDB userObj)
        {
            int salt = 0;
            SqlConnection con = new SqlConnection(Variables.ConStr);
            SqlCommand cmd = new SqlCommand("usp_FetchingSalt", con);
            cmd.Parameters.Add("@Username", SqlDbType.VarChar, 100).Value = userObj.Username;
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    salt = Convert.ToInt32((reader["Salt"]));
                }
                reader.Read();
                con.Close();
               
            }
            catch (Exception x)
            {
                throw new Exception("Error Occured " + x.Message);
                
            }
            return salt;
        }

        public static bool UsernameValidationForLogin(clsUserDB userObj)
        {	
            bool Result = false;
            SqlConnection con = new SqlConnection(Variables.ConStr);
            SqlCommand cmd = new SqlCommand("usp_UserNameValidationForLogin", con);
            cmd.Parameters.Add("@Username", SqlDbType.VarChar, 100).Value = userObj.Username;
            cmd.Parameters.Add("@Password", SqlDbType.Char, 60).Value = userObj.Password;
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Result = true;
                }
                reader.Read();
                con.Close();
            }
            catch (Exception x)
            {
                throw new Exception("Error Occured " + x.Message);
            }
            return Result;
        }

        public static bool UserLoginValidation(clsUserDB clickObj) 
        {
            bool Result = false;
            SqlConnection con = new SqlConnection(Variables.ConStr);
            SqlCommand cmd = new SqlCommand("usp_UserLoginValidation", con);
            cmd.Parameters.Add("@ClickPointOnXAxis", SqlDbType.Int).Value = clickObj.ClickPointOnXAxis;
            cmd.Parameters.Add("@ClickPointOnYAxis", SqlDbType.Int).Value = clickObj.ClickPointOnYAxis;
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Result = true;
                }
                reader.Read();
                con.Close();
            }
            catch (Exception x)
            {
                throw new Exception("Error Occured " + x.Message);   
            }
            return Result;
        }

        public static bool UserPatternValidation(clsPatternDB patternObj)
        {
            bool Result = false;
            SqlConnection con = new SqlConnection(Variables.ConStr);
            SqlCommand cmd = new SqlCommand("usp_UserPatternValidation", con);
            cmd.Parameters.Add("@FKUsername", SqlDbType.VarChar, 100).Value = patternObj.FKUsername;
            cmd.Parameters.Add("@Pattern", SqlDbType.VarChar).Value = patternObj.Pattern;
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Result = true;
                }
                reader.Read();
                con.Close();
            }
            catch (Exception x)
            {
                throw new Exception("Error Occured " + x.Message);
            }
            return Result;
        }
    }
}
