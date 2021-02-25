using ETrade.Business.Abstract;
using ETrade.Business.Concrete;
using ETrade.Business.DependencyResolvers.Ninject;
using ETrade.DataAccess.Concrete.EntityFramework;
using ETrade.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETrade.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
        }

        private ICustomerService _customerService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            dgvCustomer.DataSource = _customerService.GetAll();
            cbxCustomerGenderAdd.Items.Add("K");
            cbxCustomerGenderAdd.Items.Add("E");

            cbxCustomerGenderUpdate.Items.Add("K");
            cbxCustomerGenderUpdate.Items.Add("E");

        }

        private void tbxCustomerNameSurname_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxCustomerNameSurname.Text))
            {
                dgvCustomer.DataSource = _customerService.GetCustomersByCustomerName(tbxCustomerNameSurname.Text);
            }
            else
            {
                LoadCustomers();
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _customerService.Add(new Customer
            {
                NameSurname = tbxCustomerNameSurnameAdd.Text,
                Email = tbxCustomerEmailAdd.Text,
                Gender = cbxCustomerGenderAdd.Text,
                BirthDate = Convert.ToDateTime(tbxCustomerBirthdateAdd.Text),
                TelNr1 = tbxCustomerTelNr1Add.Text,
                TelNr2 = tbxCustomerTelNr2Add.Text,
            });
            MessageBox.Show("Müşteri kaydı yapıldı.");
            LoadCustomers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _customerService.Update(new Customer
            {
                CustomerId = Convert.ToInt32(dgvCustomer.CurrentRow.Cells[0].Value),
                NameSurname = tbxCustomerNameSurnameUpdate.Text,
                Email = tbxCustomerEmailUpdate.Text,
                Gender = cbxCustomerGenderUpdate.Text,
                BirthDate = Convert.ToDateTime(tbxCustomerBirthdateUpdate.Text),
                TelNr1 = tbxCustomerTelNr1Update.Text,
                TelNr2 = tbxCustomerTelNr2Update.Text,
            });
            MessageBox.Show("Müşteri kaydı güncellendi.");
            LoadCustomers();
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvCustomer.CurrentRow;
            tbxCustomerNameSurnameUpdate.Text = row.Cells[3].Value.ToString();
            tbxCustomerEmailUpdate.Text = row.Cells[4].Value.ToString();
            cbxCustomerGenderUpdate.SelectedItem = row.Cells[5].Value.ToString();
            tbxCustomerBirthdateUpdate.Text = row.Cells[6].Value.ToString();
            tbxCustomerTelNr1Update.Text = row.Cells[8].Value.ToString();
            tbxCustomerTelNr2Update.Text = row.Cells[9].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.CurrentRow != null)
            {
                try
                {
                    _customerService.Delete(new Customer
                    {
                        CustomerId = Convert.ToInt32(dgvCustomer.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Müşteri kaydı silindi.");
                    LoadCustomers();
                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message);
                }
            }
        }
    }
}
