using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FYP.App_Code.DomainClasses;
using System.Data.SqlClient;
using System.Data;

namespace FYP.App_Code.DBContext
{
    class clsManipulateAddress
    {
        public clsAddressDB AddAddress(clsAddressDB addressObj)
        {
            SqlConnection con = new SqlConnection(Variables.ConStr);
            SqlCommand cmd = new SqlCommand("usp_AddAddress", con);
            cmd.Parameters.Add("@Title", SqlDbType.VarChar, 100).Value = addressObj.Title;
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 100).Value = addressObj.FirstName;
            cmd.Parameters.Add("@MiddleName", SqlDbType.VarChar, 100).Value = addressObj.MiddleName;
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 100).Value = addressObj.LastName;
            cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = addressObj.Username;
            cmd.Parameters.Add("@Gender", SqlDbType.VarChar).Value = addressObj.Gender;
            cmd.Parameters.Add("@BirthDay", SqlDbType.DateTime).Value = addressObj.BirthDay;
            cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = addressObj.Address;
            cmd.Parameters.Add("@Country", SqlDbType.VarChar).Value = addressObj.Country;
            cmd.Parameters.Add("@PhoneNo", SqlDbType.VarChar).Value = addressObj.PhoneNo;
            cmd.Parameters.Add("@Note", SqlDbType.VarChar).Value = addressObj.Note;
            cmd.Parameters.Add("@FKUsername", SqlDbType.VarChar, 100).Value = addressObj.FKUsername;

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
            return addressObj;
        }

        public int UpdateAddress(clsAddressDB addressObj)
        {
            int output = 0;
            SqlConnection con = new SqlConnection(Variables.ConStr);
            SqlCommand cmd = new SqlCommand("usp_UpdateAddress", con);
            cmd.Parameters.Add("@AddressID", SqlDbType.Int).Value = addressObj.AddressID;
            cmd.Parameters.Add("@Title", SqlDbType.VarChar, 100).Value = addressObj.Title;
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 100).Value = addressObj.FirstName;
            cmd.Parameters.Add("@MiddleName", SqlDbType.VarChar, 100).Value = addressObj.MiddleName;
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 100).Value = addressObj.LastName;
            cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = addressObj.Username;
            cmd.Parameters.Add("@Gender", SqlDbType.VarChar).Value = addressObj.Gender;
            cmd.Parameters.Add("@BirthDay", SqlDbType.DateTime).Value = addressObj.BirthDay;
            cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = addressObj.Address;
            cmd.Parameters.Add("@Country", SqlDbType.VarChar).Value = addressObj.Country;
            cmd.Parameters.Add("@PhoneNo", SqlDbType.VarChar).Value = addressObj.PhoneNo;
            cmd.Parameters.Add("@Note", SqlDbType.VarChar).Value = addressObj.Note;
            cmd.Parameters.Add("@FKUsername", SqlDbType.VarChar, 100).Value = addressObj.FKUsername;

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
        public static List<clsAddressDB> ShowAddress(clsAddressDB addressObj)
        {
            List<clsAddressDB> lst = new List<clsAddressDB>();
            SqlConnection con = new SqlConnection(Variables.ConStr);
            SqlCommand cmd = new SqlCommand("usp_ShowAddress", con);
            cmd.Parameters.Add("@FKUsername", SqlDbType.VarChar, 100).Value = addressObj.FKUsername;

            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    clsAddressDB obj = new clsAddressDB();
                    obj.AddressID = Convert.ToInt32(reader["AddressID"]);
                    obj.Title = reader["Title"].ToString();
                    obj.FirstName = reader["FirstName"].ToString();
                    obj.MiddleName = reader["MiddleName"].ToString();
                    obj.LastName = reader["LastName"].ToString();
                    obj.Username = reader["Username"].ToString();
                    obj.Gender = reader["Gender"].ToString();
                    obj.BirthDay = Convert.ToDateTime(reader["BirthDay"]);
                    obj.Address = reader["Address"].ToString();
                    obj.Country = reader["Country"].ToString();
                    obj.PhoneNo = reader["PhoneNo"].ToString();
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


        public static int DeleteAddress(int ID)
        {
            int result;
            SqlConnection con = new SqlConnection(Variables.ConStr);
            SqlCommand cmd = new SqlCommand("usp_DeleteAddress", con);
            cmd.Parameters.Add("@AddressID", SqlDbType.Int).Value = ID;

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
