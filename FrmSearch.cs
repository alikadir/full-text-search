using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AKBSearch
{

   

    public partial class FrmSearch : Form
    {
        public FrmSearch()
        {
            InitializeComponent();
        }

        private void BtnHedef_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();

            TxtHedef.Text = folderBrowserDialog1.SelectedPath;
        }


        private void BtnAra_Click(object sender, EventArgs e)
        {
            if (TxtHedef.Text != "" && TxtTip.Text != "" && TxtKelime.Text != "")
            {
                

                List<KelimeAramaSonuc> Bulunan = new List<KelimeAramaSonuc>();
                
                DirectoryInfo SiteKlasor = new DirectoryInfo(TxtHedef.Text);

                List<FileInfo> Dosyalar = new List<FileInfo>();

                if (CbxDahil.Checked)
                    Dosyalar.AddRange(SiteKlasor.GetFiles(TxtTip.Text, SearchOption.AllDirectories));
                else
                    Dosyalar.AddRange(SiteKlasor.GetFiles(TxtTip.Text, SearchOption.TopDirectoryOnly));

                progressBar1.Minimum = 1;
                progressBar1.Maximum = Dosyalar.Count+1;
                progressBar1.Step = 1;
                progressBar1.Value = 1;

                foreach (FileInfo item in Dosyalar)
                {
                    


                    int counter = 0;
                    string line;

                    try
                    {
                        StreamReader file = new StreamReader(item.FullName);
                        while ((line = file.ReadLine()) != null)
                        {
                            if (line.Contains(TxtKelime.Text))
                            {

                                Bulunan.Add(new KelimeAramaSonuc()
                                {
                                    DosyaAdi = item.Name,
                                    DosyaYolu = item.FullName,
                                    IndexNo = line.IndexOf(TxtKelime.Text),
                                    Satir = line.TrimStart(),
                                    SatirNo = (counter + 1)
                                });
                            }

                            counter++;
                        }

                        file.Close();
                    }
                    catch
                    { }

                    progressBar1.Value++;
                    Gbx.Text = item.Name;
                    Application.DoEvents();

                }

                dataGridView1.DataSource = Bulunan;
                Gbx.Text = "Arama Sonuçları (" + Bulunan.Count.ToString() + ")";
                Application.DoEvents();

            }
            else
                MessageBox.Show("Tüm alanları doldurun.");
        }

        private void TxtHedef_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            folderBrowserDialog1.ShowDialog();

            TxtHedef.Text = folderBrowserDialog1.SelectedPath;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                if (MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + " açılsın mı?", "Dosya Aç", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        System.Diagnostics.Process.Start(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    }
                    catch { MessageBox.Show("Açılamadı!"); }
                }
            }
        }

     

       
    }
    public class KelimeAramaSonuc
    {
        public string DosyaAdi { get; set; }
        public string DosyaYolu { get; set; }
        public int SatirNo { get; set; }
        public string Satir { get; set; }
        public int IndexNo { get; set; }
    }
}
