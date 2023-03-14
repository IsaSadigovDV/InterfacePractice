using InterfaceMiniAppPractice.Abstractions.Services;
using InterfaceMiniAppPractice.Implementations.Services;

ProductService productService= new ProductService();
//IProductService ProductService = new ProductService(); // bele de olar

productService.Create();
productService.Create();

productService.Show();
