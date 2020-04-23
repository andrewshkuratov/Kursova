using System;
using AppKit;
using System.Collections.Generic;
namespace Kursova
{
    enum cellIdentefiers
    {
        ProductCellID, DateCellID, ProducerCellID
    }

    public class ProductTableDataSource : NSTableViewDataSource
    {
        public List<Product> products = new List<Product>();

        public ProductTableDataSource()
        {
        }

        public override nint GetRowCount(NSTableView tableView)
        {
            return products.Count;
        }

        public void Sort(string key, bool ascending)
        {

            // Take action based on key
            switch (key)
            {
                case "Name":
                    if (ascending)
                    {
                        products.Sort((x, y) => x.name.CompareTo(y.name));
                    }
                    else
                    {
                        products.Sort((x, y) => -1 * x.name.CompareTo(y.name));
                    }
                    break;
                case "Date":
                    if (ascending)
                    {
                        products.Sort((x, y) => x.date.CompareTo(y.date));
                    }
                    else
                    {
                        products.Sort((x, y) => -1 * x.date.CompareTo(y.date));
                    }
                    break;
                case "Producer":
                    if (ascending)
                    {
                        products.Sort((x, y) => x.producer.CompareTo(y.producer));
                    }
                    else
                    {
                        products.Sort((x, y) => -1 * x.producer.CompareTo(y.producer));
                    }
                    break;
                case "Price":
                    if (ascending)
                    {
                        products.Sort((x, y) => x.price.CompareTo(y.price));
                    }
                    else
                    {
                        products.Sort((x, y) => -1 * x.price.CompareTo(y.price));
                    }
                    break;
            }

        }

        public override void SortDescriptorsChanged(NSTableView tableView, Foundation.NSSortDescriptor[] oldDescriptors)
        {
            // Sort the data
            if (oldDescriptors.Length > 0)
            {
                // Update sort
                Sort(oldDescriptors[0].Key, oldDescriptors[0].Ascending);
            }
            else
            {
                // Grab current descriptors and update sort
                Foundation.NSSortDescriptor[] tbSort = tableView.SortDescriptors;
                Sort(tbSort[0].Key, tbSort[0].Ascending);
            }

            // Refresh table
            tableView.ReloadData();
        }

    }
}
