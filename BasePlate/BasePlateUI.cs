using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tekla.Structures.Plugins;

namespace BasePlate
{
    class BasePlateUI
    {
        public const string BasePlatePlugin = @"" +
            @"page(""TeklaStructures"","""")" + "\n" +
            "{\n" +
                "joint(1, BasePlate)\n" +
                "{\n" +
                    @"helpurl(""BasePlate.chm::/general.html"")" + "\n" +

@"tab_page("""", ""Picture"", 1)" + "\n" +
                    "{\n" +

                        @"picture(""BasePlate_ShearKey.bmp"", 173, 126, 180, 50)" + "\n" +
                        @"parameter("""", adist1, distance, number, 440, 160, 50)" + "\n" +
                        @"attribute(""beampos"", """", option, ""%s"",none, none, ""0.0"", ""0.0"", 200,250,215)" + "\n" +
                            "{\n" +
                                @"value(""BasePlate_Beam_Position_1.xbm"", 2)"  + "\n" +
                                @"value(""BasePlate_Beam_Position_2.xbm"", 1)" + "\n" +
                                @"value(""BasePlate_Beam_Position_3.xbm"", 0)" + "\n" +
                            "}\n" +
                    "}\n" +

@"tab_page("""", ""Parts"", 2)" + "\n" +
                    "{\n" +
                        @"part (   ""j_plate"", tpl1, , , pos1, mat,  , partname)" + "\n" +
                        @"profile (""j_additional_beam"", prof, pos2, mat2,  , partname2)" + "\n" +
                        @"attribute(, ""Class"", label2, ""%s"", none, none, ""0.0"", ""0.0"", 840, 4)" + "\n" +
                        @"parameter("""", ""epClass"", integer, number, 840, 25, 50)" + "\n" +

                        //@"parameter("""", ""rw1"", distance, number, 490, 130, 50)" + "\n" +
                        //@"parameter("""", ""lwd"", distance, number, 590, 130, 50)" + "\n" +
                        //@"parameter("""", ""rw2"", distance, number, 690, 130, 50)" + "\n" +

                        //@"parameter("""", ""rb1"", distance, number, 770, 175, 50)" + "\n" +
                        //@"parameter("""", ""lbd"", distance, number, 770, 250, 50)" + "\n" +
                        //@"parameter("""", ""rb2"", distance, number, 770, 325, 50)" + "\n" +

                        //@"picture(""BasePlate_tbh1.bmp"", 520, 200, 50, 150)" + "\n" +
                     "}\n" +
@"tab_page("""", ""Weldings"", 3)" + "\n" +
                    "{\n" +
                        @"attribute(""label_only1"", ""1."", label2, ""%s"", none, none, ""0.0"", ""0.0"", 20, 80)" + "\n" +
                        @"attribute("""", ""jd_weld_Size"", label2, ""%s"", none, none, ""0.0"", ""0.0"", 80, 50)" + "\n" +
                        @"parameter("""", ""w1_size"", distance, number, 80, 80, 64)" + "\n" +
                        @"attribute("""", ""jd_weld_Type1"", label2, ""%s"", none, none, ""0.0"", ""0.0"", 180, 50)" + "\n" +
                        @"attribute(""w1_type"", """", option, ""%s"", none, none, ""0.0"", ""0.0"", 180, 80, 96)" + "\n" +
                        "{\n" +
                             @"value(""w_type_0.xbm"", 1)" + "\n" +
                             @"value(""w_type_10.xbm"", 0)" + "\n" +
                             @"value(""w_type_4.xbm"", 0)" + "\n" +
                        "}\n" +
                        @"attribute("""", ""jd_weld_Edge_around"", label2, ""%s"", none, none, ""0.0"", ""0.0"", 315, 50)" + "\n" +
                        @"attribute(""w1_around"", """", option, ""%s"", none, none, ""0.0"", ""0.0"", 315, 80, 64)" + "\n" +
                        "{\n" +
                            @"value(""w_around_0.xbm"", 0)" + "\n" +
                            @"value(""w_around_1.xbm"", 1)" + "\n" +
                        "}\n" +
                        @"attribute("""", ""jd_weld_Wshop_site"", label2, ""%s"", none, none, ""0.0"", ""0.0"", 420, 50)" + "\n" +
                        @"attribute(""w1_wtype"", """", option, ""%s"", none, none, ""0.0"", ""0.0"", 420, 80, 64)" + "\n" +
                        "{\n" +
                            @"value(""w_workshop_1.xbm"", 0)" + "\n" +
                            @"value(""w_workshop_0.xbm"", 1)" + "\n" +
                        "}\n" +
                        @"attribute("""", ""jd_weld_Wshop_site"", label2, ""%s"", none, none, ""0.0"", ""0.0"", 420, 50)" + "\n" +
                        @"attribute("""", ""Reference text"", label2, ""%s"", none, none, ""0.0"", ""0.0"", 530, 50)" + "\n" +
                        @"parameter("""", ""reference_text_1"", string, text, 530, 80, 200)" + "\n" +
                        @"attribute(""label_only2"", ""2."", label2, ""%s"", none, none, ""0.0"", ""0.0"", 20, 105)" + "\n" +
                        @"parameter("""", ""w2_size"", distance, number, 80, 105, 64)" + "\n" +
                        @"attribute(""w2_type"", """", option, ""%s"", none, none, ""0.0"", ""0.0"", 180, 105, 96)" + "\n" +
                        "{\n" +
                             @"value(""w_type_0.xbm"", 1)" + "\n" +
                             @"value(""w_type_10.xbm"", 0)" + "\n" +
                             @"value(""w_type_4.xbm"", 0)" + "\n" +
                        "}\n" +
                        @"attribute(""w2_around"", """", option, ""%s"", none, none, ""0.0"", ""0.0"", 315, 105, 64)" + "\n" +
                        "{\n" +
                            @"value(""w_around_0.xbm"", 0)" + "\n" +
                            @"value(""w_around_1.xbm"", 1)" + "\n" +
                        "}\n" +
                        @"attribute(""w2_wtype"", """", option, ""%s"", none, none, ""0.0"", ""0.0"", 420, 105, 64)" + "\n" +
                        "{\n" +
                            @"value(""w_workshop_1.xbm"", 0)" + "\n" +
                            @"value(""w_workshop_0.xbm"", 1)" + "\n" +
                        "}\n" +
                        @"parameter("""", ""reference_text_2"", string, text, 530, 105, 200)" + "\n" +

                        @"picture(""BasePlate_Weldings.bmp"", 480, 200, 100, 210)" + "\n" +
                    "}\n" +
@"tab_page("""", ""Bolts"", 5)" + "\n" +
                    "{\n" +
                        @"parameter("""", ""diameter"", bolt_size, number, 170, 5, 150)" + "\n" +
                        @"parameter("""", ""screwdin"", bolt_standard, text, 170, 30, 150)" + "\n" +
                        @"parameter("""", ""tolerance"", distance, number,170,55,150)" + "\n" +
                        @"attribute(""thread_in"", """", option, ""%s"",  none, none, ""0.0"", ""0.0"",170,80,150)" + "\n" +
                        "{\n" +
                            @"value(""j_Default"", 2)" + "\n" +
                            @"value(""j_no"", 0)" + "\n" +
                            @"value(""j_yes"", 1)" + "\n" +
                        "}\n" +
                        @"attribute(""assembly_type"", """", option, ""%s"",  none, none, ""0.0"", ""0.0"",170,111,150)" + "\n" +
                        "{\n" +
                            @"value(""j_Default"", 2)" + "\n" +
                            @"value(""j_site"", 1)" + "\n" +
                            @"value(""j_workshop"", 0)" + "\n" +
                        "}\n" +
                        @"attribute(""bolt_size_lb"", ""j_bolt_size"", label2, ""%s"",  none, none, ""0.0"", ""0.0"",20,5)" + "\n" +
                        @"attribute(""bolt_standard_lb"", ""j_bolt_standard"", label3, ""%s"",  none, none, ""0.0"", ""0.0"",20,30)" + "\n" +
                        @"attribute(""tolerance_lb"", ""j_tolerance"", label2, ""%s"",  none, none, ""0.0"", ""0.0"",20,55)" + "\n" +
                        @"attribute(""thread_in_material_lb"", ""j_thread_in_material"", label3, ""%s"",  none, none, ""0.0"", ""0.0"",20,80)" + "\n" +

                        //@"attribute(""lwtyp"", """", option, ""%s"",  none, none, ""0.0"", ""0.0"",250,185,90)" + "\n" +
                        //"{\n" +
                            //@"value(""j_Default"", 2)" + "\n" +
                            //@"value("""",0)" + "\n" +
                            //@"value(""j_left"", 0)" + "\n" +
                            //@"value(""j_middle"", 1)" + "\n" +
                            //@"value(""j_right"", 0)" + "\n" +
                        //"}\n" +

