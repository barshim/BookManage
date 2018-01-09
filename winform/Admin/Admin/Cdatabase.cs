using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Admin
{
    class Cdatabase
    {
        public static string connStr = "Data Source=.;Initial Catalog=bookmanage;Integrated Security=True;User Id=sa;Password=sa;"; //连接数据库                                
        public static SqlConnection conn = new SqlConnection(connStr);//存储连接数据库字符串

        // “读”数据的静态方法
        public static DataSet GetDataFromDB(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlDataAdapter myAdapter = new SqlDataAdapter(sqlStr, conn);
                DataSet myDataSet = new DataSet();
                myDataSet.Clear();
                myAdapter.Fill(myDataSet);
                conn.Close();
                if (myDataSet.Tables[0].Rows.Count != 0)
                {
                    return myDataSet;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                SqlDataAdapter myAdapter = new SqlDataAdapter(sqlStr, conn);
                DataSet myDataSet = new DataSet();
                myDataSet.Clear();
                myAdapter.Fill(myDataSet);
                conn.Close();
                if (myDataSet.Tables[0].Rows.Count != 0)
                {
                    return myDataSet;
                }
                else
                {
                    return null;
                }
            }
        }

        // “写”数据的静态方法
        public static bool UpdateDB(string sqlStr)
        {
            try
            {
                conn.Open();
                // 定义数据命令对象
                SqlCommand myCmd = new SqlCommand(sqlStr, conn);
                // 设置 Command 对象的 CommandType 属性
                myCmd.CommandType = CommandType.Text;
                // 执行 SQL 语句
                myCmd.ExecuteNonQuery();
                conn.Close();
                // 数据更新成功,返回 true
                return true;
            }
            catch (Exception e)
            {
                SqlCommand myCmd = new SqlCommand(sqlStr, conn);
                // 设置 Command 对象的 CommandType 属性
                myCmd.CommandType = CommandType.Text;
                // 执行 SQL 语句
                myCmd.ExecuteNonQuery();
                conn.Close();
                // 数据更新成功,返回 true
                return true;
            }
        }

    }
}
