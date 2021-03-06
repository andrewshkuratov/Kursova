// This file has been autogenerated from a class added in the UI designer.

using System;
using Foundation;
using AppKit;

namespace Kursova
{
	public partial class AddProductController : NSViewController
	{
		Database db = new Database();

        // Called when created directly from a XIB file
        [Export("initWithCoder:")]
        public AddProductController(NSCoder coder) : base(coder)
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        partial void AddProductAction(NSObject sender)
        {
            if (productName.StringValue == "")
            {
                var message = new NSAlert();
                message.MessageText = "Empty Product Value";
                message.RunModal();
            }
            else if(producerName.StringValue == "")
            {
                var message = new NSAlert();
                message.MessageText = "Empty Producer Value";
                message.RunModal();
            }
            else if (price.StringValue == "")
            {
                var message = new NSAlert();
                message.MessageText = "Empty Price Value";
                message.RunModal();
            }
            else if (date.StringValue == "")
            {
                var message = new NSAlert();
                message.MessageText = "Empty Date Value";
                message.RunModal();
            }
            else
            {
                var priceValue = new double();
                try
                {
                    priceValue = double.Parse(price.StringValue);
                } catch (Exception e)
                {
                    var message = new NSAlert();
                    message.MessageText = "Price field : " + e.Message;
                    message.RunModal();
                    return;
                }
                db.InsertToDb(productName.StringValue, date.StringValue, producerName.StringValue, priceValue);
                this.View.Window.OrderOut(null);
            }
        }

    }
}
