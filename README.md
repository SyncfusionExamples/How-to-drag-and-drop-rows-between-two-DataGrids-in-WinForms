# How to drag and drop rows between two Data Grids in WinForms

This sample demonstrates how to drag and drop rows between two `Data Grid` controls and control the behavior when dropping into another grid by using the `CrossGridDropAction` property.

The sample includes both available actions:

- `CrossGridDropAction.Move` - the dragged records are removed from the source grid and added to the target grid.
- `CrossGridDropAction.Copy` - the dragged records are copied to the target grid without removing them from the source grid.

> [!NOTE]
> The `CrossGridDropAction` property applies only when rows are dragged between two `Data Grid` controls. Dragging from other controls, such as `ListView`, into an `Data Grid` does not support these actions.

## Screenshot

![Drag and Drop Between Grids](Assets/DragAndDropBetweenGrids_Image.png)

## Requirements

- Visual Studio 2022
- .NET Framework 4.6.2 or .NET 8/9/10 on Windows
- Syncfusion WinForms `Data Grid` package

## How to run this example

1. Open the `DragDropBetweenDataGrids.sln` file in Visual Studio.
2. Restore the required NuGet packages.
3. Set the startup project to `DragDropBetweenDataGrids`.
4. Build and run the application.

## Project structure

- `DragDropBetweenDataGrids/` - main sample project
  - `Form1.cs` - contains the drag-and-drop logic and action selection
  - `OrderInfo.cs` and `OrderInfoCollection.cs` - sample data models
  - `Form1.Designer.cs` - UI layout

## Documentation

- [WinForms DataGrid documentation](https://help.syncfusion.com/windowsforms/datagrid/overview)
- [CrossGridDropAction API reference](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.DataGrid.Enums.CrossGridDropAction.html)
