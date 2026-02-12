using RS1_2024_25.API.Data.Models.SharedTables;
using RS1_2024_25.API.Data.Models.TenantSpecificTables.Modul1_Auth;
using RS1_2024_25.API.Helper.BaseClasses;
using System.ComponentModel.DataAnnotations.Schema;

namespace RS1_2024_25.API.Data.Models.TenantSpecificTables.Modul2_Basic
{
    public class Semester : TenantSpecificTable
    {
        public int StudentId { get; set; }
        [ForeignKey(nameof(StudentId))]
        public Student? Student { get; set; }
        public int AcademicYearId { get; set; }
        [ForeignKey(nameof(AcademicYearId))]
        public AcademicYear? AcademicYear { get; set; }
        public int StudyYear { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public float TuitionFee { get; set; }
        public bool isRenewal { get; set; }
        public int RecordedById { get; set; }
        [ForeignKey(nameof(RecordedById))]
        public MyAppUser? MyAppUser{ get; set; }
        public bool isDeleted { get; set; }
    }
}
