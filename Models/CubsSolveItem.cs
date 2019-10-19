using System;

namespace CubsSolve.Models
{
    public class CubsSolveItem
    {
        public long Id { get; set; }
        public Double X1 { get; set; }
        public Double Y1 { get; set; }
        public Double Z1 { get; set; }
        public Double X2 { get; set; }
        public Double Y2 { get; set; }
        public Double Z2 { get; set; }
        public Double X_ax_origin { get; set; }
        public Double Y_ax_origin { get; set; }
        public Double Z_ax_origin { get; set; }
        public Double X_ax_1 { get; set; }
        public Double Y_ax_1 { get; set; }
        public Double Z_ax_1 { get; set; }
        public Double X_ax_2 { get; set; }
        public Double Y_ax_2 { get; set; }
        public Double Z_ax_2 { get; set; }
        public Double X_ax_3 { get; set; }
        public Double Y_ax_3 { get; set; }
        public Double Z_ax_3 { get; set; }
        public Double SuperimposedDeadLoad { get; set; }
        public Double LiveLoad { get; set; }
        public Double SectionB { get; set; }
        public Double SectionH { get; set; }
        public Double ElemLength { get; set; }
        public Double ElemVolume { get; set; }
        public String MaterialGrade { get; set; }
        public Double SelfWeight { get; set; }
        public String DesignCode { get; set; }
        public Int32 ServiceClass { get; set; }
        public Decimal Cost { get; set; }
        public Int32 SolutionState { get; set; }
    }
}

