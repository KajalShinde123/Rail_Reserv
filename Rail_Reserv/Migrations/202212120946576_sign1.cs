namespace Rail_Reserv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sign1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TrainDetails",
                c => new
                    {
                        Train_id = c.Int(nullable: false, identity: true),
                        TrainName = c.String(nullable: false),
                        SourceStation = c.String(),
                        DestinationStation = c.String(),
                        Fare = c.String(),
                        ArrivalTime = c.String(),
                        DepartureTime = c.String(),
                        TotalSeats = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Train_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TrainDetails");
        }
    }
}
