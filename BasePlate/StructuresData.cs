using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tekla.Structures.Plugins;

namespace BasePlate
{
    public class StructuresData
    {
        //Base Plate Detail 1004

        //Plate
        [StructuresField("tpl1")]
        public double tpl1;

        [StructuresField("bpl1")]
        public double bpl1;

        [StructuresField("hpl1")]
        public double hpl1;

        [StructuresField("pos1")]
        public double pos1;

        [StructuresField("mat")]
        public string mat;

        [StructuresField("partname")]
        public string partname;

        [StructuresField("beampos")]
        public int beampos;



        //Additional beam
        [StructuresField("adist1")]
        public double adist1;

        [StructuresField("prof")]
        public string prof;

        [StructuresField("pos2")]
        public double pos2;

        [StructuresField("mat2")]
        public string mat2;

        [StructuresField("partname2")]
        public string partname2;

        [StructuresField("startno_pos1")]
        public int GussetStartNoPos;

        [StructuresField("prefix_pos1")]
        public string GussetPrefixPos;

        [StructuresField("epClass")]
        public int epClass;

        
        //Weldings
        [StructuresField("w1_size")]
        public double w1_size;

        [StructuresField("w1_type")]
        public int w1_type;

        [StructuresField("w1_around")]
        public int w1_around;

        [StructuresField("w1_wtype")]
        public int w1_wtype;

        [StructuresField("w2_size")]
        public double w2_size;

        [StructuresField("w2_type")]
        public int w2_type;

        [StructuresField("w2_around")]
        public int w2_around;

        [StructuresField("w2_wtype")]
        public int w2_wtype;

        [StructuresField("w3_size")]
        public double w3_size;

        [StructuresField("w3_type")]
        public int w3_type;

        [StructuresField("w3_around")]
        public int w3_around;

        [StructuresField("w3_wtype")]
        public int w3_wtype;

        [StructuresField("w4_size")]
        public double w4_size;

        [StructuresField("w4_type")]
        public int w4_type;

        [StructuresField("w4_around")]
        public int w4_around;

        [StructuresField("w4_wtype")]
        public int w4_wtype;

        //Bolts tab_page atribuutit

        [StructuresField("diameter")]
        public double diameter;

        [StructuresField("screwdin")]
        public string screwdin;

        [StructuresField("tolerance")]
        public double tolerance;

        [StructuresField("thread_in")]
        public int thread_in;

        [StructuresField("assembly_type")]
        public int assembly_type;

        [StructuresField("longholex")]
        public double longholex;

        [StructuresField("longholey")]
        public double longholey;

        [StructuresField("holetype")]
        public int holetype;

        [StructuresField("holedirection")]
        public int holedirection;

        [StructuresField("nb")]
        public int nb;

        [StructuresField("nw")]
        public int nw;

        [StructuresField("lwtyp")]
        public int lwtyp;

        [StructuresField("lwa")]
        public double lwa;

        [StructuresField("lbtyp")]
        public int lbtyp;

        [StructuresField("lba")]
        public double lba;

        [StructuresField("rb1")]
        public double rb1;

        [StructuresField("rb2")]
        public double rb2;

        [StructuresField("rw1")]
        public double rw1;

        [StructuresField("rw2")]
        public double rw2;

        [StructuresField("lbd")]
        public string lbd;

        [StructuresField("lwd")]
        public string lwd;

        [StructuresField("estring")]
        public string estring;

    }
}
