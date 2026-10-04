using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhaoxi.AirCompressorMonitorSystem.Utils
{
    public class SQLiteHelper
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        public static readonly string connString = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        /// <summary>
        /// 执行SQL语句，返回受影响的行数----insert\update\delete
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="paras">参数数组</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql, params SQLiteParameter[] paras)
        {
            int count = 0;
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                SQLiteCommand cmd = BuilderCommand(conn, sql, null, paras);
                count = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            return count;
        }

        /// <summary>
        /// 执行查询，返回第一行第一列的值  -----返回一个值
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="paras">参数数组</param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql, params SQLiteParameter[] paras)
        {
            object result = null;
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                SQLiteCommand cmd = BuilderCommand(conn, sql, null, paras);
                result = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
            }
            return result;
        }

        /// <summary>
        /// 执行查询，返回一个SqlDataReader对象   ---- 查询
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="paras">参数数组</param>
        /// <returns></returns>
        public static SQLiteDataReader ExecuteReader(string sql, params SQLiteParameter[] paras)
        {
            SQLiteConnection conn = new SQLiteConnection(connString);
            SQLiteCommand cmd = BuilderCommand(conn, sql, null, paras);
            try
            {
                SQLiteDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return dr;
            }
            catch (SQLiteException ex)
            {
                conn.Close();
                throw new Exception("创建DataReader对象发生异常", ex);
            }
        }


        //SQLiteDataAdapter的两个填充方法、一个更新方法
        /// <summary>
        /// 执行查询，填充到DataTable中   ---- 单结果查询
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="paras">参数数组</param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sql, params SQLiteParameter[] paras)
        {
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                SQLiteCommand cmd = BuilderCommand(conn, sql, null, paras);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        /// <summary>
        /// 执行查询，填充到DataSet中（返回多结果集）
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql, params SQLiteParameter[] paras)
        {
            DataSet ds = new DataSet();
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                SQLiteCommand cmd = BuilderCommand(conn, sql, null, paras);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(ds);
            }
            return ds;
        }

        /// <summary>
        /// 更新DataTable到数据库----针对于更新单表
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int UpdateDataTable(DataTable dt, string sql)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn);
                SQLiteCommandBuilder cmdBuilder = new SQLiteCommandBuilder(da);
                return da.Update(dt);
            }
        }


        //SQLiteTransaction的两个方法
        /// <summary>
        /// 执行事务  ---- 一系列的sql语句（不带参数）
        /// </summary>
        /// <param name="sqlList"> 一系列的sql语句</param>
        /// <returns></returns>
        public static bool ExecuteTrans(List<string> sqlList)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                SQLiteTransaction tran = conn.BeginTransaction();
                //SqlCommand cmd = new SqlCommand("", conn);
                //cmd.Transaction = tran;
                SQLiteCommand cmd = BuilderCommand(conn, "", tran);
                try
                {
                    foreach (string sql in sqlList)
                    {
                        if (!string.IsNullOrEmpty(sql))
                        {
                            cmd.CommandText = sql;
                            cmd.CommandType = CommandType.Text;
                            cmd.ExecuteNonQuery();
                        }
                    }
                    tran.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw new Exception("执行事务出现异常！", ex);
                }
            }
        }

        /// <summary>
        /// 执行事务---一系列的操作（CommandInfo对象----操作）
        /// </summary>
        /// <param name="comList"></param>
        /// <returns></returns>
        public static bool ExecuteTrans(List<CommandInfo> comList)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                SQLiteTransaction tran = conn.BeginTransaction();
                SQLiteCommand cmd = BuilderCommand(conn, "", tran);
                try
                {
                    foreach (CommandInfo com in comList)
                    {
                        cmd.CommandText = com.commandText;
                        cmd.CommandType = CommandType.Text;
                        if (com.paras != null && com.paras.Length > 0)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddRange(com.paras);
                        }
                        cmd.ExecuteNonQuery();
                    }
                    tran.Commit();
                    return true;
                }
                catch (SQLiteException ex)
                {
                    tran.Rollback();
                    throw new Exception("执行事务出现异常！", ex);
                }
            }
        }

        /// <summary>
        ///  执行事务   针对SQL Server数据库而言
        /// 一般用于多步操作：有先后顺序---第一步的执行结果得到后才能执行下一步。。。。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        public static T ExecuteTrans<T>(Func<SQLiteCommand, T> action)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                SQLiteTransaction trans = conn.BeginTransaction();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.Transaction = trans;
                return action(cmd);
            }
        }



        //统一构建SQLiteCommand对象的方法
        private static SQLiteCommand BuilderCommand(SQLiteConnection conn, string sql, SQLiteTransaction trans, params SQLiteParameter[] paras)
        {
            if (conn == null)
                throw new Exception("连接对象不能为空！");
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            if (trans != null)
                cmd.Transaction = trans;
            if (paras != null && paras.Length > 0)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddRange(paras);
            }
            return cmd;
        }
    }

    /// <summary>
    /// 封装一个操作信息类
    /// </summary>
    public class CommandInfo
    {
        public string commandText;//sql语句
        public SQLiteParameter[] paras;//参数数组

        public CommandInfo() { }
        public CommandInfo(string sql)
        {
            this.commandText = sql;
        }

        public CommandInfo(string sql, SQLiteParameter[] _paras)
        {
            paras = _paras;
            commandText = sql;
        }
    }
}
