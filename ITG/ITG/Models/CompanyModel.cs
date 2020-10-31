using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ITG.Models
{
    public class Company : Companies
    {
        [XmlElement("id")]
        public string id { get; set; }

        [XmlElement("inn")]
        public string inn { get; set; }

        [XmlElement("kpp")]
        public string kpp { get; set; }

        [XmlElement("date_accept")]
        public string date_accept { get; set; }

        [XmlElement("ogrn")]
        public string ogrn { get; set; }
    }

    [XmlRoot("companies")]
    public class Companies
    {
        [XmlElement("company")]
        public Company[] company { get; set; }
    }
}


/*
 * <inn>7744001497</inn>
<ogrn>1027700167110</ogrn>
<kpp>772801001</kpp>
<short_name>БАНК ГПБ (АО)</short_name>
<full_name>
<![CDATA[ "ГАЗПРОМБАНК" (АКЦИОНЕРНОЕ ОБЩЕСТВО) ]]>
</full_name>
<phone>74992772568</phone>
<fax>--</fax>
<email>Boris.Makuev@gazprombank.ru</email>
<addr_main>117420, Г МОСКВА, УЛ НАМЁТКИНА, 16, 1,</addr_main>
<addr_post>117420, Г МОСКВА, УЛ НАМЁТКИНА, 16, 1</addr_post>
<country>Российская Федерация (РФ, Россия)</country>
<profile_type>Резидент РФ</profile_type>
<date_last_update>2020-10-09 09:47:38+03</date_last_update>
<region>Москва</region>
<profile type="customer">Заказчик</profile>
<profile type="supplier">Юридическое лицо (РФ)</profile>
<accreditation type="customer">2015-11-25 18:39:00+03</accreditation>
<accreditation type="supplier">2019-09-30 12:11:02+03</accreditation>

 */
