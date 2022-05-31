using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acciopus.Post
{
    class Post
    {
        public int ilan_id;
        public String ilan_firma_adi;
        public int ilan_aranan_meslek_id;
        public String ilan_baslik;
        public String ilan_aciklama;
        public String ilan_teklif_edilen_maas;
        public String ilan_istenen_tecrube_suresi;
        public DateTime ilan_tarihi;

        public Post()
        {
        }

        public Post(int ilan_id, string ilan_firma_adi, int ilan_paylasan_id, int ilan_aranan_meslek_id, string ilan_baslik, string ilan_aciklama, string ilan_teklif_edilen_maas, string ilan_istenen_tecrube_suresi, DateTime ilan_tarihi)
        {
            this.ilan_id = ilan_id;
            this.ilan_firma_adi = ilan_firma_adi;
            this.ilan_aranan_meslek_id = ilan_aranan_meslek_id;
            this.ilan_baslik = ilan_baslik;
            this.ilan_aciklama = ilan_aciklama;
            this.ilan_teklif_edilen_maas = ilan_teklif_edilen_maas;
            this.ilan_istenen_tecrube_suresi = ilan_istenen_tecrube_suresi;
            this.ilan_tarihi = ilan_tarihi;
        }




    }

}
