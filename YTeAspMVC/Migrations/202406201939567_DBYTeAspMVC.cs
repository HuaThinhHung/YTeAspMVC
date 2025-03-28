namespace YTeAspMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBYTeAspMVC : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bookings", "BookingTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bookings", "BookingTime");
        }
    }
}
