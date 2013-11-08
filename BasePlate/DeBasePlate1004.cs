using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Globalization;

using Tekla.Structures.Plugins;
using TSG = Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;
using Tekla.Structures;
using Tekla.Structures.Datatype;
using Distance = Tekla.Structures.Datatype.Distance;

namespace BasePlate
{
    class DeBasePlate1004
    {
        // Baseplate

        

        private double _tpl1;
        public double Tpl1
        {
            get { return _tpl1; }
            set { _tpl1 = value; }
        }

        private double _hpl1;
        public double Hpl1
        {
            get { return _hpl1; }
            set { _hpl1 = value; }
        }

        private double _bpl1;
        public double Bpl1
        {
            get { return _bpl1; }
            set { _bpl1 = value; }
        }

        private string _mat;
        public string Mat
        {
            get { return _mat; }
            set { _mat = value; }
        }

        private double _pos1;
        public double Pos1
        {
            get { return _pos1; }
            set { _pos1 = value; }
        }

        private string _partname;
        public string Partname
        {
            get { return _partname; }
            set { _partname = value; }
        }

        private int _epClass;
        public int EpClass
        {
            get { return _epClass; }
            set { _epClass = value; }
        }

        // Bolts 
        private double _rb1;
        public double Rb1
        {
            get { return _rb1; }
            set { _rb1 = value; }
        }

        private double _rb2;
        public double Rb2
        {
            get { return _rb2; }
            set { _rb2 = value; }
        }

        private string _lbd;
        public string Lbd
        {
            get { return _lbd; }
            set { _lbd = value; }
        }

        private double _rw1;
        public double Rw1
        {
            get { return _rw1; }
            set { _rw1 = value; }
        }

        private double _rw2;
        public double Rw2
        {
            get { return _rw2; }
            set { _rw2 = value; }
        }

        private string _lwd;
        public string Lwd
        {
            get { return _lwd; }
            set { _lwd = value; }
        }

        private int _lwtyp;
        public int Lwtyp
        {
            get { return _lwtyp; }
            set { _lwtyp = value; }
        }

        private int _lbtyp;
        public int Lbtyp
        {
            get { return _lbtyp; }
            set { _lbtyp = value; }
        }

        private double _lwa;
        public double Lwa
        {
            get { return _lwa; }
            set { _lwa = value; }
        }

        private double _lba;
        public double Lba
        {
            get { return _lba; }
            set { _lba = value; }
        }

        private double _diameter;
        public double Diameter
        {
            get { return _diameter; }
            set { _diameter = value; }
        }

        private string _screwdin;
        public string Screwdin
        {
            get { return _screwdin; }
            set { _screwdin = value; }
        }

        private double _tolerance;
        public double Tolerance
        {
            get { return _tolerance; }
            set { _tolerance = value; }
        }

        private int _threadIn;
        public int ThreadIn
        {
            get { return _threadIn; }
            set { _threadIn = value; }
        }

        private int _assemblyType;
        public int AssemblyType
        {
            get { return _assemblyType; }
            set { _assemblyType = value; }
        }

        private double _longHoleX;
        public double LongHoleX
        {
            get { return _longHoleX; }
            set { _longHoleX = value; }
        }

        private double _longHoleY;
        public double LongHoleY
        {
            get { return _longHoleY; }
            set { _longHoleY = value; }
        }

        private int _holeType;
        public int HoleType
        {
            get { return _holeType; }
            set { _holeType = value; }
        }

        private int _holeDirection;
        public int HoleDirection
        {
            get { return _holeDirection; }
            set { _holeDirection = value; }
        }

        private int _nw;
        public int Nw
        {
            get { return _nw; }
            set { _nw = value; }
        }

        private int _nb;
        public int Nb
        {
            get { return _nb; }
            set { _nb = value; }
        }

        private string _estring;
        public string Estring
        {
            get { return _estring; }
            set { _estring = value; }
        }

        // Additional Beam
        private double _adist1;
        public double Adist1
        {
            get { return _adist1; }
            set { _adist1 = value; }
        }

        private string _prof;
        public string Prof
        {
            get { return _prof; }
            set { _prof = value; }
        }

        private double _pos2;
        public double Pos2
        {
            get { return _pos2; }
            set { _pos2 = value; }
        }

        private string _mat2;
        public string Mat2
        {
            get { return _mat2; }
            set { _mat2 = value; }
        }

        private string _partname2;
        public string Partname2
        {
            get { return _partname2; }
            set { _partname2 = value; }
        }

        private int _beampos;
        public int Beampos
        {
            get { return _beampos; }
            set { _beampos = value; }
        }

        //Weldings
        private double _w1Size;
        public double W1Size
        {
            get { return _w1Size; }
            set { _w1Size = value; }
        }

