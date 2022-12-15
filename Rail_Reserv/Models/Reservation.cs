using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Rail_Reserv.Models
{
    public class Reservation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Res_Id { get; set; }
        public string Res_Name { get; set; }
        public string Res_Gender { get; set; }
        public string Res_Address { get; set; }
        [ForeignKey("Passenger")]
        public int Id { get; set; }
        public Passenger Passenger { get; set; }
        public string QuotaType { get; set; }
        public string Res_Date { get; set; }
        [ForeignKey("TrainDetail")]
        public int Train_id { get; set; }
        public TrainDetail TrainDetail { get; set; }
        public long PRN_NO { get; set; }
        public int Seat_No { get; set; }
        public int Transaction_Id { get; set; }
    }
}