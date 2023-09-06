namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnClick(object sender, EventArgs e)
        {
            //Application.Exit();

            //szerokosc okna
            int windowWidth = Size.Width;
            //wysokosc okna
            int windowHeigh = Size.Height;
            //Unikamy sytuacji, ze guzik ucieka z ekranu
            windowWidth -= button1.Width;
            windowHeigh -= button1.Height;

            //inicjalizacja generatora liczb losowych
            Random rnd = new Random();
            //losowa odleglosc od lewej
            int randomLeft = rnd.Next(windowWidth);
            //losowa odleglosc od gory
            int randomTop = rnd.Next(windowHeigh);
            //przesuwany guzik
            //location musi byc podana jako punkt na ekranie
            Point topLeftCorner = new Point(randomLeft, randomTop);
            //button1 -> atrybut mojego przycisku :>
            button1.Location = topLeftCorner;
        }
    }
}