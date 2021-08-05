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
            else status.Text = string.Format("Inserted {0} invoices ({1} rows).", invoiceAndRowCount.Item1, invoiceAndRowCount.Item2);
        }

        private Type GetVoucherType(out string table)
        {
            if (taxOnlyRadio.Checked)
            {
                table = "acrtrans";
                return typeof(TaxOnlyVoucher);
            }
            else if (arRadio.Checked)
            {
                table = "acrtrans";
                return typeof(ARVoucher);
            }
            else if (glRadio.Checked)
            {
                table = "agltransact";
                return typeof(GLVoucher);
            }
            else
            {
                table = "acrtrans";
                return typeof(APVoucher);
            }
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            bool isDataOK = ValidateFields();
            if (isDataOK)
            {
                Generator_config config = new Generator_config();
                config.ConnectionString = connectionString.Text;
                config.VoucherType = GetVoucherType(out string table);
                config.Table = table;
                config.Client = client.Text;
                config.Currency = currency.Text;
                config.MaxAmountAbs = Decimal.Parse(maxAmountAbs.Text);
                config.MinAmountAbs = Decimal.Parse(minAmountAbs.Text);
                config.Treatment_code = treatmentCode.Text;
                config.Voucher_no_min = Int64.Parse(voucher_no_min.Text);
                config.Voucher_no_max = Int64.Parse(voucher_no_max.Text);
                config.FileMode = fileCheckbox.Checked;
                config.CashBook = cashbookBox.Checked;
                config.BankStatement = bankStatementBox.Checked;
                if (config.BankStatement)
                {
                    config.BankName = bankNameBox.Text;
                    config.BankStatementLines = Int32.Parse(bankStatNumberBox.Text);
                }
                SetStatus(Tuple.Create(0, 0));

                ToggleEnabled(false);
                await Task.Run(() => Controller.Run(config, this));
                status.Text += " Ready";
                ToggleEnabled(true);

            }
            else status.Text = "Validation failed. Review the input and start over.";

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
            groupBox10.Enabled = enabled;
            maxAmountAbsGrp.Enabled = enabled;
            voucherTypeGroupBox.Enabled = enabled;
        }
        private bool ValidateFields()
        {

            if(string.IsNullOrWhiteSpace(treatmentCode.Text) || treatmentCode.Text.Length < 1) return false;
            if (!Int64.TryParse(voucher_no_min.Text, out _) || !Int64.TryParse(voucher_no_max.Text, out _)) return false;
            if (!Double.TryParse(minAmountAbs.Text, out _) || !Double.TryParse(maxAmountAbs.Text, out _)) return false;
            if (string.IsNullOrWhiteSpace(client.Text) || client.Text.Length < 2) return false;
            if (string.IsNullOrWhiteSpace(currency.Text) || currency.Text.Length < 3) return false;
            if (!fileCheckbox.Checked && !DatabaseHandler.CheckConnection(connectionString.Text)) return false;
            if (fileCheckbox.Checked && !System.IO.Directory.Exists(fileTextBox.Text)) return false;
            if (bankStatementBox.Checked && !UInt32.TryParse(bankStatNumberBox.Text, out _)) return false;
            return true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (fileCheckbox.Checked)
            {
                fileTextBox.Enabled = true;
                browseButton.Enabled = true;
            }
            else
            {
                fileTextBox.Enabled = false;
                browseButton.Enabled = false;
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if(result == DialogResult.OK) fileTextBox.Text = dialog.SelectedPath;

        }

        private void arRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cashbookBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cashbookBox.Checked || bankStatementBox.Checked) bankNameBox.Enabled = true;
            else bankNameBox.Enabled = false;
        }

        private void bankStatementBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cashbookBox.Checked || bankStatementBox.Checked) bankNameBox.Enabled = true;
            else bankNameBox.Enabled = false;

            if (bankStatementBox.Checked) bankStatNumberBox.Enabled = true;
            else bankStatNumberBox.Enabled = false;
        }
    }
}
