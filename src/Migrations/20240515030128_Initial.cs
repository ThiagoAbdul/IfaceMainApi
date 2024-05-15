using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IfaceMainApi.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    PostalCode = table.Column<string>(type: "text", nullable: false),
                    StreetName = table.Column<string>(type: "text", nullable: false),
                    StreetNumber = table.Column<int>(type: "integer", nullable: false),
                    AdministrativeDivision = table.Column<string>(type: "text", nullable: true),
                    Complement = table.Column<string>(type: "text", nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "credentials",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    HashPassword = table.Column<string>(type: "text", nullable: false),
                    HasMfa = table.Column<bool>(type: "boolean", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_credentials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "medicines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    DrugLabel = table.Column<string>(type: "text", nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "phone",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Number = table.Column<string>(type: "text", nullable: false),
                    IsLandline = table.Column<bool>(type: "boolean", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phone", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "clinics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BusinessName = table.Column<string>(type: "text", nullable: false),
                    CorporateName = table.Column<string>(type: "text", nullable: false),
                    TaxId = table.Column<string>(type: "text", nullable: false),
                    CredentialsId = table.Column<Guid>(type: "uuid", nullable: false),
                    MainPhoneNumberId = table.Column<Guid>(type: "uuid", nullable: true),
                    SecondaryPhoneNumberId = table.Column<Guid>(type: "uuid", nullable: true),
                    AddressId = table.Column<Guid>(type: "uuid", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clinics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_clinics_addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_clinics_credentials_CredentialsId",
                        column: x => x.CredentialsId,
                        principalTable: "credentials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_clinics_phone_MainPhoneNumberId",
                        column: x => x.MainPhoneNumberId,
                        principalTable: "phone",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_clinics_phone_SecondaryPhoneNumberId",
                        column: x => x.SecondaryPhoneNumberId,
                        principalTable: "phone",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "person",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Gender = table.Column<int>(type: "integer", nullable: false),
                    MainPhoneId = table.Column<Guid>(type: "uuid", nullable: true),
                    SecondaryPhoneId = table.Column<Guid>(type: "uuid", nullable: true),
                    MainAddressId = table.Column<Guid>(type: "uuid", nullable: true),
                    SecondaryAddressId = table.Column<Guid>(type: "uuid", nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_person", x => x.Id);
                    table.ForeignKey(
                        name: "FK_person_addresses_MainAddressId",
                        column: x => x.MainAddressId,
                        principalTable: "addresses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_person_addresses_SecondaryAddressId",
                        column: x => x.SecondaryAddressId,
                        principalTable: "addresses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_person_phone_MainPhoneId",
                        column: x => x.MainPhoneId,
                        principalTable: "phone",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_person_phone_SecondaryPhoneId",
                        column: x => x.SecondaryPhoneId,
                        principalTable: "phone",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "caregivers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PersonId = table.Column<Guid>(type: "uuid", nullable: false),
                    CredentialsId = table.Column<Guid>(type: "uuid", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_caregivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_caregivers_credentials_CredentialsId",
                        column: x => x.CredentialsId,
                        principalTable: "credentials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_caregivers_person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "caregiver_helps",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SupervisorId = table.Column<Guid>(type: "uuid", nullable: false),
                    HelperId = table.Column<Guid>(type: "uuid", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_caregiver_helps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_caregiver_helps_caregivers_HelperId",
                        column: x => x.HelperId,
                        principalTable: "caregivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_caregiver_helps_caregivers_SupervisorId",
                        column: x => x.SupervisorId,
                        principalTable: "caregivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "clinic_caregivers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ClinicId = table.Column<Guid>(type: "uuid", nullable: false),
                    CaregiverId = table.Column<Guid>(type: "uuid", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clinic_caregivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_clinic_caregivers_caregivers_CaregiverId",
                        column: x => x.CaregiverId,
                        principalTable: "caregivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_clinic_caregivers_clinics_ClinicId",
                        column: x => x.ClinicId,
                        principalTable: "clinics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "person_with_alzheimer_disease",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PersonId = table.Column<Guid>(type: "uuid", nullable: false),
                    DeviceToken = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    AlzheimerState = table.Column<int>(type: "integer", nullable: false),
                    ClinicId = table.Column<Guid>(type: "uuid", nullable: true),
                    ResponsibleId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsTheClinicCaredFor = table.Column<bool>(type: "boolean", nullable: false),
                    BirthDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_person_with_alzheimer_disease", x => x.Id);
                    table.ForeignKey(
                        name: "FK_person_with_alzheimer_disease_caregivers_ResponsibleId",
                        column: x => x.ResponsibleId,
                        principalTable: "caregivers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_person_with_alzheimer_disease_clinics_ClinicId",
                        column: x => x.ClinicId,
                        principalTable: "clinics",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_person_with_alzheimer_disease_person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "non_user_support_person",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PersonId = table.Column<Guid>(type: "uuid", nullable: false),
                    PersonWithAlzheimersDiseaseId = table.Column<Guid>(type: "uuid", nullable: false),
                    Relationship = table.Column<int>(type: "integer", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_non_user_support_person", x => x.Id);
                    table.ForeignKey(
                        name: "FK_non_user_support_person_person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_non_user_support_person_person_with_alzheimer_disease_Perso~",
                        column: x => x.PersonWithAlzheimersDiseaseId,
                        principalTable: "person_with_alzheimer_disease",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "prescription",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PatientId = table.Column<Guid>(type: "uuid", nullable: false),
                    MedicineId = table.Column<Guid>(type: "uuid", nullable: false),
                    Comments = table.Column<string>(type: "text", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prescription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_prescription_medicines_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "medicines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_prescription_person_with_alzheimer_disease_PatientId",
                        column: x => x.PatientId,
                        principalTable: "person_with_alzheimer_disease",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "scheduling",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PersonWithAlzheimersDiseaseId = table.Column<Guid>(type: "uuid", nullable: false),
                    PrescriptionId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsMedication = table.Column<bool>(type: "boolean", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Cron = table.Column<string>(type: "text", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scheduling", x => x.Id);
                    table.ForeignKey(
                        name: "FK_scheduling_person_with_alzheimer_disease_PersonWithAlzheime~",
                        column: x => x.PersonWithAlzheimersDiseaseId,
                        principalTable: "person_with_alzheimer_disease",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_scheduling_prescription_PrescriptionId",
                        column: x => x.PrescriptionId,
                        principalTable: "prescription",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_caregiver_helps_HelperId",
                table: "caregiver_helps",
                column: "HelperId");

            migrationBuilder.CreateIndex(
                name: "IX_caregiver_helps_SupervisorId",
                table: "caregiver_helps",
                column: "SupervisorId");

            migrationBuilder.CreateIndex(
                name: "IX_caregivers_CredentialsId",
                table: "caregivers",
                column: "CredentialsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_caregivers_PersonId",
                table: "caregivers",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_clinic_caregivers_CaregiverId",
                table: "clinic_caregivers",
                column: "CaregiverId");

            migrationBuilder.CreateIndex(
                name: "IX_clinic_caregivers_ClinicId",
                table: "clinic_caregivers",
                column: "ClinicId");

            migrationBuilder.CreateIndex(
                name: "IX_clinics_AddressId",
                table: "clinics",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_clinics_CredentialsId",
                table: "clinics",
                column: "CredentialsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_clinics_MainPhoneNumberId",
                table: "clinics",
                column: "MainPhoneNumberId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_clinics_SecondaryPhoneNumberId",
                table: "clinics",
                column: "SecondaryPhoneNumberId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_credentials_Email",
                table: "credentials",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_non_user_support_person_PersonId",
                table: "non_user_support_person",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_non_user_support_person_PersonWithAlzheimersDiseaseId",
                table: "non_user_support_person",
                column: "PersonWithAlzheimersDiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_person_MainAddressId",
                table: "person",
                column: "MainAddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_person_MainPhoneId",
                table: "person",
                column: "MainPhoneId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_person_SecondaryAddressId",
                table: "person",
                column: "SecondaryAddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_person_SecondaryPhoneId",
                table: "person",
                column: "SecondaryPhoneId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_person_with_alzheimer_disease_ClinicId",
                table: "person_with_alzheimer_disease",
                column: "ClinicId");

            migrationBuilder.CreateIndex(
                name: "IX_person_with_alzheimer_disease_PersonId",
                table: "person_with_alzheimer_disease",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_person_with_alzheimer_disease_ResponsibleId",
                table: "person_with_alzheimer_disease",
                column: "ResponsibleId");

            migrationBuilder.CreateIndex(
                name: "IX_prescription_MedicineId",
                table: "prescription",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_prescription_PatientId",
                table: "prescription",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_scheduling_PersonWithAlzheimersDiseaseId",
                table: "scheduling",
                column: "PersonWithAlzheimersDiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_scheduling_PrescriptionId",
                table: "scheduling",
                column: "PrescriptionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "caregiver_helps");

            migrationBuilder.DropTable(
                name: "clinic_caregivers");

            migrationBuilder.DropTable(
                name: "non_user_support_person");

            migrationBuilder.DropTable(
                name: "scheduling");

            migrationBuilder.DropTable(
                name: "prescription");

            migrationBuilder.DropTable(
                name: "medicines");

            migrationBuilder.DropTable(
                name: "person_with_alzheimer_disease");

            migrationBuilder.DropTable(
                name: "caregivers");

            migrationBuilder.DropTable(
                name: "clinics");

            migrationBuilder.DropTable(
                name: "person");

            migrationBuilder.DropTable(
                name: "credentials");

            migrationBuilder.DropTable(
                name: "addresses");

            migrationBuilder.DropTable(
                name: "phone");
        }
    }
}
