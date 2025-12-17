using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;

namespace DragDropBetweenDataGrids
{
    partial class Form1
    {
        private IContainer components = null;
        private SfDataGrid sfDataGrid1;
        private SfDataGrid sfDataGrid2;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel headerPanel;
        private Label labelDropAction;
        private ComboBox comboBoxDropAction;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.headerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.labelDropAction = new System.Windows.Forms.Label();
            this.comboBoxDropAction = new System.Windows.Forms.ComboBox();
            this.sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.sfDataGrid2 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid2)).BeginInit();
            this.SuspendLayout();

            // Set the window caption for the Drag and Drop sample
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Text = "Drag and Drop";

            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.AutoSize = false;
            
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1512, 925);

            // 
            // headerPanel
            // 
            this.headerPanel.AutoSize = true;
            this.headerPanel.Dock = DockStyle.Fill;
            this.headerPanel.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.headerPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.TabIndex = 10;

            // 
            // labelDropAction
            // 
            this.labelDropAction.AutoSize = true;
            this.labelDropAction.Margin = new System.Windows.Forms.Padding(0, 6, 8, 0);
            this.labelDropAction.Text = "CrossGridDropAction:";

            // 
            // comboBoxDropAction
            // 
            this.comboBoxDropAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDropAction.Items.AddRange(new object[] { "Move", "Copy" });
            this.comboBoxDropAction.SelectedIndex = 0;
            this.comboBoxDropAction.SelectedIndexChanged += new System.EventHandler(this.comboBoxDropAction_SelectedIndexChanged);

            // add header controls
            this.headerPanel.Controls.Add(this.labelDropAction);
            this.headerPanel.Controls.Add(this.comboBoxDropAction);

            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.AccessibleName = "Table";
            this.sfDataGrid1.AllowFiltering = true;
            this.sfDataGrid1.AutoSize = false;
            this.sfDataGrid1.Dock = DockStyle.Fill;
            this.sfDataGrid1.Margin = new System.Windows.Forms.Padding(20);
            this.sfDataGrid1.Name = "sfDataGrid1";
            this.sfDataGrid1.RowHeight = (int)DpiAware.LogicalToDeviceUnits(21.0f);
            this.sfDataGrid1.ShowGroupDropArea = true;
            this.sfDataGrid1.TabIndex = 0;
            this.sfDataGrid1.Text = "sfDataGrid1";
            this.sfDataGrid1.AutoSizeColumnsMode = AutoSizeColumnsMode.Fill;
            this.sfDataGrid1.SelectionMode = GridSelectionMode.Multiple;
            this.sfDataGrid1.AllowDraggingRows = true;
            this.sfDataGrid1.AllowDraggingColumns = true;
            this.sfDataGrid1.AllowDrop = true;

            // 
            // sfDataGrid2
            // 
            this.sfDataGrid2.AccessibleName = "Table";
            this.sfDataGrid2.AllowFiltering = true;
            this.sfDataGrid2.AutoSize = false;
            this.sfDataGrid2.Dock = DockStyle.Fill;
            this.sfDataGrid2.Margin = new System.Windows.Forms.Padding(20);
            this.sfDataGrid2.Name = "sfDataGrid2";
            this.sfDataGrid2.RowHeight = (int)DpiAware.LogicalToDeviceUnits(21.0f);
            this.sfDataGrid2.ShowGroupDropArea = true;
            this.sfDataGrid2.TabIndex = 1;
            this.sfDataGrid2.Text = "sfDataGrid2";
            this.sfDataGrid2.AutoSizeColumnsMode = AutoSizeColumnsMode.Fill;
            this.sfDataGrid2.SelectionMode = GridSelectionMode.Multiple;
            this.sfDataGrid2.AllowDraggingRows = true;
            this.sfDataGrid2.AllowDraggingColumns = true;
            this.sfDataGrid2.AllowDrop = true;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1512, 925);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.MinimumSize = new System.Drawing.Size(739, 585);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drag and Drop";

            // Add controls to layout
            this.tableLayoutPanel1.Controls.Add(this.headerPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.sfDataGrid1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.sfDataGrid2, 0, 2);

            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

