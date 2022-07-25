using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dataSet1.Course' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.courseTableAdapter.Fill(this.dataSet1.Course);
            // TODO: Bu kod satırı 'dataSet1.Professor' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.professorTableAdapter.Fill(this.dataSet1.Professor);
            // TODO: Bu kod satırı 'dataSet1.Student' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.studentTableAdapter.Fill(this.dataSet1.Student);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int course;
            course = (int)comboBox1.SelectedValue;
            this.studentTableAdapter.InsertQuery(textBox1.Text, textBox2.Text, Convert.ToDouble(textBox3.Text), course);
            this.studentTableAdapter.Fill(this.dataSet1.Student);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IDX;
            int Sel_ID;
            IDX = dataGridView1.CurrentRow.Index;
            int.TryParse(dataGridView1.Rows[IDX].Cells[0].Value.ToString(), out Sel_ID);
            this.studentTableAdapter.DeleteQuery(Sel_ID);
            this.studentTableAdapter.Fill(this.dataSet1.Student);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int student, IDX;
            int Sel_ID = 0;
            IDX = dataGridView1.CurrentRow.Index;
            student = (int)comboBox1.SelectedValue;
            int.TryParse(dataGridView1.Rows[IDX].Cells[0].Value.ToString(), out Sel_ID);
            this.studentTableAdapter.UpdateQuery(textBox1.Text, textBox2.Text, Convert.ToDouble(textBox3.Text), student, Sel_ID);
            this.studentTableAdapter.Fill(this.dataSet1.Student);
        }
    }
}
