using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransGenerator
{
    public partial class Window : Form
    {
        public Window(Controller controller)
        {
            Controller = controller;
            InitializeComponent();
        }
        public Controller Controller { get; private set; }
        public delegate void LabelDelegate(Tuple<int, int> invoiceAndRowCount);
        public void SetStatus(Tuple<int, int> invoiceAndRowCount)
        {
            if(status.InvokeRequired)
            {
                LabelDelegate ldel = new LabelDelegate(SetStatus);
                status.Invoke(ldel, invoiceAndRowCount);
            }
            else status.Text = string.Format("Inserted {0} invoices ({1} rows)", invoiceAndRowCount.Item1, invoiceAndRowCount.Item2);
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            bool isDataOK = ValidateFields();
            if (isDataOK)
            {
                Generator_config config = new Generator_config();
                config.ConnectionString = connectionString.Text;
                config.Client = client.Text;
                config.Currency = currency.Text;
                config.ImportType = registerRadio.Checked ? "REG" : "POS";
                config.MaxAmountAbs = Decimal.Parse(maxAmountAbs.Text);
                config.MinAmountAbs = Decimal.Parse(minAmountAbs.Text);
                config.Treatment_code = treatmentCode.Text;
                config.Voucher_no_min = Int32.Parse(voucher_no_min.Text);
                config.Voucher_no_max = Int32.Parse(voucher_no_max.Text);
                SetStatus(Tuple.Create(0, 0));
              
                ToggleEnabled(false);
                //await Controller.Run(config, this); //temp for debugging
                await Task.Run(() => Controller.Run(config, this));
                status.Text += " Ready";
                ToggleEnabled(true);
                
            }

        }
        private void ToggleEnabled(bool enabled)
        {
            startButton.Enabled = enabled;
            groupBox1.Enabled = enabled;
            groupBox2.Enabled = enabled;
            groupBox3.Enabled = enabled;
            groupBox4.Enabled = enabled;
            groupBox5.Enabled = enabled;
            groupBox6.Enabled = enabled;
            groupBox7.Enabled = enabled;
            groupBox8.Enabled = enabled;
            maxAmountAbsGrp.Enabled = enabled;
        }
        private bool ValidateFields()
        {
            //todo
            return true;
        }
    }
}
