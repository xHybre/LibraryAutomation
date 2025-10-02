using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Nesneler;

namespace WindowsFormsApp1
{
    public partial class form_1 : Form
    {


        List<Kisi> persons = new List<Kisi>();
        List<book> books = new List<book>();

        public form_1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Clear button functionality to clear username and password fields
        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_kullaniciAdi.Text = string.Empty;
            txt_sifre.Text = string.Empty;
        }

        // Login button functionality to validate user credentials and navigate to respective pages
        private void btn_giris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi, sifre = "";

            kullaniciAdi = txt_kullaniciAdi.Text;
            sifre = txt_sifre.Text;
            bool kontrol = false;

            foreach (Kisi person in persons)
            {
                if (kullaniciAdi.ToLower() == person.getUserName() && sifre.ToLower() == person.getPassword() && person.getAuthority().ToLower() == "admin")
                {
                    //go to admin page
                    AdminPage adminPage = new AdminPage(persons);
                    adminPage.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }
                else if(kullaniciAdi.ToLower() == person.getUserName() && sifre.ToLower() == person.getPassword() && person.getAuthority().ToLower() == "manager")
                {
                    //go to manager page
                    ManagerPage managerPage = new ManagerPage(persons);
                    managerPage.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }
                else if(kullaniciAdi.ToLower() == person.getUserName() && sifre.ToLower() == person.getPassword() && person.getAuthority().ToLower() == "staff")
                {
                    //go to staff page
                    StuffPage stuffPage = new StuffPage(books);
                    stuffPage.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }
            }

            // Show error message if credentials are invalid
            if (kontrol == false)
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 

        private void form_1_Load(object sender, EventArgs e)
        {
            // Example persons

            persons.Add(new Kisi(1,"Taylan", "Işık", DateTime.Now, "taylan1", "1" ,"Admin",60000));
            persons.Add(new Kisi(2, "Ahmet", "Çimen", DateTime.Now, "ahmet2", "2", "Admin",60000));
            persons.Add(new Kisi(3, "Tamer", "Korkusuz", DateTime.Now, "tamer3", "3", "Manager", 50000));
            persons.Add(new Kisi(4, "Enes", "Dağ", DateTime.Now, "enes4", "4", "Manager", 50000));
            persons.Add(new Kisi(5, "Demet", "Yılmaz", DateTime.Now, "demet5", "5", "Staff", 40000));
            persons.Add(new Kisi(6, "Furkan", "Koçak", DateTime.Now, "furkan6", "6", "Janitor", 30000));

            // Example books

            books.Add(new book(1, "İçimizdeki Şeytan", "Sabahattin Ali", "Türkçe", "Yapı Kredi Yayınları", "Roman", 100, 250, 2016));
            books.Add(new book(2, "Tutunamayanlar", "Oğuz Atay", "Türkçe", "İletişim Yayınları", "Roman", 350, 760, 2015));
            books.Add(new book(3, "Uçurtma Avcısı", "Khaled Hosseini", "İngilizce", "Everest Yayınları", "Roman", 100, 350, 2010));
            books.Add(new book(4, "Küçük Prens", "Antoine de Saint-Exupéry", "Fransızca", "Can Yayınları", "Çocuk Kitabı", 50, 120, 2018));
            books.Add(new book(5, "Kürk Mantolu Madonna", "Sabahattin Ali", "Türkçe", "Yapı Kredi Yayınları", "Roman", 650, 220, 2015));
        }
    }
}
