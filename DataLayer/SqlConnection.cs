using System;
using System.Data.OleDb;

namespace DataLayer
{
    public class SqlConnection
    {
        //oledb bağlantısı geri dondüren fonksiyon
        public OleDbConnection Conn()
        {
            //oledbconnection objesi
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Ace.OleDb.12.0;Data Source=C:\Users\baris\Documents\Database2.accdb");
            //objeyi donduruyorum
            return conn;
        }
        //oledbcommand komutlar için donduren fonksiyon
        public OleDbCommand cmd(string str, OleDbConnection conn)
        {
            //oledbcommand objesi
            OleDbCommand cmd = new OleDbCommand(str, conn);
            //oledbcommand donduruyorum
            return cmd;
        }
    }
}
