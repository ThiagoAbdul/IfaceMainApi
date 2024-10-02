using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IfaceMainApi.Migrations
{
    /// <inheritdoc />
    public partial class ImageChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "photos");

            migrationBuilder.DropColumn(
                name: "EntityName",
                table: "changes");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "schedules",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 16, 2, 38, 42, 46, DateTimeKind.Utc).AddTicks(2438),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 9, 15, 18, 17, 55, 229, DateTimeKind.Utc).AddTicks(5220));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "prescriptions",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 16, 2, 38, 42, 45, DateTimeKind.Utc).AddTicks(8710),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 9, 15, 18, 17, 55, 229, DateTimeKind.Utc).AddTicks(3188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "persons_with_alzheimer_disease",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 16, 2, 38, 42, 44, DateTimeKind.Utc).AddTicks(9657),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 9, 15, 18, 17, 55, 228, DateTimeKind.Utc).AddTicks(5452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "persons",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 16, 2, 38, 42, 44, DateTimeKind.Utc).AddTicks(9072),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 9, 15, 18, 17, 55, 228, DateTimeKind.Utc).AddTicks(4955));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "known_persons",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 16, 2, 38, 42, 44, DateTimeKind.Utc).AddTicks(5221),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 9, 15, 18, 17, 55, 228, DateTimeKind.Utc).AddTicks(2629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "changes",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 16, 2, 38, 42, 44, DateTimeKind.Utc).AddTicks(4733),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 9, 15, 18, 17, 55, 228, DateTimeKind.Utc).AddTicks(2100));

            migrationBuilder.AddColumn<int>(
                name: "Entity",
                table: "changes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "PwadId",
                table: "changes",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "caregivers",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 16, 2, 38, 42, 44, DateTimeKind.Utc).AddTicks(2257),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 9, 15, 18, 17, 55, 227, DateTimeKind.Utc).AddTicks(9607));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Routines",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 16, 2, 38, 42, 46, DateTimeKind.Utc).AddTicks(1040),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 9, 15, 18, 17, 55, 229, DateTimeKind.Utc).AddTicks(4332));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Carefuls",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 16, 2, 38, 42, 46, DateTimeKind.Utc).AddTicks(4054),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 9, 15, 18, 17, 55, 229, DateTimeKind.Utc).AddTicks(6272));

            migrationBuilder.CreateTable(
                name: "images",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    KnownPersonId = table.Column<Guid>(type: "uuid", nullable: false),
                    Url = table.Column<string>(type: "text", nullable: false),
                    Embedding = table.Column<string>(type: "text", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2024, 9, 16, 2, 38, 42, 45, DateTimeKind.Utc).AddTicks(7540)),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_images_known_persons_KnownPersonId",
                        column: x => x.KnownPersonId,
                        principalTable: "known_persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_changes_PwadId",
                table: "changes",
                column: "PwadId");

            migrationBuilder.CreateIndex(
                name: "IX_images_KnownPersonId",
                table: "images",
                column: "KnownPersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_changes_persons_with_alzheimer_disease_PwadId",
                table: "changes",
                column: "PwadId",
                principalTable: "persons_with_alzheimer_disease",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_changes_persons_with_alzheimer_disease_PwadId",
                table: "changes");

            migrationBuilder.DropTable(
                name: "images");

            migrationBuilder.DropIndex(
                name: "IX_changes_PwadId",
                table: "changes");

            migrationBuilder.DropColumn(
                name: "Entity",
                table: "changes");

            migrationBuilder.DropColumn(
                name: "PwadId",
                table: "changes");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "schedules",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 15, 18, 17, 55, 229, DateTimeKind.Utc).AddTicks(5220),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 9, 16, 2, 38, 42, 46, DateTimeKind.Utc).AddTicks(2438));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "prescriptions",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 15, 18, 17, 55, 229, DateTimeKind.Utc).AddTicks(3188),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 9, 16, 2, 38, 42, 45, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "persons_with_alzheimer_disease",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 15, 18, 17, 55, 228, DateTimeKind.Utc).AddTicks(5452),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 9, 16, 2, 38, 42, 44, DateTimeKind.Utc).AddTicks(9657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "persons",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 15, 18, 17, 55, 228, DateTimeKind.Utc).AddTicks(4955),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 9, 16, 2, 38, 42, 44, DateTimeKind.Utc).AddTicks(9072));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "known_persons",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 15, 18, 17, 55, 228, DateTimeKind.Utc).AddTicks(2629),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 9, 16, 2, 38, 42, 44, DateTimeKind.Utc).AddTicks(5221));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "changes",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 15, 18, 17, 55, 228, DateTimeKind.Utc).AddTicks(2100),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 9, 16, 2, 38, 42, 44, DateTimeKind.Utc).AddTicks(4733));

            migrationBuilder.AddColumn<string>(
                name: "EntityName",
                table: "changes",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "caregivers",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 15, 18, 17, 55, 227, DateTimeKind.Utc).AddTicks(9607),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 9, 16, 2, 38, 42, 44, DateTimeKind.Utc).AddTicks(2257));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Routines",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 15, 18, 17, 55, 229, DateTimeKind.Utc).AddTicks(4332),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 9, 16, 2, 38, 42, 46, DateTimeKind.Utc).AddTicks(1040));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Carefuls",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 15, 18, 17, 55, 229, DateTimeKind.Utc).AddTicks(6272),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 9, 16, 2, 38, 42, 46, DateTimeKind.Utc).AddTicks(4054));

            migrationBuilder.CreateTable(
                name: "photos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    KnownPersonId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2024, 9, 15, 18, 17, 55, 229, DateTimeKind.Utc).AddTicks(2339)),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    Embedding = table.Column<string>(type: "text", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    Url = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_photos_known_persons_KnownPersonId",
                        column: x => x.KnownPersonId,
                        principalTable: "known_persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_photos_KnownPersonId",
                table: "photos",
                column: "KnownPersonId");
        }
    }
}
