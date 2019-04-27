using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskModel
{
    public class AssetInfo
    {
        /// <summary>
        /// 资产名
        /// </summary>
        public string AssetName
        {
            get;
            set;
        }

        /// <summary>
        /// 资产期望收益率
        /// </summary>
        public double Er
        {
            get;
            set;
        }

        /// <summary>
        /// 资产收益率的标准差
        /// </summary>
        public double SD
        {
            get;
            set;
        }
    }
}
