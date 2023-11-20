using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class InstructorManager : IInstructorService
    {
        IInstructorDal _instructorDal;
        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }
        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }

        public List<Instructor> GetAllByInstructorId(int id)
        {
            return _instructorDal.GetAll(i=>i.InstructorId == id);
        }
    }
}
