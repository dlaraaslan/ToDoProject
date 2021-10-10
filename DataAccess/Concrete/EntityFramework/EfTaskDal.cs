using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTaskDal : EfEntityRepositoryBase<Task, ToDoContext>, ITaskDal
    {
        public List<TaskDetailDto> GetTaskDetails() 
        {
            using (ToDoContext context = new ToDoContext())
            {
                var result = from t in context.Tasks
                             join c in context.Categories
                             on t.CategoryId equals c.Id
                             select new TaskDetailDto
                             {
                                 Description = t.Description,
                                 IsComplete = t.IsComplete,
                                 CategoryName = c.CategoryName,
                                 StartDate = t.StartDate.Value,
                                 EndDate = t.EndDate.Value
                             };
                return result.ToList();
            }
        }
    }
}
