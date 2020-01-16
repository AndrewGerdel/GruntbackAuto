namespace GruntbackAuto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zip = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PaymentInfoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreditCardNumber = c.String(),
                        CCV = c.Int(nullable: false),
                        BillingZip = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Customers", "Address_ID", c => c.Int());
            AddColumn("dbo.Customers", "PaymentInfo_ID", c => c.Int());
            CreateIndex("dbo.Customers", "Address_ID");
            CreateIndex("dbo.Customers", "PaymentInfo_ID");
            AddForeignKey("dbo.Customers", "Address_ID", "dbo.Addresses", "ID");
            AddForeignKey("dbo.Customers", "PaymentInfo_ID", "dbo.PaymentInfoes", "ID");
            DropColumn("dbo.Customers", "PaymentInfo_CreditCardNumber");
            DropColumn("dbo.Customers", "PaymentInfo_CCV");
            DropColumn("dbo.Customers", "PaymentInfo_BillingZip");
            DropColumn("dbo.Customers", "Address_Address1");
            DropColumn("dbo.Customers", "Address_Address2");
            DropColumn("dbo.Customers", "Address_City");
            DropColumn("dbo.Customers", "Address_State");
            DropColumn("dbo.Customers", "Address_Zip");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Address_Zip", c => c.String());
            AddColumn("dbo.Customers", "Address_State", c => c.String());
            AddColumn("dbo.Customers", "Address_City", c => c.String());
            AddColumn("dbo.Customers", "Address_Address2", c => c.String());
            AddColumn("dbo.Customers", "Address_Address1", c => c.String());
            AddColumn("dbo.Customers", "PaymentInfo_BillingZip", c => c.String());
            AddColumn("dbo.Customers", "PaymentInfo_CCV", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "PaymentInfo_CreditCardNumber", c => c.String());
            DropForeignKey("dbo.Customers", "PaymentInfo_ID", "dbo.PaymentInfoes");
            DropForeignKey("dbo.Customers", "Address_ID", "dbo.Addresses");
            DropIndex("dbo.Customers", new[] { "PaymentInfo_ID" });
            DropIndex("dbo.Customers", new[] { "Address_ID" });
            DropColumn("dbo.Customers", "PaymentInfo_ID");
            DropColumn("dbo.Customers", "Address_ID");
            DropTable("dbo.PaymentInfoes");
            DropTable("dbo.Addresses");
        }
    }
}
