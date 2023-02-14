namespace Basic
{
    partial class Form1
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
            this.lbInputName = new System.Windows.Forms.Label();
            this.tbInputName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDetailQtyValue = new System.Windows.Forms.Label();
            this.lbDetailPriceValue = new System.Windows.Forms.Label();
            this.lbDetailNameValue = new System.Windows.Forms.Label();
            this.lbDetailName = new System.Windows.Forms.Label();
            this.lbDetailPrice = new System.Windows.Forms.Label();
            this.lbDetailQty = new System.Windows.Forms.Label();
            this.lbInputPrice = new System.Windows.Forms.Label();
            this.tbInputPrice = new System.Windows.Forms.TextBox();
            this.lbInputQty = new System.Windows.Forms.Label();
            this.tbInputQty = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbProductList = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTotalQtyValue = new System.Windows.Forms.Label();
            this.lbTotalPriceValue = new System.Windows.Forms.Label();
            this.lbTotalQty = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbInputName
            // 
            this.lbInputName.AutoSize = true;
            this.lbInputName.Location = new System.Drawing.Point(42, 43);
            this.lbInputName.Name = "lbInputName";
            this.lbInputName.Size = new System.Drawing.Size(59, 25);
            this.lbInputName.TabIndex = 0;
            this.lbInputName.Text = "Name";
            // 
            // tbInputName
            // 
            this.tbInputName.Location = new System.Drawing.Point(136, 40);
            this.tbInputName.Name = "tbInputName";
            this.tbInputName.Size = new System.Drawing.Size(150, 31);
            this.tbInputName.TabIndex = 1;
            this.tbInputName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbDetailQtyValue);
            this.panel1.Controls.Add(this.lbDetailPriceValue);
            this.panel1.Controls.Add(this.lbDetailNameValue);
            this.panel1.Controls.Add(this.lbDetailName);
            this.panel1.Controls.Add(this.lbDetailPrice);
            this.panel1.Controls.Add(this.lbDetailQty);
            this.panel1.Location = new System.Drawing.Point(610, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 112);
            this.panel1.TabIndex = 3;
            // 
            // lbDetailQtyValue
            // 
            this.lbDetailQtyValue.AutoSize = true;
            this.lbDetailQtyValue.Location = new System.Drawing.Point(142, 74);
            this.lbDetailQtyValue.Name = "lbDetailQtyValue";
            this.lbDetailQtyValue.Size = new System.Drawing.Size(53, 25);
            this.lbDetailQtyValue.TabIndex = 0;
            this.lbDetailQtyValue.Text = "value";
            // 
            // lbDetailPriceValue
            // 
            this.lbDetailPriceValue.AutoSize = true;
            this.lbDetailPriceValue.Location = new System.Drawing.Point(142, 40);
            this.lbDetailPriceValue.Name = "lbDetailPriceValue";
            this.lbDetailPriceValue.Size = new System.Drawing.Size(53, 25);
            this.lbDetailPriceValue.TabIndex = 0;
            this.lbDetailPriceValue.Text = "value";
            // 
            // lbDetailNameValue
            // 
            this.lbDetailNameValue.AutoSize = true;
            this.lbDetailNameValue.Location = new System.Drawing.Point(142, 6);
            this.lbDetailNameValue.Name = "lbDetailNameValue";
            this.lbDetailNameValue.Size = new System.Drawing.Size(53, 25);
            this.lbDetailNameValue.TabIndex = 0;
            this.lbDetailNameValue.Text = "value";
            // 
            // lbDetailName
            // 
            this.lbDetailName.AutoSize = true;
            this.lbDetailName.Location = new System.Drawing.Point(15, 6);
            this.lbDetailName.Name = "lbDetailName";
            this.lbDetailName.Size = new System.Drawing.Size(73, 25);
            this.lbDetailName.TabIndex = 0;
            this.lbDetailName.Text = "Name : ";
            // 
            // lbDetailPrice
            // 
            this.lbDetailPrice.AutoSize = true;
            this.lbDetailPrice.Location = new System.Drawing.Point(15, 40);
            this.lbDetailPrice.Name = "lbDetailPrice";
            this.lbDetailPrice.Size = new System.Drawing.Size(58, 25);
            this.lbDetailPrice.TabIndex = 0;
            this.lbDetailPrice.Text = "Price :";
            // 
            // lbDetailQty
            // 
            this.lbDetailQty.AutoSize = true;
            this.lbDetailQty.Location = new System.Drawing.Point(15, 74);
            this.lbDetailQty.Name = "lbDetailQty";
            this.lbDetailQty.Size = new System.Drawing.Size(50, 25);
            this.lbDetailQty.TabIndex = 0;
            this.lbDetailQty.Text = "Qty :";
            // 
            // lbInputPrice
            // 
            this.lbInputPrice.AutoSize = true;
            this.lbInputPrice.Location = new System.Drawing.Point(42, 101);
            this.lbInputPrice.Name = "lbInputPrice";
            this.lbInputPrice.Size = new System.Drawing.Size(49, 25);
            this.lbInputPrice.TabIndex = 0;
            this.lbInputPrice.Text = "Price";
            // 
            // tbInputPrice
            // 
            this.tbInputPrice.Location = new System.Drawing.Point(136, 98);
            this.tbInputPrice.Name = "tbInputPrice";
            this.tbInputPrice.Size = new System.Drawing.Size(150, 31);
            this.tbInputPrice.TabIndex = 2;
            this.tbInputPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // lbInputQty
            // 
            this.lbInputQty.AutoSize = true;
            this.lbInputQty.Location = new System.Drawing.Point(42, 158);
            this.lbInputQty.Name = "lbInputQty";
            this.lbInputQty.Size = new System.Drawing.Size(41, 25);
            this.lbInputQty.TabIndex = 0;
            this.lbInputQty.Text = "Qty";
            // 
            // tbInputQty
            // 
            this.tbInputQty.Location = new System.Drawing.Point(136, 155);
            this.tbInputQty.Name = "tbInputQty";
            this.tbInputQty.Size = new System.Drawing.Size(150, 31);
            this.tbInputQty.TabIndex = 3;
            this.tbInputQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(174, 216);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 34);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(330, 216);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(112, 34);
            this.btnDetail.TabIndex = 6;
            this.btnDetail.Text = "Detail";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(448, 216);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 34);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.Button_Click);
            // 
            // lbProductList
            // 
            this.lbProductList.FormattingEnabled = true;
            this.lbProductList.ItemHeight = 25;
            this.lbProductList.Location = new System.Drawing.Point(330, 40);
            this.lbProductList.Name = "lbProductList";
            this.lbProductList.Size = new System.Drawing.Size(230, 154);
            this.lbProductList.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbTotalQtyValue);
            this.panel2.Controls.Add(this.lbTotalPriceValue);
            this.panel2.Controls.Add(this.lbTotalQty);
            this.panel2.Controls.Add(this.lbTotalPrice);
            this.panel2.Location = new System.Drawing.Point(610, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 81);
            this.panel2.TabIndex = 1;
            // 
            // lbTotalQtyValue
            // 
            this.lbTotalQtyValue.AutoSize = true;
            this.lbTotalQtyValue.Location = new System.Drawing.Point(142, 44);
            this.lbTotalQtyValue.Name = "lbTotalQtyValue";
            this.lbTotalQtyValue.Size = new System.Drawing.Size(53, 25);
            this.lbTotalQtyValue.TabIndex = 0;
            this.lbTotalQtyValue.Text = "value";
            // 
            // lbTotalPriceValue
            // 
            this.lbTotalPriceValue.AutoSize = true;
            this.lbTotalPriceValue.Location = new System.Drawing.Point(142, 16);
            this.lbTotalPriceValue.Name = "lbTotalPriceValue";
            this.lbTotalPriceValue.Size = new System.Drawing.Size(53, 25);
            this.lbTotalPriceValue.TabIndex = 0;
            this.lbTotalPriceValue.Text = "value";
            // 
            // lbTotalQty
            // 
            this.lbTotalQty.AutoSize = true;
            this.lbTotalQty.Location = new System.Drawing.Point(15, 44);
            this.lbTotalQty.Name = "lbTotalQty";
            this.lbTotalQty.Size = new System.Drawing.Size(92, 25);
            this.lbTotalQty.TabIndex = 0;
            this.lbTotalQty.Text = "Total Qty :";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Location = new System.Drawing.Point(15, 16);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(100, 25);
            this.lbTotalPrice.TabIndex = 0;
            this.lbTotalPrice.Text = "Total Price :";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(42, 216);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(112, 34);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 319);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbProductList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbInputQty);
            this.Controls.Add(this.lbInputQty);
            this.Controls.Add(this.tbInputPrice);
            this.Controls.Add(this.lbInputPrice);
            this.Controls.Add(this.tbInputName);
            this.Controls.Add(this.lbInputName);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbInputName;
        private TextBox tbInputName;
        private Panel panel1;
        private Label lbInputPrice;
        private TextBox tbInputPrice;
        private Label lbInputQty;
        private TextBox tbInputQty;
        private Button btnAdd;
        private Button btnDetail;
        private Button btnDelete;
        private Label lbDetailName;
        private Label lbDetailPrice;
        private Label lbDetailQty;
        private ListBox lbProductList;
        private Panel panel2;
        private Label lbTotalQty;
        private Label lbTotalPrice;
        private Label lbDetailQtyValue;
        private Label lbDetailPriceValue;
        private Label lbDetailNameValue;
        private Label lbTotalQtyValue;
        private Label lbTotalPriceValue;
        private Button btnTest;
    }
}