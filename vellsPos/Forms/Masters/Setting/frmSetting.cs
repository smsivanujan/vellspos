using FoxLearn.License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vellsPos.Entities.Layouts;
using vellsPos.Entities.Masters;
using vellsPos.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace vellsPos.Forms.Layouts
{
    public partial class frmSetting : Form
    {
        private string uid;
        ReturnResult result;
        String msgStatus;
        String directoryPath = "";
        string rootPath = @"c:\vellspos";

        private FormMovable formMove;

        public frmSetting()
        {
            InitializeComponent();

            formMove = new FormMovable(this);
            formMove.SetMovable(pnl_head, lbl_title);
        }

        private void frmPayout_Load(object sender, EventArgs e)
        {
            txt_imagePath.Visible = false;
            lbl_imageStatus.Visible = false;

            if (tbPage_client == tb_setting.SelectedTab)
            {
                btn_save.Visible = true;
                btn_restore.Visible = false;
            }

            String clientIdCountSQL = "SELECT COUNT(id) FROM clients ";
            String clientIdCount = DBTransactionService.getScalerData(clientIdCountSQL);

            if(clientIdCount.Equals("0"))
            {
                //
            }
            else
            {
                String clientIdSQL = "SELECT id FROM clients ";
                String clientId = DBTransactionService.getScalerData(clientIdSQL);
                uid = clientId; ;
                fillData();
            }
           

            
        }

        private void fillData()
        {
            Client client = Client.getOneClient(Int32.Parse(uid));
            txt_id.Text = uid;
            txt_bussinessName.Text = client.Bussiness_name;
            txt_contactNumber.Text = client.Contact_number;
            txt_email.Text = client.Email;
            txt_address.Text = client.Address;
            txt_imagePath.Text = client.Image;

            if (!String.IsNullOrEmpty(txt_imagePath.Text))
            {
                pb_clientImage.Image = Image.FromFile(client.Image);
            }
        }

     

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonww1_Click(object sender, EventArgs e)
        {
            //frmProductCreate p = new frmProductCreate() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //this.pnl_container.Controls.Add(p);
            //p.Show();
        }

        private void pnl_root_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clientSave()
        {
            ReturnResult nameResult = Validator.validateText(txt_bussinessName.Text, "Bussiness Name");
            ReturnResult numberResult = Validator.validateText(txt_contactNumber.Text, "Contact Number");
            ReturnResult emailResult = Validator.validateText(txt_email.Text, "Email");
            ReturnResult addressResult = Validator.validateText(txt_address.Text, "Address");

            if (!nameResult.Status)
            {
                MessageBox.Show(nameResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!numberResult.Status)
            {
                MessageBox.Show(numberResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!emailResult.Status)
            {
                MessageBox.Show(emailResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!addressResult.Status)
            {
                MessageBox.Show(addressResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Client client = new Client();
                client.Bussiness_name = txt_bussinessName.Text;
                client.Contact_number = txt_contactNumber.Text;
                client.Email = txt_email.Text;
                client.Address = txt_address.Text;

                if (!String.IsNullOrEmpty(txt_imagePath.Text))
                {
                    directoryPath = Path.Combine(rootPath, Path.GetFileName(txt_imagePath.Text));
                    ImageUpload imageUpload = new ImageUpload();
                    imageUpload.DirectoryPath = directoryPath;
                    imageUpload.RootPath = rootPath;//root folder from save
                    imageUpload.ImagePath = txt_imagePath.Text;
                    ReturnResult resul2 = ImageUpload.store(imageUpload);
                }

                //ReturnResult result = Customer.store(customer);
                client.Image = directoryPath;//root folder to save
                if (string.IsNullOrEmpty(txt_id.Text))
                {
                    //save();
                    result = Client.store(client);
                    msgStatus = "added";

                }
                else
                {
                    //update();
                    client.Id = Int32.Parse(uid);
                    result = Client.update(client);
                    msgStatus = "updated";
                }

                if (result.Status)
                {
                    //ActivityLog aL = new ActivityLog();
                    //aL.Date = DateTime.Now;
                    //User user = new User();
                    //String query = "SELECT id from user WHERE name = '" + Session.uname + "'";
                    //String id = DBTransactionService.getScalerData(query);
                    //user.Id = Int32.Parse(id);
                    //aL.User = user;
                    //aL.Description = "One New Transaction Added.[Date : " + dtp_dateFrom.Value + "Employee : " + txtname.Text + "Transaction Category : " + txttransaction.Text + "Invoice No : " + txtInvoiceNo.Text + "Amount : " + txtamount.Text + " Description :" + txtdescrib.Text + " Added by :" + Session.uname + "]";
                    //ActivityLog.store(aL);
                    MessageBox.Show("Client has been " + msgStatus + " successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(result.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //}
            }
        }

        private void printcustomerLoyalitySave()
        {
            ReturnResult nameResult = Validator.validateText(txt_bussinessName.Text, "Bussiness Name");
            ReturnResult numberResult = Validator.validateText(txt_contactNumber.Text, "Contact Number");
            ReturnResult emailResult = Validator.validateText(txt_email.Text, "Email");
            ReturnResult addressResult = Validator.validateText(txt_address.Text, "Address");

            if (!nameResult.Status)
            {
                MessageBox.Show(nameResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!numberResult.Status)
            {
                MessageBox.Show(numberResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!emailResult.Status)
            {
                MessageBox.Show(emailResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!addressResult.Status)
            {
                MessageBox.Show(addressResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Client client = new Client();
                client.Bussiness_name = txt_bussinessName.Text;
                client.Contact_number = txt_contactNumber.Text;
                client.Email = txt_email.Text;
                client.Address = txt_address.Text;

                if (!String.IsNullOrEmpty(txt_imagePath.Text))
                {
                    directoryPath = Path.Combine(rootPath, Path.GetFileName(txt_imagePath.Text));
                    ImageUpload imageUpload = new ImageUpload();
                    imageUpload.DirectoryPath = directoryPath;
                    imageUpload.RootPath = rootPath;//root folder from save
                    imageUpload.ImagePath = txt_imagePath.Text;
                    ReturnResult resul2 = ImageUpload.store(imageUpload);
                }

                //ReturnResult result = Customer.store(customer);
                client.Image = directoryPath;//root folder to save
                if (this.Tag is null)
                {
                    //save();
                    result = Client.store(client);
                    msgStatus = "added";

                }
                else
                {
                    //update();
                    client.Id = Int32.Parse(this.Tag.ToString());
                    result = Client.update(client);
                    msgStatus = "updated";
                }

                if (result.Status)
                {
                    //ActivityLog aL = new ActivityLog();
                    //aL.Date = DateTime.Now;
                    //User user = new User();
                    //String query = "SELECT id from user WHERE name = '" + Session.uname + "'";
                    //String id = DBTransactionService.getScalerData(query);
                    //user.Id = Int32.Parse(id);
                    //aL.User = user;
                    //aL.Description = "One New Transaction Added.[Date : " + dtp_dateFrom.Value + "Employee : " + txtname.Text + "Transaction Category : " + txttransaction.Text + "Invoice No : " + txtInvoiceNo.Text + "Amount : " + txtamount.Text + " Description :" + txtdescrib.Text + " Added by :" + Session.uname + "]";
                    //ActivityLog.store(aL);
                    MessageBox.Show("Client has been " + msgStatus + " successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(result.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //}
            }
        }
        private void printSave()
        {
            ReturnResult nameResult = Validator.validateText(txt_bussinessName.Text, "Bussiness Name");
            ReturnResult numberResult = Validator.validateText(txt_contactNumber.Text, "Contact Number");
            ReturnResult emailResult = Validator.validateText(txt_email.Text, "Email");
            ReturnResult addressResult = Validator.validateText(txt_address.Text, "Address");

            if (!nameResult.Status)
            {
                MessageBox.Show(nameResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!numberResult.Status)
            {
                MessageBox.Show(numberResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!emailResult.Status)
            {
                MessageBox.Show(emailResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!addressResult.Status)
            {
                MessageBox.Show(addressResult.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Client client = new Client();
                client.Bussiness_name = txt_bussinessName.Text;
                client.Contact_number = txt_contactNumber.Text;
                client.Email = txt_email.Text;
                client.Address = txt_address.Text;

                if (!String.IsNullOrEmpty(txt_imagePath.Text))
                {
                    directoryPath = Path.Combine(rootPath, Path.GetFileName(txt_imagePath.Text));
                    ImageUpload imageUpload = new ImageUpload();
                    imageUpload.DirectoryPath = directoryPath;
                    imageUpload.RootPath = rootPath;//root folder from save
                    imageUpload.ImagePath = txt_imagePath.Text;
                    ReturnResult resul2 = ImageUpload.store(imageUpload);
                }

                //ReturnResult result = Customer.store(customer);
                client.Image = directoryPath;//root folder to save
                if (this.Tag is null)
                {
                    //save();
                    result = Client.store(client);
                    msgStatus = "added";

                }
                else
                {
                    //update();
                    client.Id = Int32.Parse(this.Tag.ToString());
                    result = Client.update(client);
                    msgStatus = "updated";
                }

                if (result.Status)
                {
                    //ActivityLog aL = new ActivityLog();
                    //aL.Date = DateTime.Now;
                    //User user = new User();
                    //String query = "SELECT id from user WHERE name = '" + Session.uname + "'";
                    //String id = DBTransactionService.getScalerData(query);
                    //user.Id = Int32.Parse(id);
                    //aL.User = user;
                    //aL.Description = "One New Transaction Added.[Date : " + dtp_dateFrom.Value + "Employee : " + txtname.Text + "Transaction Category : " + txttransaction.Text + "Invoice No : " + txtInvoiceNo.Text + "Amount : " + txtamount.Text + " Description :" + txtdescrib.Text + " Added by :" + Session.uname + "]";
                    //ActivityLog.store(aL);
                    MessageBox.Show("Client has been " + msgStatus + " successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(result.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //}
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (tbPage_client == tb_setting.SelectedTab)
            {
                clientSave();
            }
            else if (tbPage_customerLoyality == tb_setting.SelectedTab)
            {
                MessageBox.Show("Test2");
            }
            else if (tbPage_print == tb_setting.SelectedTab)
            {
                MessageBox.Show("Test3");
            }
            else
            {
                MessageBox.Show("Test4");
            }
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {

        }

        private void tbPage_client_Click(object sender, EventArgs e)
        {

        }

        private void btn_uploadImage_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image file..";
            ofd.DefaultExt = ".jpg";
            ofd.Filter = "Media Files|*.jpg;*.png;*.gif;*.bmp;*.jpeg|All Files|*.*";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txt_imagePath.Visible = true;
                lbl_imageStatus.Visible = true;

                txt_imagePath.Text = ofd.FileName;
                pb_clientImage.Load(ofd.FileName);
                lbl_imageStatus.Text = "Image Uploded";
                lbl_imageStatus.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void tbPage_activation_Click(object sender, EventArgs e)
        {
           
        }

        private void checkKeyValidation()
        {
            lbl_productNumber.Text = HardwareInfo.GetBoardProductId();
            KeyManager km = new KeyManager(lbl_productNumber.Text);
            LicenseInfo lic = new LicenseInfo();
            int value = km.LoadSuretyFile(string.Format(@"{0}\Key.lic", Application.StartupPath), ref lic);
            string productKey = lic.ProductKey;
            if (km.ValidKey(ref productKey))
            {
                KeyValuesClass kv = new KeyValuesClass();
                if (km.DisassembleKey(productKey, ref kv))
                {
                    lbl_productName.Text = Properties.Settings.Default.ProductName;
                    lbl_productKey.Text = productKey;
                    if (kv.Type == LicenseType.TRIAL)
                    {
                        Int32 expiaryDaycount = Convert.ToInt32((kv.Expiration - DateTime.Now.Date).Days);
                        lbl_activationDayCount.Text = string.Format("{0} days", (kv.Expiration - DateTime.Now.Date).Days);
                        lbl_activationStatus.Text = "This Product Activation key will Expire in";
                        lbl_licenseType.Text = "Trial";

                        if (expiaryDaycount <= 0)
                        {
                            lbl_activationStatus.Text = "Please Activate your Product";
                        }
                    }
                    else
                    {
                        lbl_licenseType.Text = "Full";
                    }
                }
            }
        }

        private void tb_setting_Click(object sender, EventArgs e)
        {
            lbl_productNumber.Text = HardwareInfo.GetBoardProductId();
            checkKeyValidation();
        }

        private void tb_setting_TabIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void tb_setting_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (tbPage_client == tb_setting.SelectedTab)
            {
                btn_save.Visible = true;
                btn_restore.Visible = false;
            }
            else if (tbPage_customerLoyality == tb_setting.SelectedTab)
            {
                btn_save.Visible = true;
                btn_restore.Visible = true;
            }
            else if (tbPage_print == tb_setting.SelectedTab)
            {
                btn_save.Visible = true;
                btn_restore.Visible = true;
            }
            else
            {
                btn_save.Visible = false;
                btn_restore.Visible = false;
            }
        }
    }
}
