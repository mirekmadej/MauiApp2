namespace MauiApp2
{
    class Pytanie
    {
        public string pytanie { get; set; }
        public string o1{ get; set; }
        public string o2{ get; set; }
        public string o3{ get; set; }
        public string o4{ get; set; }
        public string odp { get; set; }
    }
    public partial class MainPage : ContentPage
    {
        private List<Pytanie> pytania = new List<Pytanie>();
        private static int nr = 0;
        public MainPage()
        {
            InitializeComponent();
            wczytajDane();
            
            wypiszPytanie();
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
        }
        private void btnNastepneClicked(object sender, EventArgs e)
        {
            nr++;
            if(nr == pytania.Count - 1) 
                btnNastepne.IsEnabled = false;
            btnPoprzednie.IsEnabled = true;
            wypiszPytanie();

        }
        private void btnWyslijClicked(object sender, EventArgs e)
        {

        }

        private void wczytajDane()
        {
            string odp="";
            string wyczysc(string linia)
            {
                if(linia.Contains("*"))
                {
                    odp = linia.Substring(4);
                    return linia.Substring(4);
                }
                return linia.Substring(3); 
            }

            using (TextReader r = File.OpenText(@"C:\Users\mm\source\repos\MauiApp2\MauiApp2\test.txt"))
            {
                
                string linia = "" ;
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
                    pytania.Add(p1);    
                }

            }
        }
    }

}
