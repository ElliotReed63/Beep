using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Prototype
{
    public partial class Leaderboard1 : BaseGUI
    {
        public Leaderboard1()
        {
            InitializeComponent();
        }

        private void Leaderboard1_Load(object sender, EventArgs e)
        {

            
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
/*             // Clear arrows from all columns
            foreach (DataGridViewColumn col in grid.Columns)
            {
                col.HeaderCell.SortGlyphDirection = SortOrder.None; //resets the column arrow
            }

            // Set the arrow on the clicked column based on direction
            if (direction == ListSortDirection.Ascending)
            {
                column.HeaderCell.SortGlyphDirection = SortOrder.Ascending;
            }
            else
            {
                column.HeaderCell.SortGlyphDirection = SortOrder.Descending;
            }
*/