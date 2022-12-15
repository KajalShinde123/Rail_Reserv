using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rail_Reserv.Models
{
    public class TrainDetail
    {
        [Key]
        public int Train_id{ get; set; }
        [Required(ErrorMessage ="Train Name is mandatory")]
        public string TrainName { get; set; }
        public string SourceStation{ get; set;}
        public string DestinationStation { get; set; }
        public string Fare { get; set;}
        public string ArrivalTime { get; set;}
        public string DepartureTime { get; set;}
        public int TotalSeats { get; set;}
        }
    }
