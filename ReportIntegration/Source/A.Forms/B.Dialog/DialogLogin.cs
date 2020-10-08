using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using Ulee.Controls;

namespace Sgs.ReportIntegration
{
    public partial class DialogLogin : UlFormEng
    {
        public string UserId { get { return idEdit.Text.Trim(); } }

        public string Passwd { get { return passwdEdit.Text; } }

        public DialogLogin()
        {
            InitializeComponent();
        }
    }
}
