using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class  Messages
    {
        //Car
        public static string AddCarMessage = "Araç başarıyla eklendi.";
        public static string AddErrorCarMessage = "Araba açıklaması en az 2 karakterden oluşmalıdır ve günlük fiyatı da 0 liradan büyük olmalıdır.";
        public static string DeleteCarMessage = "Araç başarıyla silindi.";
        public static string EditCarMessage = "Araç başarıyla düzenlendi.";
        public static string GetSuccessCarMessage = "Araç bilgisi / bilgileri getirildi.";
        public static string GetErrorCarMessage = "Araç bilgisi / bilgileri getirilemedi.";


        //Brand
        public static string AddBrandMessage = "Marka başarıyla eklendi.";
        public static string DeleteBrandMessage = "Marka başarıyla silindi.";
        public static string EditBrandMessage = "Marka başarıyla güncellendi.";
        public static string GetSuccessBrandMessage = "Marka bilgisi / bilgileri getirildi.";
        public static string GetErrorBrandMessage = "Marka bilgisi / bilgileri getirilemedi.";

        //Color
        public static string AddColorMessage = "Renk başarıyla eklendi.";
        public static string DeleteColorMessage = "Renk başarıyla silindi.";
        public static string EditColorMessage = "Renk başarıyla güncellendi.";
        public static string GetSuccessColorMessage = "Renk bilgisi / bilgileri getirildi.";
        public static string GetErrorColorMessage = "Renk bilgisi / bilgileri getirilemedi.";
    }
}
