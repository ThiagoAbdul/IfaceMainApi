namespace IfaceMainApi.Models.Entities
{
    public class Routine : EntityBase
    {
        public string CronExp { get; set; } = string.Empty;
        public Guid PersonWithAlzheimersDiseaseId { get; set; }
        public PersonWithAlzheimerDisease? PersonWithAlzheimersDisease { get; set; }

        public string Description { get; set; } = string.Empty;

        public Routine()
        {
            
        }

    }
}
