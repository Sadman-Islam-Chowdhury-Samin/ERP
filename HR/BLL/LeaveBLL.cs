using HR.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace HR.BLL
{
    public class LeaveBLL
    {

        public void AddLeave(string name, string duration)
        {
            try
            {
                // Call DAL to save Leave
                LeaveDAL ObjLeaveDAL = new HR.DAL.LeaveDAL();
                ObjLeaveDAL.InsertLeave(name, duration);
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }

        public DataTable ShowAllLeaves()
        {
            try
            {
                LeaveDAL ObjLeaveDAL = new HR.DAL.LeaveDAL();
                return ObjLeaveDAL.ShowAllLeaves();
            }
            catch (Exception msgException)
            {
                throw msgException;
            }
        }

        public void UpdateLeave(int id, string name, string duration)
        {
            try
            {
                LeaveDAL objLeaveDAL = new LeaveDAL();
                objLeaveDAL.UpdateLeave(id, name, duration);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteLeave(int id)
        {
            try
            {
                LeaveDAL objLeaveDAL = new LeaveDAL();
                objLeaveDAL.DeleteLeave(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}