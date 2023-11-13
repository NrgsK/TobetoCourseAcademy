using Business.Concretes;
using Entities.Concretes;

Category category1= new Category();
category1.Id = 1;
category1.Name = "Programlama";

CategoryManager categoryManager = new CategoryManager();
categoryManager.Add(category1);


//Sıfırdan proje oluşturunuz --> TobetoETrade
//Product sınıfını katmanlarında işletiniz.
//Product --> Id,Name,Unitprice