using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZauraKursachFull
{
    public partial class Form1 : Form
    {
        private int[] mas;

        public Form1()
        {
            InitializeComponent();
        }

        private void MainBTN_Click(object sender, EventArgs e)
        {
            try
            {
                mas = MainTB.Text.Split(' ').Select(int.Parse).ToArray();
            }
            catch
            {
                MessageBox.Show("Вы что-то сделали не так");
                return;
            }
                MessageBox.Show(
                string.Join(", ", sort(mas)),
                "Результат"
                );
        }

        private static int[] sort(int[] massive)
        {
            if (massive.Length == 1)
                return massive;
            int mid_point = massive.Length / 2;
            return merge(sort(massive.Take(mid_point).ToArray()), sort(massive.Skip(mid_point).ToArray()));
        }
        private static int[] merge(int[] mass1, int[] mass2)
        {
            int a = 0, b = 0;
            int[] merged = new int[mass1.Length + mass2.Length];
            for (int i = 0; i < mass1.Length + mass2.Length; i++)
            {
                if (b < mass2.Length && a < mass1.Length)
                    if (mass1[a] > mass2[b] && b < mass2.Length)
                        merged[i] = mass2[b++];
                    else
                        merged[i] = mass1[a++];
                else
                    if (b < mass2.Length)
                    merged[i] = mass2[b++];
                else
                    merged[i] = mass1[a++];
            }
            return merged;
        }
    }
}
