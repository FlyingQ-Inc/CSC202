namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;       //String storing user input
        string operand1 = string.Empty;    //String storing first operand
        string operand2 = string.Empty;    //String storing second operand
        char operation;                    //Character for operation
        double result = 0.0;               //Result of calculation

        public Form1()
        {
            InitializeComponent();
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";            //Clears the text box before displaying the input
            input += "0";
            this.textBox1.Text += input;        //Displays the input in the text box
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";            //Clears the text box before displaying the input
            input += ".";
            this.textBox1.Text += input;        //Displays the input in the text box
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";            //Clears the text box
            this.input = string.Empty;          //Clears the input string
            this.operand1 = string.Empty;       //Clears the first operand
            this.operand2 = string.Empty;       //Clears the second operand
        }

        private void One_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";            //Clears the text box before displaying the input
            input += "1";                       //+= is a shortcut for input = input + "1"
            this.textBox1.Text += input;        //Displays the input in the text box
        }

        private void Two_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";            //Clears the text box before displaying the input
            input += "2";
            this.textBox1.Text += input;        //Displays the input in the text box
        }

        private void Three_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";            //Clears the text box before displaying the input
            input += "3";
            this.textBox1.Text += input;        //Displays the input in the text box
        }

        private void Four_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";            //Clears the text box before displaying the input
            input += "4";
            this.textBox1.Text += input;        //Displays the input in the text box
        }

        private void Five_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";            //Clears the text box before displaying the input
            input += "5";
            this.textBox1.Text += input;        //Displays the input in the text box
        }

        private void Six_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";            //Clears the text box before displaying the input
            input += "6";
            this.textBox1.Text += input;        //Displays the input in the text box
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";            //Clears the text box before displaying the input
            input += "7";
            this.textBox1.Text += input;        //Displays the input in the text box
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";            //Clears the text box before displaying the input
            input += "8";
            this.textBox1.Text += input;        //Displays the input in the text box
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";            //Clears the text box before displaying the input
            input += "9";
            this.textBox1.Text += input;        //Displays the input in the text box
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            operand1 = input;           //stores contents of input in operand1
            operation = '-';            //sets operation to subtraction
            input = string.Empty;       //clears input to be ready for next user input
        }

        private void Add_Click(object sender, EventArgs e)
        {
            operand1 = input;           //stores contents of input in operand1
            operation = '+';            //sets operation to addition
            input = string.Empty;       //clears input to be ready for next user input
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            operand1 = input;           //stores contents of input in operand1
            operation = '*';            //sets operation to multiplication
            input = string.Empty;       //clears input to be ready for next user input
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            operand1 = input;           //stores contents of input in operand1
            operation = '/';            //sets operation to division
            input = string.Empty;       //clears input to be ready for next user input
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            operand2 = input;           // stores contents of input in operand2
            double num1, num2;          // variables to store the operands as doubles
            double.TryParse(operand1, out num1);  // converts operand1 to double and stores in num1
            double.TryParse(operand2, out num2);  // converts operand2 to double and stores in num2

            //the following block of code needed to be added after initial debug, the text box did not clear after the result was displayed
            this.textBox1.Text = "";    // clears the text box
            this.input = string.Empty;  // clears the input string
            this.operand1 = string.Empty;  // clears the first operand
            this.operand2 = string.Empty;  // clears the second operand


            if (operation == '+')           // checks if operation is addition
            {
                result = num1 + num2;       // adds num1 and num2 and stores in result
                textBox1.Text = result.ToString();  // displays result in text box
            }
            else if (operation == '-')      // checks if operation is subtraction
            {
                result = num1 - num2;       // subtracts num2 from num1 and stores in result
                textBox1.Text = result.ToString();  // displays result in text box
            }
            else if (operation == '*')      // checks if operation is multiplication
            {
                result = num1 * num2;       // multiplies num1 and num2 and stores in result
                textBox1.Text = result.ToString();  // displays result in text box
            }
            else if (operation == '/')      // checks if operation is division
            {
                if (num2 != 0)              // checks if num2 is not zero
                {
                    result = num1 / num2;   // divides num1 by num2 and stores in result
                    textBox1.Text = result.ToString();  // displays result in text box
                }
                else
                {
                    textBox1.Text = "DIV/Zero!";    // displays error message if num2 is zero
                }
            }
        }
    }
}
