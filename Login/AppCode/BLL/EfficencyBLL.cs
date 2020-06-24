using Login.AppCode.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class EfficencyBLL
{
    public EfficencyBLL()
    {
    }

    public DataTable InsertEfficencyData(EfficencyInput efficency)
    {
        DataTable dt = null;
        try
        {
            EfficencyGateway efficencyGateway = new EfficencyGateway();
            dt = efficencyGateway.InsertEfficencyData(efficency);
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }


    public DataTable LoadEfficencyInformation()
    {
        DataTable dt = null;
        try
        {
            EfficencyGateway efficencyGateway = new EfficencyGateway();
            dt = efficencyGateway.LoadEfficencyInformation();
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public int UpdateEfficencyInfo(EfficencyInput efficency)
    {
        int actionResult = 0;
        try
        {
            EfficencyGateway efficencyGateway = new EfficencyGateway();
            actionResult = efficencyGateway.UpdateEfficencyInfo(efficency);
            return actionResult;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public int DeleteEfficencyInfo(int EfficencyId)
    {
        int actionResult = 0;
        try
        {
            EfficencyGateway efficencyGateway = new EfficencyGateway();
            actionResult = efficencyGateway.DeleteEfficencyInfo(EfficencyId);
            return actionResult;
        }
        catch (Exception ex)
        {
            throw ex;
        }

    }
    public DataTable GetIncentiveSummaryReports(string FromDate, string ToDate, string Plant)
    {
        DataTable dt = null;
        try
        {
            EfficencyGateway efficencyGateway = new EfficencyGateway();
            dt = efficencyGateway.GetIncentiveSummaryReports(FromDate,ToDate,Plant);
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }


    public DataTable GetEfficencySummaryReport(string FromDate, string ToDate)
    {
        DataTable dt = null;
        try
        {
            EfficencyGateway efficencyGateway = new EfficencyGateway();
            dt = efficencyGateway.GetEfficencySummaryReport(FromDate, ToDate);
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public DataTable GetProductionAndOtSummeryReport(string FromDate, string ToDate)
    {
        DataTable dt = null;
        try
        {
            EfficencyGateway efficencyGateway = new EfficencyGateway();
            dt = efficencyGateway.GetProductionAndOtSummeryReport(FromDate, ToDate);
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public DataTable SampleCostBrakeDownSummeryReport(string FromDate, string ToDate, double MaterialCostR1, double OverHeadCostR1, double MaterialCostK2, double OverHeadCostK2, double PlanCpm)
    {
        DataTable dt = null;
        try
        {
            EfficencyGateway efficencyGateway = new EfficencyGateway();
            dt = efficencyGateway.SampleCostBrakeDownSummeryReport(FromDate, ToDate, MaterialCostR1, OverHeadCostR1, MaterialCostK2, OverHeadCostK2, PlanCpm);
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public DataTable GetMailSummeryReport(string FromDate, string ToDate)
    {
        DataTable dt = null;
        try
        {
            EfficencyGateway efficencyGateway = new EfficencyGateway();
            dt = efficencyGateway.GetMailSummeryReport(FromDate, ToDate);
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }



    public DataTable SampleCostBrakeDownReportForMail(string FromDate, string ToDate, double MaterialCostR1, double OverHeadCostR1, double MaterialCostK2, double OverHeadCostK2)
    {
        DataTable dt = null;
        try
        {
            EfficencyGateway efficencyGateway = new EfficencyGateway();
            dt = efficencyGateway.SampleCostBrakeDownReportForMail(FromDate, ToDate, MaterialCostR1, OverHeadCostR1, MaterialCostK2, OverHeadCostK2);
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public DataTable GetBuyerWiseProduction(string FromDate, string ToDate,string Plant)
    {
        DataTable dt = null;
        try
        {
            EfficencyGateway efficencyGateway = new EfficencyGateway();
            dt = efficencyGateway.GetBuyerWiseProduction(FromDate, ToDate, Plant);
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public DataTable GetItemCategoryWiseReport(string FromDate, string ToDate, string Plant)
    {
        DataTable dt = null;
        try
        {
            EfficencyGateway efficencyGateway = new EfficencyGateway();
            dt = efficencyGateway.GetItemCategoryWiseReport(FromDate, ToDate,Plant);
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public DataTable GetDepartmentWiseReport(string FromDate, string ToDate,string plant)
    {
        DataTable dt = null;
        try
        {
            EfficencyGateway efficencyGateway = new EfficencyGateway();
            dt = efficencyGateway.GetDepartmentWiseReport(FromDate, ToDate,plant);
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }


    public DataTable GetSupervisorSummeryReport(string FromDate, string ToDate, string Plant)
    {
        DataTable dt = null;
        try
        {
            EfficencyGateway efficencyGateway = new EfficencyGateway();
            dt = efficencyGateway.GetSupervisorSummeryReport(FromDate, ToDate, Plant);
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}

