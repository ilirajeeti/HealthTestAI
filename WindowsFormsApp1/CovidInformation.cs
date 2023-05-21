using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CovidInformation : Form
    {
        public CovidInformation()
        {
            InitializeComponent();
        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            var goBack = new Form1();
            goBack.Show();
            this.Hide();
        }

        private void bunifuButton16_Click(object sender, EventArgs e)
        {
            var covidTest = new CovidTest();
            covidTest.Show();
            this.Hide();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sëmundja Coronavirus 2019 (COVID-19) është një sëmundje ngjitëse e shkaktuar nga një virus, sindroma e rëndë akute e frymëmarrjes koronavirus"
                  , "TEST", MessageBoxButtons.OK, MessageBoxIcon.Information
                  );
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rasti i parë i njohur u identifikua në Wuhan, Kinë, në dhjetor 2019.\r\n"
                  , "TEST", MessageBoxButtons.OK, MessageBoxIcon.Information
                  );
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simptomat e COVID-19 janë të ndryshueshme, por shpesh përfshijnë temperaturë,  kollë, dhimbje koke,  lodhje, vështirësi në frymëmarrje, humbje të nuhatjes dhe humbje të shijes.\r\n"
                  , "TEST", MessageBoxButtons.OK, MessageBoxIcon.Information
                  );
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simptomat mund të fillojnë një deri në katërmbëdhjetë ditë pas ekspozimit ndaj virusit"
                  , "TEST", MessageBoxButtons.OK, MessageBoxIcon.Information
                  );
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("COVID-19 transmetohet kur grimcat infektive thithen ose vijnë në kontakt me sytë, hundën ose gojën.\r\n"
                  , "TEST", MessageBoxButtons.OK, MessageBoxIcon.Information
                  );
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Masat parandaluese përfshijnë distancimin fizik ose social, karantinimin, ajrosjen e hapësirave të brendshme, përdorimin e maskave ose mbulesave të fytyrës në publik, mbulimin e kollitjes dhe teshtitjes, larjen e duarve dhe mbajtjen e duarve të palara larg fytyrës.\r\n"
                  , "TEST", MessageBoxButtons.OK, MessageBoxIcon.Information
                  );
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Janë identifikuar tre grupe të zakonshme simptomash: një grup simptomash të frymëmarrjes me kollë, sputum, gulçim dhe ethe; një grup simptomash musculoskeletal me dhimbje muskujsh dhe kyçesh, dhimbje koke dhe lodhje; dhe një grup simptomash të tretjes me dhimbje barku, të vjella dhe diarre.\r\n"
                  , "TEST", MessageBoxButtons.OK, MessageBoxIcon.Information
                  );
        }

        private void bunifuButton9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Varianti Omicron u bë dominant në SHBA në dhjetor 2021"
                  , "TEST", MessageBoxButtons.OK, MessageBoxIcon.Information
                  );
        }

        private void bunifuButton10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Testi zakonisht bëhet në mostrat e frymëmarrjes të marra nga një shtupë nazofaringeale; megjithatë, mund të përdoret gjithashtu një shtupë hundore ose mostër e pështymës.\r\n"
                  , "TEST", MessageBoxButtons.OK, MessageBoxIcon.Information
                  );
        }

        private void bunifuButton11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vaksina e parë për COVID-19 iu dha miratimi rregullator më 2 dhjetor 2020 nga rregullatori i barnave në Mbretërinë e Bashkuar MHRA"
                  , "TEST", MessageBoxButtons.OK, MessageBoxIcon.Information
                  );
        }

        private void bunifuButton12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rreziku i infektimit me COVID-19 rritet veçanërisht në hapësirat ku njerëzit përfshihen në ushtrime fizike ose ngrenë zërin (p.sh., duke ushtruar, duke bërtitur, duke kënduar) pasi kjo rrit nxjerrjen e pikave të frymëmarrjes. Ekspozimi i zgjatur ndaj këtyre kushteve, zakonisht më shumë se 15 minuta, çon në rrezik më të lartë të infeksionit.\r\n"
                  , "TEST", MessageBoxButtons.OK, MessageBoxIcon.Information
                  );
        }

        private void bunifuButton13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Individët mund të aplikojnë metoda të distancimit social duke qëndruar në shtëpi, duke kufizuar udhëtimin, duke shmangur zonat e mbushura me njerëz, duke përdorur përshëndetje pa kontakt dhe duke u distancuar fizikisht nga të tjerët.\r\n"
                  , "TEST", MessageBoxButtons.OK, MessageBoxIcon.Information
                  );
        }

        private void bunifuButton14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sasia e kohës që virusi mund të mbijetojë varet shumë nga lloji i sipërfaqes, temperatura dhe lagështia.\r\n"
                  , "TEST", MessageBoxButtons.OK, MessageBoxIcon.Information
                  );
        }

        private void bunifuButton15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sëmundja mund të marrë një ecuri të lehtë me pak ose aspak simptoma, që i ngjan sëmundjeve të tjera të zakonshme të rrugëve të sipërme të frymëmarrjes, siç është ftohja e zakonshme.\r\n"
                  , "TEST", MessageBoxButtons.OK, MessageBoxIcon.Information
                  );
        }
    }
}
