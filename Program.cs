using Abstraction;
YazilimGelistirme yazilimci1 = new YazilimGelistirme();
yazilimci1._ad = "Muhsin";
yazilimci1._soyAd = "Tahsin";
yazilimci1._departman = "IT";

SatisTemsilcisi satis1 = new SatisTemsilcisi();
satis1._ad = "Nafiz";
satis1._soyAd = "Mafiz";
satis1._departman = "Satis";

ProjeYoneticisi yonetici1 = new ProjeYoneticisi();
yonetici1._ad = "Vunay";
yonetici1._soyAd = "Munay";
yonetici1._departman = "Yonetim";

yazilimci1.Gorev();
satis1.Gorev();
yonetici1.Gorev();