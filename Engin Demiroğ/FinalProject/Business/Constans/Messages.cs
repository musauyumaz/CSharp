using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductDeleted = "Ürün Silindi";
        public static string ProductUpdated = "Ürün Güncellendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductListed = "Ürünler Listelendi";
        public static string UnitPriceInvalid="Ürün fiyatı 0' a küçük ve eşit olamaz";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists ="Ürün ismi daha önceden kullanılmış";
        public static string CategoryLimitExceed = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string UserRegistered ="Kayıt Oldu";
        public static string UserNotFound ="Kullanıcı Bulunamadı";
        public static string PasswordError ="Parola Hatası";
        public static string SuccessfulLogin="Başarılı Giriş";
        public static string UserAlreadyExists="Kullanıcı Mevcut";
        public static string AccessTokenCreated="Token Zaten Oluşturulmuş";
        public static string AuthorizationDenied="Yetkilendirme Reddedildi";
    }
}
