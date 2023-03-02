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

namespace vellsPos.Forms.Masters.Setting
{
    public partial class frmActivation : Form
    {
        private FormMovable formMove;
        const int ProductCode = 1;
        public frmActivation()
        {
            InitializeComponent();

            formMove = new FormMovable(this);
            formMove.SetMovable(pnl_head, lbl_title);
        }

        private void btn_active_Click(object sender, EventArgs e)
        {
            KeyManager keyManager = new KeyManager(txt_productNumber.Text);
            string productKey = txt_productKey.Text;
            if (keyManager.ValidKey(ref productKey))
            {
                KeyValuesClass keyValuesClass = new KeyValuesClass();
                if (keyManager.DisassembleKey(productKey, ref keyValuesClass))
                {
                    LicenseInfo lic = new LicenseInfo();
                    lic.ProductKey = productKey;
                    lic.FullName = Properties.Settings.Default.ProductName;
                    if (keyValuesClass.Type == LicenseType.TRIAL)
                    {
                        lic.Day = keyValuesClass.Expiration.Day;
                        lic.Month = keyValuesClass.Expiration.Month;
                        lic.Year = keyValuesClass.Expiration.Year;
                    }
                    keyManager.SaveSuretyFile(string.Format(@"{0}\Key.lic", Application.StartupPath), lic);
                    MessageBox.Show("You have been successfully registered.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Your product key is invalid. Try Again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                
        }

        private void frmActivations_Load(object sender, EventArgs e)
        {
            txt_productNumber.Text = HardwareInfo.GetBoardProductId();
            checkKeyValidation();


        }

        private void checkKeyValidation()
        {
            txt_productNumber.Text = HardwareInfo.GetBoardProductId();
            KeyManager km = new KeyManager(txt_productNumber.Text);
            LicenseInfo lic = new LicenseInfo();
            int value = km.LoadSuretyFile(string.Format(@"{0}\Key.lic", Application.StartupPath), ref lic);
            string productKey = lic.ProductKey;
            if (km.ValidKey(ref productKey))
            {
                KeyValuesClass kv = new KeyValuesClass();
                if (km.DisassembleKey(productKey, ref kv))
                {
                    //////lblProductName.Text = "FoxLearn";
                    txt_productKey.Text = productKey;
                    if (kv.Type == LicenseType.TRIAL)
                    {
                        lbl_activationDayCount.Text = string.Format("{0} days", (kv.Expiration - DateTime.Now.Date).Days);
                        lbl_activationStatus.Text = "This Product Activation key will Expire in";
                    }
                    else
                    {
                        lbl_activationStatus.Text = "Full";
                    }
                }              
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gb_activation_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmActivationInfo frmActivationInfo = new frmActivationInfo();
            frmActivationInfo.ShowDialog();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
