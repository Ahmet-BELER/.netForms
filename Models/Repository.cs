namespace   FormsApp.Models{
    public class Repository{

        static Repository(){
            _categories.Add(new Category {CategoryId = 1 , Name="iphone"} );
            _categories.Add(new Category {CategoryId = 2 , Name="mac"} );

            _products.Add(new Product {ProductId=1 ,Name = "iphone14", Price=40000, IsActive=true,Image="1.jpg",CategoryId =1});
            _products.Add(new Product {ProductId=2 ,Name = "iphone11", Price=60000, IsActive=true,Image="2.jpg",CategoryId =1});
            _products.Add(new Product {ProductId=3 ,Name = "iphone13", Price=50000, IsActive=true,Image="3.jpg",CategoryId =1});
            _products.Add(new Product {ProductId=4 ,Name = "iphone12 Pro", Price=70000, IsActive=true,Image="4.jpg",CategoryId =1});

            _products.Add(new Product {ProductId=5 ,Name = "Mackbook Air", Price=80000, IsActive=true,Image="5.jpg",CategoryId =2});
            _products.Add(new Product {ProductId=6 ,Name = "Macbook Pro", Price=90000, IsActive=true,Image="6.jpg",CategoryId =2});
        }




        private static readonly List<Product> _products = new ();

        private static readonly List<Category> _categories = new (); 


        public static List<Product> Products {
            get {

                return _products;
            }
        }


        public static void CreatProduct(Product entity){
            _products.Add(entity);
        }





        public static List<Category> Categories {
            get {
                return _categories;
            }
            
        }


    }

}