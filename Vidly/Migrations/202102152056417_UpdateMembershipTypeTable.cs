namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypeTable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Type1' WHERE id = 1");
            Sql("UPDATE MembershipTypes SET Name = 'Type2' WHERE id = 2");
            Sql("UPDATE MembershipTypes SET Name = 'Type3' WHERE id = 3");
            Sql("UPDATE MembershipTypes SET Name = 'Type4' WHERE id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
