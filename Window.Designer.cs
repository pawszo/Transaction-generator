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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.registerRadio = new System.Windows.Forms.RadioButton();
            this.postRadio = new System.Windows.Forms.RadioButton();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.maxAmountAbsGrp.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 36);
            this.label1.Text = "Transaction Generator v1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.registerRadio);
            this.groupBox1.Controls.Add(this.postRadio);
            this.groupBox1.Location = new System.Drawing.Point(21, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = true;
            this.groupBox1.Size = new System.Drawing.Size(133, 44);
            this.groupBox1.Text = "Import type";
            // 
            // registerRadio
            // 
            this.registerRadio.AutoSize = true;
            this.registerRadio.Location = new System.Drawing.Point(87, 22);
            this.registerRadio.Name = "registerRadio";
            this.registerRadio.Size = new System.Drawing.Size(46, 19);
            this.registerRadio.Text = "REG";
            this.registerRadio.UseVisualStyleBackColor = true;
            // 
            // postRadio
            // 
            this.postRadio.AutoSize = true;
            this.postRadio.Location = new System.Drawing.Point(6, 22);
            this.postRadio.Name = "postRadio";
            this.postRadio.Size = new System.Drawing.Size(47, 19);
            this.postRadio.Text = "POS";
            this.postRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.treatmentCode);
            this.groupBox2.Location = new System.Drawing.Point(189, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = true;
            this.groupBox2.Size = new System.Drawing.Size(133, 44);
            this.groupBox2.Text = "Treatment code";
            // 
            // treatmentCode
            // 
            this.treatmentCode.Location = new System.Drawing.Point(6, 15);
            this.treatmentCode.Name = "treatmentCode";
            this.treatmentCode.Size = new System.Drawing.Size(121, 23);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.minAmountAbs);
            this.groupBox3.Location = new System.Drawing.Point(21, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = true;
            this.groupBox3.Size = new System.Drawing.Size(133, 61);
            this.groupBox3.Text = "Min transaction amount";
            // 
            // minAmountAbs
            // 
            this.minAmountAbs.Location = new System.Drawing.Point(7, 33);
            this.minAmountAbs.Name = "minAmountAbs";
            this.minAmountAbs.Size = new System.Drawing.Size(120, 23);
            this.minAmountAbs.Text = "100";
            // 
            // maxAmountAbsGrp
            // 
            this.maxAmountAbsGrp.Controls.Add(this.maxAmountAbs);
            this.maxAmountAbsGrp.Location = new System.Drawing.Point(189, 232);
            this.maxAmountAbsGrp.Name = "maxAmountAbsGrp";
            this.maxAmountAbsGrp.Size = new System.Drawing.Size(133, 61);
            this.maxAmountAbsGrp.TabIndex = 5;
            this.maxAmountAbsGrp.TabStop = true;
            this.maxAmountAbsGrp.Text = "Max transaction amount";
            // 
            // maxAmountAbs
            // 
            this.maxAmountAbs.Location = new System.Drawing.Point(7, 33);
            this.maxAmountAbs.Name = "maxAmountAbs";
            this.maxAmountAbs.Size = new System.Drawing.Size(120, 23);
            this.maxAmountAbs.Text = "20000";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.voucher_no_max);
            this.groupBox4.Location = new System.Drawing.Point(189, 166);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = true;
            this.groupBox4.Size = new System.Drawing.Size(133, 45);
            this.groupBox4.Text = "Last voucher_no";
            // 
            // voucher_no_max
            // 
            this.voucher_no_max.Location = new System.Drawing.Point(6, 16);
            this.voucher_no_max.Name = "voucher_no_max";
            this.voucher_no_max.Size = new System.Drawing.Size(120, 23);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.voucher_no_min);
            this.groupBox5.Location = new System.Drawing.Point(21, 166);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = true;
            this.groupBox5.Size = new System.Drawing.Size(133, 45);
            this.groupBox5.Text = "First voucher_no";
            // 
            // voucher_no_min
            // 
            this.voucher_no_min.Location = new System.Drawing.Point(6, 16);
            this.voucher_no_min.Name = "voucher_no_min";
            this.voucher_no_min.Size = new System.Drawing.Size(120, 23);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.client);
            this.groupBox6.Location = new System.Drawing.Point(189, 318);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = true;
            this.groupBox6.Size = new System.Drawing.Size(133, 45);
            this.groupBox6.Text = "Client";
            // 
            // client
            // 
            this.client.Location = new System.Drawing.Point(6, 16);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(120, 23);
            this.client.Text = "EN";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.currency);
            this.groupBox7.Location = new System.Drawing.Point(21, 318);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = true;
            this.groupBox7.Size = new System.Drawing.Size(133, 45);
            this.groupBox7.Text = "Currency";
            // 
            // currency
            // 
            this.currency.Location = new System.Drawing.Point(6, 16);
            this.currency.Name = "currency";
            this.currency.Size = new System.Drawing.Size(120, 23);
            this.currency.Text = "GBP";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.connectionString);
            this.groupBox8.Location = new System.Drawing.Point(21, 394);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = true;
            this.groupBox8.Size = new System.Drawing.Size(301, 100);
            this.groupBox8.Text = "Connection string";
            // 
            // connectionString
            // 
            this.connectionString.Location = new System.Drawing.Point(6, 23);
            this.connectionString.Name = "connectionString";
            this.connectionString.Size = new System.Drawing.Size(288, 71);

            this.connectionString.Text = @"Server=PLWR-L06236; Database=u4erp; Integrated Security=True;";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(85, 510);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(176, 23);
 
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.status);
            this.groupBox9.Location = new System.Drawing.Point(21, 544);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(301, 45);
            this.groupBox9.Text = "Status";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(7, 19);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(140, 15);
            this.status.Text = "Ready";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 601);
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
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Window";
            this.Text = "Transaction generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private GroupBox groupBox1;
        private RadioButton registerRadio;
        private RadioButton postRadio;
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
    }
}

