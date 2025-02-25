﻿namespace CarCareTracker.Models
{
    public class GasRecordViewModel
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public string Date { get; set; }
        /// <summary>
        /// American moment
        /// </summary>
        public int Mileage { get; set; }
        /// <summary>
        /// Wtf is a kilometer?
        /// </summary>
        public decimal Gallons { get; set; }
        public decimal Cost { get; set; }
        public int DeltaMileage { get; set; }
        public decimal MilesPerGallon { get; set; }
        public decimal CostPerGallon { get; set; }
    }
}
