using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using FYP.App_Code.DomainClasses;

namespace FYP.App_Code.DBContext
{
    class clsManipulatePaymentCard
    {             

        public clsPaymentCardDB AddCard(clsPaymentCardDB paymentObj)
        {
            SqlConnection con = new SqlConnection(Variables.ConStr);
            SqlCommand cmd = new SqlCommand("usp_AddCard", con);
            cmd.Parameters.Add("@NameOnCard", SqlDbType.VarChar, 100).Value = paymentObj.NameOnCard;
            cmd.Parameters.Add("@Type", SqlDbType.VarChar, 100).Value = paymentObj.Type;
            cmd.Parameters.Add("@Number", SqlDbType.VarChar, 100).Value = paymentObj.Number;
            cmd.Parameters.Add("@SecurityCode", SqlDbType.VarChar, 100).Value = paymentObj.SecurityCode;
            cmd.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = paymentObj.StartDate;
            cmd.Parameters.Add("@ExpirationDate", SqlDbType.DateTime).Value = paymentObj.ExpirationDate;
            cmd.Parameters.Add("@Note", SqlDbType.VarChar).Value = paymentObj.Note;
            cmd.Parameters.Add("@FKUsername", SqlDbType.VarChar, 100).Value = paymentObj.FKUsername;

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
            return paymentObj;
        }

        public int UpdateCard(clsPaymentCardDB paymentObj)
        {
            int output = 0;
            SqlConnection con = new SqlConnection(Variables.ConStr);
            SqlCommand cmd = new SqlCommand("usp_UpdateCard", con);
            cmd.Parameters.Add("@CardID", SqlDbType.Int).Value = paymentObj.CardID;
            cmd.Parameters.Add("@NameOnCard", SqlDbType.VarChar, 100).Value = paymentObj.NameOnCard;
            cmd.Parameters.Add("@Type", SqlDbType.VarChar, 100).Value = paymentObj.Type;
            cmd.Parameters.Add("@Number", SqlDbType.VarChar, 100).Value = paymentObj.Number;
            cmd.Parameters.Add("@SecurityCode", SqlDbType.VarChar, 100).Value = paymentObj.SecurityCode;
            cmd.Parameters.Add("@StartDate", SqlDbType.VarChar, 100).Value = paymentObj.StartDate;
            cmd.Parameters.Add("@ExpirationDate", SqlDbType.VarChar, 100).Value = paymentObj.ExpirationDate;
            cmd.Parameters.Add("@Note", SqlDbType.VarChar).Value = paymentObj.Note;
            cmd.Parameters.Add("@FKUsername", SqlDbType.VarChar, 100).Value = paymentObj.FKUsername;

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
       
        public static List<clsPaymentCardDB> ShowCard(clsPaymentCardDB paymentObj)
        {
            List<clsPaymentCardDB> lst = new List<clsPaymentCardDB>();
            SqlConnection con = new SqlConnection(Variables.ConStr);
            SqlCommand cmd = new SqlCommand("usp_ShowCard", con);
            cmd.Parameters.Add("@FKUsername", SqlDbType.VarChar, 100).Value = paymentObj.FKUsername;

            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    clsPaymentCardDB obj = new clsPaymentCardDB();
                    obj.CardID = Convert.ToInt32(reader["CardID"]);
                    obj.NameOnCard = reader["NameOnCard"].ToString();
                    obj.Type = reader["Type"].ToString();
                    obj.Number = reader["Number"].ToString();
                    obj.SecurityCode = reader["SecurityCode"].ToString();
                    obj.StartDate = Convert.ToDateTime(reader["StartDate"]);
                    obj.ExpirationDate = Convert.ToDateTime(reader["ExpirationDate"]);
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
        
        public static int DeleteCard(int ID)
        {
            int result;
            SqlConnection con = new SqlConnection(Variables.ConStr);
            SqlCommand cmd = new SqlCommand("usp_DeleteCard", con);
            cmd.Parameters.Add("@CardID", SqlDbType.Int).Value = ID;

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
