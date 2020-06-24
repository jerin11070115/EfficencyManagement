using Login.AppCode.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class EfficencyGateway: ConnectionGateway
    {
    public EfficencyGateway()
    {

    }

    public DataTable InsertEfficencyData(EfficencyInput efficency)
    {
        DataTable dt = new DataTable();
        try
        {
            OpenConnection();
            ArrayList arlSqlParameter = new ArrayList();
            arlSqlParameter.Add(new SqlParameter("@Plant", efficency.Plant));
            arlSqlParameter.Add(new SqlParameter("@SewingTeam", efficency.SewingTeam));
            arlSqlParameter.Add(new SqlParameter("@Supervisor", efficency.Supervisor));
            arlSqlParameter.Add(new SqlParameter("@Attendance", efficency.Attendance));
            arlSqlParameter.Add(new SqlParameter("@BuyerName", efficency.BuyerName));
            arlSqlParameter.Add(new SqlParameter("@SerialNumber", efficency.SerialNumber));
            arlSqlParameter.Add(new SqlParameter("@StyleNumber", efficency.StyleNumber));
            arlSqlParameter.Add(new SqlParameter("@SampleType", efficency.SampleType));
            arlSqlParameter.Add(new SqlParameter("@ItemCategory", efficency.ItemCategory));
            arlSqlParameter.Add(new SqlParameter("@SmvFactor", efficency.SmvFactor));
            arlSqlParameter.Add(new SqlParameter("@SmvFactorValue", efficency.SmvFactorValue));
            arlSqlParameter.Add(new SqlParameter("@SampleMaker", efficency.SampleMaker));
            arlSqlParameter.Add(new SqlParameter("@SampleMakingTime", efficency.SampleMakingTime));
            arlSqlParameter.Add(new SqlParameter("@ProductQuentity", efficency.ProductQuentity));
            arlSqlParameter.Add(new SqlParameter("@SmvValue", efficency.SmvValue));
            arlSqlParameter.Add(new SqlParameter("@MachineLostTime", efficency.MachineLostTime));
            arlSqlParameter.Add(new SqlParameter("@MerchantLostTime", efficency.MerchantLostTime));
            arlSqlParameter.Add(new SqlParameter("@PatternLostTime", efficency.PatternLostTime));
            arlSqlParameter.Add(new SqlParameter("@EmbiLostTime", efficency.EmbiLostTime));
            arlSqlParameter.Add(new SqlParameter("@OtherLostTime", efficency.OtherLostTime));
            arlSqlParameter.Add(new SqlParameter("@TotalLostTime", efficency.TotalLostTime));
            arlSqlParameter.Add(new SqlParameter("@OverTime90Person", efficency.OverTime90Person));
            arlSqlParameter.Add(new SqlParameter("@OverTime105Person", efficency.OverTime105Person));
            arlSqlParameter.Add(new SqlParameter("@OverTime120Person", efficency.OverTime120Person));
            arlSqlParameter.Add(new SqlParameter("@OverTime90", efficency.OverTime90));
            arlSqlParameter.Add(new SqlParameter("@OverTime105", efficency.OverTime105));
            arlSqlParameter.Add(new SqlParameter("@OverTime120", efficency.OverTime120));
            arlSqlParameter.Add(new SqlParameter("@TotalOverTime", efficency.TotalOverTime));
            arlSqlParameter.Add(new SqlParameter("@TotalOfficialTime", efficency.TotalOfficialTime));
            arlSqlParameter.Add(new SqlParameter("@TotalTime", efficency.TotalTime));
            arlSqlParameter.Add(new SqlParameter("@Rating", efficency.Rating));
            arlSqlParameter.Add(new SqlParameter("@EstimatedTime", efficency.EstimatedTime));
            arlSqlParameter.Add(new SqlParameter("@TotalProduceMinute", efficency.TotalProduceMinute));
            arlSqlParameter.Add(new SqlParameter("@Fact1Below21", efficency.Fact1Below21));
            arlSqlParameter.Add(new SqlParameter("@Fact2Above20", efficency.Fact2Above20));
            arlSqlParameter.Add(new SqlParameter("@TotalFact", efficency.TotalFact));
            arlSqlParameter.Add(new SqlParameter("@ActualTakenTime", efficency.ActualTakenTime));
            arlSqlParameter.Add(new SqlParameter("@PerformancePercentage", efficency.PerformancePercentage));
            arlSqlParameter.Add(new SqlParameter("@MinimumProduceTime", efficency.MinimumProduceTime));
            arlSqlParameter.Add(new SqlParameter("@NonProductiveTime", efficency.NonProductiveTime));

            arlSqlParameter.Add(new SqlParameter("@Department", efficency.Department));
            //arlSqlParameter.Add(new SqlParameter("@Wip", efficency.Wip));
            //arlSqlParameter.Add(new SqlParameter("@MaterialCostAvg", efficency.MaterialCostAvg));
            //arlSqlParameter.Add(new SqlParameter("@OverHeadCost", efficency.OverHeadCost));

            arlSqlParameter.Add(new SqlParameter("@ProductionDate", efficency.ProductionDate));
            arlSqlParameter.Add(new SqlParameter("@Comments", efficency.Comments));

            dt = this.ExecuteQuery("[effi].[USP_InsertEfficencyInfo]", arlSqlParameter);
        }
        catch (Exception ex)
        {


        }
        finally
        {
            CloseConnection();
        }
        return dt;

    }

    public DataTable LoadEfficencyInformation()
    {
        DataTable dt = new DataTable();
        try
        {
            OpenConnection();
            ArrayList arlSqlParameter = new ArrayList();
            dt = this.ExecuteQuery("[effi].[Usp_GetAllInfoOfEfficency]", arlSqlParameter);
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally {

            CloseConnection();
        }

    }
    public int UpdateEfficencyInfo(EfficencyInput efficency)
    {
        int ActionResult = 0;
        try
        {
            OpenConnection();
            ArrayList arlSqlParameter = new ArrayList();
            arlSqlParameter.Add(new SqlParameter("@EfficencyId", efficency.EfficencyId));

            arlSqlParameter.Add(new SqlParameter("@plant", efficency.Plant));
            arlSqlParameter.Add(new SqlParameter("@SewingTeam", efficency.SewingTeam));
            arlSqlParameter.Add(new SqlParameter("@Supervisor", efficency.Supervisor));
            arlSqlParameter.Add(new SqlParameter("@Attendance", efficency.Attendance));
            arlSqlParameter.Add(new SqlParameter("@BuyerName", efficency.BuyerName));
            arlSqlParameter.Add(new SqlParameter("@SerialNumber", efficency.SerialNumber));
            arlSqlParameter.Add(new SqlParameter("@StyleNumber", efficency.StyleNumber));
            arlSqlParameter.Add(new SqlParameter("@SampleType", efficency.SampleType));
            arlSqlParameter.Add(new SqlParameter("@ItemCategory", efficency.ItemCategory));
            arlSqlParameter.Add(new SqlParameter("@SmvFactor", efficency.SmvFactor));
            arlSqlParameter.Add(new SqlParameter("@SmvFactorValue", efficency.SmvFactorValue));
            arlSqlParameter.Add(new SqlParameter("@SampleMaker", efficency.SampleMaker));
            arlSqlParameter.Add(new SqlParameter("@SampleMakingTime", efficency.SampleMakingTime));
            arlSqlParameter.Add(new SqlParameter("@ProductQuentity", efficency.ProductQuentity));
            arlSqlParameter.Add(new SqlParameter("@SmvValue", efficency.SmvValue));
            arlSqlParameter.Add(new SqlParameter("@MachineLostTime", efficency.MachineLostTime));
            arlSqlParameter.Add(new SqlParameter("@MerchantLostTime", efficency.MerchantLostTime));
            arlSqlParameter.Add(new SqlParameter("@PatternLostTime", efficency.PatternLostTime));
            arlSqlParameter.Add(new SqlParameter("@EmbiLostTime", efficency.EmbiLostTime));
            arlSqlParameter.Add(new SqlParameter("@OtherLostTime", efficency.OtherLostTime));
            arlSqlParameter.Add(new SqlParameter("@TotalLostTime", efficency.TotalLostTime));
            arlSqlParameter.Add(new SqlParameter("@OverTime90Person", efficency.OverTime90Person));
            arlSqlParameter.Add(new SqlParameter("@OverTime105Person", efficency.OverTime105Person));
            arlSqlParameter.Add(new SqlParameter("@OverTime120Person", efficency.OverTime120Person));
            arlSqlParameter.Add(new SqlParameter("@OverTime90", efficency.OverTime90));
            arlSqlParameter.Add(new SqlParameter("@OverTime105", efficency.OverTime105));
            arlSqlParameter.Add(new SqlParameter("@OverTime120", efficency.OverTime120));
            arlSqlParameter.Add(new SqlParameter("@TotalOverTime", efficency.TotalOverTime));
            arlSqlParameter.Add(new SqlParameter("@TotalOfficialTime", efficency.TotalOfficialTime));
            arlSqlParameter.Add(new SqlParameter("@TotalTime", efficency.TotalTime));
            arlSqlParameter.Add(new SqlParameter("@Rating", efficency.Rating));
            arlSqlParameter.Add(new SqlParameter("@EstimatedTime", efficency.EstimatedTime));
            arlSqlParameter.Add(new SqlParameter("@TotalProduceMinute", efficency.TotalProduceMinute));
            arlSqlParameter.Add(new SqlParameter("@Fact1Below21", efficency.Fact1Below21));
            arlSqlParameter.Add(new SqlParameter("@Fact2Above20", efficency.Fact2Above20));
            arlSqlParameter.Add(new SqlParameter("@TotalFact", efficency.TotalFact));
            arlSqlParameter.Add(new SqlParameter("@ActualTakenTime", efficency.ActualTakenTime));
            arlSqlParameter.Add(new SqlParameter("@PerformancePercentage", efficency.PerformancePercentage));
            arlSqlParameter.Add(new SqlParameter("@MinimumProduceTime", efficency.MinimumProduceTime));
            arlSqlParameter.Add(new SqlParameter("@NonProductiveTime", efficency.NonProductiveTime));

            arlSqlParameter.Add(new SqlParameter("@Department", efficency.Department));
            

            arlSqlParameter.Add(new SqlParameter("@ProductionDate", efficency.ProductionDate));
            arlSqlParameter.Add(new SqlParameter("@Comments", efficency.Comments));

            ActionResult = this.ExecuteActionQuery("[Effi].[USP_UpdateEfficencyInfo]", arlSqlParameter);
            return ActionResult;
        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally {
            CloseConnection();
        }


    }

    public int DeleteEfficencyInfo(int EfficencyId)
    {
        int actionResult = 0;
        try {
            OpenConnection();
            ArrayList arlSqlParameter = new ArrayList();
            arlSqlParameter.Add(new SqlParameter("@EfficencyId", EfficencyId));

            actionResult = this.ExecuteActionQuery("[Effi].[USP_DeleteEfficencyInfo]", arlSqlParameter);
            return actionResult;
        }
        catch (Exception ex)
        {
            throw ex;
                
        }
        finally
        {

            CloseConnection();
        }
    }

    public DataTable GetIncentiveSummaryReports(string FromDate, string ToDate,string Plant)
    {
        DataTable dt = null;
        try
        {
            OpenConnection();
            ArrayList arlSqlParameter = new ArrayList();
            arlSqlParameter.Add(new SqlParameter("@FromDate", FromDate));
            arlSqlParameter.Add(new SqlParameter("@ToDate", ToDate));
            arlSqlParameter.Add(new SqlParameter("@Plant", Plant));
            dt = this.ExecuteQuery("[Reports].[USP_GetIncentiveSummaryReport]", arlSqlParameter);
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally {
            CloseConnection();
        }
    }



    public DataTable GetEfficencySummaryReport(string FromDate, string ToDate)
    {
        DataTable dt = null;
        try
        {
            OpenConnection();
            ArrayList arlSqlParameter = new ArrayList();
            arlSqlParameter.Add(new SqlParameter("@FromDate", FromDate));
            arlSqlParameter.Add(new SqlParameter("@ToDate", ToDate));
          
       
            dt = this.ExecuteQuery("[Reports].[USP_GetEfficencySummeryReport]", arlSqlParameter);
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            CloseConnection();
        }
    }

    public DataTable GetProductionAndOtSummeryReport(string FromDate, string ToDate)
    {
        DataTable dt = null;
        try
        {
            OpenConnection();
            ArrayList arlSqlParameter = new ArrayList();
            arlSqlParameter.Add(new SqlParameter("@FromDate", FromDate));
            arlSqlParameter.Add(new SqlParameter("@ToDate", ToDate));
            dt = this.ExecuteQuery("[Reports].[USP_GetProductionAndOtSummery]", arlSqlParameter);
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            CloseConnection();
        }
    }

    public DataTable SampleCostBrakeDownSummeryReport(string FromDate, string ToDate, double MaterialCostR1, double OverHeadCostR1, double MaterialCostK2, double OverHeadCostK2, double PlanCpm)
    {
        DataTable dt = null;
        try
        {
            OpenConnection();
            ArrayList arlSqlParameter = new ArrayList();
            arlSqlParameter.Add(new SqlParameter("@FromDate", FromDate));
            arlSqlParameter.Add(new SqlParameter("@ToDate", ToDate));
            arlSqlParameter.Add(new SqlParameter("@MaterialCostR1", MaterialCostR1));
            arlSqlParameter.Add(new SqlParameter("@OverHeadCostR1", OverHeadCostR1));
            arlSqlParameter.Add(new SqlParameter("@MaterialCostK2", MaterialCostK2));
            arlSqlParameter.Add(new SqlParameter("@OverHeadCostK2", OverHeadCostK2));
            arlSqlParameter.Add(new SqlParameter("@PlanCpm", PlanCpm));
            dt = this.ExecuteQuery("[Reports].[USP_SampleCostBreakeDownSummeryReport]", arlSqlParameter);
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            CloseConnection();
        }
    }

    public DataTable GetMailSummeryReport(string FromDate, string ToDate)
    {
        DataTable dt = null;
        try
        {
            OpenConnection();
            ArrayList arlSqlParameter = new ArrayList();
            arlSqlParameter.Add(new SqlParameter("@FromDate", FromDate));
            arlSqlParameter.Add(new SqlParameter("@ToDate", ToDate));
            dt = this.ExecuteQuery("[Reports].[USP_GetMailReports]", arlSqlParameter);
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            CloseConnection();
        }
    }

    public DataTable SampleCostBrakeDownReportForMail(string FromDate, string ToDate, double MaterialCostR1, double OverHeadCostR1, double MaterialCostK2, double OverHeadCostK2)
    {
        DataTable dt = null;
        try
        {
            OpenConnection();
            ArrayList arlSqlParameter = new ArrayList();
            arlSqlParameter.Add(new SqlParameter("@FromDate", FromDate));
            arlSqlParameter.Add(new SqlParameter("@ToDate", ToDate));
            arlSqlParameter.Add(new SqlParameter("@MaterialCostR1", MaterialCostR1));
            arlSqlParameter.Add(new SqlParameter("@OverHeadCostR1", OverHeadCostR1));
            arlSqlParameter.Add(new SqlParameter("@MaterialCostK2", MaterialCostK2));
            arlSqlParameter.Add(new SqlParameter("@OverHeadCostK2", OverHeadCostK2));
            
            dt = this.ExecuteQuery("[Reports].[USP_CostingSummaryOfMail]", arlSqlParameter);
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            CloseConnection();
        }
    }
    public DataTable GetBuyerWiseProduction(string FromDate, string ToDate,string Plant)
    {
        DataTable dt = null;
        try
        {
            OpenConnection();
            ArrayList arlSqlParameter = new ArrayList();
            arlSqlParameter.Add(new SqlParameter("@FromDate", FromDate));
            arlSqlParameter.Add(new SqlParameter("@ToDate", ToDate));
            arlSqlParameter.Add(new SqlParameter("@Plant", Plant));
            dt = this.ExecuteQuery("[Reports].[USP_GetBuyerWiseProduction]", arlSqlParameter);
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            CloseConnection();
        }
    }
    public DataTable GetItemCategoryWiseReport(string FromDate, string ToDate, string Plant)
    {
        DataTable dt = null;
        try
        {
            OpenConnection();
            ArrayList arlSqlParameter = new ArrayList();
            arlSqlParameter.Add(new SqlParameter("@FromDate", FromDate));
            arlSqlParameter.Add(new SqlParameter("@ToDate", ToDate));
            arlSqlParameter.Add(new SqlParameter("@Plant", Plant));
            dt = this.ExecuteQuery("[Reports].[USP_GetItemCategoryWiseReport]", arlSqlParameter);
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            CloseConnection();
        }
    }
    public DataTable GetDepartmentWiseReport(string FromDate, string ToDate, string plant)
    {
        DataTable dt = null;
        try
        {
            OpenConnection();
            ArrayList arlSqlParameter = new ArrayList();
            arlSqlParameter.Add(new SqlParameter("@FromDate", FromDate));
            arlSqlParameter.Add(new SqlParameter("@ToDate", ToDate));
            arlSqlParameter.Add(new SqlParameter("@Plant", plant));
            dt = this.ExecuteQuery("[Reports].[USP_GetDepartmentWiseReport]", arlSqlParameter);
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            CloseConnection();
        }
    }

    public DataTable GetSupervisorSummeryReport(string FromDate, string ToDate,string Plant)
    {
        DataTable dt = null;
        try
        {
            OpenConnection();
            ArrayList arlSqlParameter = new ArrayList();
            arlSqlParameter.Add(new SqlParameter("@FromDate", FromDate));
            arlSqlParameter.Add(new SqlParameter("@ToDate", ToDate));
            arlSqlParameter.Add(new SqlParameter("@Plant", Plant));
            dt = this.ExecuteQuery("[Reports].[USP_GetSupervisorSummeryReport]", arlSqlParameter);
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            CloseConnection();
        }
    }

}

