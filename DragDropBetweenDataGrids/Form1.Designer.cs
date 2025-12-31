
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid;

namespace DragDropBetweenDataGrids
{
    partial class Form1
    {
        private IContainer components = null;
        private SfDataGrid sfDataGrid1;
        private SfDataGrid sfDataGrid2;
        private Label labelDropAction;
        private ComboBox comboBoxDropAction;
        private FlowLayoutPanel headerPanel;
        private TableLayoutPanel mainTable;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            this.labelDropAction = new Label();
            this.comboBoxDropAction = new ComboBox();
            this.sfDataGrid1 = new SfDataGrid();
            this.sfDataGrid2 = new SfDataGrid();
            this.headerPanel = new FlowLayoutPanel();
            this.mainTable = new TableLayoutPanel();

            ((ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            ((ISupportInitialize)(this.sfDataGrid2)).BeginInit();
            this.SuspendLayout();

            // --- Form DPI settings (supported in older frameworks) ---
            this.AutoScaleDimensions = new SizeF(96F, 96F);  // baseline
            this.AutoScaleMode = AutoScaleMode.Dpi;

            // --- Header panel (label + combo) ---
            this.headerPanel.AutoSize = true;
            this.headerPanel.Dock = DockStyle.Top;
            this.headerPanel.Margin = new Padding(8);
            this.headerPanel.Padding = new Padding(8);
            this.headerPanel.WrapContents = false;

            // labelDropAction
            this.labelDropAction.AutoSize = true;
            this.labelDropAction.Text = "CrossGridDropAction:";
            this.labelDropAction.Margin = new Padding(0, 6, 12, 6);

            // comboBoxDropAction
            this.comboBoxDropAction.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxDropAction.Items.AddRange(new object[] { "Move", "Copy" });
            this.comboBoxDropAction.Width = 140;
            this.comboBoxDropAction.SelectedIndexChanged += new System.EventHandler(this.comboBoxDropAction_SelectedIndexChanged);

            this.headerPanel.Controls.Add(this.labelDropAction);
            this.headerPanel.Controls.Add(this.comboBoxDropAction);
            this.headerPanel.Padding = new Padding(50,50,0,0);

            // --- Main table layout: 2 rows ---
            this.mainTable.Dock = DockStyle.Fill;
            this.mainTable.ColumnCount = 1;
            this.mainTable.RowCount = 2;
            this.mainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.mainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.mainTable.Padding = new Padding(40);

            // sfDataGrid1
            this.sfDataGrid1.AccessibleName = "Table";
            this.sfDataGrid1.AllowDraggingColumns = true;
            this.sfDataGrid1.AllowDraggingRows = true;
            this.sfDataGrid1.AllowDrop = true;
            this.sfDataGrid1.AllowFiltering = true;
            this.sfDataGrid1.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.sfDataGrid1.SelectionMode = Syncfusion.WinForms.DataGrid.Enums.GridSelectionMode.Multiple;
            this.sfDataGrid1.ShowGroupDropArea = true;
            this.sfDataGrid1.Dock = DockStyle.Fill;

            // sfDataGrid2
            this.sfDataGrid2.AccessibleName = "Table";
            this.sfDataGrid2.AllowDraggingColumns = true;
            this.sfDataGrid2.AllowDraggingRows = true;
            this.sfDataGrid2.AllowDrop = true;
            this.sfDataGrid2.AllowFiltering = true;
            this.sfDataGrid2.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.sfDataGrid2.SelectionMode = Syncfusion.WinForms.DataGrid.Enums.GridSelectionMode.Multiple;
            this.sfDataGrid2.ShowGroupDropArea = true;
            this.sfDataGrid2.Dock = DockStyle.Fill;

            this.mainTable.Controls.Add(this.sfDataGrid1, 0, 0);
            this.mainTable.Controls.Add(this.sfDataGrid2, 0, 1);

            // Form
            this.BackColor = SystemColors.Window;
            this.ClientSize = new Size(1344, 740);
            this.MinimumSize = new Size(659, 477);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Drag and Drop";
            this.WindowState = FormWindowState.Maximized;

            this.Controls.Add(this.mainTable);
            this.Controls.Add(this.headerPanel);

            ((ISupportInitialize)(this.sfDataGrid1)).EndInit();
            ((ISupportInitialize)(this.sfDataGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}