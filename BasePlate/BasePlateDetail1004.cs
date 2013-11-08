using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tekla.Structures.Plugins;
using TSG = Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;
using System.Windows.Forms;
using Tekla.Structures.Geometry3d;
using Tekla.Structures;

namespace BasePlate
{
    class BasePlateDetail1004
    {
        //Base Plate properties
        private double _tpl2;      
        public double Tpl2
        {
            get { return _tpl2; }
            set {_tpl2 = value; }
        }

        private double _bpl2;      
        public double Bpl2
        {
            get { return _bpl2; }
            set {_bpl2 = value; }
        }

        private double _hpl2;      
        public double Hpl2
        {
            get { return _hpl2; }
            set {_hpl2 = value; }
        }

        private string _mat2;
        public string Mat2
        {
            get { return _mat2; }
            set {_mat2 = value; }
        }

        private string _pre2;
        public string Pre2
        {
            get { return _pre2; }
            set { _pre2 = value; }
        }

        private int _sno2;
        public int Sno2
        {
            get { return _sno2; }
            set { _sno2 = value; }
        }
        
        private string _partName2;
        public string PartName2
        {
            get { return _partName2; }
            set { _partName2 = value; }

        }

        private int _epClass;
        public int EpClass
        {
            get { return _epClass; }
            set { _epClass = value; }
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

        public BasePlateDetail1004(StructuresData data)
        {
            try
            {
                if( data != null)
                {
                    WeldCatalog welds = new WeldCatalog();
                    this.Tpl2 = data.tpl2;
                    this.Bpl2 = data.bpl2;
                    this.Hpl2 = data.hpl2;

                    this.Pre2 = data.GussetPrefixPos;
                    this.Sno2 = data.GussetStartNoPos;

                    if (data.mat2 != String.Empty) this.Mat2 = data.mat2;
                    else this.Mat2 = "S355J2H";                   
                    this.PartName2 = data.partName2;
                    this.EpClass = data.epClass;

                    // Weld dialog parameters
                    if (data.w1_size != Convert.ToDouble(Int32.MinValue)) this.W1Size = data.w1_size;
                    else this.W1Size = 6.0;
                    this.W1Type = welds.GetWeld(data.w1_type);
                    this.W1Around = data.w1_around;
                    this.W1WType = data.w1_wtype;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool Insert(Beam primary)
        {
            bool result = false;
            try
            {
                Detail currentDetail = new Detail();

                currentDetail.Name = "Base plate (1004)";
                currentDetail.Number = 1004;

                currentDetail.UpVector = new Vector(0, 0, 0);
                currentDetail.PositionType = PositionTypeEnum.MIDDLE_PLANE;
                currentDetail.AutoDirectionType = AutoDirectionTypeEnum.AUTODIR_GLOBAL_Z;
                currentDetail.DetailType = DetailTypeEnum.END;

                // Values from dialog

                currentDetail.SetAttribute("tpl1", this.Tpl2);
                currentDetail.SetAttribute("bpl1", this.Bpl2);
                currentDetail.SetAttribute("hpl1", this.Hpl2);

                currentDetail.SetAttribute("prefix_pos1", this.Pre2);
                currentDetail.SetAttribute("startno_pos1", this.Sno2);

                currentDetail.SetAttribute("mat", this.Mat2);
                currentDetail.SetAttribute("partname", this.PartName2);

                currentDetail.Class = this.EpClass;

                // Set weld details
                currentDetail.SetAttribute("w1_size", this.W1Size);
                currentDetail.SetAttribute("w1_type", this.W1Type);
                currentDetail.SetAttribute("w1_around", this.W1Around);
                currentDetail.SetAttribute("w1_wtype", this.W1WType);

                // We don't want to show other welds for detail so set them 0
                currentDetail.SetAttribute("w1_type2", 0);
                currentDetail.SetAttribute("w2_type", 0);
                currentDetail.SetAttribute("w2_type2", 0);

                currentDetail.SetPrimaryObject(primary);
                double refPointX = 0.0;
                //secondary.GetReportProperty("PROFILE.HEIGHT", ref refPointX);
                currentDetail.SetReferencePoint(new TSG.Point(-refPointX / 2, 0, 0));

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
