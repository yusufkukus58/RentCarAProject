using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
  public static  class Messages
    {
        public static string CarAdded="Araba Eklendi.";
        public static string CarDeleted="Araba Silindi.";
        public static string CarUpdated="Araba Güncellendi.";
        public static string BrandAdded="Marka Eklendi.";
        public static string BrandDeleted="Marka Silindi.";
        public static string BrandUpdated="Marka Güncellendi.";
        public static string ColorAdded="Renk Eklendi.";
        public static string ColorDeleted="Renk Silindi.";
        public static string ColorUpdated="Renk Güncellendi.";
        public static string ColorListed="Renk Listelendi.";
        public static string CarListed="Araba Listelendi.";
        public static string BrandListed="Marka Listelendi.";
        public static string CustomerAdded="Müşteriler Eklendi.";
        public static string CustomerDeleted="Müşteriler Silindi.";
        public static string CustomerUpdated="Müşteriler Güncellendi.";
        public static string CustomerListed="Müşteriler Listelendi.";
        public static string InvalidSale = "Geçersiz Kiralama";
        public static string RentalAdded = "Arabayı Kiraladınız.";
        public static string RentalNotAdded = "Malesef arabayı kiralayamazsınız. ";
        public static string RentalList = "Kiralana İşlemleri listelendi.";

        public static string CarImageAdded = "Araba resmi eklendi.";
        public static string CarImageDelete = "Arabanın resmi silindi.";
        public static string CarImageUpdate = "Arabanın resmi güncellendi.";
        public static string CarImageNotFound = "Araba fotografı bulunamaadı.";

       
        public static string FailAddedImageLimit = "Fotograf koyma limitiniz dolmuştur.";

        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string SuccessfulLogin = "Giriş başarılı";

        public static string PasswordError = "Şifre yanlış";

        public static string UserNotFount = "Kullanıcı bulunamadı";

        public static string CarImageIsNotExists { get; internal set; }
      
    }
}
