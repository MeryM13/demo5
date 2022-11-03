using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using demo5.UTILS;

namespace demo5.FORMS
{
    public partial class ClientServicesForm : Form
    {
        public ClientServicesForm(int clientID)
        {
            InitializeComponent();
            try
            {
                layoutServices.Controls.Clear();
                foreach (var service in DataWork.GetClientServiceList(clientID))
                {
                    ClientService item = new ClientService(service);
                    item.Tag = "product";
                    layoutServices.Controls.Add(item);
                }
                layoutServices.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
