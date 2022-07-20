using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterLevelData
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<ComboData> dictCombobox = new List<ComboData>();
            dictCombobox.Add(new ComboData ("1", "Course Gravel"));
            dictCombobox.Add(new ComboData ("2", "Mediuum Sand"));
            dictCombobox.Add(new ComboData("3", "Gravel"));
            dictCombobox.Add(new ComboData("4", "Fine Sand"));
            dictCombobox.Add(new ComboData("5", "Silt"));

            comboBox1.DataSource = dictCombobox;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";

            List<string> strCombobox = new List<string>();

            strCombobox.Add("English");
            strCombobox.Add("French");

            comboBox2.DataSource = strCombobox;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = ".";            
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;

                DataProcessor dp = DataProcessorFactory.GetProcessor("csv");

                DataTable dt = dp.ProcessData(selectedFileName);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str1 = dataGridView1.SelectedCells[0].Value.ToString();

            str1 = str1.Replace('a', '@');

            dataGridView1.SelectedCells[0].Value = str1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sel = (string) comboBox2.SelectedItem;

            LanguageText text = LanguageTextFactory.GetLanguageText(sel);
            button1.Text = text.SelectFile();
            button2.Text = text.ReplaceFile();
            button3.Text = text.ShowId();
            label1.Text = text.LabelId();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ComboData item = (ComboData)comboBox1.SelectedItem;

            label2.Text = item.Id;
        }
    }
}
