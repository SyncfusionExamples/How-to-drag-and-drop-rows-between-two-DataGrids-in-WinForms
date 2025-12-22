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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.labelDropAction = new System.Windows.Forms.Label();
            this.comboBoxDropAction = new System.Windows.Forms.ComboBox();
            this.sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.sfDataGrid2 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDropAction
            // 
            this.labelDropAction.AutoSize = true;
            this.labelDropAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10);
            this.labelDropAction.Location = new System.Drawing.Point(18, 10);
            this.labelDropAction.Name = "labelDropAction";
            this.labelDropAction.Size = new System.Drawing.Size(195, 20);
            this.labelDropAction.TabIndex = 3;
            this.labelDropAction.Text = "CrossGridDropAction:";
            // 
            // comboBoxDropAction
            // 
            this.comboBoxDropAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDropAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDropAction.Items.AddRange(new object[] {
            "Move",
            "Copy"});
            this.comboBoxDropAction.Location = new System.Drawing.Point(219, 6);
            this.comboBoxDropAction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDropAction.Name = "comboBoxDropAction";
            this.comboBoxDropAction.Size = new System.Drawing.Size(107, 28);
            this.comboBoxDropAction.TabIndex = 2;
            this.comboBoxDropAction.SelectedIndexChanged += new System.EventHandler(this.comboBoxDropAction_SelectedIndexChanged);
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.AccessibleName = "Table";
            this.sfDataGrid1.AllowDraggingColumns = true;
            this.sfDataGrid1.AllowDraggingRows = true;
            this.sfDataGrid1.AllowDrop = true;
            this.sfDataGrid1.AllowFiltering = true;
            this.sfDataGrid1.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.sfDataGrid1.Location = new System.Drawing.Point(44, 55);
            this.sfDataGrid1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sfDataGrid1.Name = "sfDataGrid1";
            this.sfDataGrid1.PreviewRowHeight = 35;
            this.sfDataGrid1.RowHeight = 24;
            this.sfDataGrid1.SelectionMode = Syncfusion.WinForms.DataGrid.Enums.GridSelectionMode.Multiple;
            this.sfDataGrid1.ShowGroupDropArea = true;
            this.sfDataGrid1.Size = new System.Drawing.Size(1460, 322);
            this.sfDataGrid1.Style.DragPreviewRowStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sfDataGrid1.TabIndex = 0;
            this.sfDataGrid1.Text = "sfDataGrid1";
            // 
            // sfDataGrid2
            // 
            this.sfDataGrid2.AccessibleName = "Table";
            this.sfDataGrid2.AllowDraggingColumns = true;
            this.sfDataGrid2.AllowDraggingRows = true;
            this.sfDataGrid2.AllowDrop = true;
            this.sfDataGrid2.AllowFiltering = true;
            this.sfDataGrid2.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.sfDataGrid2.Location = new System.Drawing.Point(44, 407);
            this.sfDataGrid2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sfDataGrid2.Name = "sfDataGrid2";
            this.sfDataGrid2.PreviewRowHeight = 35;
            this.sfDataGrid2.RowHeight = 24;
            this.sfDataGrid2.SelectionMode = Syncfusion.WinForms.DataGrid.Enums.GridSelectionMode.Multiple;
            this.sfDataGrid2.ShowGroupDropArea = true;
            this.sfDataGrid2.Size = new System.Drawing.Size(1460, 322);
            this.sfDataGrid2.Style.DragPreviewRowStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sfDataGrid2.TabIndex = 1;
            this.sfDataGrid2.Text = "sfDataGrid2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1344, 740);
            this.Controls.Add(this.sfDataGrid2);
            this.Controls.Add(this.sfDataGrid1);
            this.Controls.Add(this.comboBoxDropAction);
            this.Controls.Add(this.labelDropAction);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MinimumSize = new System.Drawing.Size(659, 477);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drag and Drop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

