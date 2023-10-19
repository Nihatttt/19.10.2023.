namespace shop.core.Models
{



    internal class Product
    {
        public string Name { get; set; }
        public string price { get; set; }
        public string category { get; set; }
        public string stockcount { get; set; }



        public string GetFullInfo()
        {
            return $"Name: {Name}, price: {price}, category: {category}, stockcount: {stockcount}"
     }  }
}