        private int _w1Type;
        public int W1Type
        {
            get { return _w1Type; }
            set { _w1Type = value; }
        }

        private int _w1Around;
        public int W1Around
        {
            get { return _w1Around; }
            set { _w1Around = value; }
        }

        private int _w1WType;
        public int W1WType
        {
            get { return _w1WType; }
            set { _w1WType = value; }
        }

        private double _w2Size;
        public double W2Size
        {
            get { return _w2Size; }
            set { _w2Size = value; }
        }

        private int _w2Type;
        public int W2Type
        {
            get { return _w2Type; }
            set { _w2Type = value; }
        }

        private int _w2Around;
        public int W2Around
        {
            get { return _w2Around; }
            set { _w2Around = value; }
        }

        private int _w2WType;
        public int W2WType
        {
            get { return _w2WType; }
            set { _w2WType = value; }
        }

        private double _w3Size;
        public double W3Size
        {
            get { return _w3Size; }
            set { _w3Size = value; }
        }

        private int _w3Type;
        public int W3Type
        {
            get { return _w3Type; }
            set { _w3Type = value; }
        }

        private int _w3Around;
        public int W3Around
        {
            get { return _w3Around; }
            set { _w3Around = value; }
        }

        private int _w3WType;
        public int W3WType
        {
            get { return _w3WType; }
            set { _w3WType = value; }
        }
        
        private double _w4Size;
        public double W4Size
        {
            get { return _w4Size; }
            set { _w4Size = value; }
        }

        private int _w4Type;
        public int W4Type
        {
            get { return _w4Type; }
            set { _w4Type = value; }
        }

        private int _w4Around;
        public int W4Around
        {
            get { return _w4Around; }
            set { _w4Around = value; }
        }

        private int _w4WType;
        public int W4WType
        {
            get { return _w4WType; }
            set { _w4WType = value; }
        }


