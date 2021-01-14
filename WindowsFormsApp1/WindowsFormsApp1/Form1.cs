using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        const int margines = 20;
        public Form1()
        {
            InitializeComponent();
            this.Left = Screen.PrimaryScreen.Bounds.Left + margines;
            this.Top = Screen.PrimaryScreen.Bounds.Top + margines;
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.75F);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.8F);
            this.StartPosition = FormStartPosition.Manual;
            this.AutoScroll = true;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOblicz_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            if(!PobranieDanychCałki(out float bsXdc, out float bsXgc, out float bsEpsc))
            {
                errorProvider1.SetError(txtWynikCałki, "Niepoprawne dane!");
                return;
            }
            txtEpsc.Enabled = false;
            txtXdc.Enabled = false;
            txtXgc.Enabled = false;
            if (comboBox1.SelectedItem.Equals("Trapezów"))
            {
                float bsCi = CałkaMetodąTrapezów(bsXdc, bsXgc, bsEpsc, out int bsLicznikIteracji);
                txtWynikCałki.Text = string.Format("{0:0.000}", bsCi);
            }
            if (comboBox1.SelectedItem.Equals(""))
            {
                errorProvider1.SetError(txtWynikCałki, "Wybierz metodę całkowania!");
                return;
            }
            if (comboBox1.SelectedItem.Equals("Prostokątów"))
            {
                float bsCi = CałkaMetodąProstokątów(bsXdc, bsXgc, bsEpsc, out int bsLicznikIteracji, out float LicznikPrzedziałów);
                txtWynikCałki.Text = string.Format("{0:0.000}", bsCi);
            }
            else
            {
                errorProvider1.SetError(txtWynikCałki, "Niespodziewany błąd!!!");
            }

        }



        private void txtXd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtXg_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void txtEps_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!PobranieDanych(out float bsXd, out float bsXg, out float bsH, out float bsEps))
            {
                errorProvider1.SetError(btnWizualizacja, "Wystąpił błąd podczas pobierania danych wejściowych.");
                return;
            }
            float[,] Tablica;
            Tabela(out Tablica);
            dgvTabela.Visible = false;
            lblWizualizacjaTabelaryczna.Visible = true;
            lblWizualizacjaTabelaryczna.Text = "Graficzna Wizualizacja Funkcji F(x)";
            chtGraficzna.Visible = true;
            chtGraficzna.Titles.Add("Wykres Wartości F(x)");
            chtGraficzna.Series.Clear();
            chtGraficzna.Series.Add("Wartość F(x)");
            chtGraficzna.ChartAreas[0].AxisX.Title = "Wartość X";
            chtGraficzna.ChartAreas[0].AxisY.Title = "Wartość F(x)";
            chtGraficzna.Series[0].IsVisibleInLegend = true;
            chtGraficzna.Legends.FindByName("Legend1").Docking = Docking.Bottom;
            chtGraficzna.Series[0].Name = "Wykres F(x)";
            chtGraficzna.Series[ 0].ChartType = SeriesChartType.FastLine;
            chtGraficzna.Series[0].Color = Color.LightSeaGreen;
            chtGraficzna.Series[0].BorderDashStyle = ChartDashStyle.Dash;
            chtGraficzna.Series[0].BorderWidth = 2;
            for (int i = 0; i < Tablica.GetLength(0); i++)
            {
                chtGraficzna.Series[0].Points.AddXY(string.Format("{0:0.000}", Tablica[i, 0]), string.Format("{0:0.000}", Tablica[i, 1]));
            }
            txtEps.Enabled = false;
            txtX.Enabled = false;
            txtXd.Enabled = false;
            txtXg.Enabled = false;
            txtH.Enabled = false;
            btnGraficzna.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEpsc.Text = null;
            txtEps.Text = null;
            txtXd.Text = null;
            txtXdc.Text = null;
            txtXg.Text = null;
            txtXgc.Text = null;
            txtX.Text = null;
            txtH.Text = null;
            txtWynikCałki.Text = null;
            txtWynikSzeregu.Text = null;
            txtEpsc.Enabled = true;
            txtXdc.Enabled = true;
            txtXgc.Enabled = true;
            txtEps.Enabled = true;
            txtXd.Enabled = true;
            txtXg.Enabled = true;
            txtH.Enabled = true;
            txtX.Enabled = true;
            btnGraficzna.Enabled = true;
            btnWizualizacja.Enabled = true;
        }
        void Tabela(out float[,] Tablica)
        {
            PobranieDanych(out float bsXd, out float bsXg, out float bsH, out float bsEps);
            
            float n = ((bsXg - bsXd) / bsH);
            Tablica = new float[(int)n + 1, 2];
            for (int i = 0; i < Tablica.GetLength(0); i++)
            {
                
                
                    Tablica[i, 0] = bsXd + bsH * i;
                    Tablica[i, 1] = SumaSzeregu(bsXd+ bsH * i, bsEps);
                
            }

        }
        static float SumaSzeregu(float bsX, float bsEps)
        {
            float bsW, bsSumaWyrazów;
            int bsN;
            bsSumaWyrazów = 0.0F;// USTALENIE POCZĄTKOWYCH WARTOŚCI 
            bsW = 1.0F;
            bsN = 0;
            do // WYZNACZENIE SUMY ZA POMOCĄ WZORU ITERACJYJNEGO
            {
                bsSumaWyrazów = bsSumaWyrazów + bsW;
                bsN++;
                bsW = bsW * (((bsX - 2.0F) * (2 * bsN - 2.0F)) + (bsX - 2.0F)) / ((2.0F * bsN) + 1);
            } while (Math.Abs(bsW) > bsEps); // WARUNEK WYJSCIOWY
            return bsSumaWyrazów;

        }
        static float CałkaMetodąTrapezów(float bsD, float bsG, float bsEps, out int LicznikIteracji)
        {
            float bsH, bsCi, bsCi_1, bsSumaFx;
            bsH = bsG - bsD;
            float bsSumaFaFb = SumaSzeregu(bsD, bsEps) + SumaSzeregu(bsG, bsEps);
            bsCi = bsH * bsSumaFaFb;
            LicznikIteracji = 1;
            do
            {
                bsCi_1 = bsCi;
                LicznikIteracji++;
                bsH = (bsG - bsD) / LicznikIteracji;
                bsSumaFx = 0.0F;
                for (int j = 1; j < LicznikIteracji; j++)
                {
                    bsSumaFx = bsSumaFx + SumaSzeregu(bsD + j * bsH, bsEps);
                }
                bsCi = bsH * (bsSumaFaFb + bsSumaFx);
            } while (Math.Abs(bsCi - bsCi_1) > bsEps);
            return bsCi;

        }
        static float CałkaMetodąProstokątów(float bsA, float bsB, float Eps, out int LicznikIteracji, out float LicznikPrzedziałów)
        {
            float bsH, bsCi, bsCi_1, bsSumaFx, bsX;
            LicznikIteracji = 1;
            LicznikPrzedziałów = 1;
            bsCi = (bsB - bsA) * SumaSzeregu((bsA + bsB) / 2.0F, Eps);
            do
            {
                bsCi_1 = bsCi;
                LicznikIteracji++;
                LicznikPrzedziałów += LicznikPrzedziałów;
                bsH = (bsB - bsA) / LicznikPrzedziałów;
                bsX = bsA + bsH / 2.0F;
                bsSumaFx = 0.0F;
                for (int j = 0; j < LicznikPrzedziałów; j++)
                bsSumaFx = bsSumaFx + SumaSzeregu(bsX + j*bsH, Eps);
                bsCi = bsH * bsSumaFx;

            } while (Math.Abs(bsCi - bsCi_1) > Eps);
            return bsCi;

        }
        bool PobranieDanych(out float bsXd, out float bsXg, out float bsH, out float bsEps)
        {
            errorProvider1.Dispose();
            bsXd = bsXg = bsEps = bsH = 0.0F;
            
            if (!float.TryParse(txtXd.Text, out bsXd))
            {
                errorProvider1.SetError(txtXd, "Niepoprawna wartość!!!");
                return false;
            }
            if ((bsXd < 1.0F) || (bsXd >= 3.0F))
            {
                errorProvider1.SetError(txtXd, "Podałeś granicę spoza przedziału <1;3).");
                return false;
            }
            if (!float.TryParse(txtXg.Text, out bsXg))
            {
                errorProvider1.SetError(txtXg, "Niepoprawna wartość!!!");
                return false;
            }
            if ((bsXg < 1.0F) || (bsXg >= 3.0F))
            {
                errorProvider1.SetError(txtXg, "Podałeś granicę spoza przedziału <1;3).");
                return false;
            }
            if (!float.TryParse(txtEps.Text, out bsEps))
            {
                errorProvider1.SetError(txtEps, "Niepoprawna wartość!!!");
                return false;
            }
            if ((bsEps >= 1.0F) || (bsEps <= 0.0F))
            {
                errorProvider1.SetError(txtEps, "Podałeś Eps spoza przedziału (0;1).");
                return false;
            }
            if (!float.TryParse(txtH.Text, out bsH))
            {
                errorProvider1.SetError(txtH, "Niepoprawna wartość!!!");
                return false;
            }
            if (bsH > bsXg - bsXd)
            {
                errorProvider1.SetError(txtH, $"Zmienna H musi być większa niż {(bsXg - bsXd) / 2}");
                return false;
            }
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!PobranieDanych(out float bsXd, out float bsXg, out float bsH, out float bsEps))
            {
                errorProvider1.SetError(btnWizualizacja, "Wystąpił błąd podczas pobierania danych wejściowych.");
                return;
            }
            float[,] Tablica;
            Tabela(out Tablica);
            lblWizualizacjaTabelaryczna.Visible = true;
            chtGraficzna.Visible = false;
            dgvTabela.Visible = true;
            lblWizualizacjaTabelaryczna.Text = "Wizualizacja Tabelaryczna";
            dgvTabela.Rows.Clear();
            dgvTabela.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            for (int i = 0; i < Tablica.GetLength(0); i++)
            {
                dgvTabela.Rows.Add();
                dgvTabela.Rows[i].Cells[0].Value = string.Format("{0:0.000}", Tablica[i, 0]);
                dgvTabela.Rows[i].Cells[1].Value = string.Format("{0:0.000}", Tablica[i, 1]);
                if((i%2) == 0)
                {
                    dgvTabela.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    dgvTabela.Rows[i].DefaultCellStyle.BackColor = Color.LightCyan;
                }
            }
            txtEps.Enabled = false;
            txtX.Enabled = false;
            txtXd.Enabled = false;
            txtXg.Enabled = false;
            txtH.Enabled = false;
            btnWizualizacja.Enabled = false;
        }

        private void zmianaKoloruFormularzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = this.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                this.BackColor = colorDialog1.Color;
        }

        private void czcionkaFormularzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = this.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Font = fontDialog1.Font;
                foreach (Control KontrolkaFormularza in this.Controls)
                    KontrolkaFormularza.Font = fontDialog1.Font;
            }    
        }

        private void liniaKropkowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void kolorLiniiWykresuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //colorDialog1.Color = chtcostam.Series[0].Color;
           // if (colorDialog1:ShowDialog() == DialogResult.OK)
             //   cht.... = 
        }
        bool PobranieDanychCałki(out float bsXdc, out float bsXgc, out float bsEpsc)
        {
            errorProvider1.Dispose();
            bsXdc = bsXgc = bsEpsc = 0.0F;
            
            if (!float.TryParse(txtXdc.Text, out bsXdc))
            {
                errorProvider1.SetError(txtXdc, "Niepoprawna wartość!!!");
                return false;
            }
            if ((bsXdc < 1.0F) || (bsXdc >= 3.0F))
            {
                errorProvider1.SetError(txtXdc, "Podałeś granicę spoza przedziału <1;3).");
                return false;
            }
            if (!float.TryParse(txtXgc.Text, out bsXgc))
            {
                errorProvider1.SetError(txtXgc, "Niepoprawna wartość!!!");
                return false;
            }
            if ((bsXgc < 1.0F) || (bsXgc >= 3.0F))
            {
                errorProvider1.SetError(txtXgc, "Podałeś granicę spoza przedziału <1;3).");
                return false;
            }
            if (!float.TryParse(txtEpsc.Text, out bsEpsc))
            {
                errorProvider1.SetError(txtEpsc, "Niepoprawna wartość!!!");
                return false;
            }
            if ((bsEpsc >= 1.0F) || (bsEpsc <= 0.0F))
            {
                errorProvider1.SetError(txtEpsc, "Podałeś Eps spoza przedziału (0;1).");
                return false;
            }
            if (bsXgc <= bsXdc)
            {
                errorProvider1.SetError(txtH, $"Górna granica musi być większa od dolnej granicy");
                return false;
            }
            return true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            float bsX = 0.0F;
            float bsEps = 0.0F;
            if (!float.TryParse(txtX.Text, out bsX))
            {
                errorProvider1.SetError(txtX, "Niepoprawna wartość!!!");
                return;
            }
            if ((bsX < 1.0F) || (bsX >= 3.0F))
            {
                errorProvider1.SetError(txtX, "Podałeś X spoza przedziału <1;3).");
                return;
            }
            if (!float.TryParse(txtEps.Text, out bsEps))
            {
                errorProvider1.SetError(txtEps, "Niepoprawna wartość!!!");
                return;
            }
            if ((bsEps >= 1.0F) || (bsEps <= 0.0F))
            {
                errorProvider1.SetError(txtEps, "Podałeś Eps spoza przedziału (0;1).");
                return;
            }
            txtEps.Enabled = false;
            txtXd.Enabled = false;
            txtXg.Enabled = false;
            txtH.Enabled = false;
            txtX.Enabled = false;

            float Suma =  SumaSzeregu(bsX,bsEps);
            txtWynikSzeregu.Text = string.Format("{0:0.000}", Suma);
        }
    }
}
