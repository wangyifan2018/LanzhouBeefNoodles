using LanzhouBeefNoodles.Models;
using System.Collections.Generic;

namespace LanzhouBeefNoodles.ViewModels
{
    public class HomeViewModel
    {
        public IList<Noodle> Noodles { get; set; }
        public IList<Feedback> Feedbacks { get; set; }

    }
}
