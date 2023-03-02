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
    public partial class frmActivationInfo : Form
    {
        private FormMovable formMove;
        const int ProductCode = 1;
        public frmActivationInfo()
        {
            InitializeComponent();

            formMove = new FormMovable(this);
            formMove.SetMovable(pnl_head, lbl_title);
        }

        private void frmActivationInfo_Load(object sender, EventArgs e)
        {
            lbl_productNumber.Text = HardwareInfo.GetBoardProductId();
            checkKeyValidation();
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
                        Int32 expiaryDaycount =Convert.ToInt32((kv.Expiration - DateTime.Now.Date).Days);
                        lbl_activationDayCount.Text = string.Format("{0} days", (kv.Expiration - DateTime.Now.Date).Days);
                        lbl_activationStatus.Text = "This Product Activation key will Expire in";
                        lbl_licenseType.Text = "Trial";

                        if(expiaryDaycount<=0)
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

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gb_activation_Enter(object sender, EventArgs e)
        {

        }
    }
}
