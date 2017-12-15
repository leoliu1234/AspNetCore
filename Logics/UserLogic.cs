using System;
using AspNetCore.DataLayer.Data;
using AspNetCore.DataLayer.Models;

namespace demo
{
    public class UserLogic : IUserLogic
    {
        private readonly SchoolContext _schoolContext;
        public UserLogic(SchoolContext schoolContext)
        {
            this._schoolContext = schoolContext;
        }
        public string GetSenderName()
        {
            _schoolContext.Students.Add(new Student(){ LastName="Liu", FirstName="Leo", EnrollmentDate = DateTime.Now});
            _schoolContext.SaveChanges();
            return "Leo";
        }
    }

    public interface IUserLogic
    {
        string GetSenderName();
    }

}