using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    public class MasterDetail_FoodPageMasterMenuItem
    {
        public MasterDetail_FoodPageMasterMenuItem()
        {
            TargetType = typeof(MasterDetail_FoodPageMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}