using System;
using System.IO;
using System.Data;
using System.Data.SQLite;

namespace GabaritoMontagem
{
    class BancoDeDados
    {
        private static SQLiteConnection sqliteConnection;

        private static SQLiteConnection DbConnection()
        {
            string local = Directory.GetCurrentDirectory();

            sqliteConnection = new SQLiteConnection("Data Source=" + local + "\\Bitola.db; Version=3;");
            sqliteConnection.Open();
            return sqliteConnection;
        }

        public static string GetBitola(double distancia, bool raioMedio)
        {
            double raio = distancia / 2500;

            string raioResult = raioMedio ? raioResult = "rg_med" : raioResult = "rg_min";

            SQLiteDataAdapter da = null;

            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "select * from RaioDeGiracao where " + raioResult + " > " + raio + " limit 1";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);

                    return dt.Rows[0]["bitola"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string GetBitola(double distancia)
        {
            double raio = distancia / 2500;

            SQLiteDataAdapter da = null;

            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "select * from RaioDeGiracao where rg_min > " + raio + " limit 1";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);

                    return dt.Rows[0]["bitola"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
