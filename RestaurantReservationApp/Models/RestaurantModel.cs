using System;
namespace RestaurantReservationApp.Models
{
	public class RestaurantModel
	{
		public Guid Id { get; set; }
		public string Nombre { get; set; }
        public string Direccion { get; set; }
		public string ImagePath { get; set; }
    }
}

