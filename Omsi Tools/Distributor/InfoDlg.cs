using System;

namespace OmsiTools.Distributor
{
    public partial class InfoDlg : Telerik.WinControls.UI.RadForm
    {
        public InfoDlg()
        {
            InitializeComponent();
            radWaitingBar1.StartWaiting();
        }
    }
}
