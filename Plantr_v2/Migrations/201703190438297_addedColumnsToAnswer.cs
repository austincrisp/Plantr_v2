namespace Plantr_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedColumnsToAnswer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Answers", "AnswerOne", c => c.String());
            AddColumn("dbo.Answers", "AnswerTwo", c => c.String());
            AddColumn("dbo.Answers", "AnswerThree", c => c.String());
            AddColumn("dbo.Answers", "AnswerFour", c => c.String());
            AddColumn("dbo.Answers", "AnswerFive", c => c.String());
            AddColumn("dbo.Answers", "AnswerSix", c => c.String());
            AddColumn("dbo.Answers", "AnswerSeven", c => c.String());
            AddColumn("dbo.Answers", "AnswerEight", c => c.String());
            AddColumn("dbo.Answers", "AnswerNine", c => c.String());
            AddColumn("dbo.Answers", "AnswerTen", c => c.String());
            AddColumn("dbo.Answers", "AnswerEleven", c => c.String());
            AddColumn("dbo.Answers", "AnswerTwelve", c => c.String());
            AddColumn("dbo.Answers", "AnswerThirteen", c => c.String());
            AddColumn("dbo.Answers", "AnswerFourteen", c => c.String());
            AddColumn("dbo.Answers", "AnswerFifteen", c => c.String());
            AddColumn("dbo.Answers", "AnswerSixteen", c => c.String());
            AddColumn("dbo.Answers", "AnswerSeventeen", c => c.String());
            AddColumn("dbo.Answers", "AnswerEighteen", c => c.String());
            AddColumn("dbo.Answers", "AnswerNineteen", c => c.String());
            AddColumn("dbo.Answers", "AnswerTwenty", c => c.String());
            DropColumn("dbo.Answers", "UserAnswer");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Answers", "UserAnswer", c => c.String());
            DropColumn("dbo.Answers", "AnswerTwenty");
            DropColumn("dbo.Answers", "AnswerNineteen");
            DropColumn("dbo.Answers", "AnswerEighteen");
            DropColumn("dbo.Answers", "AnswerSeventeen");
            DropColumn("dbo.Answers", "AnswerSixteen");
            DropColumn("dbo.Answers", "AnswerFifteen");
            DropColumn("dbo.Answers", "AnswerFourteen");
            DropColumn("dbo.Answers", "AnswerThirteen");
            DropColumn("dbo.Answers", "AnswerTwelve");
            DropColumn("dbo.Answers", "AnswerEleven");
            DropColumn("dbo.Answers", "AnswerTen");
            DropColumn("dbo.Answers", "AnswerNine");
            DropColumn("dbo.Answers", "AnswerEight");
            DropColumn("dbo.Answers", "AnswerSeven");
            DropColumn("dbo.Answers", "AnswerSix");
            DropColumn("dbo.Answers", "AnswerFive");
            DropColumn("dbo.Answers", "AnswerFour");
            DropColumn("dbo.Answers", "AnswerThree");
            DropColumn("dbo.Answers", "AnswerTwo");
            DropColumn("dbo.Answers", "AnswerOne");
        }
    }
}
