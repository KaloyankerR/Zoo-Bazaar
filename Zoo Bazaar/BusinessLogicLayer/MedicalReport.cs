using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicObjectLayer
{
    public class MedicalReport
    {
        public int ID { get; set; }
        public Animal Animal { get; set; }
        public string MedicalReportTitle { get; set; }
        public string MedicalDescription { get; set; }
        public string Medicaments { get; set; }
        public string Treatment { get; set; }
        public DateTime MedicamentsStart { get; set; }
        public DateTime MedicamentsEnd { get; set; }
        public string MedicamentsTakeSchedule { get; set; }
        public bool TreatmentFinished { get; set; }

        public MedicalReport() 
        {

        }

        public MedicalReport(int id, Animal animal, string medicalReportTitle, string medicalDescription, string medicaments, string treatment, 
            DateTime medicamentsStart, DateTime medicamentsEnd, string medicamentsTakeSchedule, bool treatmentFinished)
        {
            ID = id;
            Animal = animal;
            MedicalReportTitle = medicalReportTitle;
            MedicalDescription = medicalDescription;
            Medicaments = medicaments;
            Treatment = treatment;
            MedicamentsStart = medicamentsStart;
            MedicamentsEnd = medicamentsEnd;
            MedicamentsTakeSchedule = medicamentsTakeSchedule;
            TreatmentFinished = treatmentFinished;
        }
    }
}
