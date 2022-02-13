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

            //Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\xxx.accdb;Persist Security Info=False;

           // OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Ace.OleDb.12.0;Data Source=|DataDirectory|\Database2.accdb");
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OleDb.4.0;Data Source=|DataDirectory|\Database2.mdb");
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
