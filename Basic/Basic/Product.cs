namespace Basic
{
    internal class Product
    {
        private string _Name;
        private int _Price;
        private int _Qty;
        private int _TotalPrice = 0;
        private int _TotalQty = 0;

        public int TotalQty
        {
            get { return _TotalQty; }
        }

        public int TotalPrice
        {
            get { return _TotalPrice; }
        }


        public int Qty
        {
            get { return _Qty; }
            set { _Qty = value; }
        }

        public int Price
        {
            get { return _Price; }
            set { _Price = value; _TotalPrice += _Price; }
        }


        public string Name
        {
            get { return _Name; }
            set { _Name = value; _TotalQty += _Qty; }
        }

    }
}
