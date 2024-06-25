
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Web_Watch_Shop.Models;
// dotnet aspnet-codegenerator razorpage -m Contact -dc ApplicationDbContext -udl -outDir Pages\Contacts --referenceScriptLibraries

namespace Web_Watch_Shop.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // Kiểm tra xem đã có dữ liệu chưa
                if (context.Product_Detail.Any())
                {
                    return;   // DB has been seeded
                }

               context.Product_Detail.AddRange(
               new Product_Detail
               {
                   ImagePath = "/images/product-images/popular1.jpg",
                   ProductName = "Stainless Steel Strap Quartz Wristwatch Men",
                   CategoryName = "Mens Watches",
                   ProductDescription = "Countdown Stainless Steel Strap Quartz Wristwatch Men",
                   Price = 1250
               },
               new Product_Detail
               {
                   ImagePath = "/images/product-images/girl2.jpg",
                   ProductName = "Deemiz New in High Quality",
                   CategoryName = "Ladies Watches",
                   ProductDescription = "Deemiz New Stylish Watch for Women in High Quality",
                   Price = 250
               },
               new Product_Detail
               {
                   ImagePath = "/images/product-images/popular4.png",
                   ProductName = "Romanson Stainless Steel Wrist Watch",
                   CategoryName = "Mens Watches",
                   ProductDescription = "Romanson Stainless Steel Wrist Watch For Men-Romanson",
                   Price = 1250
               },
               new Product_Detail
               {
                   ImagePath = "/images/product-images/popular2.jpg",
                   ProductName = "Browwn Leather Skeleton Watch for Men",
                   CategoryName = "Mens Watches",
                   ProductDescription = "Browwn Leather Skeleton Watch for Men",
                   Price = 450
               },
               new Product_Detail
               {
                   ImagePath = "/images/product-images/women2.png",
                   ProductName = "New Fashion Mobile Watch For Girls",
                   CategoryName = "Ladies Watches",
                   ProductDescription = "New Pink lether Fashion Mobile Watch For Girls",
                   Price = 1450
               },
               new Product_Detail
               {
                   ImagePath = "/images/product-images/popular3.png",
                   ProductName = "fTimex Allied Blue Dial Analogf",
                   CategoryName = "Mens Watches",
                   ProductDescription = "Timex Allied Blue Analog Watch for Men",
                   Price = 850
               },
               new Product_Detail
               {
                   ImagePath = "/images/product-images/women1.png",
                   ProductName = "Blue Leather Skeleton Watch for Women",
                   CategoryName = "Ladies Watches",
                   ProductDescription = "Blue Leather Watch for Women.",
                   Price = 350
               },
               new Product_Detail
               {
                   ImagePath = "/images/product-images/girl.1.jpg",
                   ProductName = "Watchify Fashion Magnetic Wrist Watch for Girls",
                   CategoryName = "Ladies Watches",
                   ProductDescription = "Watchify Fashion Magnetic Wrist Watch for Girls",
                   Price = 440
               },
               new Product_Detail
               {
                   ImagePath = "/images/product-images/popular5.png",
                   ProductName = "Luxury Brand Watch",
                   CategoryName = "Mens Watches",
                   ProductDescription = "Luxury Brand Men Watch Good Quality Black",
                   Price = 400
               },
               new Product_Detail
               {
                   ImagePath = "/images/product-images/popular6.png",
                   ProductName = "NAVIFORCE Army",
                   CategoryName = "Mens Watches",
                   ProductDescription = "NAVIFORCE Army Business Band Japan Watch",
                   Price = 250
               },
               new Product_Detail
               {
                   ImagePath = "/images/product-images/mobile4.png",
                   ProductName = "Smart Watch With Bluetooth Call",
                   CategoryName = "Mobile Watches",
                   ProductDescription = "Smart Watch With Bluetooth Call Intelligence Smart Watch.",
                   Price = 150
               },
               new Product_Detail
               {
                   ImagePath = "/images/product-images/mobile3.png ",
                   ProductName = "Waterproof Smartwatch",
                   CategoryName = "Mobile Watches",
                   ProductDescription = "Smart Watch Men Blood Pressure Waterproof Smartwatch",
                   Price = 120
               },
               new Product_Detail
               {
                   ImagePath = "/images/product-images/girl3.jpg",
                   ProductName = "High Quality Purple Magnetic Ladies Wrist Watch For Girls Women",
                   CategoryName = "Ladies Watches",
                   ProductDescription = "[NEW BRAND]High Quality Purple Magnetic Wrist Watch for Ladies",
                   Price = 1250
               },
               new Product_Detail
               {
                   ImagePath = "/images/product-images/girl4.jpg",
                   ProductName = "Love Watch For Girls",
                   CategoryName = "Ladies Watches",
                   ProductDescription = "Red Leather Double Bracelet Love Watch For Girls",
                   Price = 290
               },
               new Product_Detail
               {
                   ImagePath = "/images/product-images/girl5.jpg",
                   ProductName = "Bracelet Watch For Girls",
                   CategoryName = "Ladies Watches",
                   ProductDescription = "Cute Quartz Bracelet Watch For Girls",
                   Price = 1250
               },
               new Product_Detail
               {
                   ImagePath = "/images/product-images/mobile5.png",
                   ProductName = "Smart Band, Smart Watch",
                   CategoryName = "Mobile Watches",
                   ProductDescription = " M3 Plus Smart Fitness Band with Heart Rate Sensor,Smart Watch",
                   Price = 1250
               },
               new Product_Detail
               {
                   ImagePath = "/images/product-images/mobile6.png",
                   ProductName = "Watch with GSM slot with camera",
                   CategoryName = "Mobile Watches",
                   ProductDescription = " Watch Wearable Device Sports Watch with GSM slot with camera",
                   Price = 1650
               },
               new Product_Detail
               {
                   ImagePath = "/images/product-images/mobile7.png",
                   ProductName = "waterproof smart watch for android and ios",
                   CategoryName = "Mobile Watches",
                   ProductDescription = "High quality stylish waterproof smart watch for android and ios",
                   Price = 1950
               },
               new Product_Detail
               {
                   ImagePath = "/images/product-images/mobile8.png",
                   ProductName = "Fitness Tracker Heart Rate Monitor Smart Band",
                   CategoryName = "Mobile Watches",
                   ProductDescription = " Fitness Tracker Heart Rate Monitor Smart Band watch",
                   Price = 1450
               },
               new Product_Detail
               {
                   ImagePath = "/images/product-images/mobile9.png",
                   ProductName = "iOS Android AIVEILE 2020 Version Activity",
                   CategoryName = "Mobile Watches",
                   ProductDescription = "Smart Watch for iOS Android AIVEILE 2020 Version Activity.",
                   Price = 1550
               }
               );
               context.SaveChanges();
            }
        }
    }
}