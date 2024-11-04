using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace projekt_manager
{
    public class X
    {
        public static MySqlConnection kapcsolat;
        public static MySqlCommand parancs;
        public static MySqlDataReader eredm;
        public static string felhasznalo;
        public static string[] felhasznaloAdatok;
        public static string databasePath;
        public static string kepekPath = Directory.GetCurrentDirectory() + @"\Kepek\";
        public static bool visibility = true;
        public static bool close = false;
        public static bool mehet = false;

        static string key { get; set; } = "A!9HHhi%XjjYY4YP2@Nob009X";

        #region saját kód gyűjtemény


        public static void updateEverything(string elozoS, string s)
        {

            parancs.CommandText = $"update messages set  felado = '{s}' where felado like  '{elozoS}'";
            parancs.ExecuteScalar();
            parancs.CommandText = $"update messages set cimzett = '{s}' where cimzett like  '{elozoS}'";
            parancs.ExecuteScalar();



        }

        public static void kilepes(string felhNev, string tabla)
        {
            parancs.CommandText = "update " + tabla + " set bejelentkezve = 0 where felhNev like '" + felhNev + "'";
            parancs.ExecuteScalar();
            felhasznalo = "";
            visibility = true;
            close = true;
        }
        public static void kilepes()
        {
            visibility = true;
            close = true;
        }

        public static int getID(string tabla, string felH)
        {
            parancs.CommandText = "select ID from " + tabla + " where felhNev like '" + felH + "'";
            return Convert.ToInt32(X.parancs.ExecuteScalar());
        }


        public static void feladatTorles(string megnevez)
        {
            parancs.CommandText = "delete from tasks where megnev like '" + megnevez + "'";
            parancs.ExecuteScalar();

        }

        public static void torlesAlkalmazott(string felH)
        {
            string tabla = "workers";
            int id = getID(tabla, felH);
            parancs.CommandText = "update tasks set workerID = 0 where ID = " + id + "";
            parancs.ExecuteScalar();

            parancs.CommandText = "delete from workers where felhNev like '" + felH + "'";
            parancs.ExecuteScalar();
        }

        public static void torlesAdmin(string felH)
        {
            string tabla = "admins";
            int id = getID(tabla, felH);
            parancs.CommandText = "update tasks set adminId = 0 where id = " + id + "";
            parancs.ExecuteScalar();

            parancs.CommandText = "delete from admins where felhNev like '" + felH + "'";
            parancs.ExecuteScalar();

        }

        public static void login(string felhNev, string tabla, int type)
        {
            parancs.CommandText = "update " + tabla + " set bejelentkezve = '1' where felhNev like '" + felhNev + "' ";
            parancs.ExecuteScalar();
            felhasznalo = felhNev;
            menu m = new menu(type);
            m.Show();
            visibility = false;
            close = false;


        }

        public static void login(string felhNev)
        {
            felhasznalo = felhNev;
            menu m = new menu(2);
            m.Show();
            visibility = false;
            close = false;

        }


        public static string getNev(string s)
        {
            var d = "";

            parancs.CommandText = $"select nev from workers where felhNev like '{s}'";

            if (parancs.ExecuteScalar() == null)
            {
                parancs.CommandText = $"select nev from admins where felhNev like '{s}'";

                if (parancs.ExecuteScalar() == null)
                {
                    return "főnök";
                }
                else
                {
                    d = parancs.ExecuteScalar().ToString();
                    return d.ToString();
                }
            }
            else
            {
                d = parancs.ExecuteScalar().ToString();
                return d.ToString();
            }
        }

        public static bool CheckfelhNev(string felhNev)
        {

            parancs.CommandText = @"SELECT felhNev
                                           from workers WHERE felhNev like '" + felhNev + "'";
            object eddigiek = parancs.ExecuteScalar();

            if (eddigiek == null)
            {
                parancs.CommandText = @"SELECT felhNev
                                           from admins WHERE felhNev like '" + felhNev + "'";
                eddigiek = parancs.ExecuteScalar();
                if (eddigiek == null)
                {
                    parancs.CommandText = @"SELECT felhNev
                                           from boss WHERE felhNev like '" + felhNev + "'";
                    eddigiek = parancs.ExecuteScalar();
                    if (eddigiek == null) return true;
                    else return false;
                }
                else return false;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region órai kódok
        public static DataTable tablacsinal(string sql)
        {
            parancs.CommandText = sql;
            MySqlDataAdapter adapter = new MySqlDataAdapter(parancs);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }


        public static List<string[]> lekerdez(string sql)
        {
            parancs.CommandText = sql;
            eredm = parancs.ExecuteReader();
            List<string[]> li = new List<string[]>();
            int n = eredm.FieldCount;
            while (eredm.Read())
            {
                string[] t = new string[n];
                for (int i = 0; i < n; i++)
                    t[i] = Convert.ToString(eredm[i]);
                li.Add(t);
            }
            eredm.Close();
            return li;
        }

        public static List<string[]> vegrehajt(string sql)
        {
            parancs.CommandText = sql;
            eredm = parancs.ExecuteReader();
            List<string[]> li = new List<string[]>();
            int n = eredm.FieldCount;
            while (eredm.Read())
            {
                string[] t = new string[n];
                for (int i = 0; i < n; i++)
                    t[i] = Convert.ToString(eredm[i]);
                li.Add(t);
            }
            eredm.Close();
            return li;
        }









        #endregion

        #region internetről szedett kódok
        //http://curlybrackets.com/posts/43017/how-to-encrypt-and-decrypt-a-string-in-c-sharp
        public static string Encrypt(string text)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateEncryptor())
                    {
                        byte[] textBytes = UTF8Encoding.UTF8.GetBytes(text);
                        byte[] bytes = transform.TransformFinalBlock(textBytes, 0, textBytes.Length);
                        return Convert.ToBase64String(bytes, 0, bytes.Length);
                    }
                }
            }
        }

        public static string Decrypt(string cipher)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateDecryptor())
                    {
                        byte[] cipherBytes = Convert.FromBase64String(cipher);
                        byte[] bytes = transform.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);
                        return UTF8Encoding.UTF8.GetString(bytes);
                    }
                }
            }
        }
        #endregion


        #region database

        private String SERVER = "localhost";
        private int PORT = 3306;
        private String DBASE = "project_manager";
        private String UID = "root";
        private String PASSWD = "";
        private String connstring;
        public static MySqlConnection conn = new MySqlConnection();  // mysql kapcsolathoz
        public MySqlDataAdapter mysqlAd;                       // "select" sql-hez
        public MySqlDataReader reader;                         // "show" sql-hez
        public DataTable dataTable = new DataTable();          // http://stackoverflow.com/questions/1774498/how-to-iterate-through-a-datatable
        public string info;

        public X()
        {    // konstruktor
            connstring = String.Format("SERVER={0};PORT={1};UID={2};PASSWORD={3}", SERVER, PORT, UID, PASSWD);
        }

        public X(String _dbase, String _uid, String _passwd)
        {  // konstruktor
            connstring = String.Format("SERVER={0};PORT={1};DATABASE={2};UID={3};PASSWORD={4}",
                                 SERVER, PORT, _dbase, _uid, _passwd);
        }

        // -------------------- kapcsolatot létrehoz, megnyit, tesztel ---------------
        private bool mysql_kapcsolat()
        {
            try
            {
                info = "";
                if (!conn.Ping())
                {      // van kapcsolat?
                    conn = new MySqlConnection(connstring);
                }
                if (!conn.State.ToString().ToUpper().Equals("OPEN")) { conn.Open(); parancs = conn.CreateCommand(); }   // ha nincs nyitva, akkor nyisd!
                return true;
            }
            catch (MySqlException ex)
            {
                info = ex.Message + " " + ex.Number.ToString();
                return false;
            }
        }

        public int SQL_reccount(string s)
        {                              // select sql elemszám limit nélkül
            int poz = s.ToLower().IndexOf(" limit ");                           // van bent limit
            if (poz <= 0) { poz = s.Length; }
            s = "select count(*) db from (" + s.Substring(0, poz) + ") tabla";  // levágja a "limit"-et
            MySqlDataAdapter da = new MySqlDataAdapter(s, conn);                // "select" sql-hez
            DataSet DS = new DataSet();
            da.Fill(DS);
            return Int32.Parse(DS.Tables[0].Rows[0]["db"].ToString());
        }

        //------------------------------------- "s" paraméterként kapott sql-t futtat, figyeli az sql típust
        public int SQL_run(String s)
        {
            int i = 0;                                                         // recno
            String parancs = s.Substring(0, s.IndexOf(" ")).ToUpper();         // pl SELECT, UPDATE, INSERT 
            if (reader != null) reader.Close();                                // hátha volt előző állapot
            if (!mysql_kapcsolat()) { return i; }                              // kapcsolat felépítése 
            info += s;
            try
            {
                if (parancs == "SELECT")
                {
                    i = SQL_reccount(s);                                       // rekordszám limit nélkül 
                    mysqlAd = new MySqlDataAdapter(s, conn);
                }
                else
                {
                    MySqlCommand cmd = new MySqlCommand(s, conn);
                    if (parancs == "SHOW") { reader = cmd.ExecuteReader(); }  // SHOW                                                         // show SQL 
                    else { cmd.ExecuteNonQuery(); i = 1; }                    // insert, update, delete SQL
                }
            }
            catch (MySqlException mye) { info += mye.Message + " " + mye.Number.ToString(); }
            return i;
        }

        public static void kapcsolatBont()
        {
            X.conn.Close();
        }



        #endregion

    }
}
