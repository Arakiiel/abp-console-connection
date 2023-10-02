using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class ConsContactTableValue
    {
        public string consigneeId { get; set; }
        public string primaryContact { get; set; }
        public string contactName { get; set; }
        public string addr1 { get; set; }
        public string addr2 { get; set; }
        public string addr3 { get; set; }
        public string city { get; set; }
        public string stateCode { get; set; }
        public string state { get; set; }
        public string consCountry { get; set; }
        public string consCountryName { get; set; }
        public string zip { get; set; }
        public string contactPhone { get; set; }
        public string fax { get; set; }
        public string eMail { get; set; }
        public string ci { get; set; }
        public string consCi { get; set; }
        public string cci { get; set; }
        public string consCci { get; set; }
        public string sed { get; set; }
        public string sli { get; set; }
        public string consSed { get; set; }
        public string consSli { get; set; }
        public string nafta { get; set; }
        public string awb { get; set; }
        public string hawb { get; set; }
        public string mawb { get; set; }
        public string billOfLadg { get; set; }
        public string certOfOrigin { get; set; }
        public string lSheet { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string cmrEu { get; set; }
        public string eurEu { get; set; }
        public string gspEu { get; set; }
        public string gdEu { get; set; }
        public string atrEu { get; set; }
    }

    public class Root
    {
        public WLSENTITYSCREENREQUEST WLS_ENTITY_SCREEN_REQUEST { get; set; }
    }

    public class WLSENTITYSCREENREQUEST
    {
        public WLSGLOBALHEADER WLS_GLOBAL_HEADER { get; set; }
        public List<WLSSCREENINGPARAM> WLS_SCREENING_PARAM { get; set; }
    }

    public class WLSGLOBALHEADER
    {
        public string LOAD_DATA { get; set; }
        public string SCREEN_DATA { get; set; }
        public string EMAIL { get; set; }
        public string ORDER_NO { get; set; }
        public string VERSION_NO { get; set; }
        public string USERNAME { get; set; }
    }

    public class WLSSCREENINGPARAM
    {
        public string ENTITY_ID { get; set; }
        public string KEY_NAME { get; set; }
        public string FIELD_TYPE { get; set; }
        public string CONTACT_NO { get; set; }
        public string NAME { get; set; }
        public string COUNTRY_CODE { get; set; }
        public string ADDRESS1 { get; set; }
        public string ADDRESS2 { get; set; }
        public string ADDRESS3 { get; set; }
        public string SCREEN_DATE { get; set; }
        public string SCREEN_STATUS { get; set; }
        public string ENTITY_TYPE { get; set; }
        public string SBU_CODE { get; set; }
        public string F_NAME { get; set; }
        public string M_NAME { get; set; }
        public string STATE_NAME { get; set; }
        public string CITY { get; set; }
        public string ZIP_CODE { get; set; }
        public List<ConsContactTableValue> consContactTableValue { get; set; }
    }
}
