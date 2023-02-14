using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Basic
{
    public partial class Form1 : Form
    {
        Product product = new Product();

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        public Form1()
        {
            InitializeComponent();
            AllocConsole();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbDetailNameValue.Text = "";
            lbDetailPriceValue.Text = "";
            lbDetailQtyValue.Text = "";
            lbTotalPriceValue.Text = "";
            lbTotalQtyValue.Text = "";
            this.ActiveControl = tbInputName;
        }
        private bool button_event(string btnName)
        {
            switch (btnName)
            {
                case "Add":
                    //string name = tbInputName.Text;
                    //string price = tbInputPrice.Text;
                    //string Qty = tbInputQty.Text;
                    //int priceVal = 0;
                    //int qtyVal = 0;
                    //if (!isEmpty(name) | !isEmpty(price) | !isEmpty(Qty))
                    //{
                    //    MessageBox.Show("Fill out all of space", "Error");
                    //    return false;
                    //}
                    //if (!int.TryParse(price, out priceVal))
                    //{
                    //    MessageBox.Show("Invalid Price", "Error");
                    //    return false;
                    //}
                    //if (!int.TryParse(Qty, out qtyVal))
                    //{
                    //    MessageBox.Show("Invalid Qty", "Error");
                    //    return false;
                    //}

                    //product.Name = name;
                    //product.Price = priceVal;
                    //product.Qty = qtyVal;
                    break;


                case "Detail":
                    break;
                case "Delete":
                    break;
                default: break;
            }
            return true;
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string btnName = btn.Name.Replace("btn", "");
            Console.WriteLine(btnName);
            button_event(btnName);


        }

        private bool isValidate(string value, string name)
        {
            if (Regex.Replace(value, @"\s", "").Length == 0)
            {
                return false;
            }
            if (name == "name")
            {
                //Regex regex = new System.Text.RegularExpressions.Regex(@"^[0-9a-zA-Z]{1,100}$");
            }
            else if (name == "price")
            {

            }
            else if (name == "Qty")
            {

            }
            return true;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Console.WriteLine(product.Name);
            Console.WriteLine(product.Price);
            Console.WriteLine(product.Qty);
        }
        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                //TextBox tb = (TextBox)sender;
                //if (!isEmpty(tb.Text))
                //{
                //    MessageBox.Show("Please fill out the space.");
                //    return;
                //}
                //if (!button_event("Add"))
                //{
                //    SendKeys.Send("{TAB}"); // key down tab
                //}
                
                //if(!isEmpty(tb.))
                //e.SuppressKeyPress = true; // remove beep sound
                //SendKeys.Send("{TAB}"); // key down tab
                 
            }

            Console.WriteLine(e.KeyData.ToString());
            //e.Handled= true;
        }
        
    }
}