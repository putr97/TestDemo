using TestDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace TestDemo.DBLayer
{
    public class DataAccessDB : IDataAccessDB
    {
        private readonly IConfiguration config;
        string connsString = string.Empty;
        public DataAccessDB(IConfiguration config)
        {
            this.config = config;
            connsString = config.GetConnectionString("MyKey");
        }
        public List<CrudModel> GetData()
        {
            // string connsString = config.GetConnectionString("MyKey");// "Data Source=PRO-ACQER8AM;Initial Catalog=CrudDB;Integrated Security=True;";
            List<TestDemo.Models.CrudModel> ModelList = new List<Models.CrudModel>();
            using (SqlConnection conn = new SqlConnection(connsString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand($"select * from [dbo].[TBL_TRN_USER]", conn))
                {
                    try
                    {
                        using (var result = command.ExecuteReader())
                        {

                            while (result.Read())
                            {

                                ModelList.Add(
                                    new Models.CrudModel { Id = (int)result.GetValue("Id"), Name = (string)result.GetValue("Name"), City = (string)result.GetValue("City"), FatherName = (string)result.GetValue("FatherName").ToString() });
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                    finally
                    {
                        conn.Close();
                    }

                    return ModelList;
                }


            }
        }
        public List<TBL_TRN_REGISTRATION> GetDataREGIS()
        {
            // string connsString = config.GetConnectionString("MyKey");// "Data Source=PRO-ACQER8AM;Initial Catalog=CrudDB;Integrated Security=True;";
            List<TestDemo.Models.TBL_TRN_REGISTRATION> ModelList = new List<Models.TBL_TRN_REGISTRATION>();
            using (SqlConnection conn = new SqlConnection(connsString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand($"select * from [dbo].[TBL_TRN_REGISTRATION]", conn))
                {
                    try
                    {
                        using (var result = command.ExecuteReader())
                        {

                            while (result.Read())
                            {

                                ModelList.Add(
                                    new Models.TBL_TRN_REGISTRATION { USERID = (int)result.GetValue("USERID"), USERNAME = (string)result.GetValue("USERNAME"), PASSWORD = (string)result.GetValue("PASSWORD"), CONFIRMPASS = (string)result.GetValue("CONFIRMPASS"), EMAIL = (string)result.GetValue("EMAIL"),SEXID = (string)result.GetValue("SEXID"), MARITALID = (string)result.GetValue("MARITALID").ToString() });
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                    finally
                    {
                        conn.Close();
                    }

                    return ModelList;
                }


            }
        }


        public bool insert(string[] Param)
        {

            //   string connsString = config.GetConnectionString("MyKey");// "Data Source=PRO-ACQER8AM;Initial Catalog=CrudDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connsString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand($"INSERT INTO [dbo].[TBL_TRN_USER] ([Name],[City],[InsertDate],FatherName) VALUES ('{Param[0]}','{Param[1]}',getdate(),'{Param[3]}')", conn))
                {
                    try
                    {
                        var result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            return true;
                        }
                    }
                    catch (Exception)
                    {

                    }
                    finally
                    {
                        conn.Close();
                    }
                    return false;
                }


            }

        }

        public bool insertRegis(string[] Param)
        {
            using (SqlConnection conn = new SqlConnection(connsString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand($" INSERT INTO [dbo].[TBL_TRN_REGISTRATION] (USERNAME, [PASSWORD], CONFIRMPASS, EMAIL, SEXID, MARITALID) VALUES ('{Param[0]}','{Param[1]}','{Param[2]}','{Param[3]}','{Param[4]}','{Param[5]}')", conn))
                {
                    try
                    {
                        var result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            return true;
                        }
                    }
                    catch (Exception)
                    {
                    }
                    finally
                    {
                        conn.Close();

                    }
                    return false;
                }
            }
        }
          
     
    }
}
