using Business.Abstracts;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public IResult Add(Course course)
        {
            //if (course.CourseName == "y")
            //{
            //    return new ErrorResult("Invalid course name!");
            //}
            _courseDal.Add(course);
            return new SuccessResult("Course added.");
        }

        public IResult Delete(Course course)
        {
            _courseDal.Delete(course);
            return new SuccessResult("Course deleted.");
        }

        public IDataResult<Course> Get(int id)
        {
            return new SuccessDataResult<Course>(_courseDal.Get(c => c.CourseId == id),"Founded!");
        }

        public IDataResult<List<Course>> GetAll()
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(),"Course List ");
        }

        public IResult Update(Course course)
        {
            _courseDal.Update(course);
            return new SuccessResult("Updated!");
        }
    }
}
