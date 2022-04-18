using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassSchedule.Models {
    public interface IClassScheduleUnitOfWork {

        public Repository<Day> Days { get; }
        public Repository<Teacher> Teachers { get; }
        public Repository<Class> Classes { get; }

        public void Save();
    }
}
