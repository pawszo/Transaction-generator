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
    partial class Window : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.treatmentCode = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.minAmountAbs = new System.Windows.Forms.TextBox();
            this.maxAmountAbsGrp = new System.Windows.Forms.GroupBox();
            this.maxAmountAbs = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.voucher_no_max = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.voucher_no_min = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.client = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.currency = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.connectionString = new System.Windows.Forms.RichTextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.status = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.fileCheckbox = new System.Windows.Forms.CheckBox();
            this.voucherTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.arRadio = new System.Windows.Forms.RadioButton();
            this.apRadio = new System.Windows.Forms.RadioButton();
            this.taxOnlyRadio = new System.Windows.Forms.RadioButton();
            this.glRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.bankStatNumberBox = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.bankNameBox = new System.Windows.Forms.TextBox();
            this.bankStatementBox = new System.Windows.Forms.CheckBox();
            this.cashbookBox = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.maxAmountAbsGrp.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.voucherTypeGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Transaction Generator v1.1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.treatmentCode);
            this.groupBox2.Location = new System.Drawing.Point(266, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(50, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Treat code";
            // 
            // treatmentCode
            // 
            this.treatmentCode.Location = new System.Drawing.Point(6, 37);
            this.treatmentCode.Name = "treatmentCode";
            this.treatmentCode.Size = new System.Drawing.Size(38, 23);
            this.treatmentCode.TabIndex = 0;
            this.treatmentCode.Text = "1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.minAmountAbs);
            this.groupBox3.Location = new System.Drawing.Point(21, 328);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(133, 61);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Min transaction amount";
            // 
            // minAmountAbs
            // 
            this.minAmountAbs.Location = new System.Drawing.Point(7, 33);
            this.minAmountAbs.Name = "minAmountAbs";
            this.minAmountAbs.Size = new System.Drawing.Size(120, 23);
            this.minAmountAbs.TabIndex = 0;
            this.minAmountAbs.Text = "100";
            // 
            // maxAmountAbsGrp
            // 
            this.maxAmountAbsGrp.Controls.Add(this.maxAmountAbs);
            this.maxAmountAbsGrp.Location = new System.Drawing.Point(189, 328);
            this.maxAmountAbsGrp.Name = "maxAmountAbsGrp";
            this.maxAmountAbsGrp.Size = new System.Drawing.Size(133, 61);
            this.maxAmountAbsGrp.TabIndex = 5;
            this.maxAmountAbsGrp.TabStop = false;
            this.maxAmountAbsGrp.Text = "Max transaction amount";
            // 
            // maxAmountAbs
            // 
            this.maxAmountAbs.Location = new System.Drawing.Point(7, 33);
            this.maxAmountAbs.Name = "maxAmountAbs";
            this.maxAmountAbs.Size = new System.Drawing.Size(120, 23);
            this.maxAmountAbs.TabIndex = 0;
            this.maxAmountAbs.Text = "20000";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.voucher_no_max);
            this.groupBox4.Location = new System.Drawing.Point(189, 277);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(133, 45);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Last voucher_no";
            // 
            // voucher_no_max
            // 
            this.voucher_no_max.Location = new System.Drawing.Point(6, 16);
            this.voucher_no_max.Name = "voucher_no_max";
            this.voucher_no_max.Size = new System.Drawing.Size(120, 23);
            this.voucher_no_max.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.voucher_no_min);
            this.groupBox5.Location = new System.Drawing.Point(21, 277);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(133, 45);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "First voucher_no";
            // 
            // voucher_no_min
            // 
            this.voucher_no_min.Location = new System.Drawing.Point(6, 16);
            this.voucher_no_min.Name = "voucher_no_min";
            this.voucher_no_min.Size = new System.Drawing.Size(120, 23);
            this.voucher_no_min.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.client);
            this.groupBox6.Location = new System.Drawing.Point(189, 399);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(133, 45);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Client";
            // 
            // client
            // 
            this.client.Location = new System.Drawing.Point(6, 16);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(120, 23);
            this.client.TabIndex = 0;
            this.client.Text = "EN";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.currency);
            this.groupBox7.Location = new System.Drawing.Point(21, 399);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(133, 45);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Currency";
            // 
            // currency
            // 
            this.currency.Location = new System.Drawing.Point(6, 16);
            this.currency.Name = "currency";
            this.currency.Size = new System.Drawing.Size(120, 23);
            this.currency.TabIndex = 0;
            this.currency.Text = "GBP";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.connectionString);
            this.groupBox8.Location = new System.Drawing.Point(21, 520);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(301, 100);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Connection string";
            // 
            // connectionString
            // 
            this.connectionString.Location = new System.Drawing.Point(6, 23);
            this.connectionString.Name = "connectionString";
            this.connectionString.Size = new System.Drawing.Size(288, 71);
            this.connectionString.TabIndex = 0;
            this.connectionString.Text = "Server=PLWR-L06236; Database=u4erp; Integrated Security=True;";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(81, 639);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(176, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.status);
            this.groupBox9.Location = new System.Drawing.Point(21, 668);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(301, 45);
            this.groupBox9.TabIndex = 11;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Status";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(7, 19);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(39, 15);
            this.status.TabIndex = 0;
            this.status.Text = "Ready";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.browseButton);
            this.groupBox10.Controls.Add(this.fileTextBox);
            this.groupBox10.Controls.Add(this.fileCheckbox);
            this.groupBox10.Location = new System.Drawing.Point(21, 457);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(301, 48);
            this.groupBox10.TabIndex = 10;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Save insertion script as asq file in location";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(259, 18);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(36, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(82, 19);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(171, 23);
            this.fileTextBox.TabIndex = 1;
            // 
            // fileCheckbox
            // 
            this.fileCheckbox.AutoSize = true;
            this.fileCheckbox.Checked = true;
            this.fileCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fileCheckbox.Location = new System.Drawing.Point(6, 23);
            this.fileCheckbox.Name = "fileCheckbox";
            this.fileCheckbox.Size = new System.Drawing.Size(68, 19);
            this.fileCheckbox.TabIndex = 0;
            this.fileCheckbox.Text = "Enabled";
            this.fileCheckbox.UseVisualStyleBackColor = true;
            this.fileCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // voucherTypeGroupBox
            // 
            this.voucherTypeGroupBox.Controls.Add(this.arRadio);
            this.voucherTypeGroupBox.Controls.Add(this.apRadio);
            this.voucherTypeGroupBox.Controls.Add(this.taxOnlyRadio);
            this.voucherTypeGroupBox.Controls.Add(this.glRadio);
            this.voucherTypeGroupBox.Location = new System.Drawing.Point(21, 71);
            this.voucherTypeGroupBox.Name = "voucherTypeGroupBox";
            this.voucherTypeGroupBox.Size = new System.Drawing.Size(239, 72);
            this.voucherTypeGroupBox.TabIndex = 12;
            this.voucherTypeGroupBox.TabStop = false;
            this.voucherTypeGroupBox.Text = "Type";
            // 
            // arRadio
            // 
            this.arRadio.AutoSize = true;
            this.arRadio.Enabled = false;
            this.arRadio.Location = new System.Drawing.Point(128, 22);
            this.arRadio.Name = "arRadio";
            this.arRadio.Size = new System.Drawing.Size(93, 19);
            this.arRadio.TabIndex = 2;
            this.arRadio.TabStop = true;
            this.arRadio.Text = "AR (acrtrans)";
            this.arRadio.UseVisualStyleBackColor = true;
            this.arRadio.CheckedChanged += new System.EventHandler(this.arRadio_CheckedChanged);
            // 
            // apRadio
            // 
            this.apRadio.AutoSize = true;
            this.apRadio.Checked = true;
            this.apRadio.Location = new System.Drawing.Point(7, 45);
            this.apRadio.Name = "apRadio";
            this.apRadio.Size = new System.Drawing.Size(93, 19);
            this.apRadio.TabIndex = 1;
            this.apRadio.TabStop = true;
            this.apRadio.Text = "AP (acrtrans)";
            this.apRadio.UseVisualStyleBackColor = true;
            // 
            // taxOnlyRadio
            // 
            this.taxOnlyRadio.AutoSize = true;
            this.taxOnlyRadio.Location = new System.Drawing.Point(7, 22);
            this.taxOnlyRadio.Name = "taxOnlyRadio";
            this.taxOnlyRadio.Size = new System.Drawing.Size(123, 19);
            this.taxOnlyRadio.TabIndex = 0;
            this.taxOnlyRadio.TabStop = true;
            this.taxOnlyRadio.Text = "Tax Only (acrtrans)";
            this.taxOnlyRadio.UseVisualStyleBackColor = true;
            // 
            // glRadio
            // 
            this.glRadio.AutoSize = true;
            this.glRadio.Location = new System.Drawing.Point(128, 45);
            this.glRadio.Name = "glRadio";
            this.glRadio.Size = new System.Drawing.Size(108, 19);
            this.glRadio.TabIndex = 13;
            this.glRadio.TabStop = true;
            this.glRadio.Text = "GL (agltransact)";
            this.glRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox12);
            this.groupBox1.Controls.Add(this.groupBox11);
            this.groupBox1.Controls.Add(this.bankStatementBox);
            this.groupBox1.Controls.Add(this.cashbookBox);
            this.groupBox1.Location = new System.Drawing.Point(21, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 121);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bank reconciliation";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.bankStatNumberBox);
            this.groupBox12.Location = new System.Drawing.Point(168, 28);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(121, 52);
            this.groupBox12.TabIndex = 4;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Number of lines";
            // 
            // bankStatNumberBox
            // 
            this.bankStatNumberBox.Enabled = false;
            this.bankStatNumberBox.Location = new System.Drawing.Point(8, 15);
            this.bankStatNumberBox.Name = "bankStatNumberBox";
            this.bankStatNumberBox.Size = new System.Drawing.Size(100, 23);
            this.bankStatNumberBox.TabIndex = 0;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.bankNameBox);
            this.groupBox11.Location = new System.Drawing.Point(7, 72);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(287, 43);
            this.groupBox11.TabIndex = 3;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Bank name";
            // 
            // bankNameBox
            // 
            this.bankNameBox.Enabled = false;
            this.bankNameBox.Location = new System.Drawing.Point(6, 14);
            this.bankNameBox.Name = "bankNameBox";
            this.bankNameBox.Size = new System.Drawing.Size(275, 23);
            this.bankNameBox.TabIndex = 2;
            this.bankNameBox.Text = "NATWEST";
            // 
            // bankStatementBox
            // 
            this.bankStatementBox.AutoSize = true;
            this.bankStatementBox.Location = new System.Drawing.Point(6, 47);
            this.bankStatementBox.Name = "bankStatementBox";
            this.bankStatementBox.Size = new System.Drawing.Size(138, 19);
            this.bankStatementBox.TabIndex = 1;
            this.bankStatementBox.Text = "Add bank statements";
            this.bankStatementBox.UseVisualStyleBackColor = true;
            this.bankStatementBox.CheckedChanged += new System.EventHandler(this.bankStatementBox_CheckedChanged);
            // 
            // cashbookBox
            // 
            this.cashbookBox.AutoSize = true;
            this.cashbookBox.Location = new System.Drawing.Point(7, 16);
            this.cashbookBox.Name = "cashbookBox";
            this.cashbookBox.Size = new System.Drawing.Size(144, 19);
            this.cashbookBox.TabIndex = 0;
            this.cashbookBox.Text = "Add cashbook records";
            this.cashbookBox.UseVisualStyleBackColor = true;
            this.cashbookBox.CheckedChanged += new System.EventHandler(this.cashbookBox_CheckedChanged);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 725);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.voucherTypeGroupBox);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.maxAmountAbsGrp);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Name = "Window";
            this.Text = "Transaction generator";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.maxAmountAbsGrp.ResumeLayout(false);
            this.maxAmountAbsGrp.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.voucherTypeGroupBox.ResumeLayout(false);
            this.voucherTypeGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private GroupBox groupBox2;
        private TextBox treatmentCode;
        private GroupBox groupBox3;
        private TextBox minAmountAbs;
        private GroupBox maxAmountAbsGrp;
        private TextBox maxAmountAbs;
        private GroupBox groupBox4;
        private TextBox voucher_no_max;
        private GroupBox groupBox5;
        private TextBox voucher_no_min;
        private GroupBox groupBox6;
        private TextBox client;
        private GroupBox groupBox7;
        private TextBox currency;
        private GroupBox groupBox8;
        private RichTextBox connectionString;
        private Button startButton;
        private GroupBox groupBox9;
        private Label status;
        private GroupBox groupBox10;
        public TextBox fileTextBox;
        public CheckBox fileCheckbox;
        private Button browseButton;
        private GroupBox voucherTypeGroupBox;
        private RadioButton arRadio;
        private RadioButton apRadio;
        private RadioButton taxOnlyRadio;
        private RadioButton glRadio;
        private GroupBox groupBox1;
        private CheckBox bankStatementBox;
        private CheckBox cashbookBox;
        private TextBox bankNameBox;
        private GroupBox groupBox12;
        private TextBox bankStatNumberBox;
        private GroupBox groupBox11;
    }
}

