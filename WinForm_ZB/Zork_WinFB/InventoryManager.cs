using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using InventoryManager.Data;
using System.IO;
using Zork_WinFB.ViewModels;

namespace Zork_WinFB
{
    public partial class InventoryManager : Form
    {
        private WorldViewModel ViewModel {
            get => mViewModel;
            set => mViewModel = value;
        }
        public InventoryManager()
        {
            InitializeComponent();
            ViewModel = new WorldViewModel();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void InventoryManager_Load(object sender, EventArgs e)
        {

        }

        private void SelectfileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.World = JsonConvert.DeserializeObject<World>(File.ReadAllText(openFileDialog.FileName));
                ViewModel.Filename = openFileDialog.FileName;
            }
        }

        private WorldViewModel mViewModel;

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
