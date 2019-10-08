using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using FYP.App_Code.DomainClasses;

namespace FYP.App_Code
{
    class clsUserRegistration
    {
        //Validating username while registration.
        public static bool UserNameValidation(clsUserDB userObj) {
            bool Result = false;
            SqlConnection con = new SqlConnection(Variables.ConStr);
            SqlCommand cmd = new SqlCommand("usp_UserNameValidation", con);
            cmd.Parameters.Add("@Username", SqlDbType.VarChar, 100).Value = userObj.Username;
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
        //Inserting user registration details into database.
        public static clsUserDB RegisterUser(clsUserDB clickObj, clsImageDB imageObj, clsPatternDB patternObj)
        {
            SqlConnection con = new SqlConnection(Variables.ConStr);
            SqlCommand cmd = new SqlCommand("usp_RegisterUser", con);
            cmd.Parameters.Add("@Username", SqlDbType.VarChar, 100).Value = clickObj.Username;
            cmd.Parameters.Add("@Password", SqlDbType.Char, 60).Value = clickObj.Password;
            cmd.Parameters.Add("@Salt", SqlDbType.Int).Value = clickObj.Salt;
            cmd.Parameters.Add("@ClickPointOnXAxis", SqlDbType.Int).Value = clickObj.ClickPointOnXAxis;
            cmd.Parameters.Add("@ClickPointOnYAxis", SqlDbType.Int).Value = clickObj.ClickPointOnYAxis;
            cmd.Parameters.Add("@Picture", SqlDbType.Image).Value = imageObj.Picture;
            cmd.Parameters.Add("@FKUsername", SqlDbType.VarChar, 100).Value = imageObj.FKUsername;
            cmd.Parameters.Add("@Pattern", SqlDbType.VarChar).Value = patternObj.Pattern;
            cmd.Parameters.Add("@FKeyUsername", SqlDbType.VarChar, 100).Value = patternObj.FKUsername;
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
            return clickObj;
        }
    } 
}
