namespace Rail_Reserv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class signup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Passengers",
                c => new
                    {
                        PassengerId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(nullable: false),
                        Phone = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.String(),
                        Address = c.String(),
                        Password = c.String(nullable: false),
                        ConfirmPass = c.String(),
                    })
                .PrimaryKey(t => t.PassengerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Passengers");
        }
    }
}
