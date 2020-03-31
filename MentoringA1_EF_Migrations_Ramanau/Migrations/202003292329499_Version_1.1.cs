namespace MentoringA1_EF_Migrations_Ramanau.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Version_11 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CreditCards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CardNumber = c.String(maxLength: 16),
                        ExpirationDate = c.String(maxLength: 4),
                        Cardholder = c.String(maxLength: 4),
                        Customer_CustomerID = c.String(maxLength: 5, fixedLength: true),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerID)
                .Index(t => t.Customer_CustomerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CreditCards", "Customer_CustomerID", "dbo.Customers");
            DropIndex("dbo.CreditCards", new[] { "Customer_CustomerID" });
            DropTable("dbo.CreditCards");
        }
    }
}
