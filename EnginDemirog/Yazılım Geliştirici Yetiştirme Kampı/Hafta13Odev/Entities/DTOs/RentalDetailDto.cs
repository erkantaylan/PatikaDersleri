﻿using System;
using Core.DataAccess.Entities;

namespace Entities.DTOs
{
    public class RentalDetailDto : IDto
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public int ColorId { get; set; }
        public string ColorName { get; set; }
        public int RentalId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public decimal Amount { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}