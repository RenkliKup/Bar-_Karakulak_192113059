using System;
using System.Data.OleDb;

namespace DataLayer
{
    public class SqlConnection
    {
        public OleDbConnection Conn()
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Ace.OleDb.12.0;Data Source=C:\Users\baris\Documents\Database2.accdb");
            return conn;
        }
        public OleDbCommand cmd(string str, OleDbConnection conn)
        {
            OleDbCommand cmd = new OleDbCommand(str, conn);
            return cmd;
        }
    }
}
