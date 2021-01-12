using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class NewComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Author", "BlogPostId", "CommentMessage" },
                values: new object[] { 1, "Giannis E.", 3, "Excellent suggestion of books. I have a question though, on the third book there is a page that says it's better to wait and see how the code reacts to changes, is this a good suggestion?" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
