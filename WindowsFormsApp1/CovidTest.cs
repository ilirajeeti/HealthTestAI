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
    public partial class CovidTest : Form
    {
        public CovidTest()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (bunifuCheckBox1.Checked && bunifuCheckBox2.Checked && bunifuCheckBox3.Checked)
            {
                MessageBox.Show("Ne baz te ketyre selektimeve ju mund te keni: "
                    + "\n" + "\n"
                    + "1. Gripa: eshte nje infeksion viral i shpeshte qe shkakton simptomat si kollitje,lodhje dhe dhimbje koke. " + "\n" +
                    "2. Sinuzit: Sinuziti eshte inflamacioni i sinuseve, qe mund te shoqerohet me simptomat si kollitje,lodhje dhe dhimbje koke." + "\n" +
                    "3. Migrena: Migrena eshte nje lloj dhimbeje koke intense dhe e vazhdueshme, e shoqeruar shpesh me kollitje dhe lodhje." + "\n" +
                    "\n" +
                    "Une jam nje intelegjenc artificiale e dizajnuar nga Ilir Ajeti me udhezimet e Dr.Msc.Pr Shpetim Latifi andaj keto rezultate jane vetem supozime, mirpo per qeshtje sigurie kontaktoni mjekun."
                    , "TEST", MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                
                    bunifuCheckBox1.Checked = false;
                    bunifuCheckBox2.Checked = false;
                    bunifuCheckBox3.Checked = false;
                
            }
            else if (bunifuCheckBox2.Checked && bunifuCheckBox4.Checked && bunifuCheckBox6.Checked)
            {
                MessageBox.Show("Ne baz te ketyre selektimeve ju mund te keni: "
                   + "\n" + "\n"
                   + "1. Infeksion urinar: Infeksioni urinar shpesh shoqerohet me simptoma si lodhje, dhimbje stomaku dhe probleme me traktin urinar " + "\n" +
                   "2. Sindrome e zorreve te irrituar (IBS): IBS eshte nje kusht kronik i traktit te poshtem gastrointestinal, i cili mund te shoqerohet me lodhje, dhimbje stomaku dhe probleme me traktin urinar." + "\n" +
                   "3. Anemia: Anemia eshte nje gjendje kur ka nje nivel te ulet te hemoglobines ne gjak, e cila mnd te shoqerohet me lodhje dhe ndjesi te dobet." + "\n" +
                   "\n" +
                   "Une jam nje intelegjenc artificiale e dizajnuar nga Ilir Ajeti me udhezimet e Dr.Msc.Pr Shpetim Latifi andaj keto rezultate jane vetem supozime, mirpo per qeshtje sigurie kontaktoni mjekun."
                   , "TEST", MessageBoxButtons.OK, MessageBoxIcon.Information
                   );
            }
            else if (bunifuCheckBox1.Checked && bunifuCheckBox2.Checked && bunifuCheckBox8.Checked)
            {
                MessageBox.Show("Ne baz te ketyre selektimeve ju mund te keni: "
                   + "\n" + "\n"
                   + "1. COVID-19: Kombinimi i ketyre simptomave eshte i ngjashem me shenjat e zakonshme te COVID-19. Kollitja, lodhja dhe temperatura e larte jane simptoma te zakonshme te infeksionit me koronavirusit SARS CoV-2, qe shkakton COVID-19. " + "\n" +
                   "2. Gripi: Gripi eshte nje infeksion viral i speshte qe shkakton simptoma te ngjashme me COVID-19, si kollitje, lodhje dhe temperatua e larte." + "\n" +
                   "3. Infeksion tjeter viral ose bakterial: Gripi sezonal, mononukleoza, pneumoni, etj." + "\n" +
                   "\n" +
                   "Une jam nje intelegjenc artificiale e dizajnuar nga Ilir Ajeti me udhezimet e Dr.Msc.Pr Shpetim Latifi andaj keto rezultate jane vetem supozime, mirpo per qeshtje sigurie kontaktoni mjekun."
                   , "TEST", MessageBoxButtons.OK, MessageBoxIcon.Information
                   );
            }
            else if (bunifuCheckBox1.Checked && bunifuCheckBox2.Checked && bunifuCheckBox3.Checked && bunifuCheckBox8.Checked)
            {
                MessageBox.Show("Ne baz te ketyre selektimeve ju mund te keni: "
                   + "\n" + "\n"
                   + "1. COVID-19: Kombinimi i ketyre simptomave eshte i ngjashem me shenjat e zakonshme te COVID-19. Kollitja, lodhja dhe temperatura e larte jane simptoma te zakonshme te infeksionit me koronavirusit SARS CoV-2, qe shkakton COVID-19. " + "\n" +
                   "2. Gripi: Gripi eshte nje infeksion viral i speshte qe shkakton simptoma te ngjashme me COVID-19, si kollitje, lodhje dhe temperatua e larte." + "\n" +
                   "3. Infeksion respiratore tetjera: Kombinimi i simptomave mund te lidhet edhe me infeksione respiratore te tjera si riniti viral, sinuziti etk." + "\n" +
                   "\n" +
                   "Une jam nje intelegjenc artificiale e dizajnuar nga Ilir Ajeti me udhezimet e Dr.Msc.Pr Shpetim Latifi andaj keto rezultate jane vetem supozime, mirpo per qeshtje sigurie kontaktoni mjekun."
                   , "TEST", MessageBoxButtons.OK, MessageBoxIcon.Information
                   );
            }
            else if (bunifuCheckBox7.Checked && bunifuCheckBox5.Checked && bunifuCheckBox3.Checked)
            {
                MessageBox.Show("Ne baz te ketyre selektimeve ju mund te keni: "
                   + "\n" + "\n"
                   + "1. COVID-19: Kombinimi i ketyre simptomave eshte i ngjashem me shenjat e zakonshme te COVID-19. Kollitja, lodhja dhe temperatura e larte jane simptoma te zakonshme te infeksionit me koronavirusit SARS CoV-2, qe shkakton COVID-19. " + "\n" +
                   "2. Influenza:  Simptomat e zgjedhura gjithashtu mund te jene shenja te infeksionit te gripit, i cili shkakton veshtersi ne frymarje, dhimbje koke dhe dhimbje te muskujve." + "\n" +
                   "3. Infeksion viral i zakonshem: rhinovirusi qe shkakton ethe, adenovirusi qe  shkakton infeksion te melqise dhe te traktit respirator." + "\n" +
                   "\n" +
                   "Une jam nje intelegjenc artificiale e dizajnuar nga Ilir Ajeti me udhezimet e Dr.Msc.Pr Shpetim Latifi andaj keto rezultate jane vetem supozime, mirpo per qeshtje sigurie kontaktoni mjekun."
                   , "TEST", MessageBoxButtons.OK, MessageBoxIcon.Information
                   );
            }
            else if (bunifuCheckBox3.Checked && bunifuCheckBox4.Checked && bunifuCheckBox7.Checked)
            {
                MessageBox.Show("Ne baz te ketyre selektimeve ju mund te keni: "
                   + "\n" + "\n"
                   + "1. Migrena: Dhimbja e kokes mund te jet shenje e migrenes, nje lloj kokeqari i dhimbshme qe shkakton dhimbje te renda te kokes, ndonjeher me simptoma shtese si ndjeshmeria ndaj drites dhe zhurmes" + "\n" +
                   "2. Gastrit: Dhimbja e stomakut mund te jete shenje e gastritit, inflamacionit te murit te stomakut qe shkakton dhimbje,ndjesi te fytit dhe probleme te tjera stomakore." + "\n" +
                   "3. Astma: Veshtersia ne frymarrje mund te jete shenje e astmes,nje semundje te rrugeve ajrore qe shkakton veshtersi te frymarrjes dhe probleme te tjera te frymarrjes." + "\n" +
                   "\n" +
                   "Une jam nje intelegjenc artificiale e dizajnuar nga Ilir Ajeti me udhezimet e Dr.Msc.Pr Shpetim Latifi andaj keto rezultate jane vetem supozime, mirpo per qeshtje sigurie kontaktoni mjekun."
                   , "TEST", MessageBoxButtons.OK, MessageBoxIcon.Information
                   );
            }
            else if (bunifuCheckBox6.Checked && bunifuCheckBox7.Checked && bunifuCheckBox8.Checked)
            {
                MessageBox.Show("Ne baz te ketyre selektimeve ju mund te keni: "
                   + "\n" + "\n"
                   + "1. Infeksionet urinare: Problemet me traktin urinar, si ndjesia e djegies gjatë urinimit, shpeshim i urinimit dhe ndryshime në ngjyrën e urinës, mund të jenë shenja të infeksioneve urinare, si cistiti (infeksioni i mushkërive të urinës) ose pielonefriti (infeksioni i mushkërive të mëlçisë)." + "\n" +
                   "2. Astma: Veshtersia në frymarrje mund të jetë shenjë e astmës, një sëmundje e rrugëve ajrore që shkakton veshtersi të frymëmarrjes dhe probleme të tjera të frymëmarrjes." + "\n" +
                   "3. Infeksion viral: Temperatura e lartë mund të jetë shenjë e infeksioneve virale të shumta, përfshirë gripin, mononukleozën dhe infeksionet e virusit të hepatititit." + "\n" +
                   "\n" +
                   "Une jam nje intelegjenc artificiale e dizajnuar nga Ilir Ajeti me udhezimet e Dr.Msc.Pr Shpetim Latifi andaj keto rezultate jane vetem supozime, mirpo per qeshtje sigurie kontaktoni mjekun."
                   , "TEST", MessageBoxButtons.OK, MessageBoxIcon.Information
                   );
            }

            else if (bunifuCheckBox1.Checked && bunifuCheckBox6.Checked && bunifuCheckBox7.Checked && bunifuCheckBox3.Checked)
            {
                MessageBox.Show("Ne baz te ketyre selektimeve ju mund te keni: "
                   + "\n" + "\n"
                   + "1. Infeksionet urinare: Problemet me traktin urinar, si ndjesia e djegies gjatë urinimit, shpeshim i urinimit dhe ndryshime në ngjyrën e urinës, mund të jenë shenja të infeksioneve urinare, si cistiti (infeksioni i mushkërive të urinës) ose pielonefriti (infeksioni i mushkërive të mëlçisë)." + "\n" +
                   "2. Astma: Veshtersia në frymarrje mund të jetë shenjë e astmës, një sëmundje e rrugëve ajrore që shkakton veshtersi të frymëmarrjes dhe probleme të tjera të frymëmarrjes." + "\n" +
                   "3. Migrenat: Kollitja dhe dhimbja e kokes mund të jenë simptoma të migrenave, një lloj kokeçari tërheqës dhe të dhimbshëm." + "\n" +
                   "\n" +
                   "Une jam nje intelegjenc artificiale e dizajnuar nga Ilir Ajeti me udhezimet e Dr.Msc.Pr Shpetim Latifi andaj keto rezultate jane vetem supozime, mirpo per qeshtje sigurie kontaktoni mjekun."
                   , "TEST", MessageBoxButtons.OK, MessageBoxIcon.Information
                   );
            }
        }
    }
}
