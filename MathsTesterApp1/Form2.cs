using System;
using System.Drawing;
using System.Windows.Forms;

namespace MathsTesterApp1
{
    public partial class Form2 : Form
    {
        double value1 = 0;
        double value2 = 0;
        double result = 0;
        string operation = "";
        public Form2()
        {
            InitializeComponent();
           
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textValue1.Text = "";
            textValue2.Text = "";
            labelResult.Visible = false;

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            operation = "+";
            bool value1Ent = double.TryParse(textValue1.Text, out value1);
            bool value2Ent = double.TryParse(textValue2.Text, out value2);

            if (value1Ent && value2Ent)
            {
                switch (operation)
                {
                    case "+":
                        result = value1 + value2;
                        labelResult.Focus();
                        labelResult.ForeColor = Color.Purple;
                        labelResult.Text = result.ToString();
                        labelResult.Visible = true;
                        break;

                }
            }
            else
            {
                MessageBox.Show("Data given is invalid (non-numeric)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            operation = "*";
            
            bool value1Ent = double.TryParse(textValue1.Text, out value1);
            bool value2Ent = double.TryParse(textValue2.Text, out value2);

            if ((value1Ent && value2Ent))
            {
                switch (operation)
                {

                    case "*":
                        result = value1 * value2;
                        labelResult.Focus();
                        labelResult.ForeColor = Color.Purple;
                        labelResult.Text = result.ToString();
                        labelResult.Visible = true;
                        break;
                }
            }
            else
            {
                MessageBox.Show("Data given is invalid (non-numeric)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
      

        }

        private void textValue1_TextChanged(object sender, EventArgs e)
        {
            int textbox1 = 0;
            Int32.TryParse(textValue1.Text, out textbox1);
            if (textbox1 < 0 && textValue1.Text !="") 
            {
                labelResult.Visible = true;
                labelResult.ForeColor = Color.Red;
                labelResult.Text = "Error(Value must be > 0!)";
               
            }
        }

        private void textValue2_TextChanged(object sender, EventArgs e)
        {
            int textbox2 = 0;
            Int32.TryParse(textValue2.Text, out textbox2);
            if (textbox2 < 0 && textValue1.Text != "")
            {
                labelResult.Visible = true;
                labelResult.ForeColor = Color.Red;
                labelResult.Text = "Error(Value must be > 0)";
               
            }
        }
    }
}
