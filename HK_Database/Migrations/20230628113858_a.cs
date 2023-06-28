using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HK_Database.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    MemberId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MemberName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemberEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemberPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.MemberId);
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    ApplicationId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parameter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemberId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.ApplicationId);
                    table.ForeignKey(
                        name: "FK_Applications_Member_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AIFiles",
                columns: table => new
                {
                    AIFileId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AIFileType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AIFilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AIFiles", x => x.AIFileId);
                    table.ForeignKey(
                        name: "FK_AIFiles_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "ApplicationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "ApplicationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Embedding",
                columns: table => new
                {
                    EmbeddingId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmbeddingQuestion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmbeddingAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmbeddingVectors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AIFileId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Embedding", x => x.EmbeddingId);
                    table.ForeignKey(
                        name: "FK_Embedding_AIFiles_AIFileId",
                        column: x => x.AIFileId,
                        principalTable: "AIFiles",
                        principalColumn: "AIFileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    ChatId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ChatTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChatName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.ChatId);
                    table.ForeignKey(
                        name: "FK_Chats_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QAHistory",
                columns: table => new
                {
                    QAHistoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    QAHistoryQ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QAHistoryA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QAHistoryVectors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChatId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QAHistory", x => x.QAHistoryId);
                    table.ForeignKey(
                        name: "FK_QAHistory_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "ChatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Member",
                columns: new[] { "MemberId", "MemberEmail", "MemberName", "MemberPassword" },
                values: new object[] { "C001", "althea@gmail.com", "Althea", "althea01" });

            migrationBuilder.InsertData(
                table: "Member",
                columns: new[] { "MemberId", "MemberEmail", "MemberName", "MemberPassword" },
                values: new object[] { "C002", "jimmy@gmail.com", "Jimmy", "jimmy02" });

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "ApplicationId", "MemberId", "Model", "Parameter" },
                values: new object[] { "A001", "C001", "mm", "pp" });

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "ApplicationId", "MemberId", "Model", "Parameter" },
                values: new object[] { "A002", "C002", "mm", "pp" });

            migrationBuilder.InsertData(
                table: "AIFiles",
                columns: new[] { "AIFileId", "AIFilePath", "AIFileType", "ApplicationId" },
                values: new object[] { "D001", "dd", "dd", "A001" });

            migrationBuilder.InsertData(
                table: "AIFiles",
                columns: new[] { "AIFileId", "AIFilePath", "AIFileType", "ApplicationId" },
                values: new object[] { "D002", "dd", "dd", "A002" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "ApplicationId", "UserEmail", "UserName", "UserPassword" },
                values: new object[] { "U001", "A001", "candy@gmail.com", "Candy", "candy03" });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "ChatId", "ChatName", "ChatTime", "UserId" },
                values: new object[] { "C001", "Gay", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(13), "U001" });

            migrationBuilder.InsertData(
                table: "Embedding",
                columns: new[] { "EmbeddingId", "AIFileId", "EmbeddingAnswer", "EmbeddingQuestion", "EmbeddingVectors", "QA" },
                values: new object[] { "ii", "D001", "ee", "ee", "ee", "qq" });

            migrationBuilder.InsertData(
                table: "QAHistory",
                columns: new[] { "QAHistoryId", "ChatId", "QAHistoryA", "QAHistoryQ", "QAHistoryVectors" },
                values: new object[] { "Q001", "C001", "qq", "qq", "qq" });

            migrationBuilder.CreateIndex(
                name: "IX_AIFiles_ApplicationId",
                table: "AIFiles",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_MemberId",
                table: "Applications",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_UserId",
                table: "Chats",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Embedding_AIFileId",
                table: "Embedding",
                column: "AIFileId");

            migrationBuilder.CreateIndex(
                name: "IX_QAHistory_ChatId",
                table: "QAHistory",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ApplicationId",
                table: "Users",
                column: "ApplicationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Embedding");

            migrationBuilder.DropTable(
                name: "QAHistory");

            migrationBuilder.DropTable(
                name: "AIFiles");

            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "Member");
        }
    }
}
