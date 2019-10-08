using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using FYP.App_Code.DomainClasses;

namespace FYP.App_Code.DBContext
{
    class clsManipulateBankAccount
    {

        public clsBankAccountsDB AddBank(clsBankAccountsDB bankObj)
        {
            SqlConnection con = new SqlConnection(Variables.ConStr);
            SqlCommand cmd = new SqlCommand("usp_AddBank", con);
            cmd.Parameters.Add("@BankName", SqlDbType.VarChar, 100).Value = bankObj.BankName;
            cmd.Parameters.Add("@AccountType", SqlDbType.VarChar, 100).Value = bankObj.AccountType;
            cmd.Parameters.Add("@RoutingNumber", SqlDbType.VarChar, 100).Value = bankObj.RoutingNumber;
            cmd.Parameters.Add("@AccountNumber", SqlDbType.VarChar, 100).Value = bankObj.AccountNumber;
            cmd.Parameters.Add("@SWIFTCode", SqlDbType.VarChar, 100).Value = bankObj.SWIFTCode;
            cmd.Parameters.Add("@IBANNumber", SqlDbType.VarChar, 100).Value = bankObj.IBANNumber;
            cmd.Parameters.Add("@Pin", SqlDbType.VarChar, 100).Value = bankObj.Pin;
            cmd.Parameters.Add("@BranchAddress", SqlDbType.VarChar, 100).Value = bankObj.BranchAddress;
            cmd.Parameters.Add("@BranchPhone", SqlDbType.VarChar, 100).Value = bankObj.BranchPhone;
            cmd.Parameters.Add("@Note", SqlDbType.VarChar).Value = bankObj.Note;
            cmd.Parameters.Add("@FKUsername", SqlDbType.VarChar, 100).Value = bankObj.FKUsername;

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
            return bankObj;
        }


        public int UpdateBank(clsBankAccountsDB bankObj)
        {
            int output = 0;
            SqlConnection con = new SqlConnection(Variables.ConStr);
            SqlCommand cmd = new SqlCommand("usp_UpdateBank", con);
            cmd.Parameters.Add("@BankID", SqlDbType.Int).Value = bankObj.BankID;
            cmd.Parameters.Add("@BankName", SqlDbType.VarChar, 100).Value = bankObj.BankName;
            cmd.Parameters.Add("@AccountType", SqlDbType.VarChar, 100).Value = bankObj.AccountType;
            cmd.Parameters.Add("@RoutingNumber", SqlDbType.VarChar, 100).Value = bankObj.RoutingNumber;
            cmd.Parameters.Add("@AccountNumber", SqlDbType.VarChar, 100).Value = bankObj.AccountNumber;
            cmd.Parameters.Add("@SWIFTCode", SqlDbType.VarChar, 100).Value = bankObj.SWIFTCode;
            cmd.Parameters.Add("@IBANNumber", SqlDbType.VarChar, 100).Value = bankObj.IBANNumber;
            cmd.Parameters.Add("@Pin", SqlDbType.VarChar, 100).Value = bankObj.Pin;
            cmd.Parameters.Add("@BranchAddress", SqlDbType.VarChar, 100).Value = bankObj.BranchAddress;
            cmd.Parameters.Add("@BranchPhone", SqlDbType.VarChar, 100).Value = bankObj.BranchPhone;
            cmd.Parameters.Add("@Note", SqlDbType.VarChar).Value = bankObj.Note;
            cmd.Parameters.Add("@FKUsername", SqlDbType.VarChar, 100).Value = bankObj.FKUsername;

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
        public static List<clsBankAccountsDB> ShowBank(clsBankAccountsDB bankObj)
        {
            List<clsBankAccountsDB> lst = new List<clsBankAccountsDB>();
            SqlConnection con = new SqlConnection(Variables.ConStr);
            SqlCommand cmd = new SqlCommand("usp_ShowBank", con);
            cmd.Parameters.Add("@FKUsername", SqlDbType.VarChar, 100).Value = bankObj.FKUsername;

            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    clsBankAccountsDB obj = new clsBankAccountsDB();
                    obj.BankID = Convert.ToInt32(reader["BankID"]);
                    obj.BankName = reader["BankName"].ToString();
                    obj.AccountType = reader["AccountType"].ToString();
                    obj.AccountNumber = reader["AccountNumber"].ToString();
                    obj.RoutingNumber = reader["RoutingNumber"].ToString();
                    obj.SWIFTCode = reader["SWIFTCode"].ToString();
                    obj.IBANNumber = reader["IBANNumber"].ToString();
                    obj.Pin = reader["Pin"].ToString();
                    obj.BranchAddress = reader["BranchAddress"].ToString();
                    obj.BranchPhone = reader["BranchPhone"].ToString();
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

        public static int DeleteBank(int ID)
        {
            int result;
            SqlConnection con = new SqlConnection(Variables.ConStr);
            SqlCommand cmd = new SqlCommand("usp_DeleteBank", con);
            cmd.Parameters.Add("@BankID", SqlDbType.Int).Value = ID;

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
