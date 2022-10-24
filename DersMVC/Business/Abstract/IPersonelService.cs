using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPersonelService
    {
        public List<Personel> GetAll();
        public int PersonelEkle(Personel p);

        public int PersonelSil(Personel p);

        public int PersonelGuncelle(Personel p);
    }
}
