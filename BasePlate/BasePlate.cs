using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Tekla.Structures;
using TSG = Tekla.Structures.Geometry3d;
using Tekla.Structures.Plugins;
using Tekla.Structures.Model.UI;
using Tekla.Structures.Catalogs;
using System.Collections;
using System.IO;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Datatype;

namespace BasePlate
{
    [Plugin("BasePlate")]
    [PluginUserInterface(BasePlateUI.BasePlatePlugin)]
    //[AutoDirectionType(AutoDirectionTypeEnum.AUTODIR_GLOBAL_Z)]
    //[PositionType(PositionTypeEnum.COLLISION_PLANE)]


    class BasePlate : PluginBase
    {
        private readonly StructuresData _data;
        private readonly Model _model;

        private DeBasePlate1004 basePlateDetail;

        //Constructor
        public BasePlate(StructuresData data)
        {
            this._data = data;
            _model = new Model();
        }

        public override List<InputDefinition> DefineInput()
        {
            List<InputDefinition> PickerList = new List<InputDefinition>();
            Picker Picker = new Picker();

            int i = 0;
            while (i < 1)
            {
                Beam pickedBeam = Picker.PickObject(Picker.PickObjectEnum.PICK_ONE_OBJECT, "Pick a column") as Beam;

                if (pickedBeam != null)
                {
                    PickerList.Add(new InputDefinition(pickedBeam.Identifier));
                    i++;
                }
            }

            ArrayList PickedPoints = Picker.PickPoints(Picker.PickPointEnum.PICK_ONE_POINT);

            PickerList.Add(new InputDefinition(PickedPoints));

            return PickerList;    
        }

        public override bool Run(List<InputDefinition> Input)
        {
            bool result = false;
            
            try
            {
                Identifier ID1 = (Identifier)((InputDefinition)Input[0]).GetInput();
                Beam pickedBeam = _model.SelectModelObject(ID1) as Beam;

                Point pickedPoint = Input[1].GetInput() as Point;

                if (pickedBeam != null)
                {
                        basePlateDetail = new DeBasePlate1004(_data);
                        result = basePlateDetail.Insert(pickedBeam, pickedPoint);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }


    }
}
