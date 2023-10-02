using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class CITATION
    {
        public string CITATION_LINK { get; set; }
    }

    public class DPLHIT
    {
        public string SCORE { get; set; }
        public string NAME { get; set; }
        public string ADDRESS { get; set; }
        public string CITY { get; set; }
        public string COUNTRY { get; set; }
        public string ALSO_KNOWN_AS { get; set; }
        public string AGENCY { get; set; }
        public string COUNTRY_OF_ORIGIN { get; set; }
        public string PRIVILEGE { get; set; }
        public string EFF_DATE { get; set; }
        public string EXP_DATE { get; set; }
        public string FR_DATE { get; set; }
        public CITATION CITATION { get; set; }
        public string DPL_CATEGORY { get; set; }
    }

    public class DPLHITSDETAIL
    {
        public string ORDER_NO { get; set; }
        public string TOTAL_HITS_COUNT { get; set; }
        public List<EACHGIVENNAME> EACH_GIVEN_NAME { get; set; }
    }

    public class EACHGIVENNAME
    {
        public string CODE { get; set; }
        public string GIVEN_NAME { get; set; }
        public string STATUS { get; set; }
        public string DPL_DATE { get; set; }
        public string TOTAL_HITS { get; set; }
        public List<DPLHIT> DPL_HITS { get; set; }
    }

    public class JsonRespose
    {
        public WLSENTITYSCREENRESPONSE WLS_ENTITY_SCREEN_RESPONSE { get; set; }
    }

    public class WLSENTITYSCREENRESPONSE
    {
        public string STATUS { get; set; }
        public DPLHITSDETAIL DPL_HITS_DETAIL { get; set; }
    }
}
