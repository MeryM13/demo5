using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using demo5.CLASSES;

namespace demo5.FORMS
{
    public partial class ClientService : UserControl
    {
        public ClientService(CLASSES.ClientService service)
        {
            InitializeComponent();
            lblTitle.Text = service.Title;
            lblTime.Text = service.StartTime.ToString();
            lblFileCount.Text = $"Всего файлов: {service.DocumentCount}";
        }
    }
}
