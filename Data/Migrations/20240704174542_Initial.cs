using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Factions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserType = table.Column<int>(type: "int", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FactionFaction",
                columns: table => new
                {
                    AlliesId = table.Column<int>(type: "int", nullable: false),
                    OpponentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactionFaction", x => new { x.AlliesId, x.OpponentsId });
                    table.ForeignKey(
                        name: "FK_FactionFaction_Factions_AlliesId",
                        column: x => x.AlliesId,
                        principalTable: "Factions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FactionFaction_Factions_OpponentsId",
                        column: x => x.OpponentsId,
                        principalTable: "Factions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Adventures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModuleId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adventures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adventures_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LoreEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoreEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoreEntries_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlayerCharacters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    CharacterSheet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerCharacters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerCharacters_Characters_Id",
                        column: x => x.Id,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlayerCharacters_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompletedAdventures",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AdventureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompletedAdventures", x => new { x.UserId, x.AdventureId });
                    table.ForeignKey(
                        name: "FK_CompletedAdventures_Adventures_AdventureId",
                        column: x => x.AdventureId,
                        principalTable: "Adventures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompletedAdventures_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Dungeons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdventureId = table.Column<int>(type: "int", nullable: false),
                    Map = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dungeons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dungeons_Adventures_AdventureId",
                        column: x => x.AdventureId,
                        principalTable: "Adventures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NonPlayerCharacters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FactionId = table.Column<int>(type: "int", nullable: false),
                    StatBlock = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AdventureId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NonPlayerCharacters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NonPlayerCharacters_Adventures_AdventureId",
                        column: x => x.AdventureId,
                        principalTable: "Adventures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NonPlayerCharacters_Characters_Id",
                        column: x => x.Id,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NonPlayerCharacters_Factions_FactionId",
                        column: x => x.FactionId,
                        principalTable: "Factions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Age", "DeletedOn", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 0, null, "Xazhadir is the arch-mage who occupies the blue tower. He is the primary quest giver of the second module.", "Xazhadir" },
                    { 2, 0, null, "Azlan is a leonin from Desolation. He has embarked on a quest seeking to improve the living conditions in his tribe. ", "Azlan" },
                    { 3, 0, null, "Sea Foam is the hot-tempered, but caring and honourable mayor of Nacre.", "Mayor Sea Foam" },
                    { 4, 0, null, "Blank Canvas is a half-elf paladin, who has sworn an oath to protect nature, its beauty and its bounty.", "Blank Canvas" }
                });

            migrationBuilder.InsertData(
                table: "Factions",
                columns: new[] { "Id", "DeletedOn", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "This is Xazhadir the Diviner's seat of power.", "Blue Tower" },
                    { 2, null, "Nacre is a small fishing town where the first module takes place.", "Nacre" }
                });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "DeletedOn", "Description", "Title" },
                values: new object[,]
                {
                    { 1, null, "This is the starting module in the series. It spans levels 1-5.", "Salt, Moss and Anise" },
                    { 2, null, "This is the second module in the series. It spans levels 5-9.", "A Wizard's Playthings" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DeletedOn", "Email", "FirstName", "LastName", "Password", "UserType", "Username" },
                values: new object[,]
                {
                    { 1, null, "alexkalionski@gmail.com", "Alexei", "Kalionski", "kaminski", 0, "Shoni" },
                    { 2, null, "k.al.sotirov@gmail.com", "Kiril", "Sotirov", "azlanrustmane", 1, "Azlan" },
                    { 3, null, "stefan.neschev@gmai.com", "Stefan", "Neshev", "donnelkoza", 2, "Donnel" }
                });

            migrationBuilder.InsertData(
                table: "Adventures",
                columns: new[] { "Id", "DeletedOn", "Description", "ModuleId", "Title" },
                values: new object[,]
                {
                    { 1, null, "Players must find out about the Baron Stern Brow's daughter, Patience. They must travel to Nacre in hopes of finding her.", 1, "Road to Nacre" },
                    { 2, null, "Players must help Mayor Sea Foam with recent disappearances of his younger citizens.", 1, "The Missing Children" }
                });

            migrationBuilder.InsertData(
                table: "LoreEntries",
                columns: new[] { "Id", "AuthorId", "Content", "DeletedOn", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Rhyme of Creation\r\nFirst comes always Everglow\r\nHidden pulse from deep and low\r\nSecond comes Foundation Stone\r\nThis one to be left alone!\r\nWolfrose lively, Wolfrose calm\r\nShifts and turns in pouch or palm\r\nMany covet Summercrown\r\nWisdom’s gift of high renown \r\nLiving Rainbow – fancy’s roam,\r\nFickle as the ocean’s foam\r\nSin of the Eternal Book\r\nSeek it if you dare to look\r\nLast of Ages sees the Bow\r\nMay it ever Truepath show\r\n", null, "Rhyme of Creation" },
                    { 2, 1, "This is the story of three sisters who all desired eternal life.", null, "Salt, Moss and Anise" }
                });

            migrationBuilder.InsertData(
                table: "NonPlayerCharacters",
                columns: new[] { "Id", "AdventureId", "DeletedOn", "FactionId", "StatBlock" },
                values: new object[,]
                {
                    { 1, null, null, 1, "N/A" },
                    { 3, null, null, 2, "N/A" }
                });

            migrationBuilder.InsertData(
                table: "PlayerCharacters",
                columns: new[] { "Id", "CharacterSheet", "DeletedOn", "OwnerId" },
                values: new object[,]
                {
                    { 2, "N/A", null, 2 },
                    { 4, "N/A", null, 3 }
                });

            migrationBuilder.InsertData(
                table: "CompletedAdventures",
                columns: new[] { "AdventureId", "UserId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "Dungeons",
                columns: new[] { "Id", "AdventureId", "DeletedOn", "Description", "Map", "Title" },
                values: new object[,]
                {
                    { 1, 1, null, "Players must travel to nacre, either between two forests, or by sea. In either case, they are ambushed by fey creatures on the way there.", "N/A", "Fey Ambush" },
                    { 2, 2, null, "Players must find the missing people in Lover's cave.", "N/A", "Lover's Cave" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adventures_ModuleId",
                table: "Adventures",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_CompletedAdventures_AdventureId",
                table: "CompletedAdventures",
                column: "AdventureId");

            migrationBuilder.CreateIndex(
                name: "IX_Dungeons_AdventureId",
                table: "Dungeons",
                column: "AdventureId");

            migrationBuilder.CreateIndex(
                name: "IX_FactionFaction_OpponentsId",
                table: "FactionFaction",
                column: "OpponentsId");

            migrationBuilder.CreateIndex(
                name: "IX_LoreEntries_AuthorId",
                table: "LoreEntries",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_NonPlayerCharacters_AdventureId",
                table: "NonPlayerCharacters",
                column: "AdventureId");

            migrationBuilder.CreateIndex(
                name: "IX_NonPlayerCharacters_FactionId",
                table: "NonPlayerCharacters",
                column: "FactionId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerCharacters_OwnerId",
                table: "PlayerCharacters",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompletedAdventures");

            migrationBuilder.DropTable(
                name: "Dungeons");

            migrationBuilder.DropTable(
                name: "FactionFaction");

            migrationBuilder.DropTable(
                name: "LoreEntries");

            migrationBuilder.DropTable(
                name: "NonPlayerCharacters");

            migrationBuilder.DropTable(
                name: "PlayerCharacters");

            migrationBuilder.DropTable(
                name: "Adventures");

            migrationBuilder.DropTable(
                name: "Factions");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Modules");
        }
    }
}
