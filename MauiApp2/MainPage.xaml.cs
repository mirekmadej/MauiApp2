using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SQLite;

namespace MauiApp2
{
    class Pytanie
    {
        public int id { get; set; }
        public string pytanie { get; set; }
        public string o1{ get; set; }
        public string o2{ get; set; }
        public string o3{ get; set; }
        public string o4{ get; set; }
        public string odp { get; set; }
        public string zaznOdp { get; set; }
    }
    public partial class MainPage : ContentPage
    {
        private List<Pytanie> pytania = new List<Pytanie>();
        private List<Pytanie> pytaniaWszystkie = new List<Pytanie>();
        private static int nr = 0;
        private static int ilePytan = 0;
        private static int ileLosowac = 5;
        public MainPage()
        {
            InitializeComponent();
            //wczytajDanePlik();

            //wczytajDaneSQL();

            dodajDaneSqlite();

            wczytajDaneSQLite();

            //zapiszDoBazy();

            wylosujPytania();
            wypiszPytanie();
        }
        private void wczytajDaneSQLite()
        {
            string connStr = "DataSource=baza.db";
            SQLiteConnection conn = new SQLiteConnection(connStr);
            conn.Open();
            string zapytanie = "SELECT * FROM testy";
            SQLiteCommand command = conn.CreateCommand();
            command.CommandText = zapytanie;
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Pytanie p = new Pytanie();
                p.id = reader.GetInt32(0);
                p.pytanie = reader.GetString(1);
                p.o1 = reader.GetString(1);
                p.o2 = reader.GetString(2);
                p.o3 = reader.GetString(3);
                p.o4 = reader.GetString(4);
                p.odp = reader.GetString(5);
                p.zaznOdp = "";
                pytaniaWszystkie.Add(p);

            } 
            conn.Close();    
        }
        private void dodajDaneSqlite()
        {
            string connStr = "DataSource=baza.db";
            SQLiteConnection conn = new SQLiteConnection(connStr);
            conn.Open();
            SQLiteCommand comm = conn.CreateCommand();

            string qUsun = "DROP TABLE IF EXISTS testy";
            comm.CommandText = qUsun;
            comm.ExecuteNonQuery();
            
            string qTworzenieTabeli = "CREATE TABLE IF NOT EXISTS testy " +
                "   (id INT NOT NULL , " +
                "   pytanie VARCHAR(250) NOT NULL , " +
                "   o1 VARCHAR(250) NOT NULL , " +
                "   o2 VARCHAR(250) NOT NULL , " +
                "   o3 VARCHAR(250) NOT NULL , " +
                "   o4 VARCHAR(250) NOT NULL , " +
                "   op VARCHAR(250) NOT NULL , " +
                "   PRIMARY KEY (id));";
            
            comm.CommandText = qTworzenieTabeli;
            comm.ExecuteNonQuery();
            
            string q2 = "INSERT INTO testy (id, pytanie, o1, o2, o3, o4, op) " +
                "VALUES(1, 'pytanie', 'o1', 'o2', 'o3', 'o4', 'op')," +
                "(2, 'System operacyjny nie zajmuje się ', 'dostarczaniem mechanizmów do synchronizacji zadań i komunikacji pomiędzy zadaniami. ', 'planowaniem oraz przydziałem czasu procesora poszczególnym zadaniom. ', 'kontrolą i przydziałem pamięci operacyjnej dla uruchomionych zadań. ', 'tworzeniem źródeł aplikacji systemowych.', 'tworzeniem źródeł aplikacji systemowych.')," +
                "(3, 'Podstawową funkcją serwera FTP jest ', 'monitoring sieci. ', 'synchronizacja czasu. ', 'udostępnianie plików. ', 'zarządzanie kontami poczty. ', 'udostępnianie plików. ')," +
                "(4, 'Do cech pojedynczego konta użytkownika pracującego w systemie Windows Serwer należy ', 'numer telefonu, pod który ma oddzwonić serwer w przypadku nawiązania połączenia telefonicznego przez tego użytkownika. ', 'maksymalna wielkość pojedynczego pliku jaki użytkownik może zapisać na dysku serwera. ', 'maksymalna wielkość pulpitu użytkownika  ', 'maksymalna wielkość profilu użytkownika.', 'numer telefonu, pod który ma oddzwonić serwer w przypadku nawiązania połączenia telefonicznego przez tego użytkownika. ')," +
                "(5, 'Który z protokołów jest protokołem synchronizacji czasu? ', 'FTP ', 'NTP ', 'HTTP ', 'NNTP', 'NTP ')," +
                "(6, 'Litera S w protokole FTPS oznacza zabezpieczanie przesyłanych danych poprzez ', 'logowanie. ', 'autoryzację. ', 'szyfrowanie. ', 'uwierzytelnianie. ', 'szyfrowanie. ')," +
                "(7, 'Który z protokołów jest protoko?em wykorzystywanym do zarz?dzania urz?dzeniami sieciowymi? ', 'SMTP ', 'SNMP ', 'SFTP ', 'DNS ', 'SNMP ')," +
                "(8, 'Translacj? nazw domenowych na adresy sieciowe zajmuje się usługa ', 'DNS ', 'DHCP ', 'SMTP ', 'SNMP', 'DNS ')," +
                "(9, 'Który z protokołów jest szyfrowanym protokołem terminalowym? ', 'SSH ', 'TFTP ', 'telnet ', 'POP3', 'SSH ')," +
                "(10, 'Który protokó?ł obsługuje rozproszone wysyłanie i pobieranie plików? ', 'FTP ', 'Radius ', 'HTTPS ', 'BitTorrent', 'BitTorrent')," +
                "(11, ' AES (ang. Advanced Encryption Standard) ', 'jest poprzednikiem DES (ang. Data Encryption Standard). ', 'nie może być wykorzystany przy szyfrowaniu plików. ', 'wykorzystuje symetryczny algorytm szyfrujący. ', 'nie może być zaimplementowany sprzętowo.', 'wykorzystuje symetryczny algorytm szyfruj?cy. ');";
            comm.CommandText = q2;
            comm.ExecuteNonQuery();
            
            conn.Close();    
        }
        private void wczytajDaneSQL()
        {
            string connStr = "server=localhost;user=root;database=test;port=3306;password=";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string query = $"SELECT * FROM testy";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Pytanie p = new Pytanie();
                p.id = reader.GetInt32(0);
                p.pytanie = reader.GetString(1);
                p.o1 = reader.GetString(2);
                p.o2 = reader.GetString(3);
                p.o3 = reader.GetString(4);
                p.o4 = reader.GetString(5);
                p.odp = reader.GetString(6);
                p.zaznOdp = "";

                pytaniaWszystkie.Add(p);
            }
            conn.Close();
        }
        private void zapiszDoBazy()
        {
            //CREATE TABLE test.testy (id INT NOT NULL AUTO_INCREMENT , pytanie VARCHAR(250) NOT NULL , o1 VARCHAR(250) NOT NULL , o2 VARCHAR(250) NOT NULL , o3 VARCHAR(250) NOT NULL , o4 VARCHAR(250) NOT NULL , op VARCHAR(250) NOT NULL , PRIMARY KEY (id));
            // INSERT INTO testy (pytanie, o1, o2, o3, o4, op)
            //    VALUES("pytanie", "o1", "o2", "o3", "o4", "op");
            string connStr = "server=localhost;user=root;database=test;port3306;password=";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            foreach (var pytanie in pytania)
            {
                string query = "INSERT INTO testy (pytanie, o1, o2, o3, o4, op) VALUES(";
                query += "\"" + pytanie.pytanie + "\", ";
                query += "\"" + pytanie.o1 + "\", ";
                query += "\"" + pytanie.o2 + "\", ";
                query += "\"" + pytanie.o3 + "\", ";
                query += "\"" + pytanie.o4 + "\", ";
                query += "\"" + pytanie.odp + "\" ";
                query += ");";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }

            conn.Close();
        }
        private void wylosujPytania()
        {
            Random r = new Random();
            for (int i = 0; i < ileLosowac; i++)
            {
                int n = r.Next(0, pytaniaWszystkie.Count);
                pytania.Add(pytaniaWszystkie[n]);
                pytaniaWszystkie.RemoveAt(n);
            }
        }

        private void zmianaRB(object sender, EventArgs e)
        {
            if (pytania[nr].zaznOdp == "")
            {
                ilePytan++;
                pytania[nr].zaznOdp = "    ";
            }

            zapiszOdpowiedz();

            if (ilePytan == pytania.Count)
                btnWyslij.IsEnabled = true;
        }

        private void wypiszPytanie()
        {
            lblPytanie.Text = pytania[nr].pytanie;
            rnO1.Content = pytania[nr].o1;
            rnO2.Content = pytania[nr].o2;
            rnO3.Content = pytania[nr].o3;
            rnO4.Content = pytania[nr].o4;
        }

        private void btnPoprzednieClicked(object sender, EventArgs e)
        {


            nr--;
            if (nr == 0)
                btnPoprzednie.IsEnabled = false;
            btnNastepne.IsEnabled = true;

            wypiszPytanie();

            ustawCheckboxy();
        }


        private void btnNastepneClicked(object sender, EventArgs e)
        {


            nr++;
            if (nr == pytania.Count - 1)
                btnNastepne.IsEnabled = false;
            btnPoprzednie.IsEnabled = true;
            wypiszPytanie();

            ustawCheckboxy();

        }

        private void ustawCheckboxy()
        {
            rnO1.IsChecked = false;
            if (pytania[nr].o1 == pytania[nr].zaznOdp)
                rnO1.IsChecked = true;
            rnO2.IsChecked = false;
            if (pytania[nr].o2 == pytania[nr].zaznOdp)
                rnO2.IsChecked = true;
            rnO3.IsChecked = false;
            if (pytania[nr].o3 == pytania[nr].zaznOdp)
                rnO3.IsChecked = true;
            rnO4.IsChecked = false;
            if (pytania[nr].o4 == pytania[nr].zaznOdp)
                rnO4.IsChecked = true;
        }

        private void zapiszOdpowiedz()
        {
            if (rnO1.IsChecked)
                pytania[nr].zaznOdp = pytania[nr].o1;
            if (rnO2.IsChecked)
                pytania[nr].zaznOdp = pytania[nr].o2;
            if (rnO3.IsChecked)
                pytania[nr].zaznOdp = pytania[nr].o3;
            if (rnO4.IsChecked)
                pytania[nr].zaznOdp = pytania[nr].o4;
        }
        private void btnWyslijClicked(object sender, EventArgs e)
        {
            int punkty = 0;
            foreach (var el in pytania)
                if (el.odp == el.zaznOdp)
                    punkty++;
            lblWynik.Text = $"dobrych odpowiedzi: {punkty}";
            btnNastepne.IsEnabled = false;
            btnPoprzednie.IsEnabled = false;
            btnWyslij.IsEnabled = false;
        }
        private void wczytajDanePlik()
        {
            string odp = "";
            string wyczysc(string linia)
            {
                if (linia.Contains("*"))
                {
                    odp = linia.Substring(4);
                    return linia.Substring(4);
                }
                return linia.Substring(3);
            }

            using (TextReader r = File.OpenText(@"C:\Users\mm\source\repos\MauiApp2\MauiApp2\test.txt"))
            {
                string linia = "";
                while (true)
                {
                    Pytanie p1 = new Pytanie();
                    linia = r.ReadLine();
                    if (string.IsNullOrEmpty(linia))
                        break;
                    p1.pytanie = wyczysc(linia);
                    p1.o1 = wyczysc(r.ReadLine());
                    p1.o2 = wyczysc(r.ReadLine());
                    p1.o3 = wyczysc(r.ReadLine());
                    p1.o4 = wyczysc(r.ReadLine());
                    p1.odp = odp;
                    p1.zaznOdp = "";
                    pytaniaWszystkie.Add(p1);
                }

            }
        }
    }
}
