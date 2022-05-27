using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VeriYapilariProje
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        string text = "";

        StackLinkedList Cumlelerr = new StackLinkedList();
        StackLinkedList KelimeesStack = new StackLinkedList();
        Heap heap = new Heap(100);
        public bool isRead, toStack = false;
        object[] heapKelimee;
        string[] kelimeler;

        //Dosya yükleme işlemleri.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Text Dosyası |*.txt";
            file.RestoreDirectory = true;
            if (file.ShowDialog() == DialogResult.OK)
            {
                filePath.Text = file.FileName;
                var fileStream = file.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    text = reader.ReadToEnd();
                    text = text.ToLower();
                    isRead = true;
                    MessageBox.Show("Dosya Başarıyla Yüklendi!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Geçerli Bir .txt dosyası yükleyiniz!");
            }

        }

        private void btnStackOku_Click(object sender, EventArgs e)
        {
           
                
                int kelimeSayisi = 0;
                int cumleNumarasi = 0;
                int toplamkelimeSayisi = 0;
                string[] cumleler = text.Split('\n' );
                
                for (int i = 0; i < cumleler.Length; i++)
                {
                    cumleNumarasi++;
                    kelimeler = cumleler[i].Split(' ');
                    kelimeSayisi = kelimeler.Length;
                    KelimeStackEkle(KelimeesStack, KelimeeModifier(kelimeler));
                    rtxtbxResult.Text += (i + 1) + ". Cümlede içindeki kelime sayısı: " + kelimeSayisi + "\n";
                    Cumlelerr.Push(cumleler[i]);
                    toplamkelimeSayisi += kelimeSayisi;
                }
                rtxtbxResult.Text += "Toplam Kelime Sayısı: " + toplamkelimeSayisi + "\n" +
                    "Toplam Cümle Sayısı : " + Cumlelerr.count
                    + "\n" + "Ortalama Kelime Sayısı: " + (toplamkelimeSayisi / Cumlelerr.count);

        }


        public string[] KelimeeModifier(string[] kelimeler)
        {


            for (int i = 0; i < kelimeler.Length; i++)
            {
                for (int j = 0; j < kelimeler[i].Length; j++)
                {
                    if (Char.IsPunctuation(kelimeler[i], j))
                    {
                        kelimeler[i] =( kelimeler[i].Substring(0, j));
                        kelimeler[i].ToLower();
                        break;
                    }
                }

            }
            return kelimeler;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp="";


             for (int i = 0; i < KelimeesStack.count; i++)
             {
                temp= KelimeesStack.Pop().ToString();
                heap.Insert(temp);

             }
            rtxtbxResultKelimees.Text = heap.Disp();            
        }

        private void txtHashBTN_Click(object sender, EventArgs e)
        {
           //To-Do
        }

        public void KelimeStackEkle(StackLinkedList linkedList, string[] kelimeler)
        {

            for (int i = 0; i < kelimeler.Length; i++)
            {
                 KelimeeModifier(kelimeler);
                 KelimeesStack.Push(kelimeler[i]);
            }

            //listleme
            
            for (int i = 0; i < kelimeler.Length; i++)
            {
                Node temp=new Node(kelimeler[i]);

                rtxtbxResultKelimees.Text += temp.Data.ToString() +"\n";
            }
        }    
    }
}
