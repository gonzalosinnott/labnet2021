using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabNet2021.TP05.GUI.Extensions
{
    public static class GridViewExtension
    {
        public static DataGridView RemoveEmptyColumns(this DataGridView grdView)
        {
            foreach (DataGridViewColumn clm in grdView.Columns)
            {
                bool notAvailable = true;
                //// If you don't want to hide button columns
                //if (clm is DataGridViewButtonColumn)
                //    continue;
                foreach (DataGridViewRow row in grdView.Rows)
                {
                    if (row.Cells[clm.Index].Value == null)
                        notAvailable = true;
                    else if (!string.IsNullOrEmpty(row.Cells[clm.Index].Value.ToString()))
                    {
                        notAvailable = false;
                        break;
                    }
                }
                if (notAvailable)
                {
                    grdView.Columns[clm.Index].Visible = false;
                }
            }
            return grdView;
        }
    }
    
}
