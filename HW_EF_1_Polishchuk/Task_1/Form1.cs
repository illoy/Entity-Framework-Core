using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private MyDatabase libary = new MyDatabase();

        private bool dataReady = true;
        private void AddEmploees()
        {
            using (MyDatabase libary = new MyDatabase())
            {
                libary.Emploee.Add(new Emploees { Id = 1, Name = "Illia", LastName = "Poli", Phone = "0938363547" });
                libary.Emploee.Add(new Emploees { Id = 2, Name = "Vlad", LastName = "Babi", Phone = "0682564901" });
                libary.Emploee.Add(new Emploees { Id = 3, Name = "Roma", LastName = "Kor", Phone = "096145537" });
                libary.SaveChanges();


                libary.Emploee.Remove();
            }
            dataReady = false;
        }

        private void LoadData()
        {
            dataGridView1.Rows.Clear();

            if (dataReady)
            {
                AddEmploees();
            }

            using (MyDatabase libary = new MyDatabase())
            {
                var emploeesCollection = libary.Emploee.ToList();

                foreach (var emploee in emploeesCollection)
                {
                    dataGridView1.Rows.Add(emploee.Id, emploee.Name, emploee.LastName, emploee.Phone);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e) => LoadData();
    }
}
