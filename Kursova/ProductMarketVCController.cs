using System.Collections.Generic;
using Foundation;
using AppKit;
using ObjCRuntime;
using System;

namespace Kursova
{
    public partial class ProductMarketVCController : AppKit.NSViewController
    {
        List<Product> product = new List<Product>();
        Database db = new Database();
        ProductTableDataSource dataSource = new ProductTableDataSource();

        [Export("initWithCoder:")]
        public ProductMarketVCController(NSCoder coder) : base(coder)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            UpdateDataSource("");
        }

        partial void FindProduct(Foundation.NSObject sender)
        {
            UpdateDataSource(FindField.StringValue);
        }

        partial void DeleteAllData(NSObject sender)
        {
            db.RemoveAll();
            UpdateDataSource("");
        }

        void UpdateDataSource(String param)
        {
            product = db.GetFromDb(param);
            dataSource.products = product;
            ProductTableView.DataSource = dataSource;
            ProductTableView.Delegate = new ProductTableDelegate(dataSource);
            ProductTableView.ReloadData();
        }
    }
}
