using HR.DAL;
using System;
using System.Data;

namespace HR.BLL
{
    public class AttendanceBLL
    {
        public void AddAttendance(string employeeName, DateTime attendanceDate, bool isPresent)
        {
            try
            {
                AttendanceDAL ObjAttendanceDAL = new AttendanceDAL();
                ObjAttendanceDAL.InsertAttendance(employeeName, attendanceDate, isPresent);
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
                AttendanceDAL ObjAttendanceDAL = new AttendanceDAL();
                return ObjAttendanceDAL.ShowAllAttendance();
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }
    }
}
