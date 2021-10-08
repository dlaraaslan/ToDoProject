using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    //farklı class verilerini bir arada kullanmamızı sağlar 
    public class TaskDetailDto: IDto
    {
        public string Description { get; set; }
        public bool IsComplete { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string CategoryName { get; set; }
    }
}
