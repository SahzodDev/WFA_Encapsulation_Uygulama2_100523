using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Encapsulation_Uygulama2_100523
{
    internal class Bilgiler
    {
        

        private string isim;

        public string İsim
        {
            get 
            { 
                return isim; 
            }
            set 
            { 
                if (value.Length < 2)
                {
                    throw new ArgumentException("İsim 2 karakterden küçük olamaz.");
                }
                else
                {
                    isim = value;
                }
                
            }
        }

        private string soyisim;

        public string Soyisim
        {
            get 
            { 
                return soyisim; 
            }
            set 
            { 
                if (value.Length < 2)
                {
                    throw new ArgumentException("Soyisim 2 karakterden küçük olamaz.");
                }
                else
                {
                    soyisim = value;
                }
                
            }
        }

        private string tcNo;

        public string TC
        {
            get 
            { 
                
                return tcNo; 
            }
            set 
            { 
                if (!Int64.TryParse(value, out long tc))
                {
                    throw new ArgumentException("TC no yalnızca rakamlardan oluşabilir.");
                }
                else if (value.ToString().Length != 11)
                {
                    throw new ArgumentException("TC no 11 haneli olmalı.");
                }
                else
                {
                    tcNo = value;
                }
                
            }
        }

        private string email;

        public string Email
        {
            get 
            { 
                return email; 
            }
            set 
            { 
                if (!value.Contains("@bilgeadam.com")) 
                {
                    throw new ArgumentException("Geçersiz email adresi.");
                }
                else
                {
                    email = value;
                }
                 
            }
        }

        public string Cinsiyet { get; set; }
    }
}
