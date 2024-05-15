using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IfaceMainApi.Migrations
{
    /// <inheritdoc />
    public partial class RenameTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_caregivers_person_PersonId",
                table: "caregivers");

            migrationBuilder.DropForeignKey(
                name: "FK_clinics_phone_MainPhoneNumberId",
                table: "clinics");

            migrationBuilder.DropForeignKey(
                name: "FK_clinics_phone_SecondaryPhoneNumberId",
                table: "clinics");

            migrationBuilder.DropForeignKey(
                name: "FK_non_user_support_person_person_PersonId",
                table: "non_user_support_person");

            migrationBuilder.DropForeignKey(
                name: "FK_non_user_support_person_person_with_alzheimer_disease_Perso~",
                table: "non_user_support_person");

            migrationBuilder.DropForeignKey(
                name: "FK_person_addresses_MainAddressId",
                table: "person");

            migrationBuilder.DropForeignKey(
                name: "FK_person_addresses_SecondaryAddressId",
                table: "person");

            migrationBuilder.DropForeignKey(
                name: "FK_person_phone_MainPhoneId",
                table: "person");

            migrationBuilder.DropForeignKey(
                name: "FK_person_phone_SecondaryPhoneId",
                table: "person");

            migrationBuilder.DropForeignKey(
                name: "FK_person_with_alzheimer_disease_caregivers_ResponsibleId",
                table: "person_with_alzheimer_disease");

            migrationBuilder.DropForeignKey(
                name: "FK_person_with_alzheimer_disease_clinics_ClinicId",
                table: "person_with_alzheimer_disease");

            migrationBuilder.DropForeignKey(
                name: "FK_person_with_alzheimer_disease_person_PersonId",
                table: "person_with_alzheimer_disease");

            migrationBuilder.DropForeignKey(
                name: "FK_prescription_medicines_MedicineId",
                table: "prescription");

            migrationBuilder.DropForeignKey(
                name: "FK_prescription_person_with_alzheimer_disease_PatientId",
                table: "prescription");

            migrationBuilder.DropForeignKey(
                name: "FK_scheduling_person_with_alzheimer_disease_PersonWithAlzheime~",
                table: "scheduling");

            migrationBuilder.DropForeignKey(
                name: "FK_scheduling_prescription_PrescriptionId",
                table: "scheduling");

            migrationBuilder.DropPrimaryKey(
                name: "PK_scheduling",
                table: "scheduling");

            migrationBuilder.DropPrimaryKey(
                name: "PK_prescription",
                table: "prescription");

            migrationBuilder.DropPrimaryKey(
                name: "PK_phone",
                table: "phone");

            migrationBuilder.DropPrimaryKey(
                name: "PK_person_with_alzheimer_disease",
                table: "person_with_alzheimer_disease");

            migrationBuilder.DropPrimaryKey(
                name: "PK_person",
                table: "person");

            migrationBuilder.DropPrimaryKey(
                name: "PK_non_user_support_person",
                table: "non_user_support_person");

            migrationBuilder.RenameTable(
                name: "scheduling",
                newName: "schedules");

            migrationBuilder.RenameTable(
                name: "prescription",
                newName: "prescriptions");

            migrationBuilder.RenameTable(
                name: "phone",
                newName: "phones");

            migrationBuilder.RenameTable(
                name: "person_with_alzheimer_disease",
                newName: "persons_with_alzheimer_disease");

            migrationBuilder.RenameTable(
                name: "person",
                newName: "persons");

            migrationBuilder.RenameTable(
                name: "non_user_support_person",
                newName: "non_user_support_persons");

            migrationBuilder.RenameIndex(
                name: "IX_scheduling_PrescriptionId",
                table: "schedules",
                newName: "IX_schedules_PrescriptionId");

            migrationBuilder.RenameIndex(
                name: "IX_scheduling_PersonWithAlzheimersDiseaseId",
                table: "schedules",
                newName: "IX_schedules_PersonWithAlzheimersDiseaseId");

            migrationBuilder.RenameIndex(
                name: "IX_prescription_PatientId",
                table: "prescriptions",
                newName: "IX_prescriptions_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_prescription_MedicineId",
                table: "prescriptions",
                newName: "IX_prescriptions_MedicineId");

            migrationBuilder.RenameIndex(
                name: "IX_person_with_alzheimer_disease_ResponsibleId",
                table: "persons_with_alzheimer_disease",
                newName: "IX_persons_with_alzheimer_disease_ResponsibleId");

            migrationBuilder.RenameIndex(
                name: "IX_person_with_alzheimer_disease_PersonId",
                table: "persons_with_alzheimer_disease",
                newName: "IX_persons_with_alzheimer_disease_PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_person_with_alzheimer_disease_ClinicId",
                table: "persons_with_alzheimer_disease",
                newName: "IX_persons_with_alzheimer_disease_ClinicId");

            migrationBuilder.RenameIndex(
                name: "IX_person_SecondaryPhoneId",
                table: "persons",
                newName: "IX_persons_SecondaryPhoneId");

            migrationBuilder.RenameIndex(
                name: "IX_person_SecondaryAddressId",
                table: "persons",
                newName: "IX_persons_SecondaryAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_person_MainPhoneId",
                table: "persons",
                newName: "IX_persons_MainPhoneId");

            migrationBuilder.RenameIndex(
                name: "IX_person_MainAddressId",
                table: "persons",
                newName: "IX_persons_MainAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_non_user_support_person_PersonWithAlzheimersDiseaseId",
                table: "non_user_support_persons",
                newName: "IX_non_user_support_persons_PersonWithAlzheimersDiseaseId");

            migrationBuilder.RenameIndex(
                name: "IX_non_user_support_person_PersonId",
                table: "non_user_support_persons",
                newName: "IX_non_user_support_persons_PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_schedules",
                table: "schedules",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_prescriptions",
                table: "prescriptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_phones",
                table: "phones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_persons_with_alzheimer_disease",
                table: "persons_with_alzheimer_disease",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_persons",
                table: "persons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_non_user_support_persons",
                table: "non_user_support_persons",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_caregivers_persons_PersonId",
                table: "caregivers",
                column: "PersonId",
                principalTable: "persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_clinics_phones_MainPhoneNumberId",
                table: "clinics",
                column: "MainPhoneNumberId",
                principalTable: "phones",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_clinics_phones_SecondaryPhoneNumberId",
                table: "clinics",
                column: "SecondaryPhoneNumberId",
                principalTable: "phones",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_non_user_support_persons_persons_PersonId",
                table: "non_user_support_persons",
                column: "PersonId",
                principalTable: "persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_non_user_support_persons_persons_with_alzheimer_disease_Per~",
                table: "non_user_support_persons",
                column: "PersonWithAlzheimersDiseaseId",
                principalTable: "persons_with_alzheimer_disease",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_persons_addresses_MainAddressId",
                table: "persons",
                column: "MainAddressId",
                principalTable: "addresses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_persons_addresses_SecondaryAddressId",
                table: "persons",
                column: "SecondaryAddressId",
                principalTable: "addresses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_persons_phones_MainPhoneId",
                table: "persons",
                column: "MainPhoneId",
                principalTable: "phones",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_persons_phones_SecondaryPhoneId",
                table: "persons",
                column: "SecondaryPhoneId",
                principalTable: "phones",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_persons_with_alzheimer_disease_caregivers_ResponsibleId",
                table: "persons_with_alzheimer_disease",
                column: "ResponsibleId",
                principalTable: "caregivers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_persons_with_alzheimer_disease_clinics_ClinicId",
                table: "persons_with_alzheimer_disease",
                column: "ClinicId",
                principalTable: "clinics",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_persons_with_alzheimer_disease_persons_PersonId",
                table: "persons_with_alzheimer_disease",
                column: "PersonId",
                principalTable: "persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_prescriptions_medicines_MedicineId",
                table: "prescriptions",
                column: "MedicineId",
                principalTable: "medicines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_prescriptions_persons_with_alzheimer_disease_PatientId",
                table: "prescriptions",
                column: "PatientId",
                principalTable: "persons_with_alzheimer_disease",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_schedules_persons_with_alzheimer_disease_PersonWithAlzheime~",
                table: "schedules",
                column: "PersonWithAlzheimersDiseaseId",
                principalTable: "persons_with_alzheimer_disease",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_schedules_prescriptions_PrescriptionId",
                table: "schedules",
                column: "PrescriptionId",
                principalTable: "prescriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_caregivers_persons_PersonId",
                table: "caregivers");

            migrationBuilder.DropForeignKey(
                name: "FK_clinics_phones_MainPhoneNumberId",
                table: "clinics");

            migrationBuilder.DropForeignKey(
                name: "FK_clinics_phones_SecondaryPhoneNumberId",
                table: "clinics");

            migrationBuilder.DropForeignKey(
                name: "FK_non_user_support_persons_persons_PersonId",
                table: "non_user_support_persons");

            migrationBuilder.DropForeignKey(
                name: "FK_non_user_support_persons_persons_with_alzheimer_disease_Per~",
                table: "non_user_support_persons");

            migrationBuilder.DropForeignKey(
                name: "FK_persons_addresses_MainAddressId",
                table: "persons");

            migrationBuilder.DropForeignKey(
                name: "FK_persons_addresses_SecondaryAddressId",
                table: "persons");

            migrationBuilder.DropForeignKey(
                name: "FK_persons_phones_MainPhoneId",
                table: "persons");

            migrationBuilder.DropForeignKey(
                name: "FK_persons_phones_SecondaryPhoneId",
                table: "persons");

            migrationBuilder.DropForeignKey(
                name: "FK_persons_with_alzheimer_disease_caregivers_ResponsibleId",
                table: "persons_with_alzheimer_disease");

            migrationBuilder.DropForeignKey(
                name: "FK_persons_with_alzheimer_disease_clinics_ClinicId",
                table: "persons_with_alzheimer_disease");

            migrationBuilder.DropForeignKey(
                name: "FK_persons_with_alzheimer_disease_persons_PersonId",
                table: "persons_with_alzheimer_disease");

            migrationBuilder.DropForeignKey(
                name: "FK_prescriptions_medicines_MedicineId",
                table: "prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_prescriptions_persons_with_alzheimer_disease_PatientId",
                table: "prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_schedules_persons_with_alzheimer_disease_PersonWithAlzheime~",
                table: "schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_schedules_prescriptions_PrescriptionId",
                table: "schedules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_schedules",
                table: "schedules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_prescriptions",
                table: "prescriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_phones",
                table: "phones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_persons_with_alzheimer_disease",
                table: "persons_with_alzheimer_disease");

            migrationBuilder.DropPrimaryKey(
                name: "PK_persons",
                table: "persons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_non_user_support_persons",
                table: "non_user_support_persons");

            migrationBuilder.RenameTable(
                name: "schedules",
                newName: "scheduling");

            migrationBuilder.RenameTable(
                name: "prescriptions",
                newName: "prescription");

            migrationBuilder.RenameTable(
                name: "phones",
                newName: "phone");

            migrationBuilder.RenameTable(
                name: "persons_with_alzheimer_disease",
                newName: "person_with_alzheimer_disease");

            migrationBuilder.RenameTable(
                name: "persons",
                newName: "person");

            migrationBuilder.RenameTable(
                name: "non_user_support_persons",
                newName: "non_user_support_person");

            migrationBuilder.RenameIndex(
                name: "IX_schedules_PrescriptionId",
                table: "scheduling",
                newName: "IX_scheduling_PrescriptionId");

            migrationBuilder.RenameIndex(
                name: "IX_schedules_PersonWithAlzheimersDiseaseId",
                table: "scheduling",
                newName: "IX_scheduling_PersonWithAlzheimersDiseaseId");

            migrationBuilder.RenameIndex(
                name: "IX_prescriptions_PatientId",
                table: "prescription",
                newName: "IX_prescription_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_prescriptions_MedicineId",
                table: "prescription",
                newName: "IX_prescription_MedicineId");

            migrationBuilder.RenameIndex(
                name: "IX_persons_with_alzheimer_disease_ResponsibleId",
                table: "person_with_alzheimer_disease",
                newName: "IX_person_with_alzheimer_disease_ResponsibleId");

            migrationBuilder.RenameIndex(
                name: "IX_persons_with_alzheimer_disease_PersonId",
                table: "person_with_alzheimer_disease",
                newName: "IX_person_with_alzheimer_disease_PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_persons_with_alzheimer_disease_ClinicId",
                table: "person_with_alzheimer_disease",
                newName: "IX_person_with_alzheimer_disease_ClinicId");

            migrationBuilder.RenameIndex(
                name: "IX_persons_SecondaryPhoneId",
                table: "person",
                newName: "IX_person_SecondaryPhoneId");

            migrationBuilder.RenameIndex(
                name: "IX_persons_SecondaryAddressId",
                table: "person",
                newName: "IX_person_SecondaryAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_persons_MainPhoneId",
                table: "person",
                newName: "IX_person_MainPhoneId");

            migrationBuilder.RenameIndex(
                name: "IX_persons_MainAddressId",
                table: "person",
                newName: "IX_person_MainAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_non_user_support_persons_PersonWithAlzheimersDiseaseId",
                table: "non_user_support_person",
                newName: "IX_non_user_support_person_PersonWithAlzheimersDiseaseId");

            migrationBuilder.RenameIndex(
                name: "IX_non_user_support_persons_PersonId",
                table: "non_user_support_person",
                newName: "IX_non_user_support_person_PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_scheduling",
                table: "scheduling",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_prescription",
                table: "prescription",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_phone",
                table: "phone",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_person_with_alzheimer_disease",
                table: "person_with_alzheimer_disease",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_person",
                table: "person",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_non_user_support_person",
                table: "non_user_support_person",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_caregivers_person_PersonId",
                table: "caregivers",
                column: "PersonId",
                principalTable: "person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_clinics_phone_MainPhoneNumberId",
                table: "clinics",
                column: "MainPhoneNumberId",
                principalTable: "phone",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_clinics_phone_SecondaryPhoneNumberId",
                table: "clinics",
                column: "SecondaryPhoneNumberId",
                principalTable: "phone",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_non_user_support_person_person_PersonId",
                table: "non_user_support_person",
                column: "PersonId",
                principalTable: "person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_non_user_support_person_person_with_alzheimer_disease_Perso~",
                table: "non_user_support_person",
                column: "PersonWithAlzheimersDiseaseId",
                principalTable: "person_with_alzheimer_disease",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_person_addresses_MainAddressId",
                table: "person",
                column: "MainAddressId",
                principalTable: "addresses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_person_addresses_SecondaryAddressId",
                table: "person",
                column: "SecondaryAddressId",
                principalTable: "addresses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_person_phone_MainPhoneId",
                table: "person",
                column: "MainPhoneId",
                principalTable: "phone",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_person_phone_SecondaryPhoneId",
                table: "person",
                column: "SecondaryPhoneId",
                principalTable: "phone",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_person_with_alzheimer_disease_caregivers_ResponsibleId",
                table: "person_with_alzheimer_disease",
                column: "ResponsibleId",
                principalTable: "caregivers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_person_with_alzheimer_disease_clinics_ClinicId",
                table: "person_with_alzheimer_disease",
                column: "ClinicId",
                principalTable: "clinics",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_person_with_alzheimer_disease_person_PersonId",
                table: "person_with_alzheimer_disease",
                column: "PersonId",
                principalTable: "person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_prescription_medicines_MedicineId",
                table: "prescription",
                column: "MedicineId",
                principalTable: "medicines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_prescription_person_with_alzheimer_disease_PatientId",
                table: "prescription",
                column: "PatientId",
                principalTable: "person_with_alzheimer_disease",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_scheduling_person_with_alzheimer_disease_PersonWithAlzheime~",
                table: "scheduling",
                column: "PersonWithAlzheimersDiseaseId",
                principalTable: "person_with_alzheimer_disease",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_scheduling_prescription_PrescriptionId",
                table: "scheduling",
                column: "PrescriptionId",
                principalTable: "prescription",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
