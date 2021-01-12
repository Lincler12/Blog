using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    SubTitle = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    Introduction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogPostId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_BlogPosts_BlogPostId",
                        column: x => x.BlogPostId,
                        principalTable: "BlogPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "Author", "Content", "Introduction", "Likes", "SubTitle", "Title" },
                values: new object[] { 1, "Nikolaos Kalogeropoulos", "To fight this feeling you have to be very brave with yourself and others and and and nad To fight this feeling you have to be very brave with yourself and others and and and nad To fight this feeling you have to be very brave with yourself and others and and and nad To fight this feeling you have to be very brave with yourself and others and and and nad To fight this feeling you have to be very brave with yourself and others and and and nad", "The feeling of being lonely is something many people have experienced, in this blog post I will explain how you can fight this feeling of loneliness", 0, "An ode to a very strange existance", "To be or not to be" });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "Author", "Content", "Introduction", "Likes", "SubTitle", "Title" },
                values: new object[] { 2, "John Wick", "To fight this feeling you have to be very brave with yourself and others and and and nad To fight this feeling you have to be very brave with yourself and others and and and nad To fight this feeling you have to be very brave with yourself and others and and and nad To fight this feeling you have to be very brave with yourself and others and and and nad To fight this feeling you have to be very brave with yourself and others and and and nad", "The feeling of killing  is something many people have experienced, in this blog post I will explain how you can fight this feeling of killing", 0, "An ode to a very strange killing", "To kill or not to kill" });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BlogPostId",
                table: "Comments",
                column: "BlogPostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "BlogPosts");
        }
    }
}
