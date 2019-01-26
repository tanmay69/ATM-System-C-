using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Enter Your Pin Number");
            lblBalance.Visible = false;
            lblLoan.Visible = false;
            lblDeposit.Visible = false;
            lblWithdrawal.Visible = false;
            tabControl1.Visible = false;

            btnLoan.Enabled = false;
            btnDeposit.Enabled = false;
            btnWithdrawal.Enabled = false;
            btnBalanc.Enabled = false;

            btnLoanSystem.Enabled = false;
            btnReceipt.Enabled = false;
            btnReset.Enabled = false;
            btnExit.Enabled = false;
            btnTransfer.Enabled = false;

            lblIFSC.Visible = false;
            lblCode.Visible = false;
            txtCode.Visible = false;
            lblMoneyAmount.Visible = false;
            lblRs.Visible = false;
            txtAmount.Visible = false;
            btnSubmit.Enabled = false;

            lblIFSC1.Visible = false;
            lblCode1.Visible = false;
            txtCode1.Visible = false;
            lblMoneyAmount1.Visible = false;
            lblRs1.Visible = false;
            txtAmount1.Visible = false;
            btnSubmit1.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "2";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "7";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "6";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Are you sure you want to exit", "ATM System", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            lblPin.Text = "";
            lblBalance.Visible = false;
            lblLoan.Visible = false;
            lblDeposit.Visible = false;
            lblWithdrawal.Visible = false;

            btnLoan.Enabled = false;
            btnDeposit.Enabled = false;
            btnWithdrawal.Enabled = false;
            btnBalanc.Enabled = false;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            String pin1 = String.Format(lblPin.Text);
            if (pin1 == "6969")
            {
                lblBalance.Visible = true;
                lblLoan.Visible = true;
                lblDeposit.Visible = true;
                lblWithdrawal.Visible = true;

                btnLoan.Enabled = true;
                btnDeposit.Enabled = true;
                btnWithdrawal.Enabled = true;
                btnBalanc.Enabled = true;
            }
            else
            {
                MessageBox.Show("Invalid Pin");
                lblPin.Text = "";
            }
        }

        private void btnLoanSystem_Click(object sender, EventArgs e)
        {
            Loan l = new Loan(Convert.ToDouble(txtInterestRate.Text), Convert.ToInt32(txtNumberOfYears.Text), Convert.ToInt32(txtAmountOfLoan.Text));

            lblMonthlyPayment.Text = l.monthlyPaymentInString();

            lblTotalPayment.Text = l.totalPaymentInString();

            txtAmountOfLoan.Text = l.loanAmountInString();
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            rtfReceipt.AppendText("Loan Manaagement Systems Calculator" + "\n");
            rtfReceipt.AppendText("----------------------------------------------------------------" + "\n");
            rtfReceipt.AppendText("Enter Amount of Loan" + "\t" + txtAmountOfLoan.Text + "\n");
            rtfReceipt.AppendText("Enter Number of years" + "\t" + txtNumberOfYears.Text + "\n");
            rtfReceipt.AppendText("Enter Interest Rate" + "\t" + "\t" + txtInterestRate.Text + "\n");
            rtfReceipt.AppendText("Monthly Payment" + "\t" + "\t" + lblMonthlyPayment.Text + "\n");
            rtfReceipt.AppendText("Total Payment" + "\t" + "\t" + "\t" + lblTotalPayment.Text + "\n");
            rtfReceipt.AppendText("----------------------------------------------------------------" + "\n");
            rtfReceipt.AppendText("-----------------------------Thank You------------------" + "\n");

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtfReceipt.Text, new Font("Callibri", 25), Brushes.Black, new PointF(0, 400));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            this.tabControl1.SelectedTab = tabPage1;
            btnLoanSystem.Enabled = true;
            btnReceipt.Enabled = true;
            btnReset.Enabled = true;
            btnExit.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Are you sure you want to exit", "ATM System", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountOfLoan.Clear();
            txtNumberOfYears.Clear();
            txtInterestRate.Clear();
            lblMonthlyPayment.Text = "";
            lblTotalPayment.Text = "";
            rtfReceipt.Clear();
        }

        private void btnWtdAmt_Click(object sender, EventArgs e)
        {
            double balance = double.Parse("12000");
            double am = double.Parse("0");
            am = double.Parse(txtWtdAmt.Text);
            balance = balance - am;
            MessageBox.Show("Amount Withdrawn");
            lblResult.Text = "Your Remaing Balance is:" + balance.ToString("");

        }

        private void btnBlc_Click(object sender, EventArgs e)
        {
            

        }

        private void btnBal_Click(object sender, EventArgs e)
        {
            double balance = double.Parse("12000");
            double am = double.Parse("0");
            lblBalc.Text = "You Current Balance in your account is:" + balance.ToString("");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnBalanc_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            this.tabControl1.SelectedTab = tabPage2;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            this.tabControl1.SelectedTab = tabPage3;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            this.tabControl1.SelectedTab = tabPage4;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

             double balance = double.Parse("12000");
             double am = double.Parse("0");

            am = double.Parse(txtAmount.Text);
            balance = balance - am;
            result.Text = "Successfully Transfered! Your Remaining Balance is:" + balance.ToString("");
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            this.tabControl1.SelectedTab = tabPage4;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            String CodeAmt = String.Format(txtCode.Text);
            if (radioButtonICICI.Checked = true && CodeAmt == "1111")
            {
                btnTransfer.Enabled = true;
            }
            if (radioButtonHDFC.Checked = true && CodeAmt == "2222")
            {
                btnTransfer.Enabled = true;
            }
            if (radioButtonPNB.Checked = true && CodeAmt == "3333")
            {
                btnTransfer.Enabled = true;
            }
            if (radioButtonBOB.Checked = true && CodeAmt == "4444")
            {
                btnTransfer.Enabled = true;
            }
            if (radioButtonAB.Checked = true && CodeAmt == "5555")
            {
                btnTransfer.Enabled = true;
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            this.tabControl1.SelectedTab = tabPage5;
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            String acc = String.Format(txtAcc.Text);
            if (radioButtonICICI.Checked = true && acc == "999999")
            {
                lblIFSC.Visible = true;
                lblCode.Visible = true;
                txtCode.Visible = true;
                lblMoneyAmount.Visible = true;
                lblRs.Visible = true;
                txtAmount.Visible = true;
                btnSubmit.Enabled = true;
            }
            if (radioButtonHDFC.Checked = true && acc == "888888")
            {
                lblIFSC.Visible = true;
                lblCode.Visible = true;
                txtCode.Visible = true;
                lblMoneyAmount.Visible = true;
                lblRs.Visible = true;
                txtAmount.Visible = true;
                btnSubmit.Enabled = true;
            }
            if (radioButtonPNB.Checked = true && acc == "777777")
            {
                lblIFSC.Visible = true;
                lblCode.Visible = true;
                txtCode.Visible = true;
                lblMoneyAmount.Visible = true;
                lblRs.Visible = true;
                txtAmount.Visible = true;
                btnSubmit.Enabled = true;
            }
            if (radioButtonSBI.Checked = true && acc == "666666")
            {
                lblIFSC.Visible = true;
                lblCode.Visible = true;
                txtCode.Visible = true;
                lblMoneyAmount.Visible = true;
                lblRs.Visible = true;
                txtAmount.Visible = true;
                btnSubmit.Enabled = true;
            }
            if (radioButtonBOB.Checked = true && acc == "555555")
            {
                lblIFSC.Visible = true;
                lblCode.Visible = true;
                txtCode.Visible = true;
                lblMoneyAmount.Visible = true;
                lblRs.Visible = true;
                txtAmount.Visible = true;
                btnSubmit.Enabled = true;
            }
            if (radioButtonAB.Checked = true && acc == "444444")
            {
                lblIFSC.Visible = true;
                lblCode.Visible = true;
                txtCode.Visible = true;
                lblMoneyAmount.Visible = true;
                lblRs.Visible = true;
                txtAmount.Visible = true;
                btnSubmit.Enabled = true;
            }
        }

        private void button11_Click_2(object sender, EventArgs e)
        {
            String acc1 = String.Format(txtAcc.Text);
            if (radioButtonICICI1.Checked = true && acc1 == "999999")
            {
                lblIFSC1.Visible = true;
                lblCode1.Visible = true;
                txtCode1.Visible = true;
                lblMoneyAmount1.Visible = true;
                lblRs1.Visible = true;
                txtAmount1.Visible = true;
                btnSubmit1.Enabled = true;
            }
            if (radioButtonHDFC1.Checked = true && acc1 == "888888")
            {
                lblIFSC1.Visible = true;
                lblCode1.Visible = true;
                txtCode1.Visible = true;
                lblMoneyAmount1.Visible = true;
                lblRs1.Visible = true;
                txtAmount1.Visible = true;
                btnSubmit1.Enabled = true;
            }
            if (radioButtonPNB1.Checked = true && acc1 == "777777")
            {
                lblIFSC1.Visible = true;
                lblCode1.Visible = true;
                txtCode1.Visible = true;
                lblMoneyAmount1.Visible = true;
                lblRs1.Visible = true;
                txtAmount1.Visible = true;
                btnSubmit1.Enabled = true;
            }
            if (radioButtonSBI1.Checked = true && acc1 == "666666")
            {
                lblIFSC1.Visible = true;
                lblCode1.Visible = true;
                txtCode1.Visible = true;
                lblMoneyAmount1.Visible = true;
                lblRs1.Visible = true;
                txtAmount1.Visible = true;
                btnSubmit1.Enabled = true;
            }
            if (radioButtonBOB1.Checked = true && acc1 == "555555")
            {
                lblIFSC1.Visible = true;
                lblCode1.Visible = true;
                txtCode1.Visible = true;
                lblMoneyAmount1.Visible = true;
                lblRs1.Visible = true;
                txtAmount1.Visible = true;
                btnSubmit1.Enabled = true;
            }
            if (radioButtonAB1.Checked = true && acc1 == "444444")
            {
                lblIFSC1.Visible = true;
                lblCode1.Visible = true;
                txtCode1.Visible = true;
                lblMoneyAmount1.Visible = true;
                lblRs1.Visible = true;
                txtAmount1.Visible = true;
                btnSubmit1.Enabled = true;
            }
        }

        private void btnSubmit1_Click(object sender, EventArgs e)
        {
            String CodeAmt1 = String.Format(txtCode1.Text);
            if (radioButtonICICI1.Checked = true && CodeAmt1 == "1111")
            {
                btnDeposit1.Enabled = true;
            }
            if (radioButtonHDFC1.Checked = true && CodeAmt1 == "2222")
            {
                btnDeposit1.Enabled = true;
            }
            if (radioButtonPNB1.Checked = true && CodeAmt1 == "3333")
            {
                btnDeposit1.Enabled = true;
            }
            if (radioButtonBOB1.Checked = true && CodeAmt1 == "4444")
            {
                btnDeposit1.Enabled = true;
            }
            if (radioButtonAB1.Checked = true && CodeAmt1 == "5555")
            {
                btnDeposit1.Enabled = true;
            }
        }

        private void btnDeposit1_Click(object sender, EventArgs e)
        {
            double balance = double.Parse("12000");
            double am = double.Parse("0");

            am = double.Parse(txtAmount1.Text);
            balance = balance + am;
            result1.Text = "Successfully Deposited! Your Updated Balance is:" + balance.ToString("");
        }
    }
   }

