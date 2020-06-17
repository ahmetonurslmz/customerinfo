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

namespace CustomerInfo
{
    public partial class Form1 : Form
    {
        Jobs jobs;
        Cities cities;
        Customers customers;
        BindingSource binder = new BindingSource();

        int totalJobs;
        int totalCities;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.fetchJobs();
            this.fetchCities();
            this.fetchCustomers();
        }

        public void fetchJobs()
        {
            jobs = new Jobs();
            DataSet data_set = jobs.fetch();
            totalCities = data_set.Tables[0].Rows.Count;
            Dictionary<int, string> comboSource = new Dictionary<int, string>();

            for (int i = 0; i < totalCities; i++)
            {
                DataRow table = data_set.Tables[0].Rows[i];
                comboSource.Add(Convert.ToInt32(table.ItemArray.GetValue(0).ToString()), table.ItemArray.GetValue(1).ToString());
            }

            cbJob.DataSource = new BindingSource(comboSource, null);
            cbJob.DisplayMember = "Value";
            cbJob.ValueMember = "Key";
            cbJob.SelectedIndex = -1;

            cbSelectJob.DataSource = new BindingSource(comboSource, null);
            cbSelectJob.DisplayMember = "Value";
            cbSelectJob.ValueMember = "Key";
            cbSelectJob.SelectedIndex = -1;
        }

        public void fetchCities()
        {
            cities = new Cities();
            DataSet data_set = cities.fetch();
            totalJobs = data_set.Tables[0].Rows.Count;
            Dictionary<int, string> comboSource = new Dictionary<int, string>();

            for (int i = 0; i < totalJobs; i++)
            {
                DataRow table = data_set.Tables[0].Rows[i];
                comboSource.Add(Convert.ToInt32(table.ItemArray.GetValue(0).ToString()), table.ItemArray.GetValue(1).ToString());
            }

            cbCity.DataSource = new BindingSource(comboSource, null);
            cbCity.DisplayMember = "Value";
            cbCity.ValueMember = "Key";
            cbCity.SelectedIndex = -1;

            cbSelectCity.DataSource = new BindingSource(comboSource, null);
            cbSelectCity.DisplayMember = "Value";
            cbSelectCity.ValueMember = "Key";
            cbSelectCity.SelectedIndex = -1;
        }

        public void fetchCustomers()
        {
            try
            {
                customers = new Customers();
                DataTable salesTable = customers.fetch();

                foreach (DataRow row in salesTable.Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < salesTable.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                    listView1.Items.Add(item);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString(), "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
