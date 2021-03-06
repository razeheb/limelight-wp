﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeroconf; 

namespace Limelight
{
    /// <summary>
    /// Computer object containing name and IP address
    /// </summary>
    public class Computer
    {
        public string Name { get; set; }
        public string IpAddress { get; set; }
        public int steamID { get; set; }

        // Need to give these to the stream
        public int fps { get; set; }
        public int pixels { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Computer"/> class.
        /// </summary>
        /// <param name="name">Computer display name</param>
        /// <param name="ipAddress">Computer IP address</param>
        public Computer(string name, string ipAddress)
        {
            this.IpAddress = ipAddress;
            this.Name = name;
            this.steamID = 0;
            this.fps = 0;
            this.pixels = 0; 
        }
        /// <summary>
        /// Computer information as a string
        /// </summary>
        /// <returns>String containing name and IP</returns>
        public override string ToString()
        {
            return this.Name + " " + this.IpAddress;
        }
    }
}
