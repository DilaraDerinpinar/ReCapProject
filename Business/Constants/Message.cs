using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Message
    {

        // General
        public static string CarAdded = "Kayıt başarıyla eklendi.";
        public static string CarUpdated = "Bilgiler güncellenmiştir.";
        public static string CarDeleted = "Kayıt başarıyla silinmiştir.";
        public static string CarIsNot = "Bilgilerde eksik veya yanlışlık var!";
        public static string RentalError = "Araba teslim edilmedi!";

        // Brand 
        public static string AllListBrand = "Tüm araba markaları listelendi!";
        public static string GetBrand = "Araba markası listelendi.";

        // Color 
        public static string AllListColor = "Tüm renkler listelendi!";
        public static string GetColor = "Renk listelendi.";

        // Car - Success
        public static string AllListCar = "Tüm arabalar listelendi!";
        public static string GetCar = "Araba listelendi.";

        // Rental - Success
        public static string RentalAdded = "Kiralama bilgisi eklendi!";
        public static string AllRental = "Tüm kiralamalar listelendi!";
        public static string GetRental = "Kiralama listelendi.";
        

        // Customer - Success
        public static string CustomerAdded = "Müşteri eklendi!";
        public static string AllCustomer = "Tüm müşteriler listelendi!";
        public static string GetCustomer = "Müşteri listelendi.";

        // User - Success
        public static string UserAdded = "Üye eklendi!!";
        public static string AllUser = "Tüm üyeler listelendi!";
        public static string GetUser = "Üye listelendi.";


    }
}
