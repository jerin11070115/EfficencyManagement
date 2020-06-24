using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.AppCode.Model
{
	public class EfficencyInput
	{
        public int EfficencyId { get; set; }
		public string Plant { get; set;}
		public string SewingTeam { get; set; }
		public string Supervisor { get; set; }
		public decimal Attendance { get; set; }
		public string BuyerName { get; set; }
		public string SerialNumber { get; set; }
		public string StyleNumber { get; set; }
		public string SampleType { get; set; }
		public string ItemCategory { get; set; }
		public string SmvFactor { get; set; }
        public int SmvFactorValue { get; set; }
        public int SampleMaker { get; set; }
        public int SampleMakingTime { get; set; }
		public int ProductQuentity { get; set; }
		public decimal SmvValue { get; set; }

		public int MachineLostTime { get; set; }
		public int MerchantLostTime { get; set; }
		public int PatternLostTime { get; set; }
		public int EmbiLostTime { get; set;}
		public int OtherLostTime { get; set; }
		public int TotalLostTime { get; set;}

		public int OverTime90 { get; set; }
		public int OverTime105 { get; set; }
		public int OverTime120 { get; set; }
		public int TotalOverTime { get; set; }


        public int OverTime90Person { get; set; }
        public int OverTime105Person { get; set; }
        public int OverTime120Person { get; set; }



        public decimal TotalOfficialTime { get; set; }
		public decimal TotalTime { get; set; }


		public decimal Rating { get; set; }
		public decimal EstimatedTime { get; set; }
		public decimal TotalProduceMinute { get; set; }
		public decimal Fact1Below21 { get; set; }
		public decimal Fact2Above20 { get; set; }
        public decimal TotalFact { get; set; }
		public decimal ActualTakenTime { get; set; }

		public decimal PerformancePercentage { get; set; }
		public decimal MinimumProduceTime { get; set; }
		public decimal NonProductiveTime { get; set; }

        public string Department { get; set; }

        public decimal Wip { get; set; }
        public decimal MaterialCostAvg { get; set; }
        public decimal OverHeadCost { get; set; }
        public string ProductionDate { get; set; }
        public string Comments { get; set; }
	}
}
