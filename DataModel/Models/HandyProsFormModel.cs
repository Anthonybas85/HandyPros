using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Models
{
    public class HandyProsFormModel
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Reference { get; set; }
        public string SheetNumber { get; set; }
        public string HandyProName { get; set; }
        public DateTime DateofInspection { get; set; }
        public DateTime TimeofInspection { get; set; }

        #region ELECTRICAL INSPECTION DETAILS

        public string ElectricalInspectionDetails { get; set; }
        public bool? IsTrackLightsCheck { get; set; }
        public string TrackLightsStatus { get; set; }
        public bool? IsLedT8T5Check { get; set; }
        public string LedT8T5Status { get; set; }
        public bool? IsDownLightsCheck { get; set; }
        public string DownLightsStatus { get; set; }
        public bool? IsSpotsCheck { get; set; }
        public string SpotsStatus { get; set; }
        public bool? IsDBoardCheck { get; set; }
        public string DBoardStatus { get; set; }
        public bool? IsEmergencyCheck { get; set; }
        public string EmergencyStatus { get; set; }
        public bool? IsPlugsCheck { get; set; }
        public string PlugsStatus { get; set; }
        public bool? IsExitLightsCheck { get; set; }
        public string ExitLightsStatus { get; set; }
        public bool? IsSignageCheck { get; set; }
        public string SignageStatus { get; set; }
        public bool? IsCamerasCheck { get; set; }
        public string CamerasStatus { get; set; }
        public bool? IsUPSCheck { get; set; }
        public string UPSStatus { get; set; }

        #endregion ELECTRICAL INSPECTION DETAILS

        #region MECHANICAL INSPECTION DETAILS

        public string MechanicalInspectionDetails { get; set; }
        public bool? IsVRVVRFCheck { get; set; }
        public string VRVVRFStatus { get; set; }
        public bool? IsAHUCheck { get; set; }
        public string AHUStatus { get; set; }
        public bool? IsDuctSupplyCheck { get; set; }
        public string DuctSupplyStatus { get; set; }
        public bool? IsGrillCheck { get; set; }
        public string GrillStatus { get; set; }
        public bool? IsSplitsCheck { get; set; }
        public string SplitsStatus { get; set; }
        public bool? IsFiltersCheck { get; set; }
        public string FiltersStatus { get; set; }
        public bool? IsDrainCheck { get; set; }
        public string DrainStatus { get; set; }
        public bool? IsFreshAirCheck { get; set; }
        public string FreshAirStatus { get; set; }
        public bool? IsExhaustCheck { get; set; }
        public string ExhaustStatus { get; set; }
        public bool? IsFloorDrainCheck { get; set; }
        public string FloorDrainStatus { get; set; }
        public bool? IsManholeCheck { get; set; }
        public string ManholeStatus { get; set; }

        #endregion MECHANICAL INSPECTION DETAILS

        #region CIVIL INSPECTION DETAILS

        public string CivilInspectionDetails { get; set; }
        public bool? IsFurnitureCheck { get; set; }
        public string FurnitureStatus { get; set; }
        public bool? IsDrawersCheck { get; set; }
        public string DrawersStatus { get; set; }
        public bool? IsDoorknobsCheck { get; set; }
        public string DoorknobsStatus { get; set; }
        public bool? IsHingesCheck { get; set; }
        public string HingesStatus { get; set; }
        public bool? IsMirrorsCheck { get; set; }
        public string MirrorsStatus { get; set; }
        public bool? IsShelvesCheck { get; set; }
        public string ShelvesStatus { get; set; }
        public bool? IsRacksCheck { get; set; }
        public string RacksStatus { get; set; }
        public bool? IsWindowsCheck { get; set; }
        public string WindowsStatus { get; set; }
        public bool? IsCeilingCheck { get; set; }
        public string CeilingStatus { get; set; }
        public bool? IsFloorCheck { get; set; }
        public string FloorStatus { get; set; }
        public bool? IsFridgeCheck { get; set; }
        public string FridgeStatus { get; set; }

        #endregion CIVIL INSPECTION DETAILS


        #region Signature

        public string HandyProsTechnicianSignature { get; set; }
        public string CustomerRepresentativeSignature { get; set; }

        #endregion
    }
}
