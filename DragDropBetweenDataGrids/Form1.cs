using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;

namespace DragDropBetweenDataGrids
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Bind sample order data to the grids
            OrderInfoCollection collection = new OrderInfoCollection();
            this.sfDataGrid1.DataSource = collection.Collection1;
            this.sfDataGrid2.DataSource = collection.Collection2;
        }

        private void comboBoxDropAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            var action = (comboBoxDropAction.SelectedItem?.ToString() == "Copy")
                ? CrossGridDropAction.Copy
                : CrossGridDropAction.Move;

            this.sfDataGrid1.CrossGridDropAction = action;
            this.sfDataGrid2.CrossGridDropAction = action;
        }
    }
}
