using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace 吃什么饭
{
    /// <summary>
    /// 数据库访问类
    /// </summary>
   public static class DBHelp
    {
       public static readonly string conStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=database.mdb;User ID=Admin;Password=;Jet OLEDB:Database Password=";
       /// <summary>
       /// 无参增删改操作
       /// </summary>
       /// <param name="sql"></param>
       /// <returns></returns>
       public static int Exec(string sql)
       {
           int i = 0;
           using (OleDbConnection con = new OleDbConnection(conStr))
           {
               con.Open();
               OleDbCommand cmd = new OleDbCommand(sql, con);
               i = cmd.ExecuteNonQuery();
           }
           return i;
       }
       /// <summary>
       /// 无参单值查询
       /// </summary>
       /// <param name="sql"></param>
       /// <returns></returns>
       public static object GetSingle(string sql)
       {
           object obj = null;
           using (OleDbConnection con = new OleDbConnection(conStr))
           {
               con.Open();
               OleDbCommand cmd = new OleDbCommand(sql, con);
               obj = cmd.ExecuteScalar();
           }
           return obj;
       }
       /// <summary>
       /// 无参多值查询
       /// </summary>
       /// <param name="sql"></param>
       /// <returns></returns>
       public static DataTable GetMany(string sql)
       {
           OleDbConnection con = new OleDbConnection(conStr);
           OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
           DataSet ds = new DataSet();
           adp.Fill(ds);
           return ds.Tables[0];
       }

       /// <summary>
       /// 有参增删改操作
       /// </summary>
       /// <param name="sql"></param>
       /// <returns></returns>
       public static int Exec(string sql,params OleDbParameter[] para)
       {
           int i = 0;
           using (OleDbConnection con = new OleDbConnection(conStr))
           {
               con.Open();
               OleDbCommand cmd = new OleDbCommand(sql, con);
               cmd.Parameters.AddRange(para);
               i = cmd.ExecuteNonQuery();
           }
           return i;
       }
       /// <summary>
       /// 有参单值查询
       /// </summary>
       /// <param name="sql"></param>
       /// <returns></returns>
       public static object GetSingle(string sql, params OleDbParameter[] para)
       {
           object obj = null;
           using (OleDbConnection con = new OleDbConnection(conStr))
           {
               con.Open();
               OleDbCommand cmd = new OleDbCommand(sql, con);
               cmd.Parameters.AddRange(para);
               obj = cmd.ExecuteScalar();
           }
           return obj;
       }
       /// <summary>
       /// 有参多值查询
       /// </summary>
       /// <param name="sql"></param>
       /// <returns></returns>
       public static DataTable GetMany(string sql, params OleDbParameter[] para)
       {
           OleDbConnection con = new OleDbConnection(conStr);
           OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
           adp.SelectCommand.Parameters.AddRange(para);
           DataSet ds = new DataSet();
           adp.Fill(ds);
           return ds.Tables[0];
       }
    }
}
