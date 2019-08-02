using System;
using System.Collections.Generic;
using System.Text;

namespace StudentExercises.Models
{
    class Students
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohorts Cohort { get; set; }
    }
}
