using Business.Abstract;
using DataAccess;
using DataAccess.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class PersonelMan:IPersonelService
    {
        IPersonelDal persdal;
        public PersonelMan(IPersonelDal persdal)
        {
            this.persdal = persdal;
        }
        public List<Personel> GetAll()
        {
            return persdal.Liste();
        }

        public int PersonelEkle(Personel pers)
        {
            if (pers.personel_ad.Length > 10)
            {
                return -1;
                
            }
            return persdal.Ekle(pers);
        }

        public int PersonelSil(Personel pers)
        {
            if(pers.personel_id == 5)
            {
                return persdal.Sil(pers);
            }
            return -1;
        }

        public int PersonelGuncelle(Personel pers)
        {
            if(pers.personel_id == 2)
            {
                return persdal.Guncelle(pers);
            }
            return -1;
        }


    }
}
