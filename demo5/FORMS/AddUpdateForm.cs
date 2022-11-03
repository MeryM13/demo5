using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using demo5.CLASSES;
using demo5.UTILS;

namespace demo5.FORMS
{
    public partial class AddUpdateForm : Form
    {
        private Client _client;
        private int mode;

        private string ImageFolderPath =
            Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"..\..\IMAGES\Клиенты\"));

        private string photoPath;

        public AddUpdateForm(int clientID)
        {
            InitializeComponent();
            if (clientID == 0)
            {
                _client = new Client();
                label1.Visible = false;
                txtID.Visible = false;
                mode = 0;
            }
            else
            {
                try
                {
                    _client = DataWork.GetClientByID(clientID);
                    txtID.Text = _client.ID.ToString();
                    txtLastName.Text = _client.LastName;
                    txtFirstName.Text = _client.FirstName;
                    txtPatronymic.Text = _client.Patronymic;
                    dtBirthdate.Value = _client.Birthdate;
                    txtPhone.Text = _client.Phone;
                    txtEmail.Text = _client.Email;
                    photoPath = _client.PhotoPath;

                    if (_client.Gender == "м")
                    {
                        rbMale.Checked = true;
                    }
                    else
                    {
                        rbFemale.Checked = true;
                    }

                    ImgUpload(ImageFolderPath + Path.GetFileName(_client.PhotoPath));

                    mode = 1;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        private void ImgUpload(string path)
        {
            if (!String.IsNullOrEmpty(path))
            {
                Image image = Image.FromFile(path);
                imgClient.Image = image;
            }
        }

        private void ImgSave()
        {
            string name = Path.GetFileName(photoPath);
            if (name != _client.PhotoPath && photoPath != _client.PhotoPath)
            {
                _client.PhotoPath = name;
                File.Copy(photoPath, ImageFolderPath + name, true);
            }
        }
        
        private void ReadData()
        {
            _client.LastName = txtLastName.Text;
            _client.FirstName = txtFirstName.Text;
            _client.Patronymic = txtPatronymic.Text;
            _client.Email = txtEmail.Text;
            _client.Phone = txtPhone.Text;
            _client.Gender = rbMale.Checked ? "м" : "ж";
            _client.Birthdate = dtBirthdate.Value;
            if (mode == 0)
                _client.RegistrationDate = DateTime.Now;
            ImgSave();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveAndExit_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 0:
                {
                    try
                    {
                        ReadData();
                        DataWork.AddClient(_client);
                        this.Close();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.ToString());
                    }

                    break;
                }
                case 1:
                {
                    try
                    {
                        ReadData();
                        DataWork.UpdateClient(_client);
                        this.Close();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.ToString());
                    }

                    break;
                }
            }
        }

        private void btnChangeImg_Click(object sender, EventArgs e)
        {
            using (var openPhotoDialog = new OpenFileDialog())
            {
                if (openPhotoDialog.ShowDialog() == DialogResult.OK)
                {
                    ImgUpload(openPhotoDialog.FileName);
                    photoPath = openPhotoDialog.FileName;
                }

            }

        }

        private void btnOpenServices_Click(object sender, EventArgs e)
        {
            ClientServicesForm CSF = new ClientServicesForm(_client.ID);
            CSF.ShowDialog();
        }
    }
}
