using System;
namespace Abstraction
{
	public abstract class Calisan
	{
		public Calisan()
		{
		}
		public string _ad;
		public string _soyAd;
		public string _departman;
		public string _pozisyon;

		public virtual void Gorev()
		{
		}
	}
	public class ProjeYoneticisi:Calisan
	{
        public override void Gorev()
        {
			Console.WriteLine("Proje Yoneticisi olarak calisiyorum");
        }
    }
	public class YazilimGelistirme:Calisan
	{
        public override void Gorev()
        {
            Console.WriteLine("Yazilim gelistiricisi olarak calisiyorum");
        }
    }
    public class SatisTemsilcisi : Calisan
    {
        public override void Gorev()
        {
            Console.WriteLine("Satis temsilcisi olarak calisiyorum");
        }
    }
}

