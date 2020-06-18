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

        int totalCustomers;
        int totalCities;
        int totalJobs;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.fetchCustomers();
            this.fetchJobs();
            this.fetchCities();
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
                lvCustomers.Items.Clear();
                customers = new Customers();
                DataTable customersTable = customers.fetch();
                totalCustomers = customersTable.Rows.Count;

                foreach (DataRow row in customersTable.Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < customersTable.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                    lvCustomers.Items.Add(item);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString(), "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            this.createOrUpdateCustomer(0);
        }

        public void createOrUpdateCustomer(int customerId)
        {
            string customerName;
            string customerFamilyName;
            int customerJob;
            int customerSalary;
            int customerCity;

            try
            {
                // customer name
                if (txtName.TextLength != 0)
                {
                    customerName = txtName.Text;
                }
                else
                {
                    throw new Exception("You must enter customer name.");
                }

                // customer family name
                if (txtFamilyName.TextLength != 0)
                {
                    customerFamilyName = txtFamilyName.Text;
                }
                else
                {
                    throw new Exception("You must enter customer family name.");
                }


                // customer job
                if (cbJob.SelectedIndex > -1)
                {
                    customerJob = ((KeyValuePair<int, string>)cbJob.SelectedItem).Key;
                }
                else
                {
                    throw new Exception("You must select customer job.");
                }

                // customer salary
                if (mTxtSalary.Text.ToString().Length != 0)
                {
                    customerSalary = Convert.ToInt32(mTxtSalary.Text.ToString());
                }
                else
                {
                    throw new Exception("You must enter customer salary.");
                }

                // customer city
                if (cbCity.SelectedIndex > -1)
                {
                    customerCity = ((KeyValuePair<int, string>)cbCity.SelectedItem).Key;
                }
                else
                {
                    throw new Exception("You must select customer city.");
                }
                if (customerId > 0)
                {
                    // update
                    customers = new Customers();
                    Boolean result = customers.update(customerId, customerName, customerFamilyName, customerJob, customerSalary, customerCity);
                    if (result)
                    {
                        this.fetchCustomers();
                    }
                } else
                {
                    // create
                    customers = new Customers();
                    Boolean result = customers.create(customerName, customerFamilyName, customerJob, customerSalary, customerCity);
                    if (result)
                    {
                        this.fetchCustomers();
                        this.clearForm();
                    }
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString(), "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            this.createOrUpdateCustomer(Convert.ToInt32(lblIdValue.Text));
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblIdValue.Text = lvCustomers.Items[lvCustomers.FocusedItem.Index].SubItems[0].Text;
            txtName.Text = lvCustomers.Items[lvCustomers.FocusedItem.Index].SubItems[1].Text;
            txtFamilyName.Text = lvCustomers.Items[lvCustomers.FocusedItem.Index].SubItems[2].Text;
            mTxtSalary.Text = lvCustomers.Items[lvCustomers.FocusedItem.Index].SubItems[4].Text;
            cbJob.Text = lvCustomers.Items[lvCustomers.FocusedItem.Index].SubItems[3].Text;
            cbCity.Text = lvCustomers.Items[lvCustomers.FocusedItem.Index].SubItems[5].Text;

            btnUpdateRecord.Enabled = true;
            btnDeleteRecord.Enabled = true;
        }

        public void clearForm()
        {
            lblIdValue.Text = "0";
            txtName.Text = "";
            txtFamilyName.Text = "";
            cbJob.SelectedIndex = -1;
            mTxtSalary.Text = null;
            cbCity.SelectedIndex = -1;
            btnUpdateRecord.Enabled = false;
            btnDeleteRecord.Enabled = false;
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            this.clearForm();
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            customers = new Customers();
            Boolean result = customers.delete(Convert.ToInt32(lblIdValue.Text));
            if (result)
            {
                this.fetchCustomers();
                this.clearForm();
            }
        }

        private void cbSelectJob_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbSelectJob.SelectedIndex > -1)
            {
                customers = new Customers();
                int selectedValue = ((KeyValuePair<int, string>)cbSelectJob.SelectedItem).Key;
                int count = customers.fetchByJobs(selectedValue);
                lblSelectedJobCount.Text = count.ToString();
                lblTotalCustomerCount.Text = totalCustomers.ToString();
                prgressBarSelectedJob.Maximum = totalCustomers;
                prgressBarSelectedJob.Value = count;
            } else
            {
                prgressBarSelectedJob.Value = 0;
                lblSelectedJobCount.Text = 0.ToString();
                lblTotalCustomerCount.Text = 0.ToString();
            }
        }

        private void cbSelectCity_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbSelectCity.SelectedIndex > -1)
            {
                customers = new Customers();
                int selectedValue = ((KeyValuePair<int, string>)cbSelectCity.SelectedItem).Key;
                int count = customers.fetchByCity(selectedValue);
                lblSelectedCityCount.Text = count.ToString();
                lblTotalCustomerCountCity.Text = totalCustomers.ToString();
                prgressBarSelectedCity.Maximum = totalCustomers;
                prgressBarSelectedCity.Value = count;
            }
            else
            {
                prgressBarSelectedCity.Value = 0;
                lblSelectedCityCount.Text = 0.ToString();
                lblTotalCustomerCountCity.Text = 0.ToString();
            }
        }
    }
}
