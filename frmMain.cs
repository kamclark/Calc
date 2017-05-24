using System;
using System.Windows.Forms;

public class frmMain : Form
{
    private TextBox txtDisplay;
    private Button btnCalc;
    private Button btnNum1;
    private Button btnNum2;
    private Button btnNum3;
    private Button btnNum4;
    private Button btnNum5;
    private Button btnNum6;
    private Button btnNum7;
    private Button btnNum8;
    private Button btnNum9;
    private Button btnSub;
    private Button btnAdd;
    private Button btnDiv;
    private Button btnMult;
    private Button btnClearEntry;
    private Button btnClearData;
    private Button btnClose;
    private Button btnDecimal;
    private Button btnNum0;
    #region Windows Code
    private void InitializeComponent()
    {
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btnClearData = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(12, 22);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(250, 20);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(30, 189);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(105, 30);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "C&alculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnNum1
            // 
            this.btnNum1.ForeColor = System.Drawing.Color.Blue;
            this.btnNum1.Location = new System.Drawing.Point(12, 48);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(31, 30);
            this.btnNum1.TabIndex = 2;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.btnNum1_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.ForeColor = System.Drawing.Color.Blue;
            this.btnNum2.Location = new System.Drawing.Point(49, 48);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(31, 30);
            this.btnNum2.TabIndex = 3;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.btnNum2_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.ForeColor = System.Drawing.Color.Blue;
            this.btnNum3.Location = new System.Drawing.Point(86, 48);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(31, 30);
            this.btnNum3.TabIndex = 4;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.btnNum3_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.ForeColor = System.Drawing.Color.Blue;
            this.btnNum4.Location = new System.Drawing.Point(12, 84);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(31, 30);
            this.btnNum4.TabIndex = 5;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.btnNum4_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.ForeColor = System.Drawing.Color.Blue;
            this.btnNum5.Location = new System.Drawing.Point(49, 84);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(31, 30);
            this.btnNum5.TabIndex = 6;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.btnNum5_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.ForeColor = System.Drawing.Color.Blue;
            this.btnNum6.Location = new System.Drawing.Point(86, 84);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(31, 30);
            this.btnNum6.TabIndex = 7;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.btnNum6_Click);
            // 
            // btnNum7
            // 
            this.btnNum7.ForeColor = System.Drawing.Color.Blue;
            this.btnNum7.Location = new System.Drawing.Point(12, 120);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(31, 30);
            this.btnNum7.TabIndex = 8;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            this.btnNum7.Click += new System.EventHandler(this.btnNum7_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.ForeColor = System.Drawing.Color.Blue;
            this.btnNum8.Location = new System.Drawing.Point(49, 120);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(31, 30);
            this.btnNum8.TabIndex = 9;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.btnNum8_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.ForeColor = System.Drawing.Color.Blue;
            this.btnNum9.Location = new System.Drawing.Point(86, 120);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(31, 30);
            this.btnNum9.TabIndex = 10;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            this.btnNum9.Click += new System.EventHandler(this.btnNum9_Click);
            // 
            // btnSub
            // 
            this.btnSub.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnSub.Location = new System.Drawing.Point(222, 48);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(31, 30);
            this.btnSub.TabIndex = 11;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.Location = new System.Drawing.Point(185, 48);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(31, 30);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnDiv.Location = new System.Drawing.Point(185, 84);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(31, 30);
            this.btnDiv.TabIndex = 13;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMult
            // 
            this.btnMult.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnMult.Location = new System.Drawing.Point(222, 84);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(31, 30);
            this.btnMult.TabIndex = 14;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.ForeColor = System.Drawing.Color.Blue;
            this.btnNum0.Location = new System.Drawing.Point(49, 153);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(31, 30);
            this.btnNum0.TabIndex = 11;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            this.btnNum0.Click += new System.EventHandler(this.btnNum0_Click);
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.ForeColor = System.Drawing.Color.Red;
            this.btnClearEntry.Location = new System.Drawing.Point(123, 84);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(31, 30);
            this.btnClearEntry.TabIndex = 16;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = true;
            this.btnClearEntry.Click += new System.EventHandler(this.btnClearEntry_Click);
            // 
            // btnClearData
            // 
            this.btnClearData.ForeColor = System.Drawing.Color.Red;
            this.btnClearData.Location = new System.Drawing.Point(123, 48);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(31, 30);
            this.btnClearData.TabIndex = 15;
            this.btnClearData.Text = "C";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(175, 189);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 30);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.ForeColor = System.Drawing.Color.Blue;
            this.btnDecimal.Location = new System.Drawing.Point(123, 120);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(31, 30);
            this.btnDecimal.TabIndex = 18;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(275, 225);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClearEntry);
            this.Controls.Add(this.btnClearData);
            this.Controls.Add(this.btnNum0);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnNum9);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.btnNum7);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtDisplay);
            this.Name = "frmMain";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

    }
    #endregion
    public frmMain()
    {
        InitializeComponent();
    }
    [STAThread]

        public static void Main()
    {
        frmMain main = new frmMain();
        Application.Run(main);
    }

    bool flag;
    bool repeatOperation = false;
    bool clearableDisplay = true;

    int operationState = 0;
    float inputNumber;
    float tempNum1;
    float tempNum2;
    float tempNum3;
    float result;

    private void ClearData()
    {
        tempNum1 = 0;
        tempNum2 = 0;
        tempNum3 = 0;
        result = 0;
        txtDisplay.Text = "0";
        clearableDisplay = true;
        btnAdd.Enabled = true;
        btnSub.Enabled = true;
        btnMult.Enabled = true;
        btnDiv.Enabled = true;
    }

    private void ClearEntry()
    {
        txtDisplay.Text = "";
    }

    private void UpdateDisplay()
    {
        //
    }

    private void UpdateInput()
    {
        float.TryParse(txtDisplay.Text, out inputNumber);
    }

    private void btnNum1_Click(object sender, EventArgs e)
    {
        if (clearableDisplay == true)
        {
            txtDisplay.Text = "";
        }
                clearableDisplay = false;
                txtDisplay.Text = txtDisplay.Text + "1";
                UpdateInput();

                btnCalc.Enabled = true;
    }

    private void btnNum2_Click(object sender, EventArgs e)
    {
            if (clearableDisplay == true)
            {
                txtDisplay.Text = "";
            }
            clearableDisplay = false;
            txtDisplay.Text = txtDisplay.Text + "2";
            UpdateInput();

            btnCalc.Enabled = true;
    }

    private void btnNum3_Click(object sender, EventArgs e)
    {
        if (clearableDisplay == true)
        {
            txtDisplay.Text = "";
        }
        clearableDisplay = false;
        txtDisplay.Text = txtDisplay.Text + "3";
        UpdateInput();

        btnCalc.Enabled = true;
    }

    private void btnNum4_Click(object sender, EventArgs e)
    {
        if (clearableDisplay == true)
        {
            txtDisplay.Text = "";
        }
        clearableDisplay = false;
        txtDisplay.Text = txtDisplay.Text + "4";
        UpdateInput();

        btnCalc.Enabled = true;
    }

    private void btnNum5_Click(object sender, EventArgs e)
    {
        if (clearableDisplay == true)
        {
            txtDisplay.Text = "";
        }
        clearableDisplay = false;
        txtDisplay.Text = txtDisplay.Text + "5";
        UpdateInput();

        btnCalc.Enabled = true;
    }

    private void btnNum6_Click(object sender, EventArgs e)
    {
        if (clearableDisplay == true)
        {
            txtDisplay.Text = "";
        }
        clearableDisplay = false;
        txtDisplay.Text = txtDisplay.Text + "6";
        UpdateInput();

        btnCalc.Enabled = true;
    }

    private void btnNum7_Click(object sender, EventArgs e)
    {
        if (clearableDisplay == true)
        {
            txtDisplay.Text = "";
        }
        clearableDisplay = false;
        txtDisplay.Text = txtDisplay.Text + "7";
        UpdateInput();

        btnCalc.Enabled = true;
    }

    private void btnNum8_Click(object sender, EventArgs e)
    {
        if (clearableDisplay == true)
        {
            txtDisplay.Text = "";
        }
        clearableDisplay = false;
        txtDisplay.Text = txtDisplay.Text + "8";
        UpdateInput();

        btnCalc.Enabled = true;
    }

    private void btnNum9_Click(object sender, EventArgs e)
    {
        if (clearableDisplay == true)
        {
            txtDisplay.Text = "";
        }
        clearableDisplay = false;
        txtDisplay.Text = txtDisplay.Text + "9";
        UpdateInput();

        btnCalc.Enabled = true;
    }

    private void btnNum0_Click(object sender, EventArgs e)
    {
        if (clearableDisplay == true)
        {
            txtDisplay.Text = "";
        }
        clearableDisplay = false;
        txtDisplay.Text = txtDisplay.Text + "0";
        UpdateInput();

        btnCalc.Enabled = true;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        operationState = 1;
        btnAdd.Enabled = false;
        btnSub.Enabled = true;
        btnMult.Enabled = true;
        btnDiv.Enabled = true;

        flag = float.TryParse(txtDisplay.Text, out tempNum1);
        if (flag == false)
        {
            btnAdd.Enabled = true;
            MessageBox.Show("Enter a number", "Input Error");
            txtDisplay.Focus();
            return;
        }

        clearableDisplay = true;
        btnCalc.Enabled = false;
    }

    private void btnClearData_Click(object sender, EventArgs e)
    {
        ClearData();
    }

    private void btnClearEntry_Click(object sender, EventArgs e)
    {
        ClearEntry();
    }

    private void btnCalc_Click(object sender, EventArgs e)
    {
        repeatOperation = false;

        flag = float.TryParse(txtDisplay.Text, out tempNum2);
        if (flag == false)
        {
            MessageBox.Show("Enter a number", "Input Error");
            txtDisplay.Focus();
            return;
        }

        if (repeatOperation == false)
        {
            tempNum3 = tempNum2;
            repeatOperation = false;
        }

        switch (operationState) // 
        {
            case 1:
                // addition
                if (repeatOperation == true)
                {
                   result = tempNum1 + tempNum3;
                }
                else
                {
                   result = tempNum1 + tempNum2;

                }
                result = tempNum1 + tempNum2;
                break;

            case 2:
                // subtraction
                result = tempNum1 - tempNum2;
                tempNum1 = result;
                break;

            case 3:
                // multiplication
                result = tempNum1 * tempNum2;
                tempNum1 = result;
                break;

            case 4:
                // division
                result = tempNum1 / tempNum2;
                tempNum1 = result;
                break;

            default:
                break;
        }
        txtDisplay.Text = result.ToString();

        btnAdd.Enabled = true;
        btnSub.Enabled = true;
        btnMult.Enabled = true;
        btnDiv.Enabled = true;
    }

    private void btnDiv_Click(object sender, EventArgs e)
    {
        operationState = 4;
        btnAdd.Enabled = true;
        btnSub.Enabled = true;
        btnMult.Enabled = true;
        btnDiv.Enabled = false;

        clearableDisplay = true;

        flag = float.TryParse(txtDisplay.Text, out tempNum1);
        if (flag == false)
        {
            btnDiv.Enabled = true;
            MessageBox.Show("Enter a number", "Input Error");
            txtDisplay.Focus();
            return;
        }

        flag = float.TryParse(txtDisplay.Text, out tempNum2);
        if (flag == false)
        {
            MessageBox.Show("Enter a number", "Input Error");
            txtDisplay.Focus();
            return;
        }
        btnCalc.Enabled = false;
    }

    private void btnSub_Click(object sender, EventArgs e)
    {
        operationState = 2;
        btnAdd.Enabled = true;
        btnSub.Enabled = false;
        btnMult.Enabled = true;
        btnDiv.Enabled = true;

        clearableDisplay = true;

        flag = float.TryParse(txtDisplay.Text, out tempNum1);
        if (flag == false)
        {
            btnSub.Enabled = true;
            MessageBox.Show("Enter a number", "Input Error");
            txtDisplay.Focus();
            return;
        }

        flag = float.TryParse(txtDisplay.Text, out tempNum2);
        if (flag == false)
        {
            MessageBox.Show("Enter a number", "Input Error");
            txtDisplay.Focus();
            return;
        }

        btnCalc.Enabled = false;
    }

    private void btnMult_Click(object sender, EventArgs e)
    {
        operationState = 3;
        btnAdd.Enabled = true;
        btnSub.Enabled = true;
        btnMult.Enabled = false;
        btnDiv.Enabled = true;

        clearableDisplay = true;

        flag = float.TryParse(txtDisplay.Text, out tempNum1);
        if (flag == false)
        {
            btnMult.Enabled = true;
            MessageBox.Show("Enter a number", "Input Error");
            txtDisplay.Focus();
            return;
        }

        flag = float.TryParse(txtDisplay.Text, out tempNum2);
        if (flag == false)
        {
            MessageBox.Show("Enter a number", "Input Error");
            txtDisplay.Focus();
            return;
        }
        btnCalc.Enabled = false;
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnDecimal_Click(object sender, EventArgs e)
    {
        if (clearableDisplay == true)
        {
            txtDisplay.Text = "";
        }
        clearableDisplay = false;
        txtDisplay.Text = txtDisplay.Text + ".";
        UpdateInput();
    }
}