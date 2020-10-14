﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimuladorGerenciaMemoria.Models
{
    public class Process
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public long RegB { get; set; }
        public long RegL { get; set; }
        public double TimeToFindIndex { get; set; }
        public DateTime CreateDate { get; set; }
        /*public Process(string n, long rb, long rl, long time = 0)
        {
            Name = n;
            RegB = rb;
            RegL = rl;
            TimeToFindIndex = time;
        }*/
    }
}