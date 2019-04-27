using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiskModel
{
    public partial class MarkWoziControl : UserControl
    {
        public MarkWoziControl()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem_AddNewAssets(object sender, EventArgs e)
        {
            AssetForm aF = new AssetForm();
            aF.ShowDialog();
            AssetInfo info = aF.IResult;
            this.UpdateData(info);
        }

        private void ToolStripMenuItem_DeleteAssetClick(object sender, EventArgs e)
        {

        }

        private void UpdateData(AssetInfo info)
        {

        }
    }
}
