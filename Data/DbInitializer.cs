﻿using ECommerceAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPI.Data
{
    public static class DbInitializer
    {
        public static void InitializeProducts(ECommerceDbContext context)
        {
            // Ensure the database is created
            context.Database.Migrate();

            // Check if there are any products
            if (context.Products.Any())
            {
                return; // DB has been seeded
            }
            var products = new Product[]
            {
                new Product { Name = "4K Monitor", Category = "Monitors", Description = "Monitor with 4K resolution for stunning visuals.", Price = 499.99M, Stock = 10 },
                new Product { Name = "Bluetooth Headphones", Category = "Headphones", Description = "Wireless headphones with Bluetooth connectivity.", Price = 89.99M, Stock = 25 },
                new Product { Name = "High-Speed External Hard Drive", Category = "Storage", Description = "External hard drive with high-speed data transfer.", Price = 139.99M, Stock = 20 },
                new Product { Name = "Gaming Mouse Elite", Category = "Mice", Description = "High-end gaming mouse with customizable features.", Price = 119.99M, Stock = 15 },
                new Product { Name = "Premium Keyboard", Category = "Keyboards", Description = "Keyboard with premium feel and functionality.", Price = 89.99M, Stock = 30 },
                new Product { Name = "Home Theater System", Category = "Speakers", Description = "Complete home theater system for immersive sound.", Price = 299.99M, Stock = 12 },
                new Product { Name = "High-End DSLR Camera", Category = "Cameras", Description = "DSLR camera with high-end features for photography enthusiasts.", Price = 899.99M, Stock = 8 },
                new Product { Name = "Smart TV 55 inch", Category = "Televisions", Description = "55 inch smart TV with 4K resolution.", Price = 799.99M, Stock = 14 },
                new Product { Name = "Fitness Tracker", Category = "Wearables", Description = "Wearable fitness tracker with heart rate monitoring.", Price = 149.99M, Stock = 22 },
                new Product { Name = "Desktop Computer", Category = "Computers", Description = "High-performance desktop computer for all needs.", Price = 999.99M, Stock = 10 },
                new Product { Name = "Gaming Chair", Category = "Furniture", Description = "Ergonomic gaming chair with adjustable features.", Price = 199.99M, Stock = 18 },
                new Product { Name = "Portable Power Bank", Category = "Accessories", Description = "Power bank with high capacity and quick charge.", Price = 49.99M, Stock = 40 },
                new Product { Name = "Wireless Router", Category = "Networking", Description = "Reliable wireless router with high-speed connectivity.", Price = 129.99M, Stock = 20 },
                new Product { Name = "Bluetooth Speaker", Category = "Speakers", Description = "Portable Bluetooth speaker with excellent sound quality.", Price = 99.99M, Stock = 25 },
                new Product { Name = "High-Resolution Digital Camera", Category = "Cameras", Description = "Digital camera with high resolution and advanced features.", Price = 649.99M, Stock = 12 },
                new Product { Name = "Smartphone Pro Max", Category = "Smartphones", Description = "Top-of-the-line smartphone with advanced technology.", Price = 1199.99M, Stock = 10 },
                new Product { Name = "Professional Headphones", Category = "Headphones", Description = "Headphones designed for professional audio use.", Price = 299.99M, Stock = 8 },
                new Product { Name = "Smartwatch Advanced", Category = "Smartwatches", Description = "Advanced smartwatch with multiple health tracking features.", Price = 249.99M, Stock = 15 },
                new Product { Name = "High-Speed SSD", Category = "Storage", Description = "Solid-state drive with high-speed data transfer.", Price = 229.99M, Stock = 10 },
                new Product { Name = "Compact Camera", Category = "Cameras", Description = "Compact camera with excellent image quality.", Price = 399.99M, Stock = 18 },
                new Product { Name = "Ergonomic Office Chair", Category = "Office Supplies", Description = "Office chair designed for ergonomic comfort.", Price = 189.99M, Stock = 15 },
                new Product { Name = "High-Fidelity Speaker", Category = "Speakers", Description = "Speaker with high-fidelity sound quality.", Price = 159.99M, Stock = 20 },
                new Product { Name = "Gaming Keyboard", Category = "Keyboards", Description = "Keyboard designed specifically for gaming.", Price = 79.99M, Stock = 25 },
                new Product { Name = "Premium Wireless Mouse", Category = "Mice", Description = "High-quality wireless mouse with ergonomic design.", Price = 69.99M, Stock = 30 },
                new Product { Name = "Professional Inkjet Printer", Category = "Printers", Description = "Inkjet printer with high resolution for professional printing.", Price = 179.99M, Stock = 12 },
                new Product { Name = "Mesh Wi-Fi System", Category = "Networking", Description = "Mesh Wi-Fi system for reliable and fast internet coverage.", Price = 219.99M, Stock = 8 },
                new Product { Name = "Smartphone Pro", Category = "Smartphones", Description = "Smartphone with top features and performance.", Price = 999.99M, Stock = 14 },
                new Product { Name = "Portable SSD", Category = "Storage", Description = "Portable SSD with fast read and write speeds.", Price = 149.99M, Stock = 18 },
                new Product { Name = "High-Quality Headphones", Category = "Headphones", Description = "Headphones with high-quality sound and comfort.", Price = 189.99M, Stock = 20 },
                new Product { Name = "Gaming Monitor Pro", Category = "Monitors", Description = "High-refresh rate monitor for gaming.", Price = 399.99M, Stock = 15 },
                new Product { Name = "Ergonomic Gaming Chair", Category = "Furniture", Description = "Gaming chair with ergonomic features for long hours.", Price = 249.99M, Stock = 10 },
                new Product { Name = "Smartwatch Sport Pro", Category = "Smartwatches", Description = "Sport smartwatch with advanced tracking features.", Price = 299.99M, Stock = 12 },
                new Product { Name = "High-Resolution Monitor", Category = "Monitors", Description = "Monitor with high resolution and color accuracy.", Price = 359.99M, Stock = 14 },
                new Product { Name = "Portable Power Charger", Category = "Accessories", Description = "Portable charger with high capacity for devices.", Price = 39.99M, Stock = 30 },
                new Product { Name = "High-Performance Desktop", Category = "Computers", Description = "Desktop computer with high-performance specs.", Price = 1299.99M, Stock = 8 },
                new Product { Name = "Bluetooth Earbuds", Category = "Headphones", Description = "Wireless earbuds with Bluetooth and noise cancellation.", Price = 79.99M, Stock = 25 },
                new Product { Name = "Compact External Drive", Category = "Storage", Description = "External drive with compact size and high storage.", Price = 119.99M, Stock = 20 },
                new Product { Name = "Gaming PC Elite", Category = "Gaming", Description = "High-end gaming PC with top specs and features.", Price = 1999.99M, Stock = 5 },
                new Product { Name = "High-Resolution Scanner", Category = "Printers", Description = "Scanner with high resolution for detailed image capture.", Price = 229.99M, Stock = 10 },
                new Product { Name = "Smartphone Mini", Category = "Smartphones", Description = "Compact smartphone with essential features.", Price = 499.99M, Stock = 20 },
                new Product { Name = "Professional Speaker", Category = "Speakers", Description = "Speaker designed for professional audio applications.", Price = 249.99M, Stock = 15 },
                new Product { Name = "Smartwatch 4", Category = "Smartwatches", Description = "Smartwatch with advanced features and elegant design.", Price = 179.99M, Stock = 18 },
                new Product { Name = "Wireless Gaming Headset", Category = "Gaming", Description = "Gaming headset with wireless connectivity and high sound quality.", Price = 129.99M, Stock = 12 },
                new Product { Name = "High-Speed Network Switch", Category = "Networking", Description = "Network switch with high-speed data transfer.", Price = 89.99M, Stock = 15 },
                new Product { Name = "4K Streaming Device", Category = "Accessories", Description = "Streaming device with 4K resolution support.", Price = 79.99M, Stock = 20 },
                new Product { Name = "Portable Power Bank 20000mAh", Category = "Accessories", Description = "High-capacity power bank for extended use.", Price = 59.99M, Stock = 25 },
                new Product { Name = "High-End Bluetooth Speaker", Category = "Speakers", Description = "Bluetooth speaker with premium sound and build quality.", Price = 219.99M, Stock = 10 },
                new Product { Name = "Professional Camera Lens", Category = "Cameras", Description = "High-quality camera lens for professional photography.", Price = 349.99M, Stock = 8 },
                new Product { Name = "Smartphone Max", Category = "Smartphones", Description = "Max model smartphone with advanced features.", Price = 1299.99M, Stock = 12 },
                new Product { Name = "Premium Gaming Chair", Category = "Furniture", Description = "Gaming chair with premium materials and design.", Price = 299.99M, Stock = 10 },
                new Product { Name = "Gaming Monitor Elite", Category = "Monitors", Description = "Elite gaming monitor with high refresh rate and resolution.", Price = 499.99M, Stock = 14 },
                new Product { Name = "Advanced Fitness Tracker", Category = "Wearables", Description = "Fitness tracker with advanced health metrics.", Price = 179.99M, Stock = 18 },
                new Product { Name = "Home Office Desk", Category = "Furniture", Description = "Office desk designed for home use with ample space.", Price = 299.99M, Stock = 10 },
                new Product { Name = "Professional Gaming Keyboard", Category = "Keyboards", Description = "Keyboard with features tailored for gaming professionals.", Price = 139.99M, Stock = 12 },
                new Product { Name = "High-Fidelity Headphones", Category = "Headphones", Description = "Headphones with high-fidelity sound for audiophiles.", Price = 249.99M, Stock = 10 },
                new Product { Name = "Wireless Earbuds Pro", Category = "Headphones", Description = "Pro version wireless earbuds with high-quality sound.", Price = 149.99M, Stock = 20 },
                new Product { Name = "High-Speed USB Hub", Category = "Accessories", Description = "USB hub with high-speed data transfer capabilities.", Price = 29.99M, Stock = 30 },
                new Product { Name = "Gaming Laptop Pro", Category = "Laptops", Description = "High-performance gaming laptop with advanced features.", Price = 1999.99M, Stock = 8 },
                new Product { Name = "High-Resolution Home Printer", Category = "Printers", Description = "Home printer with high-resolution output.", Price = 169.99M, Stock = 12 },
                new Product { Name = "Laptop Alpha", Category = "Laptops", Description = "A high-performance laptop with Intel i7 processor.", Price = 1199.99M, Stock = 15 },
                new Product { Name = "Headphone X100", Category = "Headphones", Description = "Noise-cancelling wireless headphones.", Price = 249.99M, Stock = 25 },
                new Product { Name = "Smartphone Pro", Category = "Smartphones", Description = "Latest model smartphone with 5G support.", Price = 999.99M, Stock = 20 },
                new Product { Name = "Tablet Ultra", Category = "Tablets", Description = "High-resolution tablet with stylus support.", Price = 349.99M, Stock = 30 },
                new Product { Name = "Smartwatch Series 5", Category = "Smartwatches", Description = "Smartwatch with GPS and heart rate monitoring.", Price = 199.99M, Stock = 40 },
                new Product { Name = "Bluetooth Speaker Z1", Category = "Speakers", Description = "Portable Bluetooth speaker with excellent sound quality.", Price = 129.99M, Stock = 35 },
                new Product { Name = "DSLR Camera X", Category = "Cameras", Description = "High-resolution DSLR camera with interchangeable lenses.", Price = 599.99M, Stock = 10 },
                new Product { Name = "Gaming Console 2024", Category = "Gaming", Description = "Next-gen gaming console with 4K support.", Price = 399.99M, Stock = 15 },
                new Product { Name = "4K Monitor 27\"", Category = "Monitors", Description = "27-inch 4K monitor with HDR support.", Price = 349.99M, Stock = 20 },
                new Product { Name = "Mechanical Keyboard RGB", Category = "Keyboards", Description = "Mechanical keyboard with customizable RGB lighting.", Price = 89.99M, Stock = 25 },
                new Product { Name = "Wireless Mouse Pro", Category = "Mice", Description = "High-precision wireless mouse with ergonomic design.", Price = 59.99M, Stock = 30 },
                new Product { Name = "All-in-One Printer 3000", Category = "Printers", Description = "Multi-function printer with wireless capabilities.", Price = 149.99M, Stock = 12 },
                new Product { Name = "Wi-Fi Router X", Category = "Networking", Description = "High-speed router with advanced security features.", Price = 99.99M, Stock = 18 },
                new Product { Name = "External Hard Drive 2TB", Category = "Storage", Description = "External hard drive with 2TB capacity.", Price = 109.99M, Stock = 25 },
                new Product { Name = "HD Webcam 1080p", Category = "Webcams", Description = "HD webcam with built-in microphone for clear video calls.", Price = 69.99M, Stock = 20 },
                new Product { Name = "Phone Case Slim", Category = "Accessories", Description = "Slim and protective phone case.", Price = 29.99M, Stock = 40 },
                new Product { Name = "Ergonomic Office Chair", Category = "Office Supplies", Description = "Comfortable office chair with lumbar support.", Price = 199.99M, Stock = 15 },
                new Product { Name = "Adjustable Standing Desk", Category = "Furniture", Description = "Standing desk with adjustable height.", Price = 349.99M, Stock = 10 },
                new Product { Name = "Laptop Beta", Category = "Laptops", Description = "Affordable laptop with decent performance.", Price = 799.99M, Stock = 18 },
                new Product { Name = "Headphone Elite", Category = "Headphones", Description = "High-end headphones with supreme audio quality.", Price = 299.99M, Stock = 20 },
                new Product { Name = "Smartphone Plus", Category = "Smartphones", Description = "Smartphone with enhanced camera and battery life.", Price = 849.99M, Stock = 15 },
                new Product { Name = "Tablet Pro", Category = "Tablets", Description = "Professional-grade tablet with high performance.", Price = 429.99M, Stock = 12 },
                new Product { Name = "Smartwatch Classic", Category = "Smartwatches", Description = "Elegant smartwatch with advanced features.", Price = 229.99M, Stock = 20 },
                new Product { Name = "Portable Speaker A", Category = "Speakers", Description = "Compact speaker with powerful sound.", Price = 99.99M, Stock = 30 },
                new Product { Name = "Mirrorless Camera Y", Category = "Cameras", Description = "Compact mirrorless camera with high image quality.", Price = 499.99M, Stock = 15 },
                new Product { Name = "Gaming Laptop X", Category = "Gaming", Description = "High-performance gaming laptop with advanced GPU.", Price = 1399.99M, Stock = 8 },
                new Product { Name = "Curved Monitor 32\"", Category = "Monitors", Description = "32-inch curved monitor with immersive viewing experience.", Price = 399.99M, Stock = 22 },
                new Product { Name = "Gaming Keyboard", Category = "Keyboards", Description = "Durable keyboard with mechanical switches.", Price = 79.99M, Stock = 30 },
                new Product { Name = "Precision Mouse", Category = "Mice", Description = "High-DPI mouse for precise movements.", Price = 69.99M, Stock = 28 },
                new Product { Name = "Laser Printer Pro", Category = "Printers", Description = "High-speed laser printer with sharp text quality.", Price = 179.99M, Stock = 10 },
                new Product { Name = "Mesh Wi-Fi System", Category = "Networking", Description = "Mesh Wi-Fi system for better coverage.", Price = 149.99M, Stock = 15 },
                new Product { Name = "Portable SSD 1TB", Category = "Storage", Description = "High-speed portable SSD with 1TB storage.", Price = 159.99M, Stock = 20 },
                new Product { Name = "Webcam HD 720p", Category = "Webcams", Description = "HD webcam for video streaming.", Price = 49.99M, Stock = 35 },
                new Product { Name = "Phone Charger Fast", Category = "Accessories", Description = "Fast charger for modern smartphones.", Price = 19.99M, Stock = 50 },
                new Product { Name = "Executive Desk Chair", Category = "Office Supplies", Description = "Luxurious office chair with leather finish.", Price = 249.99M, Stock = 12 },
                new Product { Name = "Convertible Desk", Category = "Furniture", Description = "Desk that converts between sitting and standing positions.", Price = 399.99M, Stock = 8 },
                new Product { Name = "Laptop Gamma", Category = "Laptops", Description = "Laptop with high-speed SSD and 16GB RAM.", Price = 1099.99M, Stock = 14 },
                new Product { Name = "Headphone Pro X", Category = "Headphones", Description = "Headphones with superior noise-cancelling.", Price = 219.99M, Stock = 30 },
                new Product { Name = "Smartphone Max", Category = "Smartphones", Description = "Flagship smartphone with OLED display.", Price = 1199.99M, Stock = 10 },
                new Product { Name = "Tablet Mini", Category = "Tablets", Description = "Compact tablet with great portability.", Price = 299.99M, Stock = 20 },
                new Product { Name = "Smartwatch X", Category = "Smartwatches", Description = "Smartwatch with built-in GPS and fitness tracking.", Price = 189.99M, Stock = 25 },
                new Product { Name = "Outdoor Speaker", Category = "Speakers", Description = "Weather-resistant speaker for outdoor use.", Price = 139.99M, Stock = 28 },
                new Product { Name = "Professional Camera", Category = "Cameras", Description = "Camera with advanced features for professional use.", Price = 699.99M, Stock = 7 },
                new Product { Name = "Gaming Chair", Category = "Gaming", Description = "Ergonomic gaming chair with adjustable settings.", Price = 249.99M, Stock = 12 },
                new Product { Name = "Ultra-Wide Monitor", Category = "Monitors", Description = "34-inch ultra-wide monitor for immersive experience.", Price = 499.99M, Stock = 15 },
                new Product { Name = "Backlit Keyboard", Category = "Keyboards", Description = "Keyboard with adjustable backlighting.", Price = 99.99M, Stock = 25 },
                new Product { Name = "Gaming Mouse", Category = "Mice", Description = "High-precision gaming mouse with extra buttons.", Price = 79.99M, Stock = 32 },
                new Product { Name = "Inkjet Printer", Category = "Printers", Description = "Color inkjet printer for high-quality prints.", Price = 129.99M, Stock = 18 },
                new Product { Name = "Router AC2000", Category = "Networking", Description = "High-performance router with dual-band.", Price = 119.99M, Stock = 20 },
                new Product { Name = "Backup Drive 4TB", Category = "Storage", Description = "4TB backup drive with USB 3.0 support.", Price = 199.99M, Stock = 15 },
                new Product { Name = "Webcam HD Pro", Category = "Webcams", Description = "HD webcam with advanced image processing.", Price = 89.99M, Stock = 20 },
                new Product { Name = "Phone Stand", Category = "Accessories", Description = "Adjustable phone stand for hands-free use.", Price = 15.99M, Stock = 50 },
                new Product { Name = "Mesh Office Chair", Category = "Office Supplies", Description = "Mesh office chair with breathable design.", Price = 179.99M, Stock = 14 },
                new Product { Name = "Ergonomic Desk", Category = "Furniture", Description = "Ergonomic desk with cable management.", Price = 359.99M, Stock = 9 },
                new Product { Name = "Laptop Delta", Category = "Laptops", Description = "Laptop with powerful graphics card and fast processor.", Price = 1399.99M, Stock = 12 },
                new Product { Name = "Noise Cancelling Headphones", Category = "Headphones", Description = "High-quality headphones with active noise cancellation.", Price = 279.99M, Stock = 18 },
                new Product { Name = "Smartphone Elite", Category = "Smartphones", Description = "Elite smartphone with premium features.", Price = 1099.99M, Stock = 15 },
                new Product { Name = "Tablet Basic", Category = "Tablets", Description = "Basic tablet suitable for everyday use.", Price = 249.99M, Stock = 25 },
                new Product { Name = "Smartwatch Sport", Category = "Smartwatches", Description = "Sporty smartwatch with fitness tracking features.", Price = 159.99M, Stock = 30 },
                new Product { Name = "Portable Audio Speaker", Category = "Speakers", Description = "Compact speaker with powerful sound and long battery life.", Price = 119.99M, Stock = 20 },
                new Product { Name = "High-End Camera", Category = "Cameras", Description = "Camera with high-end features for professional photography.", Price = 799.99M, Stock = 8 },
                new Product { Name = "Gaming Headset", Category = "Gaming", Description = "Gaming headset with surround sound and noise cancellation.", Price = 89.99M, Stock = 22 },
                new Product { Name = "High Resolution Monitor", Category = "Monitors", Description = "Monitor with ultra-high resolution and color accuracy.", Price = 449.99M, Stock = 16 },
                new Product { Name = "Ergonomic Keyboard", Category = "Keyboards", Description = "Keyboard designed for ergonomic comfort.", Price = 79.99M, Stock = 25 },
                new Product { Name = "Wireless Gaming Mouse", Category = "Mice", Description = "Gaming mouse with high DPI and customizable buttons.", Price = 89.99M, Stock = 28 },
                new Product { Name = "Laserjet Printer", Category = "Printers", Description = "High-speed laser printer for office use.", Price = 159.99M, Stock = 10 },
                new Product { Name = "Mesh Network Kit", Category = "Networking", Description = "Complete mesh network kit for whole-home coverage.", Price = 189.99M, Stock = 15 },
                new Product { Name = "High-Speed External SSD", Category = "Storage", Description = "External SSD with high-speed performance and large capacity.", Price = 179.99M, Stock = 20 },
                new Product { Name = "4K Webcam", Category = "Webcams", Description = "Webcam with 4K resolution for sharp video quality.", Price = 129.99M, Stock = 18 },
                new Product { Name = "Phone Holder", Category = "Accessories", Description = "Phone holder with adjustable angles.", Price = 22.99M, Stock = 40 },
                new Product { Name = "Deluxe Office Chair", Category = "Office Supplies", Description = "Deluxe office chair with premium materials and design.", Price = 249.99M, Stock = 10 },
                new Product { Name = "Modern Desk", Category = "Furniture", Description = "Modern desk with clean lines and ample workspace.", Price = 389.99M, Stock = 8 },
                new Product { Name = "Laptop Zeta", Category = "Laptops", Description = "Laptop with advanced features and sleek design.", Price = 1099.99M, Stock = 14 },
                new Product { Name = "High-Fidelity Headphones", Category = "Headphones", Description = "Headphones with exceptional sound fidelity.", Price = 229.99M, Stock = 22 },
                new Product { Name = "Smartphone X", Category = "Smartphones", Description = "Smartphone with cutting-edge technology and design.", Price = 849.99M, Stock = 20 },
                new Product { Name = "Tablet Advanced", Category = "Tablets", Description = "Advanced tablet with high performance and features.", Price = 399.99M, Stock = 15 },
                new Product { Name = "Smartwatch 2024", Category = "Smartwatches", Description = "Latest smartwatch model with advanced functionality.", Price = 219.99M, Stock = 20 },
                new Product { Name = "Compact Bluetooth Speaker", Category = "Speakers", Description = "Small yet powerful Bluetooth speaker.", Price = 109.99M, Stock = 30 },
                new Product { Name = "High-Performance Camera", Category = "Cameras", Description = "Camera with high-performance capabilities for professional use.", Price = 699.99M, Stock = 12 },
                new Product { Name = "Gaming PC", Category = "Gaming", Description = "High-performance gaming PC with the latest specs.", Price = 1499.99M, Stock = 7 },
                new Product { Name = "Wide Screen Monitor", Category = "Monitors", Description = "Wide screen monitor with great color accuracy.", Price = 429.99M, Stock = 18 },
                new Product { Name = "Comfortable Keyboard", Category = "Keyboards", Description = "Keyboard designed for long-term comfort and usability.", Price = 69.99M, Stock = 30 },
                new Product { Name = "Advanced Gaming Mouse", Category = "Mice", Description = "Gaming mouse with advanced DPI settings and ergonomic design.", Price = 79.99M, Stock = 28 },
                new Product { Name = "Photo Printer", Category = "Printers", Description = "Printer designed specifically for high-quality photo printing.", Price = 139.99M, Stock = 14 },
                new Product { Name = "Wi-Fi Mesh System", Category = "Networking", Description = "Advanced Wi-Fi mesh system for seamless coverage.", Price = 159.99M, Stock = 20 },
                new Product { Name = "Portable Hard Drive 1TB", Category = "Storage", Description = "Compact hard drive with 1TB storage capacity.", Price = 129.99M, Stock = 25 },
                new Product { Name = "Webcam HD", Category = "Webcams", Description = "High-definition webcam with sharp image quality.", Price = 59.99M, Stock = 35 },
                new Product { Name = "Smartphone Charger", Category = "Accessories", Description = "Fast-charging smartphone charger with universal compatibility.", Price = 24.99M, Stock = 40 },
                new Product { Name = "Executive Chair", Category = "Office Supplies", Description = "Executive chair with luxury and comfort.", Price = 299.99M, Stock = 12 },
                new Product { Name = "Standing Desk Converter", Category = "Furniture", Description = "Desk converter to switch between sitting and standing positions.", Price = 299.99M, Stock = 10 },
                new Product { Name = "Laptop Omega", Category = "Laptops", Description = "Premium laptop with high-end features and performance.", Price = 1399.99M, Stock = 10 },
                new Product { Name = "Over-Ear Headphones", Category = "Headphones", Description = "Comfortable over-ear headphones with superior sound quality.", Price = 219.99M, Stock = 20 },
                new Product { Name = "Smartphone 2024", Category = "Smartphones", Description = "2024 model smartphone with cutting-edge technology.", Price = 949.99M, Stock = 18 },
                new Product { Name = "Tablet Max", Category = "Tablets", Description = "High-end tablet with extensive features and performance.", Price = 429.99M, Stock = 12 },
                new Product { Name = "Smartwatch 5", Category = "Smartwatches", Description = "Smartwatch with enhanced fitness tracking and notifications.", Price = 199.99M, Stock = 22 },
                new Product { Name = "Outdoor Bluetooth Speaker", Category = "Speakers", Description = "Durable speaker designed for outdoor use with long battery life.", Price = 129.99M, Stock = 15 },
                new Product { Name = "Camera Professional", Category = "Cameras", Description = "Professional-grade camera with exceptional features.", Price = 799.99M, Stock = 8 },
                new Product { Name = "Gaming Laptop Ultra", Category = "Gaming", Description = "High-end gaming laptop with powerful GPU and CPU.", Price = 1599.99M, Stock = 6 },
                new Product { Name = "Gaming Monitor", Category = "Monitors", Description = "Monitor with high refresh rate and low latency.", Price = 449.99M, Stock = 14 },
                new Product { Name = "Backlit Mechanical Keyboard", Category = "Keyboards", Description = "Mechanical keyboard with customizable backlighting and switches.", Price = 99.99M, Stock = 20 },
                new Product { Name = "Gaming Mouse Pro", Category = "Mice", Description = "Professional gaming mouse with programmable buttons and high DPI.", Price = 89.99M, Stock = 24 },
                new Product { Name = "Inkjet Photo Printer", Category = "Printers", Description = "Printer with high resolution for professional photo prints.", Price = 149.99M, Stock = 12 },
                new Product { Name = "Home Wi-Fi Router", Category = "Networking", Description = "Reliable router with wide coverage for home use.", Price = 99.99M, Stock = 20 },
                new Product { Name = "External Storage Drive", Category = "Storage", Description = "External drive with ample storage space and fast transfer speeds.", Price = 159.99M, Stock = 15 },
                new Product { Name = "Webcam Pro", Category = "Webcams", Description = "Professional webcam with high-definition video and built-in microphone.", Price = 89.99M, Stock = 20 },
                new Product { Name = "Universal Phone Charger", Category = "Accessories", Description = "Charger compatible with various phone models and fast charging.", Price = 19.99M, Stock = 45 },
                new Product { Name = "Mesh Office Chair Deluxe", Category = "Office Supplies", Description = "Deluxe office chair with ergonomic design and high comfort.", Price = 229.99M, Stock = 12 },
                new Product { Name = "Executive Desk", Category = "Furniture", Description = "Elegant desk with ample workspace and modern design.", Price = 399.99M, Stock = 10 },
                new Product { Name = "Laptop Pro", Category = "Laptops", Description = "Professional laptop with top-of-the-line specifications.", Price = 1499.99M, Stock = 8 },
                new Product { Name = "Studio Headphones", Category = "Headphones", Description = "Headphones with studio-quality sound and comfort.", Price = 299.99M, Stock = 15 },
                new Product { Name = "Smartphone 2025", Category = "Smartphones", Description = "2025 smartphone with advanced features and design.", Price = 1099.99M, Stock = 10 },
                new Product { Name = "Tablet Pro Max", Category = "Tablets", Description = "Premium tablet with top performance and features.", Price = 499.99M, Stock = 10 },
                new Product { Name = "Smartwatch Classic 2", Category = "Smartwatches", Description = "Classic smartwatch with updated features and design.", Price = 219.99M, Stock = 18 },
                new Product { Name = "Portable Speaker Elite", Category = "Speakers", Description = "High-quality portable speaker with premium sound.", Price = 149.99M, Stock = 20 },
                new Product { Name = "High-Resolution Camera", Category = "Cameras", Description = "Camera with high resolution and professional features.", Price = 699.99M, Stock = 12 },
                new Product { Name = "Gaming Chair Pro", Category = "Gaming", Description = "Gaming chair with advanced ergonomic features.", Price = 299.99M, Stock = 10 },
                new Product { Name = "Ultra HD Monitor", Category = "Monitors", Description = "Monitor with ultra HD resolution for superior clarity.", Price = 499.99M, Stock = 12 },
                new Product { Name = "Mechanical Keyboard Elite", Category = "Keyboards", Description = "Elite mechanical keyboard with customizable switches.", Price = 119.99M, Stock = 20 },
                new Product { Name = "Precision Gaming Mouse", Category = "Mice", Description = "Gaming mouse with high precision and programmable settings.", Price = 89.99M, Stock = 22 },
                new Product { Name = "Photo Inkjet Printer", Category = "Printers", Description = "Inkjet printer with high quality for photo printing.", Price = 139.99M, Stock = 14 },
                new Product { Name = "Smart Wi-Fi Router", Category = "Networking", Description = "Router with smart features and wide coverage.", Price = 129.99M, Stock = 18 },
                new Product { Name = "Portable Hard Drive 2TB", Category = "Storage", Description = "Portable hard drive with 2TB capacity.", Price = 179.99M, Stock = 15 },
                new Product { Name = "High-Def Webcam", Category = "Webcams", Description = "Webcam with high-definition video capabilities.", Price = 69.99M, Stock = 25 },
                new Product { Name = "Quick Charge Phone Charger", Category = "Accessories", Description = "Quick charge phone charger with universal compatibility.", Price = 22.99M, Stock = 40 },
                new Product { Name = "High-Back Office Chair", Category = "Office Supplies", Description = "Office chair with high back and premium comfort.", Price = 229.99M, Stock = 10 },
                new Product { Name = "Ergonomic Office Desk", Category = "Furniture", Description = "Office desk with ergonomic features and ample storage.", Price = 359.99M, Stock = 8 }
            };

            context.Products.AddRange(products);
            context.SaveChanges();
        }
        public static async Task InitializeUsers(ECommerceDbContext context, IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            // Create Admin role if it doesn't exist
            string[] roleNames = { "Admin", "Customer", "Manager", "Seller", "Guest", "Support Staff", "Analyst" };
            IdentityResult roleResult;

            foreach (var roleName in roleNames)
            {
                var roleExist = await roleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    roleResult = await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            // Seed users with multiple roles
            await SeedUser(userManager, roleManager, "admin@example.com", "Admin@123!", new[] { "Admin", "Manager" });
            await SeedUser(userManager, roleManager, "manager@example.com", "Manager@123!", new[] { "Manager" });
            await SeedUser(userManager, roleManager, "seller@example.com", "Seller@123!", new[] { "Seller", "Customer" });
            await SeedUser(userManager, roleManager, "customer@example.com", "Customer@123!", new[] { "Customer" });
            await SeedUser(userManager, roleManager, "support@example.com", "Support@123!", new[] { "Support Staff" });

        }
        private static async Task SeedUser(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, string email, string password, string[] roles)
        {
            var user = await userManager.FindByEmailAsync(email);
            if (user == null)
            {
                user = new ApplicationUser()
                {
                    UserName = email,
                    Email = email
                };
                await userManager.CreateAsync(user, password);
            }

            foreach (var role in roles)
            {
                if (!await userManager.IsInRoleAsync(user, role))
                {
                    await userManager.AddToRoleAsync(user, role);
                }
            }
        }
    }
}
