using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform
{
    public partial class ButtonAndViewer: UserControl
    {

        /// <summary>
        /// 保存一个数
        /// </summary>
        Int16 iValue1 = 0;






        /// <summary>
        /// 按钮事件
        /// </summary>
        [Description("Press button")]
        public event EventHandler Event1;


        [Description("value will show in the io filed"), Category("Data")]
        public Int16 Value1
        {
            get
            {
                return iValue1;
            }
            set
            {
                iValue1 = value;
                iOValue1.Text = iValue1.ToString();
            }

        }


        public ButtonAndViewer()
        {
            InitializeComponent();
        }

        

        private void btnEvent1_Click(object sender, EventArgs e)
        {
            if (this!=null)
            {
                this.Event1(this, e);
            }
        }
    }
}
