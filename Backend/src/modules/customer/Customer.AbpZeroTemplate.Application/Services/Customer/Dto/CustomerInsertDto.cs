using System;
using System.ComponentModel.DataAnnotations;

namespace Customer.AbpZeroTemplate.Application.Share.Customer.Dto
{
    public class CustomerInsertDto
    {
        public int Id { get; set; }
        public string Customer_Id { get; set; }
        public string Customer_Name { get; set; }
        public DateTime? Customer_Birth { get; set; }
        public string Customer_Gender { get; set; }
        public string Customer_Phone { get; set; }
        public string Customer_Email { get; set; }
        public int? Customer_Point { get; set; }
        public string Customer_Creator { get; set; }
        public DateTime? Customer_Creation_Date { get; set; }
        public int? Customer_IsDeleted { get; set; }
    }
}
