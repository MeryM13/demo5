using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using demo5.UTILS;
using demo5.CLASSES;

namespace demo5.FORMS
{
    public partial class MainForm : Form
    {
        private int _page = 1;
        private int _pageSize = 10;
        private string _filter = "";
        private string _sort = "";
        private string _searchString = "";
        private string _searchCategory = "";
        private int _selectedClientID = 0;
        private int _entryNumber;
        private bool _showBirthday = false;
        public MainForm()
        {
            InitializeComponent();
            cmbEntryNumber.SelectedIndex = 0;
            Render();
        }

        private void Render()
        {
            try
            {
                dgClients.DataSource = DataWork.GetClientEntries(_page, _pageSize, _filter, _sort, _searchString, _searchCategory,_showBirthday).Tables[0];
                _entryNumber =
                    DataWork.GetEntryNumber(_page, _pageSize, _filter, _sort, _searchString, _searchCategory, _showBirthday);
                if (_pageSize > 0)
                {
                    lblShowedEntries.Text =
                        $"Показаны записи с {(_page - 1) * _pageSize + 1} по {(_page * _pageSize > _entryNumber ? _entryNumber : _page * _pageSize)} из {_entryNumber}";
                }
                else
                {
                    lblShowedEntries.Text =
                        $"Показаны записи с 1 по {_entryNumber} из {_entryNumber}";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if ((_page - 2) * _pageSize + 1 <= 0)
                return;

            _page--;
            Render();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if ((_page + 1) * _pageSize > _entryNumber)
                return;

            _page++;
            Render();
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            _filter = "ж";
            Render();
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            _filter = "м";
            Render();
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            rbMale.Checked = false;
            rbFemale.Checked = false;
            _filter = "";
            Render();
        }

        private void cmbEntryNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _pageSize = int.Parse(cmbEntryNumber.SelectedItem.ToString());
            }
            catch 
            {
                _pageSize = -1;
            }

            _page = 1;
            Render();
        }

        private void cmbSearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            _searchCategory = cmbSearchCategory.SelectedItem.ToString();
            Render();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _searchString = txtSearch.Text;
            Render();
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            _sort = cmbSort.SelectedItem.ToString();
            Render();
        }

        private void dgClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedClientID = int.Parse(dgClients.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUpdateForm AUF = new AddUpdateForm(0);
            AUF.ShowDialog();
            Render();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedClientID == 0)
            {
                MessageBox.Show("Select a client");
                return;
            }
            AddUpdateForm AUF = new AddUpdateForm(_selectedClientID);
            AUF.ShowDialog();
            Render();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedClientID == 0)
            {
                MessageBox.Show("Выберите клиента");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete client data", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (!DataWork.CanDeleteClient(_selectedClientID))
                {
                    MessageBox.Show("Невозможно удалить клиента");
                    return;
                }
                DataWork.DeleteClient(_selectedClientID);
            }
        }

        private void rbShowBirthday_Click(object sender, EventArgs e)
        {
            rbShowBirthday.Checked = !rbShowBirthday.Checked;
            _showBirthday = !_showBirthday;
            Render();
        }
    }
}