        public DeBasePlate1004(StructuresData data)
        {
            try
            {
                if (data != null)
                {
                    WeldCatalog welds = new WeldCatalog();

                    //Weldings paramaters
                    if (data.w1_size != Convert.ToDouble(Int32.MinValue)) this.W1Size = data.w1_size;
                    else this.W1Size = 6.0;
                    this.W1Type = welds.GetWeld(data.w1_type);
                    this.W1Around = data.w1_around;
                    this.W1WType = data.w1_wtype;

                    if (data.w2_size != Convert.ToDouble(Int32.MinValue)) this.W2Size = data.w2_size;
                    else this.W2Size = 6.0;
                    this.W2Type = welds.GetWeld(data.w2_type);
                    this.W2Around = data.w2_around;
                    this.W2WType = data.w2_wtype;
                    
                    /*
                    if (data.w3_size != Convert.ToDouble(Int32.MinValue)) this.W3Size = data.w3_size;
                    else this.W3Size = 6.0;
                    this.W3Type = 4;
                    this.W3Around = data.w3_around;
                    this.W3WType = data.w3_wtype;
                     
                    if (data.w4_size != Convert.ToDouble(Int32.MinValue)) this.W4Size = data.w4_size;
                    else this.W4Size = 6.0;
                    this.W4Type = welds.GetWeld(data.w4_type);
                    this.W4Around = data.w4_around;
                    this.W4WType = data.w4_wtype;
                    */


                    this.Adist1 = data.adist1;
                    this.Prof = data.prof;
                    this.Pos2 = data.pos2;
                    this.Mat2 = data.mat2;
                    this.Partname2 = data.partname2;
                    this.Estring = data.estring;

                    this.Tpl1 = data.tpl1;
                    this.Hpl1 = data.hpl1;
                    this.Bpl1 = data.bpl1;

                    if (data.mat != System.String.Empty) this.Mat = data.mat;
                    else this.Mat = "S355J2H";

                    this.Partname = data.partname;
                    this.EpClass = data.epClass;
                    this.Beampos = data.beampos;

                    this.Estring = data.estring;
                    this.Rb1 = data.rb1;
                    this.Rb2 = data.rb2;
                    this.Rw1 = data.rw1;
                    this.Rw2 = data.rw2;

                    if (data.lbd != System.String.Empty) this.Lbd = data.lbd;
                    else this.Lbd = "500";

                    if (data.lwd != System.String.Empty) this.Lwd = data.lwd;
                    else this.Lwd = "550";

                    this.Nb = data.nb;
                    this.Nw = data.nw;
                    this.Diameter = data.diameter;
                    this.Screwdin = data.screwdin;
                    this.Tolerance = data.tolerance;
                    this.ThreadIn = data.thread_in;
                    this.AssemblyType = data.assembly_type;
                    this.Lwtyp = data.lwtyp;
                    this.Lwa = data.lwa;
                    this.Lbtyp = data.lbtyp;
                    this.Lba = data.lba;
                    this.LongHoleX = data.longholex;
                    this.LongHoleY = data.longholey;
                    this.HoleType = data.holetype;
                    this.HoleDirection = data.holedirection;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private ArrayList ReturnDistances(string lwd)
        {
            CultureInfo invC = CultureInfo.InvariantCulture;

            ArrayList FinalSpacesCollection = new ArrayList();
            string[] Lwd_Values = lwd.Split(' ');

            for (int splitnum = 0; splitnum < Lwd_Values.Length; splitnum++)
            {
                string NewValue = Lwd_Values.GetValue(splitnum).ToString();

                if (NewValue.Contains("*"))
                {
                    int NumberItems = int.Parse(NewValue.Split('*').GetValue(0).ToString());
                    double SpaceValue = double.Parse(NewValue.Split('*').GetValue(1).ToString());
                    for (int counter1 = 0; counter1 < NumberItems; counter1++)
                    {
                        if (SpaceValue != 0)
                        {
                            FinalSpacesCollection.Add(SpaceValue);
                        }
                    }
                }
                else
                {
                    if (double.Parse(NewValue) != 0)
                    {
                        FinalSpacesCollection.Add(double.Parse(NewValue));
                    }
                }
            }
            return FinalSpacesCollection;
        }

 
        private Tekla.Structures.Datatype.DistanceList GetDistanceList(string DistList)
        {
            return Tekla.Structures.Datatype.DistanceList.Parse(DistList,
                                                        System.Globalization.CultureInfo.InvariantCulture,
                                                        Tekla.Structures.Datatype.Distance.UnitType.Millimeter);


        }

        public bool Insert(Beam pickedBeam, Point pickedPoint)
        {
            bool result = false;

            try
            {
                Detail currentDetail = new Detail();

                currentDetail.Name = "BasePlate (1004)";
                currentDetail.Number = 1004;
                currentDetail.DetailType = DetailTypeEnum.END;

                //Baseplate arvot dialogista
                
                currentDetail.SetAttribute("tpl1", this.Tpl1);
                currentDetail.SetAttribute("hpl1", this.Hpl1);
                currentDetail.SetAttribute("bpl1", this.Bpl1);
                currentDetail.SetAttribute("pos1", this.Pos1);
                currentDetail.SetAttribute("mat", this.Mat);
                currentDetail.SetAttribute("partname", this.Partname);
                currentDetail.Class = this.EpClass;

                // Bolts arvot dialogista
                currentDetail.SetAttribute("rb1", this.Rb1); 
                currentDetail.SetAttribute("rb2", this.Rb2);
                currentDetail.SetAttribute("lbd", this.Lbd);
                currentDetail.SetAttribute("rw1", this.Rw1);
                currentDetail.SetAttribute("rw2", this.Rw2);
                currentDetail.SetAttribute("lwd", this.Lwd);
                currentDetail.SetAttribute("lwtyp", this.Lwtyp);
                currentDetail.SetAttribute("lbtyp", this.Lbtyp);
                currentDetail.SetAttribute("lba", this.Lba);
                currentDetail.SetAttribute("lwa", this.Lwa);
                currentDetail.SetAttribute("estring", this.Estring);

                currentDetail.SetAttribute("diameter", this.Diameter);
                currentDetail.SetAttribute("screwdin", this.Screwdin);
                currentDetail.SetAttribute("tolerance", this.Tolerance);
                currentDetail.SetAttribute("thread_in", this.ThreadIn);
                currentDetail.SetAttribute("assembly_type", this.AssemblyType);

                currentDetail.SetAttribute("nb", this.Nb);
                currentDetail.SetAttribute("nw", this.Nw);
                currentDetail.SetAttribute("longholex", this.LongHoleX);
                currentDetail.SetAttribute("longholey", this.LongHoleY);
                currentDetail.SetAttribute("holetype", this.HoleType);
                currentDetail.SetAttribute("holedirection", this.HoleDirection);

                //Additional beam arvot dialogista
                currentDetail.SetAttribute("adist1", this.Adist1);
                currentDetail.SetAttribute("prof", this.Prof);
                currentDetail.SetAttribute("mat2", this.Mat2);
                currentDetail.SetAttribute("partname2", this.Partname2);
                currentDetail.SetAttribute("pos2", this.Pos2);

                // Set weld details
                currentDetail.SetAttribute("w1_size", this.W1Size);
                currentDetail.SetAttribute("w1_type", this.W1Type);
                currentDetail.SetAttribute("w1_around", this.W1Around);
                currentDetail.SetAttribute("w1_wtype", this.W1WType);

                currentDetail.SetAttribute("w1_type2", 0);
                currentDetail.SetAttribute("w2_type", 0);
                currentDetail.SetAttribute("w2_type2", 0);
                currentDetail.SetAttribute("w3_type", 0);
                currentDetail.SetAttribute("w3_type2", 0);
                currentDetail.SetAttribute("w4_type", 0);
                currentDetail.SetAttribute("w4_type2", 0);

                double h = 0.0;
                double w = 0.0;
                pickedBeam.GetReportProperty("PROFILE.WIDTH", ref w);
                pickedBeam.GetReportProperty("PROFILE.HEIGHT", ref h);

                ArrayList aDistances = new ArrayList();
                DistanceList distanceList = new DistanceList();

		        if (Distance.CurrentUnitType == Distance.UnitType.Millimeter)
		        {
			        distanceList = DistanceList.Parse(this.Lwd,CultureInfo.InvariantCulture, Distance.UnitType.Millimeter);
			        foreach (Distance distance in distanceList)
				        aDistances.Add(distance.ConvertTo(Distance.UnitType.Millimeter));
		        }
		        else if (Distance.CurrentUnitType == Distance.UnitType.Inch)
		        {
			        distanceList = DistanceList.Parse(this.Lwd, CultureInfo.InvariantCulture, Distance.UnitType.Inch);
			        foreach (Distance distance in distanceList)
				        aDistances.Add(distance.ConvertTo(Distance.UnitType.Inch));
		        }
                             
                double DistSum = 0.0;
                for (int ii = 0; ii < aDistances.Count; ii++)
                {
                    double currentDist = (double)aDistances[ii];
                    DistSum += currentDist;
                }

                ArrayList aDistances1 = new ArrayList();
                DistanceList distanceList1 = new DistanceList();

                if (Distance.CurrentUnitType == Distance.UnitType.Millimeter)
                {
                    distanceList1 = DistanceList.Parse(this.Lbd, CultureInfo.InvariantCulture, Distance.UnitType.Millimeter);
                    foreach (Distance distance in distanceList1)
                        aDistances1.Add(distance.ConvertTo(Distance.UnitType.Millimeter));
                }
                else if (Distance.CurrentUnitType == Distance.UnitType.Inch)
                {
                    distanceList1 = DistanceList.Parse(this.Lbd, CultureInfo.InvariantCulture, Distance.UnitType.Inch);
                    foreach (Distance distance in distanceList1)
                        aDistances1.Add(distance.ConvertTo(Distance.UnitType.Inch));
                }

                double DistSum1 = 0.0;
                for (int ii = 0; ii < aDistances1.Count; ii++)
                {
                    double currentDist1 = (double)aDistances1[ii];
                    DistSum1 += currentDist1;
                }


                //MessageBox.Show("Lwd sum = " + DistSum);
                //MessageBox.Show("Lbd sum = " + DistSum1);

                currentDetail.SetAttribute("lwtyp", -2147483648);
                currentDetail.SetAttribute("lbtyp", -2147483648);

                //Nurkka
                if (this.Beampos.Equals(1))
                {
                    double lwa_value = Rw1 + DistSum + Rw2 - w;
                    double lba_value = Rb1 + DistSum1 + Rb2 - h;

                    currentDetail.SetAttribute("lwa", lwa_value / 2);
                    currentDetail.SetAttribute("lba", lba_value / 2);
                    currentDetail.SetAttribute("estring", "1");

                    currentDetail.SetAttribute("w1_size", this.W1Size);
                    currentDetail.SetAttribute("w1_type", this.W1Type);
                    currentDetail.SetAttribute("w1_around", this.W1Around);
                    currentDetail.SetAttribute("w1_wtype", this.W1WType);

                    currentDetail.SetAttribute("w2_size", this.W2Size);
                    currentDetail.SetAttribute("w2_around", this.W2Around);
                    currentDetail.SetAttribute("w2_wtype", this.W2WType);
                    currentDetail.SetAttribute("w2_type", this.W2Type);

                }

                //Reuna
                if (this.Beampos.Equals(0))
                {
                    double lwa_value = Rw1 + DistSum1 + Rw2 - w;
                    currentDetail.SetAttribute("lwa", lwa_value / 2);

                    currentDetail.SetAttribute("w1_size", this.W1Size);
                    currentDetail.SetAttribute("w1_type", this.W1Type);
                    currentDetail.SetAttribute("w1_around", this.W1Around);
                    currentDetail.SetAttribute("w1_wtype", this.W1WType);

                    currentDetail.SetAttribute("w3_size", this.W2Size);
                    currentDetail.SetAttribute("w3_around", this.W2Around);
                    currentDetail.SetAttribute("w3_wtype", this.W2WType);
                    currentDetail.SetAttribute("w3_type", this.W2Type);
                }


                currentDetail.SetPrimaryObject(pickedBeam);

                currentDetail.SetReferencePoint(pickedPoint);

                result = currentDetail.Insert();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result;
        }

    }
}
