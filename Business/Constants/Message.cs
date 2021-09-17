using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Message
    {

        // General
        public static string CarAdded = "Araba kaydı başarıyla eklendi.";
        public static string CarUpdated = "Arabanın bilgileri güncellenmiştir.";
        public static string CarDeleted = "Araba kaydı başarıyla silinmiştir.";
        public static string CarIsNot = "Araba bilgilerinde eksik veya yanlışlık var!";
        public static string RentalError = "Araba teslim edilmedi!";

        // Brand 
        public static string BrandAdded = "Marka kaydı başarıyla eklendi.";
        public static string BrandDeleted = "Marka kaydı silindi.";
        public static string BrandUpdated = "Marka bilgileri güncellendi.";
        public static string AllListBrand = "Tüm araba markaları listelendi!";
        public static string GetBrand = "Araba markası listelendi.";
        public static string BrandNameInvalid = "İsim geçersiz.";

        // Color 
        public static string ColorAdded = "İstediğiniz renk eklendi.";
        public static string ColorDeleted = "Seçtiğiniz renk silindi.";
        public static string ColorUpdate = "İstediğiniz renk bilgileri güncellendi.";
        public static string AllListColor = "Tüm renkler listelendi!";
        public static string GetColor = "Renk listelendi.";

        // Car - Success
        public static string AllListCar = "Tüm arabalar listelendi!";
        public static string GetCar = "Araba listelendi.";

        // Rental - Success
        public static string RentalAdded = "Kiralama bilgisi eklendi.";
        public static string RentalDeleted = "Kiralama bilgisi silindi.";
        public static string RentalUpdated = "Kiralama bilgisi güncellendi.";
        public static string AllRental = "Tüm kiralamalar listelendi!";
        public static string GetRental = "Kiralama listelendi.";
        

        // Customer - Success
        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomerDeleted = "Müşteri silindi.";
        public static string CustomerUpdated = "Müşteri bilgileri güncellendi.";
        public static string AllCustomer = "Tüm müşteriler listelendi!";
        public static string GetCustomer = "Müşteri listelendi.";

        // User - Success
        public static string UserAdded = "Üye eklendi.";
        public static string UserDeleted = "Üye silindi.";
        public static string UserUpdated = "Üye bilgileri güncellendi.";
        public static string AllUser = "Tüm üyeler listelendi!";
        public static string GetUser = "Üye listelendi.";


    }
}
