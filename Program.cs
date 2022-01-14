
using Product3.Methods;
using Product3.Models;

SeoLink Seolink = new SeoLink();
//Sale salee = new Sale();
Phone phone1 = new()
{
    Id = 1,
    PhoneName = "Samsung",
    Size = 35,
    SeoUrl = Seolink.Seo("Samsung")
};

Phone phone2 = new()
{
    Id = 2,
    PhoneName = "Iphohe",
    Size = 370M,
    SeoUrl = Seolink.Seo("Iphone")
};

Phone phone3 = new()
{
    Id = 3,
    PhoneName = "Xiomi",
    Size = 300M,
    SeoUrl = Seolink.Seo("Xiomi")
};


Computer Computer1 = new()
{
    Id = 1,
    ProductName = "HP",
    Size = 13,
    SeoUrl = Seolink.Seo("HP")
};
Computer Computer2 = new()
{
    Id = 2,
    ProductName = "ASUS",
    Size = 15,
    SeoUrl = Seolink.Seo("ASUS")
};

Computer Computer3 = new()
{
    Id = 3,
    ProductName = "DELL",
    Size = 17,
    SeoUrl = Seolink.Seo("DELL")
};

List<string> product3 = new();

product3.Add(phone1.PhoneName + phone1.Price);

Console.WriteLine(phone1);
