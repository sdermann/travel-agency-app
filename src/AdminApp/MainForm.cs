using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Models;

namespace AdminApp
{
    public partial class MainForm : Form
    {
       
            static List<Portion> Trips = new List<Portion> { new Portion(new Trip("Spain", 500, "Rive", "TwoRooms", "Maria"), 2), new Portion(new Trip("USA", 5000, "Uni", "Room", "Gorge"), 9) };
            Agency CoralTravel = new Agency("CoralTravel", "Cool",Trips.Count, 0, Trips);
            VisitEasy store;
            public MainForm(ref VisitEasy easy)
            {
                InitializeComponent();
                store = easy;
            
                store.FillTestData(20);
                store.Agencies.Add(CoralTravel);
                agencyBindingSource.DataSource = store.Agencies;
            }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            store.Load();
            agencyBindingSource.ResetBindings(false);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!store.IsDirty)
                return;
            var res = MessageBox.Show("Save data before exit?", "", MessageBoxButtons.YesNoCancel);
            switch (res)
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    store.Save();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pf = new EditAgency();
            if (pf.ShowDialog() == DialogResult.OK)
            {
                store.AddAgency(pf.Agency);
                agencyBindingSource.ResetBindings(false);
                store.IsDirty = true;

                // select and scroll to the last row
                var lastIdx = agencyGridView1.Rows.Count - 1;
                agencyGridView1.Rows[lastIdx].Selected = true;
                agencyGridView1.FirstDisplayedScrollingRowIndex = lastIdx;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var toEdit = agencyGridView1.SelectedRows[0].DataBoundItem as Agency;
            var pf = new EditAgency(toEdit);
            if (pf.ShowDialog() == DialogResult.OK)
            {
                agencyBindingSource.ResetBindings(false);
                store.IsDirty = true;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var toDel = agencyGridView1.SelectedRows[0].DataBoundItem as Agency;
            var res = MessageBox.Show($"Delete {toDel.Name} ?", "", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                store.Agencies.Remove(toDel);
                agencyBindingSource.ResetBindings(false);
                store.IsDirty = true;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            store.Save();
        }

        private void agencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editToolStripMenuItem.Enabled =
            deleteToolStripMenuItem.Enabled =
            agencyGridView1.SelectedRows.Count > 0;
        }
    }
}
