using scheduleApp.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace scheduleApp.Models
{
    public class schedule
    {
        public int ID { get; set; }
        public int IDDiscipline { get; set; }
        [ForeignKey(nameof(IDDiscipline))]
        public discipline Discipline { get; set; }

        public int IDBegin { get; set; }
        [ForeignKey(nameof(IDBegin))]
        public time TimeBegin { get; set; }

        public int IDEnd { get; set; }
        [ForeignKey(nameof(IDEnd))]
        public time TimeEnd { get; set; }
    }
}
