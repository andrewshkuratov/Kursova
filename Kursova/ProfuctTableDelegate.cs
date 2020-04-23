using System;
using AppKit;
namespace Kursova
{
    public class ProductTableDelegate : NSTableViewDelegate
    {
        private const string CellIdentifier = "ProdCell";

        private ProductTableDataSource DataSource;

        public ProductTableDelegate(ProductTableDataSource datasource)
        {
            this.DataSource = datasource;
        }

        public override NSView GetViewForItem(NSTableView tableView, NSTableColumn tableColumn, nint row)
        {
            NSTextField view = (NSTextField)tableView.MakeView(CellIdentifier, this);
            if (view == null)
            {
                view = new NSTextField();
                view.Identifier = CellIdentifier;
                view.BackgroundColor = NSColor.Clear;
                view.Bordered = false;
                view.Selectable = false;
                view.Editable = false;
            }

            // Setup view based on the column selected
            switch (tableColumn.Title)
            {
                case "Product Name":
                    view.StringValue = DataSource.products[(int)row].name;
                    break;
                case "Creation Date":
                    view.StringValue = DataSource.products[(int)row].date;
                    break;
                case "Producer Name":
                    view.StringValue = DataSource.products[(int)row].producer;
                    break;
                case "Price":
                    view.StringValue = (DataSource.products[(int)row].price).ToString();
                    break;
            }

            return view;
        }
    }
}
