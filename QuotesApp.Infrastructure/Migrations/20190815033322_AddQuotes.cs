using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuotesApp.Infrastructure.Migrations
{
    public partial class AddQuotes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Text = table.Column<string>(maxLength: 3000, nullable: false),
                    Author = table.Column<string>(maxLength: 100, nullable: false),
                    Source = table.Column<string>(maxLength: 100, nullable: true),
                    Date = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 1, "Kevin Kruse", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Life is about making an impact, not making an income.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 74, "Vincent van Gogh", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "I would rather die of passion than of boredom.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 73, "Oprah Winfrey", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "You become what you believe.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 72, "George Eliot", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "It is never too late to be what you might have been.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 71, "Roger Staubach", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "There are no traffic jams along the extra mile.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 70, "Chinese Proverb", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "The person who says it cannot be done should not interrupt the person who is doing it.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 69, " Albert Einstein", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "A person who never made a mistake never tried anything new.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 68, "Bill Cosby", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "In order to succeed, your desire for success should be greater than your fear of failure.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 67, "Benjamin Franklin", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "I didn’t fail the test. I just found 100 ways to do it wrong.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 66, "Bob Dylan", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "What’s money? A man is a success if he gets up in the morning and goes to bed at night and in between does what he wants to do.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 65, "Erica Jong", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "You take your life in your own hands, and what happens? A terrible thing, no one to blame.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 64, "Jamie Paolinetti", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Limitations live only in our minds.  But if we use our imaginations, our possibilities become limitless.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 63, "Leonardo da Vinci", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "I have been impressed with the urgency of doing. Knowing is not enough; we must apply. Being willing is not enough; we must do.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 62, "Booker T. Washington", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "If you want to lift yourself up, lift up someone else.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 61, "Joshua J. Marine", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Challenges are what make life interesting and overcoming them is what makes life meaningful.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 60, "Les Brown", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Too many of us are not living our dreams because we are living our fears.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 59, "Marie Curie", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "We must believe that we are gifted for something, and that this thing, at whatever cost, must be attained.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 58, "Unknown", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "You can’t fall if you don’t climb.  But there’s no joy in living your whole life on the ground.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 57, "Latin Proverb", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "If the wind will not serve, take to the oars.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 56, "Aristotle", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "First, have a definite, clear practical ideal; a goal, an objective. Second, have the necessary means to achieve your ends; wisdom, money, materials, and methods. Third, adjust all your means to that end.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 55, "Sheryl Sandberg", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "If you're offered a seat on a rocket ship, don't ask what seat! Just get on.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 54, "Dalai Lama", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Happiness is not something readymade.  It comes from your own actions.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 75, "Unknown", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "A truly rich man is one whose children run into his arms when his hands are empty.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 76, "Ann Landers", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "It is not what you do for your children, but what you have taught them to do for themselves, that will make them successful human beings. ", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 77, "Abigail Van Buren", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "If you want your children to turn out well, spend twice as much time with them, and half as much money.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 78, "Farrah Gray", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Build your own dreams, or someone else will hire you to build theirs.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 100, "Audrey Hepburn", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, ". Nothing is impossible, the word itself says, “I’m possible!”", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 99, "Benjamin Franklin", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Either write something worth reading or do something worth writing.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 98, "Norman Vincent Peale", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Change your thoughts and you change your world.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 97, "Abraham Lincoln", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "It’s not the years in your life that count. It’s the life in your years.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 96, "Henry Ford", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "When everything seems to be going against you, remember that the airplane takes off against the wind, not with it.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 95, "Ayn Rand", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "The question isn’t who is going to let me; it’s who is going to stop me.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 94, "Grandma Moses", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Life is what we make it, always has been, always will be.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 93, "Eleanor Roosevelt", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Remember no one can make you feel inferior without your consent.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 92, "Beverly Sills", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "You may be disappointed if you fail, but you are doomed if you don't try.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 91, "Mae Jemison", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "It's your place in the world; it's your life. Go on and do all you can with it, and make it the life you want to live.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 53, "Maya Angelou", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Life is not measured by the number of breaths we take, but by the moments that take our breath away.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 90, "Gloria Steinem", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Dreaming, after all, is a form of planning.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 88, "Teddy Roosevelt", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Do what you can, where you are, with what you have.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 87, "Martin Luther King Jr.", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Our lives begin to end the day we become silent about things that matter.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 86, "Norman Vaughan", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Dream big and dare to fail.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 85, "Maya Angelou", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "You can’t use up creativity.  The more you use, the more you have.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 84, "Dalai Lama", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Remember that not getting what you want is sometimes a wonderful stroke of luck.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 83, "Oprah Winfrey", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "If you look at what you have in life, you'll always have more. If you look at what you don't have in life, you'll never have enough.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 82, "Confucius", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "It does not matter how slowly you go as long as you do not stop.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 81, "Rosa Parks", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "I have learned over the years that when one's mind is made up, this diminishes fear.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 80, "Sir Claus Moser", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Education costs money.  But then so does ignorance.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 79, "Jesse Owens", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "The battles that count aren't the ones for gold medals. The struggles within yourself-the invisible battles inside all of us-that's where it's at.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 89, "Tony Robbins", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "If you do what you’ve always done, you’ll get what you’ve always gotten.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 52, "Lao Tzu", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "When I let go of what I am, I become what I might be.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 51, "Anne Frank", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "How wonderful it is that nobody need wait a single moment before starting to improve the world.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 50, "Confucius", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Everything has beauty, but not everyone can see.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 23, "Stephen Covey", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "I am not a product of my circumstances. I am a product of my decisions.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 22, "Vince Lombardi", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Winning isn’t everything, but wanting to win is.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 21, "Steve Jobs", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Your time is limited, so don’t waste it living someone else’s life.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 20, "Woody Allen", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Eighty percent of success is showing up.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 19, "Socrates", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "An unexamined life is not worth living.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 18, "Chinese Proverb", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "The best time to plant a tree was 20 years ago. The second best time is now.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 17, "Buddha", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "The mind is everything. What you think you become. ", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 16, "Alice Walker", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "The most common way people give up their power is by thinking they don’t have any.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 15, "Charles Swindoll", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Life is 10% what happens to me and 90% of how I react to it.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 14, "Mark Twain", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Twenty years from now you will be more disappointed by the things that you didn’t do than by the ones you did do, so throw off the bowlines, sail away from safe harbor, catch the trade winds in your sails.  Explore, Dream, Discover.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 24, "Pablo Picasso", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Every child is an artist.  The problem is how to remain an artist once he grows up.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 13, "Earl Nightingale", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "We become what we think about.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 11, "Kevin Kruse", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Life isn't about getting and having, it's about giving and being.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 10, "W. Clement Stone", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Definiteness of purpose is the starting point of all achievement.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 9, "Babe Ruth", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Every strike brings me closer to the next home run.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 8, "Amelia Earhart", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "The most difficult thing is the decision to act, the rest is merely tenacity.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 7, "Michael Jordan", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "I've missed more than 9000 shots in my career. I've lost almost 300 games. 26 times I've been trusted to take the game winning shot and missed. I've failed over and over and over again in my life. And that is why I succeed.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 6, "Wayne Gretzky", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "You miss 100% of the shots you don’t take.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 5, "Florence Nightingale", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "I attribute my success to this: I never gave or took any excuse.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 4, "Robert Frost", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Two roads diverged in a wood, and I—I took the one less traveled by, And that has made all the difference. ", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 3, "Albert Einstein", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Strive not to be a success, but rather to be of value.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 2, "Napoleon Hill", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Whatever the mind of man can conceive and believe, it can achieve.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 12, "John Lennon", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Life is what happens to you while you’re busy making other plans.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 101, "Steve Jobs", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, ". The only way to do great work is to love what you do.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 25, "Christopher Columbus", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "You can never cross the ocean until you have the courage to lose sight of the shore.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 27, "Jim Rohn", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Either you run the day, or the day runs you.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 49, "Helen Keller", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "When one door of happiness closes, another opens, but often we look so long at the closed door that we do not see the one that has been opened for us.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 48, "Japanese Proverb", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Fall seven times and stand up eight.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 47, "John Lennon", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "When I was 5 years old, my mother always told me that happiness was the key to life. When I went to school, they asked me what I wanted to be when I grew up.I wrote down 'happy'. They told me I didn’t understand the assignment, and I told them they didn’t understande life.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 46, "Arthur Ashe", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Start where you are. Use what you have. Do what you can.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 45, "Maimonides", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Teach thy tongue to say, \"I do not know,\" and thous shalt progress.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 44, "Plato", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "We can easily forgive a child who is afraid of the dark; the real tragedy of life is when men are afraid of the light.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 43, "George Addair", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Everything you’ve ever wanted is on the other side of fear.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 42, "Theodore Roosevelt", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Believe you can and you’re halfway there.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 41, " Ancient Indian Proverb", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Certain things catch your eye, but pursue only those that capture the heart.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 40, "Booker T. Washington", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Few things can help an individual more than to place responsibility on him, and to let him know that you trust him. ", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 26, "Maya Angelou", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "I’ve learned that people will forget what you said, people will forget what you did, but people will never forget how you made them feel.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 39, "Erma Bombeck", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "When I stand before God at the end of my life, I would hope that I would not have a single bit of talent left and could say, I used everything you gave me.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 37, "Ralph Waldo Emerson", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "The only person you are destined to become is the person you decide to be.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 36, "Jesus", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Ask and it will be given to you; search, and you will find; knock and the door will be opened for you.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 35, "Aristotle", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "There is only one way to avoid criticism: do nothing, say nothing, and be nothing.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 34, "Vincent Van Gogh", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "If you hear a voice within you say “you cannot paint,” then by all means paint and that voice will be silenced.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 33, "Anais Nin", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Life shrinks or expands in proportion to one's courage.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 32, "Zig Ziglar", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "People often say that motivation doesn’t last. Well, neither does bathing.  That’s why we recommend it daily.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 31, "Frank Sinatra", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "The best revenge is massive success.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 30, "Johann Wolfgang von Goethe", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Whatever you can do, or dream you can, begin it.  Boldness has genius, power and magic in it.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 29, "Mark Twain", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "The two most important days in your life are the day you are born and the day you find out why.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 28, "Henry Ford", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Whether you think you can or you think you can’t, you’re right.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 38, "Henry David Thoreau", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, "Go confidently in the direction of your dreams.  Live the life you have imagined.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "Source", "Text", "UpdatedAt" },
                values: new object[] { 102, "Zig Ziglar", new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), null, null, false, null, ". If you can dream it, you can achieve it.", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quotes");
        }
    }
}
