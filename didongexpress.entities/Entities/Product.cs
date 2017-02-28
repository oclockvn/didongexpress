using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace didongexpress.entities
{
    /// <summary>
    /// ok, so this is product data model
    /// </summary>
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double MarketPrice { get; set; }

        public bool IncludeVat { get; set; }
        public bool OriginalProduct { get; set; }
        public string Extras { get; set; }
        public bool WarrantyPolicy { get; set; }

        public string Thickness { get; set; }
        public string OS { get; set; }
        public string InternalMemory { get; set; }
        public string RAM { get; set; } // or: double RAM + string RAMUnit, whatever

        /// <summary>
        /// what is slug?
        /// you will know soon
        /// </summary>
        public string Slug { get; set; }

        /* Note:
         * 
         * some device has 512 (MB) of RAM
         * some has 1, 2, 3..  (Gb) of RAM
         * 
         * we can ...bla bla
         * 
         * if we use 
         * public int RAM { get; set; } + public int RAMUnit { get; set; } // or enum unit of ram
         * we must use select list to select unit...in admin...
         * 
         * and I dont want to waste time
         * 
         * ah ah, but i guest (and pretty sure) in real world, they use public int RAM { get; set; } + public int RAMUnit { get; set; }
         * 
         * finally, save as string is simplest
         * 
         * */
        public string Screen { get; set; }
        public string BackCamera { get; set; }
        public double Pin { get; set; }
        public int PinUnit { get; set; }

        //
        // screen
        public string ScreenTech { get; set; }

        /// <summary>
        /// pixel
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// pixel
        /// </summary>
        public double Height{ get; set; }

        /// <summary>
        /// in Inch
        /// </summary>
        public double ScreenSize { get; set; }
        public string Sensor { get; set; }
        public string SensorGlass { get; set; }

        // 
        // back camera
        public int BackCameraResolution { get; set; }
        public string BackCameraNote { get; set; }
        public string BackCemeraVideo { get; set; }
        public string BackCameraFlash { get; set; }
        public string BackCameraCapture { get; set; }

        // 
        // front camera
        public int FrontCameraResolution { get; set; }
        public bool? FrontCameraSupport { get; set; }
        public string FrontCameraVideocall { get; set; }
        public string FrontCameraNote { get; set; }

        //
        // os
        public string Chipset { get; set; }
        public double CPUSpeed { get; set; }
        public string GPU { get; set; }

        //
        // memory
        public string RemainMemory { get; set; }
        public string ExternalMemory { get; set; }
        public string SupportMemory { get; set; }

        //
        // connect
        public string Connect2G { get; set; }
        public string Connect3G { get; set; }
        public string Connect4G { get; set; }
        public int SimSlot { get; set; }
        public int SimType { get; set; } // nano/micro/normal -> need enum
        public string Wifi { get; set; }
        public string GPS { get; set; }
        public string Bluetooth { get; set; }
        public bool NFC { get; set; }
        public string ConnectGateway { get; set; }
        public string HeadsetJack { get; set; }
        public string OtherConnect { get; set; }

        //
        // design
        public string Design { get; set; }
        public string material { get; set; }
        public double DesignHeight { get; set; }
        public double DesignWidth { get; set; }
        public double DesignThick { get; set; }

        //
        // pin
        public string PinType { get; set; }

        // 
        // extra
        public string Movie { get; set; }
        public string Music { get; set; }
        public string AudioRecord { get; set; }
        public string Radio { get; set; }
        public string OtherFeatures { get; set; }

        //
        // warranty
        public string Warranty { get; set; }

        //
        // gift
        public string Gift1 { get; set; }
        public string Gift2 { get; set; }
        public string Gift3 { get; set; }
        
        [ForeignKey("SubCategory")]
        public int? SubCategoryId { get; set; }
        public Category SubCategory { get; set; }
    }
}
