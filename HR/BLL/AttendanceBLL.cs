using HR.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace HR.BLL
{
    public class AttendanceBLL
    {
        public void AddAttendance(string name, string day1)
        {
            try
            {
                // Call DAL to save Attendance
                AttendanceDAL ObjAttendanceDAL = new HR.DAL.AttendanceDAL();
                ObjAttendanceDAL.InsertAttendance(name, day1);
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }

        public DataTable ShowAllAttendance()
        {
            try
            {
                AttendanceDAL ObjAttendanceDAL = new HR.DAL.AttendanceDAL();
                return ObjAttendanceDAL.ShowAllAttendance();
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }

    }

    
    
}