using AppNet.Bussines.Abstract;
using AppNet.Domain.Entities.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNet.WinFormUI
{
    public partial class FrmSafe : Form
    {
        private IServiceProvider _sp;
        public FrmSafe(IServiceProvider sp)
        {
            this._sp = sp;
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int tahsilatTur = 0;
            if (cmbTahsilatTur.SelectedIndex==1)tahsilatTur = (int)TahsilatTur.nakit;
            else if(cmbTahsilatTur.SelectedIndex==2)tahsilatTur = (int)TahsilatTur.kKarti;
            else if(cmbTahsilatTur.SelectedIndex==3)tahsilatTur = (int)TahsilatTur.cek;
            
            var safe = _sp.GetRequiredService<ISafeService>();
            Safe newSafe = new Safe
            {
                Total = Convert.ToDecimal(txtMiktar.Text),
                AddingId = 1,
                Type = (int)SafeType.input,
                TahsilatTuru=tahsilatTur,
                Explanation = txtAciklama.Text,
                CustomerId = 1
            };
            safe.Add(newSafe);
        }

       
    }
}
