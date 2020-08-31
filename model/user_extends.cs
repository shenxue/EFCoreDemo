using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreDemo
{
    [Table("user_extends")]
    public class user_extends
    {
        [System.ComponentModel.DataAnnotations.Key]
        public Guid userid { get; set; }
        /// <summary>
        /// 配偶情况
        /// </summary>
        public string wife_status { get; set; }
        /// <summary>
        /// 配偶姓名
        /// </summary>
        public string wife_name { get; set; }
        /// <summary>
        /// 配偶身份证件类型
        /// </summary>
        public string wife_idtype { get; set; }
        /// <summary>
        /// 配偶身份证件号码
        /// </summary>
        public string wife_idnumber { get; set; }
        /// <summary>
        /// 配偶国籍
        /// </summary>
        public string wife_nationality { get; set; }
        /// <summary>
        /// 配偶出生日期
        /// </summary>
        public DateTime? wife_birthday { get; set; }
        /// <summary>
        /// 是否实名认证通过
        /// </summary>
        public bool is_certification { get; set; } = false;
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? create_date { get; set; } = DateTime.Now;
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? update_date { get; set; } = DateTime.Now;
        /// <summary>
        /// 真实姓名
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 身份证号码
        /// </summary>
        public string idnumber { get; set; }

        /// <summary>
        /// 身份证件类型
        /// </summary>
        public string idtype { get; set; }

        /// <summary>
        /// 纳税人识别号
        /// </summary>
        public string taxpayer_idnumber { get; set; }

        /// <summary>
        /// 出生日期
        /// </summary>
        public string birthday { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string sex { get; set; }

        /// <summary>
        /// 国籍
        /// </summary>
        public string country { get; set; } = "中华人民共和国";

        /// <summary>
        /// 户籍所在地
        /// </summary>
        public string domicile { get; set; }

        /// <summary>
        /// 经常居住省
        /// </summary>
        public string frequent_province { get; set; }

        /// <summary>
        /// 经常居住市
        /// </summary>
        public string frequent_city { get; set; }

        /// <summary>
        /// 经常居住县
        /// </summary>
        public string frequent_county { get; set; }

        /// <summary>
        /// 经常居住详细地址
        /// </summary>
        public string frequent_detail { get; set; }

        /// <summary>
        /// 联系地址省
        /// </summary>
        public string contact_province { get; set; }

        /// <summary>
        /// 联系地址市
        /// </summary>
        public string contact_city { get; set; }

        /// <summary>
        /// 联系地址县
        /// </summary>
        public string contact_county { get; set; }

        /// <summary>
        /// 联系地址地址
        /// </summary>
        public string contact_detail { get; set; }

        /// <summary>
        /// 学历
        /// </summary>
        public string education { get; set; }

        /// <summary>
        /// 民族
        /// </summary>
        public string nation { get; set; }

        /// <summary>
        /// 电子邮箱
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// 身份证签发机关
        /// </summary>
        public string authority { get; set; }

        /// <summary>
        /// 身份证有效日期
        /// </summary>
        public string valid_date { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        public string nickname { get; set; }

        /// <summary>
        /// 用户头像
        /// </summary>
        public string avatarurl { get; set; }
        /// <summary>
        /// 是否已毕业
        /// </summary>
        public bool? is_graduation { get; set; }
    }
}
