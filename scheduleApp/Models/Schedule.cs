using scheduleApp.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace scheduleApp.Models
{
    public class Schedule
    {
        public int ID { get; set; }
        public int IDDiscipline { get; set; }
        [ForeignKey(nameof(IDDiscipline))]
        public Discipline Discipline { get; set; }

        public int IDBegin { get; set; }
        [ForeignKey(nameof(IDBegin))]
        public Time TimeBegin { get; set; }

        public int IDEnd { get; set; }
        [ForeignKey(nameof(IDEnd))]
        public Time TimeEnd { get; set; }
    }
}
