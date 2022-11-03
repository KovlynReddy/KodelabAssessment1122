using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KodelabAssessment1122DLL.DomainModels
{
    public class BaseModel
    {
        [Key]
        public int id { get; set; }
        public string ModelId { get; set; }
        public int IsDeleted { get; set; }
        public string CreatorId { get; set; }
        public string CreatedDateTime { get; set; }
    }
}
