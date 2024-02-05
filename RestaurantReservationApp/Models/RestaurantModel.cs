using System;
namespace RestaurantReservationApp.Models
{
	public class RestaurantModel
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
        public string Type { get; set; }
        public string Score { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
    }
}

