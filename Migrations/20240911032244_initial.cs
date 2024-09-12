using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IfaceMainApi.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "changes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    EntityName = table.Column<string>(type: "text", nullable: false),
                    RegisterId = table.Column<Guid>(type: "uuid", nullable: true),
                    Operation = table.Column<int>(type: "integer", nullable: false),
                    Sync = table.Column<bool>(type: "boolean", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2024, 9, 11, 3, 22, 44, 333, DateTimeKind.Utc).AddTicks(2001)),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_changes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "persons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Gender = table.Column<int>(type: "integer", nullable: false),
                    MainPhoneNumber = table.Column<string>(type: "text", nullable: true),
                    SecondaryPhoneNumber = table.Column<string>(type: "text", nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2024, 9, 11, 3, 22, 44, 333, DateTimeKind.Utc).AddTicks(4670)),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "caregivers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PersonId = table.Column<Guid>(type: "uuid", nullable: false),
                    AuthId = table.Column<Guid>(type: "uuid", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2024, 9, 11, 3, 22, 44, 332, DateTimeKind.Utc).AddTicks(9350)),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_caregivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_caregivers_persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "persons_with_alzheimer_disease",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PersonId = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DeviceToken = table.Column<string>(type: "text", nullable: true),
                    AlzheimerStage = table.Column<int>(type: "integer", nullable: false),
                    MainCaregiverId = table.Column<Guid>(type: "uuid", nullable: false),
                    CaregiverId = table.Column<Guid>(type: "uuid", nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2024, 9, 11, 3, 22, 44, 333, DateTimeKind.Utc).AddTicks(5091)),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_persons_with_alzheimer_disease", x => x.Id);
                    table.ForeignKey(
                        name: "FK_persons_with_alzheimer_disease_caregivers_CaregiverId",
                        column: x => x.CaregiverId,
                        principalTable: "caregivers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_persons_with_alzheimer_disease_caregivers_MainCaregiverId",
                        column: x => x.MainCaregiverId,
                        principalTable: "caregivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_persons_with_alzheimer_disease_persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carefuls",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CaregiverId = table.Column<Guid>(type: "uuid", nullable: false),
                    PwadId = table.Column<Guid>(type: "uuid", nullable: false),
                    CarefulToken = table.Column<string>(type: "text", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2024, 9, 11, 3, 22, 44, 334, DateTimeKind.Utc).AddTicks(6749)),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carefuls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carefuls_caregivers_CaregiverId",
                        column: x => x.CaregiverId,
                        principalTable: "caregivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carefuls_persons_with_alzheimer_disease_PwadId",
                        column: x => x.PwadId,
                        principalTable: "persons_with_alzheimer_disease",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Routines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CronExp = table.Column<string>(type: "text", nullable: false),
                    PersonWithAlzheimersDiseaseId = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2024, 9, 11, 3, 22, 44, 334, DateTimeKind.Utc).AddTicks(4776)),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Routines_persons_with_alzheimer_disease_PersonWithAlzheimer~",
                        column: x => x.PersonWithAlzheimersDiseaseId,
                        principalTable: "persons_with_alzheimer_disease",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "known_persons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PersonId = table.Column<Guid>(type: "uuid", nullable: false),
                    PersonWithAlzheimersDiseaseId = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2024, 9, 11, 3, 22, 44, 333, DateTimeKind.Utc).AddTicks(2500)),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_known_persons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_known_persons_persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_known_persons_persons_with_alzheimer_disease_PersonWithAlzh~",
                        column: x => x.PersonWithAlzheimersDiseaseId,
                        principalTable: "persons_with_alzheimer_disease",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "prescriptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PatientId = table.Column<Guid>(type: "uuid", nullable: false),
                    MedicineName = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2024, 9, 11, 3, 22, 44, 334, DateTimeKind.Utc).AddTicks(3522)),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_prescriptions_persons_with_alzheimer_disease_PatientId",
                        column: x => x.PatientId,
                        principalTable: "persons_with_alzheimer_disease",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "schedules",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PersonWithAlzheimersDiseaseId = table.Column<Guid>(type: "uuid", nullable: false),
                    PrescriptionId = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    When = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2024, 9, 11, 3, 22, 44, 334, DateTimeKind.Utc).AddTicks(5663)),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_schedules_persons_with_alzheimer_disease_PersonWithAlzheime~",
                        column: x => x.PersonWithAlzheimersDiseaseId,
                        principalTable: "persons_with_alzheimer_disease",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "photos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    KnownPersonId = table.Column<Guid>(type: "uuid", nullable: false),
                    Url = table.Column<string>(type: "text", nullable: false),
                    Embedding = table.Column<string>(type: "text", nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2024, 9, 11, 3, 22, 44, 334, DateTimeKind.Utc).AddTicks(2513)),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                name: "IX_Carefuls_CaregiverId",
                table: "Carefuls",
                column: "CaregiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Carefuls_PwadId_CaregiverId",
                table: "Carefuls",
                columns: new[] { "PwadId", "CaregiverId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Routines_PersonWithAlzheimersDiseaseId",
                table: "Routines",
                column: "PersonWithAlzheimersDiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_caregivers_AuthId",
                table: "caregivers",
                column: "AuthId");

            migrationBuilder.CreateIndex(
                name: "IX_caregivers_PersonId",
                table: "caregivers",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_known_persons_PersonId",
                table: "known_persons",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_known_persons_PersonWithAlzheimersDiseaseId",
                table: "known_persons",
                column: "PersonWithAlzheimersDiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_persons_with_alzheimer_disease_CaregiverId",
                table: "persons_with_alzheimer_disease",
                column: "CaregiverId");

            migrationBuilder.CreateIndex(
                name: "IX_persons_with_alzheimer_disease_MainCaregiverId",
                table: "persons_with_alzheimer_disease",
                column: "MainCaregiverId");

            migrationBuilder.CreateIndex(
                name: "IX_persons_with_alzheimer_disease_PersonId",
                table: "persons_with_alzheimer_disease",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_photos_KnownPersonId",
                table: "photos",
                column: "KnownPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_prescriptions_PatientId",
                table: "prescriptions",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_schedules_PersonWithAlzheimersDiseaseId",
                table: "schedules",
                column: "PersonWithAlzheimersDiseaseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carefuls");

            migrationBuilder.DropTable(
                name: "Routines");

            migrationBuilder.DropTable(
                name: "changes");

            migrationBuilder.DropTable(
                name: "photos");

            migrationBuilder.DropTable(
                name: "prescriptions");

            migrationBuilder.DropTable(
                name: "schedules");

            migrationBuilder.DropTable(
                name: "known_persons");

            migrationBuilder.DropTable(
                name: "persons_with_alzheimer_disease");

            migrationBuilder.DropTable(
                name: "caregivers");

            migrationBuilder.DropTable(
                name: "persons");
        }
    }
}
