﻿using System.ComponentModel.DataAnnotations;
using static TransactionsAPI.Consts.Enums.Enums;

namespace TransactionsAPI.Models.DTOs.Order
{
    public class OrderCreateDto
    {
        [Required]
        public string? CustomerIdNumber { get; set; }
        [RegularExpression(@"^[a-zA-Z\s' \-]*$", ErrorMessage = "Only English letters, apostrophes, dashes and spaces are allowed.")]
        [MaxLength(15)]
        public string? CustomerFullName { get; set; }
        [RegularExpression(@"^['א-ת\s' \-]*$", ErrorMessage = "Only Hebrew letters, apostrophes, dashes and spaces are allowed.")]
        [MaxLength(20)]
        public string? CustomerFullNameHebrew { get; set; }
        public DateTime? CustomerDateOfBirth { get; set; }
        public OrderType OrderType { get; set; }
        public Decimal Amount { get; set; }
        public string? AccountNumber { get; set; }
    }
}
