using SharpShell.Attributes;
using SharpShell.SharpDeskBand;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NetWork
{
    [ComVisible(true)]
    [DisplayName("网速")]
    public class Class1 : SharpDeskBand
    {
        protected override UserControl CreateDeskBand()
        {
            return new UserControl1();
        }

        protected override BandOptions GetBandOptions()
        {
            return new BandOptions
            {
                HasVariableHeight = true
            };
        }
    }
}
