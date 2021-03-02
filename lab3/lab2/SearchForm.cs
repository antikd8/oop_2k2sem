using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class SearchForm : Form
    {
        List<Flat> flats = new List<Flat>();
        public SearchForm(List<Flat> flats, SearchType searchType)
        {
            InitializeComponent();
            panelRooms.Enabled = false;
            panelDistrict.Enabled = false;
            panelYear.Enabled = false;
            this.flats = flats;
            if (searchType == SearchType.searchYear)
                panelYear.Enabled = true;
            if (searchType == SearchType.searchDistrict)
                panelDistrict.Enabled = true;
            if (searchType == SearchType.searchRooms)
                panelRooms.Enabled = true;

        }

        private void comboBoxDistrict_TextChanged(object sender, EventArgs e)
        {
            treeViewResult.Nodes.Clear();
            string n = comboBoxDistrict.Text;
            foreach (Flat x in flats)
                if (n == x.address.District)
                    treeViewResult.Nodes.Add(x.TakeElementTree());
                else
                    treeViewResult.Nodes.Add("Ничего не найдено!");
        }
    }
}