                        //@"parameter("""", ""lwa"", distance, number,250,208,60)" + "\n" +
                        //@"attribute(""lbtyp"", """", option, ""%s"",  none, none, ""0.0"", ""0.0"",100,284,90)" + "\n" +
                        //"{\n" +
                            //@"value(""j_Default"", 2)" + "\n" +
                            //@"value("""", 0)" + "\n" +
                            //@"value(""j_top"", 0)" + "\n" +
                            //@"value(""j_middle"", 1)" + "\n" +
                            //@"value(""j_below"", 0)" + "\n" +
                        //"}\n" +
                        //@"parameter("""", ""lba"", distance, number,110,315,60)" + "\n" +

                        //@"picture(""slotted_hole_extended"", 155, 115, 326, 0)" + "\n" +
                        //@"parameter("""", ""longholex"", distance, number,444,20,60)" + "\n" +
                        //@"parameter("""", ""longholey"", distance, number,533,70,60)" + "\n" +
                        //@"parameter("""", ""holetype"", hole_type, text,463,100,150)" + "\n" +
                        //@"parameter("""", ""holedirection"", hole_direction, text,463,125,150)" + "\n" +
                        //@"attribute(""hole_type_lb"", ""albl_Hole_Type_"", label3 , ""%s"", none, none , ""0.0"", ""0.0"", 332, 100)" + "\n" +
                        //@"attribute(""hole_direction_lb"", ""albl_Rotate_Slots_"", label3 , ""%s"", none, none , ""0.0"", ""0.0"", 332, 125)" + "\n" +

                        @"picture(""bolts.bmp"", 146, 172, 180, 235)" + "\n" +
                        @"parameter("""", ""rb1"", distance, number,410,265,60)" + "\n" +
                        @"parameter("""", ""nb"", integer, number,410,315,40)" + "\n" +
                        @"parameter("""", ""lbd"", distance_list_no_toggle, text,455,315,135)" + "\n" +
                        @"parameter("""", ""rb2"", distance, number,410,365,60)" + "\n" +
                        @"parameter("""", ""rw1"", distance, number,190,419,60)" + "\n" +
                        @"parameter("""", ""rw2"", distance, number,310,419,60)" + "\n" +
                        @"parameter("""", ""nw"", integer, number,190,445,40)" + "\n" +
                        @"parameter("""", ""lwd"", distance_list_no_toggle, text,235,445,135)" + "\n" +
                        //@"parameter("""", ""estring"", distance_list_no_toggle, text,455,445,135)" + "\n" +
                    "}\n" +
                "}\n" +
            "}\n";
    }
}
