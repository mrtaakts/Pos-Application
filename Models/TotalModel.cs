using System.ComponentModel.DataAnnotations;
using pos.ViewModel;
using pos.Models;
using POS.Models;

namespace pos.Models
{
    public class TotalModel
    {
        public OrderViewModel orderModel { get; set; }
        public Product produc { get; set; }
    }


}

