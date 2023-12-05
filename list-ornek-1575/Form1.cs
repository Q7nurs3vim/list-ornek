using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_ornek_1575
{
    public partial class Form1 : Form
    {
        List<string> kisiler = new List<string>();
        int indexSira = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisiler.Add("Riato");
            kisiler.Add("Mshel");
            kisiler.Add("Sanchez");

            lbKisiler.DataSource = kisiler.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
           kisiler.Add(txtKisiler.Text);

          lbKisiler.DataSource=kisiler.ToList();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            bool durum = kisiler.Contains(txtKisiler.Text);
            if (durum)
            {
                MessageBox.Show("ARADIĞINIZ KİŞİ MEVCUT ");
            }
            else
            {
                MessageBox.Show("ARADIĞINIZ KİŞİ MEVCUT DEĞİL");
            }
        }

        private void btnSira_Click(object sender, EventArgs e)
        {
            int sira = kisiler.IndexOf(txtKisiler.Text);
            if(sira > -1)
            {
                MessageBox.Show(txtKisiler.Text + "" + sira + ". Sırasındadır.");
            }
            else
            {
                MessageBox.Show(txtKisiler.Text+"Aradığınız kişi yoktur");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int sira = kisiler.IndexOf(txtKisiler.Text);
            if (sira > -1)
            {
                kisiler.RemoveAt(sira);

            }
            lbKisiler.DataSource = kisiler.ToList();
        }

        private void btnSilRemove_Click(object sender, EventArgs e)
        {
            bool durum = kisiler.Contains(txtKisiler.Text);
            if (durum)
            {
                kisiler.Remove(txtKisiler.Text);
            }
            lbKisiler.DataSource = kisiler.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            kisiler[indexSira] = txtKisiler.Text;

            lbKisiler.DataSource= kisiler.ToList();
        }

        private void lbKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKisiler.Text = lbKisiler.SelectedValue.ToString();
            indexSira = lbKisiler.SelectedIndex;
        }

        private void btnSayı_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for(int i = 0; i < kisiler.Count; i++)
            {
                if (kisiler[i].Length == 5)
                {
                    sayac++;
                }
            }

        }

        private void btnM_Click(object sender, EventArgs e)
        {
            
        }
    }
}
