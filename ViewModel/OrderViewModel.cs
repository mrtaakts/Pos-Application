using System.ComponentModel.DataAnnotations;

namespace pos.ViewModel
{
    public class OrderViewModel
    {
        public string Yemek { get; set; }
        public int Adet { get; set; }
        public double Fiyat { get; set; }


    }
}