using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmptyCoreWebApplication.Migrations
{
    public partial class SeedCoursesData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Description", "Price", "ProductName" },
                values: new object[] { "English 101: Introduction to Language Learning is designed for students who are beginning their journey in mastering the English language. This course focuses on developing foundational skills in reading, writing, listening, and speaking.", 500m, "English 101" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Description", "Price", "ProductName" },
                values: new object[] { "English 201: Intermediate Language Learning is designed for students who have a foundational knowledge of English and seek to further develop their language skills. This course focuses on enhancing proficiency in reading, writing, listening, and speaking at an intermediate level.", 600m, "English 201" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Description", "Price", "ProductName" },
                values: new object[] { "English 301: Advanced Language Learning is designed for students who have an intermediate proficiency in English and aim to achieve advanced language skills. This course focuses on refining and mastering the intricacies of English in reading, writing, listening, and speaking.", 800m, "English 301" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Description", "Price", "ProductName" },
                values: new object[] { "English 401: Proficient Language Mastery is designed for students who have advanced proficiency in English and aspire to reach a near-native level of fluency. This course focuses on perfecting language skills in reading, writing, listening, and speaking through engagement with highly complex texts and sophisticated communication activities.", 1000m, "English 401" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "Description", "Price", "ProductName" },
                values: new object[] { "German 101: Introduction to German Language is designed for beginners eager to start learning German. This course focuses on building foundational skills in reading, writing, listening, and speaking German. Students will learn basic vocabulary, essential grammar, and key phrases for everyday communication.", 500m, "German 101" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "Price", "ProductName" },
                values: new object[] { 6, "German 201: Intermediate German Language is designed for students who have a basic understanding of German and wish to enhance their proficiency. This course focuses on expanding vocabulary, refining grammar, and improving skills in reading, writing, listening, and speaking at an intermediate level.", 600m, "German 201" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "Price", "ProductName" },
                values: new object[] { 7, "German 301: Advanced German Language is designed for students who have intermediate proficiency in German and aim to reach a higher level of fluency. This course focuses on refining advanced language skills in reading, writing, listening, and speaking. ", 800m, "German 301" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "Price", "ProductName" },
                values: new object[] { 8, "German 401: Proficient German Language Mastery is designed for students who have advanced proficiency in German and strive for near-native fluency. This course focuses on perfecting language skills in reading, writing, listening, and speaking through engagement with highly complex texts and sophisticated communication activities.", 1000m, "German 401" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 17000m, "Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 1000m, "Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 500m, "Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 7000m, "Monitor" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 1500m, "Deck" });
        }
    }
}
