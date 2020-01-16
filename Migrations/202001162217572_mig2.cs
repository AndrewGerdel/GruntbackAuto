namespace GruntbackAuto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Customer_ID = c.Int(),
                        Part_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.Customer_ID)
                .ForeignKey("dbo.Parts", t => t.Part_ID)
                .Index(t => t.Customer_ID)
                .Index(t => t.Part_ID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PaymentInfo_CreditCardNumber = c.String(),
                        PaymentInfo_CCV = c.Int(nullable: false),
                        PaymentInfo_BillingZip = c.String(),
                        Address_Address1 = c.String(),
                        Address_Address2 = c.String(),
                        Address_City = c.String(),
                        Address_State = c.String(),
                        Address_Zip = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Part_ID", "dbo.Parts");
            DropForeignKey("dbo.Orders", "Customer_ID", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "Part_ID" });
            DropIndex("dbo.Orders", new[] { "Customer_ID" });
            DropTable("dbo.Customers");
            DropTable("dbo.Orders");
        }
    }
}
