using static QwUI.Data.DIL.MySQLDB;
using QwUI.Data.DIL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using QwUI;
namespace DBSchema
{
    public class Tables
    {
        /// <summary> 
        /// 皮带利用率
        /// </summary>
        public partial class app_beltoperation : Table
        {
            public app_beltoperation(BaseDB baseDB) : base("ID", baseDB)
            {

            }
        }

        /// <summary> 
        /// 生产记录表
        /// </summary>
        public partial class app_pureteboard : Table
        {
            public app_pureteboard(BaseDB baseDB) : base("ID", baseDB)
            {

            }
        }

        /// <summary> 
        /// 
        /// </summary>
        public partial class createuser : Table
        {
            public createuser(BaseDB baseDB) : base("ID", baseDB)
            {

            }
        }

        /// <summary> 
        /// 
        /// </summary>
        public partial class materialstable : Table
        {
            public materialstable(BaseDB baseDB) : base("ID", baseDB)
            {

            }
        }

        /// <summary> 
        /// 
        /// </summary>
        public partial class operationtable : Table
        {
            public operationtable(BaseDB baseDB) : base("ID", baseDB)
            {

            }
        }

        /// <summary> 
        /// 
        /// </summary>
        public partial class processstatustable : Table
        {
            public processstatustable(BaseDB baseDB) : base("ID", baseDB)
            {

            }
        }

        /// <summary> 
        /// 
        /// </summary>
        public partial class recipetable : Table
        {
            public recipetable(BaseDB baseDB) : base("ID", baseDB)
            {

            }
        }

        /// <summary> 
        /// 
        /// </summary>
        public partial class repairstable : Table
        {
            public repairstable(BaseDB baseDB) : base("ID", baseDB)
            {

            }
        }


    }


    public class Views
    {

    }

    public class SP
    {

    }


}

namespace DBNames
{
    public static class T_Col_Name
    {
        /// <summary> 
        /// app_beltoperation
        /// </summary>
        public class app_beltoperation
        {
            /// <summary>
            /// 
            /// </summary>
            public const string @ID = nameof(@ID);
            /// <summary>
            /// 板ID
            /// </summary>
            public const string @BoardId_Str = nameof(@BoardId_Str);
            /// <summary>
            /// 皮带位置
            /// </summary>
            public const string @Index_Int = nameof(@Index_Int);
            /// <summary>
            /// 模板长度
            /// </summary>
            public const string @BoardLength_Dec = nameof(@BoardLength_Dec);
            /// <summary>
            /// 皮带长度
            /// </summary>
            public const string @BeltLength_Dec = nameof(@BeltLength_Dec);
            /// <summary>
            /// 
            /// </summary>
            public const string @OperationRate_Dec = nameof(@OperationRate_Dec);
            /// <summary>
            /// 创建时间
            /// </summary>
            public const string @CreateTime_Dt = nameof(@CreateTime_Dt);

        }
        /// <summary> 
        /// app_pureteboard
        /// </summary>
        public class app_pureteboard
        {
            /// <summary>
            /// 
            /// </summary>
            public const string @ID = nameof(@ID);
            /// <summary>
            /// 组织
            /// </summary>
            public const string @OrgID_Int = nameof(@OrgID_Int);
            /// <summary>
            /// 
            /// </summary>
            public const string @ProductID_Str = nameof(@ProductID_Str);
            /// <summary>
            /// 
            /// </summary>
            public const string @Length_Dec = nameof(@Length_Dec);
            /// <summary>
            /// 
            /// </summary>
            public const string @Width_Dec = nameof(@Width_Dec);
            /// <summary>
            /// 
            /// </summary>
            public const string @Height_Dec = nameof(@Height_Dec);
            /// <summary>
            /// 
            /// </summary>
            public const string @Area_Dec = nameof(@Area_Dec);
            /// <summary>
            /// 
            /// </summary>
            public const string @CreateUser_Str = nameof(@CreateUser_Str);
            /// <summary>
            /// 
            /// </summary>
            public const string @CreateTime_Dt = nameof(@CreateTime_Dt);
            /// <summary>
            /// 
            /// </summary>
            public const string @Code_Int = nameof(@Code_Int);
            /// <summary>
            /// 
            /// </summary>
            public const string @Model_Str = nameof(@Model_Str);
            /// <summary>
            /// 
            /// </summary>
            public const string @RecipeNo_Str = nameof(@RecipeNo_Str);

        }
        /// <summary> 
        /// createuser
        /// </summary>
        public class createuser
        {
            /// <summary>
            /// 
            /// </summary>
            public const string @id = nameof(@id);
            /// <summary>
            /// 
            /// </summary>
            public const string @UserName = nameof(@UserName);
            /// <summary>
            /// 
            /// </summary>
            public const string @PassWord = nameof(@PassWord);
            /// <summary>
            /// 
            /// </summary>
            public const string @Department = nameof(@Department);

        }
        /// <summary> 
        /// materialstable
        /// </summary>
        public class materialstable
        {
            /// <summary>
            /// 
            /// </summary>
            public const string @id = nameof(@id);
            /// <summary>
            /// 
            /// </summary>
            public const string @Dates = nameof(@Dates);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes1 = nameof(@NOtes1);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes2 = nameof(@NOtes2);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes3 = nameof(@NOtes3);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes4 = nameof(@NOtes4);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes5 = nameof(@NOtes5);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes6 = nameof(@NOtes6);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes7 = nameof(@NOtes7);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes8 = nameof(@NOtes8);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes9 = nameof(@NOtes9);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes10 = nameof(@NOtes10);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes11 = nameof(@NOtes11);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes12 = nameof(@NOtes12);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes13 = nameof(@NOtes13);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes14 = nameof(@NOtes14);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes15 = nameof(@NOtes15);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes16 = nameof(@NOtes16);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes17 = nameof(@NOtes17);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes18 = nameof(@NOtes18);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes19 = nameof(@NOtes19);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes20 = nameof(@NOtes20);

        }
        /// <summary> 
        /// operationtable
        /// </summary>
        public class operationtable
        {
            /// <summary>
            /// 
            /// </summary>
            public const string @id = nameof(@id);
            /// <summary>
            /// 
            /// </summary>
            public const string @Dates = nameof(@Dates);
            /// <summary>
            /// 
            /// </summary>
            public const string @Name = nameof(@Name);
            /// <summary>
            /// 
            /// </summary>
            public const string @Department = nameof(@Department);
            /// <summary>
            /// 
            /// </summary>
            public const string @Logs = nameof(@Logs);

        }
        /// <summary> 
        /// processstatustable
        /// </summary>
        public class processstatustable
        {
            /// <summary>
            /// 
            /// </summary>
            public const string @id = nameof(@id);
            /// <summary>
            /// 
            /// </summary>
            public const string @Dates = nameof(@Dates);
            /// <summary>
            /// 
            /// </summary>
            public const string @Logs = nameof(@Logs);

        }
        /// <summary> 
        /// recipetable
        /// </summary>
        public class recipetable
        {
            /// <summary>
            /// 
            /// </summary>
            public const string @id = nameof(@id);
            /// <summary>
            /// 
            /// </summary>
            public const string @productNO = nameof(@productNO);
            /// <summary>
            /// 
            /// </summary>
            public const string @machine_name = nameof(@machine_name);
            /// <summary>
            /// 
            /// </summary>
            public const string @date = nameof(@date);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes1 = nameof(@Notes1);
            /// <summary>
            /// 
            /// </summary>
            public const string @link = nameof(@link);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes2 = nameof(@Notes2);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes3 = nameof(@Notes3);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes4 = nameof(@Notes4);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes5 = nameof(@Notes5);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes6 = nameof(@Notes6);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes7 = nameof(@Notes7);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes8 = nameof(@Notes8);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes9 = nameof(@Notes9);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes10 = nameof(@Notes10);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes11 = nameof(@Notes11);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes12 = nameof(@Notes12);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes13 = nameof(@Notes13);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes14 = nameof(@Notes14);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes15 = nameof(@Notes15);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes16 = nameof(@Notes16);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes17 = nameof(@Notes17);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes18 = nameof(@Notes18);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes19 = nameof(@Notes19);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes20 = nameof(@Notes20);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes21 = nameof(@Notes21);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes22 = nameof(@Notes22);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes23 = nameof(@Notes23);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes24 = nameof(@Notes24);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes25 = nameof(@Notes25);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes26 = nameof(@Notes26);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes27 = nameof(@Notes27);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes28 = nameof(@Notes28);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes29 = nameof(@Notes29);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes30 = nameof(@Notes30);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes31 = nameof(@Notes31);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes32 = nameof(@Notes32);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes33 = nameof(@Notes33);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes34 = nameof(@Notes34);
            /// <summary>
            /// 
            /// </summary>
            public const string @Notes35 = nameof(@Notes35);

        }
        /// <summary> 
        /// repairstable
        /// </summary>
        public class repairstable
        {
            /// <summary>
            /// 
            /// </summary>
            public const string @id = nameof(@id);
            /// <summary>
            /// 
            /// </summary>
            public const string @Dates = nameof(@Dates);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes1 = nameof(@NOtes1);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes2 = nameof(@NOtes2);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes3 = nameof(@NOtes3);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes4 = nameof(@NOtes4);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes5 = nameof(@NOtes5);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes6 = nameof(@NOtes6);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes7 = nameof(@NOtes7);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes8 = nameof(@NOtes8);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes9 = nameof(@NOtes9);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes10 = nameof(@NOtes10);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes11 = nameof(@NOtes11);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes12 = nameof(@NOtes12);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes13 = nameof(@NOtes13);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes14 = nameof(@NOtes14);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes15 = nameof(@NOtes15);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes16 = nameof(@NOtes16);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes17 = nameof(@NOtes17);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes18 = nameof(@NOtes18);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes19 = nameof(@NOtes19);
            /// <summary>
            /// 
            /// </summary>
            public const string @NOtes20 = nameof(@NOtes20);

        }

    }

    public static class V_Col_Name
    {

    }


    public static class SP_Paramters
    {

    }

}
namespace DBModel
{

    /// <summary> 
    /// 皮带利用率
    /// </summary>
    public class app_beltoperation : ObservableObject
    {
        private int _ID;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            get { return _ID; }
            set
            {
                if (value != (_ID))
                {
                    _ID = value;
                    OnPropertyChanged(nameof(ID));
                }
            }
        }
        private string _BoardId_Str;
        /// <summary>
        /// 板ID
        /// </summary>
        public string BoardId_Str
        {
            get { return _BoardId_Str; }
            set
            {
                if (value != (_BoardId_Str))
                {
                    _BoardId_Str = value;
                    OnPropertyChanged(nameof(BoardId_Str));
                }
            }
        }
        private int _Index_Int;
        /// <summary>
        /// 皮带位置
        /// </summary>
        public int Index_Int
        {
            get { return _Index_Int; }
            set
            {
                if (value != (_Index_Int))
                {
                    _Index_Int = value;
                    OnPropertyChanged(nameof(Index_Int));
                }
            }
        }
        private decimal _BoardLength_Dec;
        /// <summary>
        /// 模板长度
        /// </summary>
        public decimal BoardLength_Dec
        {
            get { return _BoardLength_Dec; }
            set
            {
                if (value != (_BoardLength_Dec))
                {
                    _BoardLength_Dec = value;
                    OnPropertyChanged(nameof(BoardLength_Dec));
                }
            }
        }
        private decimal _BeltLength_Dec;
        /// <summary>
        /// 皮带长度
        /// </summary>
        public decimal BeltLength_Dec
        {
            get { return _BeltLength_Dec; }
            set
            {
                if (value != (_BeltLength_Dec))
                {
                    _BeltLength_Dec = value;
                    OnPropertyChanged(nameof(BeltLength_Dec));
                }
            }
        }
        private decimal _OperationRate_Dec;
        /// <summary>
        /// 
        /// </summary>
        public decimal OperationRate_Dec
        {
            get { return _OperationRate_Dec; }
            set
            {
                if (value != (_OperationRate_Dec))
                {
                    _OperationRate_Dec = value;
                    OnPropertyChanged(nameof(OperationRate_Dec));
                }
            }
        }
        private DateTime? _CreateTime_Dt;
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime_Dt
        {
            get { return _CreateTime_Dt; }
            set
            {
                if (value != (_CreateTime_Dt))
                {
                    _CreateTime_Dt = value;
                    OnPropertyChanged(nameof(CreateTime_Dt));
                }
            }
        }

    }
    /// <summary> 
    /// 生产记录表
    /// </summary>
    public class app_pureteboard : ObservableObject
    {
        private int _ID;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            get { return _ID; }
            set
            {
                if (value != (_ID))
                {
                    _ID = value;
                    OnPropertyChanged(nameof(ID));
                }
            }
        }
        private string _OrgID_Int;
        /// <summary>
        /// 组织
        /// </summary>
        public string OrgID_Int
        {
            get { return _OrgID_Int; }
            set
            {
                if (value != (_OrgID_Int))
                {
                    _OrgID_Int = value;
                    OnPropertyChanged(nameof(OrgID_Int));
                }
            }
        }
        private string _ProductID_Str;
        /// <summary>
        /// 
        /// </summary>
        public string ProductID_Str
        {
            get { return _ProductID_Str; }
            set
            {
                if (value != (_ProductID_Str))
                {
                    _ProductID_Str = value;
                    OnPropertyChanged(nameof(ProductID_Str));
                }
            }
        }
        private string _Length_Dec;
        /// <summary>
        /// 
        /// </summary>
        public string Length_Dec
        {
            get { return _Length_Dec; }
            set
            {
                if (value != (_Length_Dec))
                {
                    _Length_Dec = value;
                    OnPropertyChanged(nameof(Length_Dec));
                }
            }
        }
        private string _Width_Dec;
        /// <summary>
        /// 
        /// </summary>
        public string Width_Dec
        {
            get { return _Width_Dec; }
            set
            {
                if (value != (_Width_Dec))
                {
                    _Width_Dec = value;
                    OnPropertyChanged(nameof(Width_Dec));
                }
            }
        }
        private string _Height_Dec;
        /// <summary>
        /// 
        /// </summary>
        public string Height_Dec
        {
            get { return _Height_Dec; }
            set
            {
                if (value != (_Height_Dec))
                {
                    _Height_Dec = value;
                    OnPropertyChanged(nameof(Height_Dec));
                }
            }
        }
        private decimal _Area_Dec;
        /// <summary>
        /// 
        /// </summary>
        public decimal Area_Dec
        {
            get { return _Area_Dec; }
            set
            {
                if (value != (_Area_Dec))
                {
                    _Area_Dec = value;
                    OnPropertyChanged(nameof(Area_Dec));
                }
            }
        }
        private string _CreateUser_Str;
        /// <summary>
        /// 
        /// </summary>
        public string CreateUser_Str
        {
            get { return _CreateUser_Str; }
            set
            {
                if (value != (_CreateUser_Str))
                {
                    _CreateUser_Str = value;
                    OnPropertyChanged(nameof(CreateUser_Str));
                }
            }
        }
        private DateTime? _CreateTime_Dt;
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CreateTime_Dt
        {
            get { return _CreateTime_Dt; }
            set
            {
                if (value != (_CreateTime_Dt))
                {
                    _CreateTime_Dt = value;
                    OnPropertyChanged(nameof(CreateTime_Dt));
                }
            }
        }
        private string _Code_Int;
        /// <summary>
        /// 
        /// </summary>
        public string Code_Int
        {
            get { return _Code_Int; }
            set
            {
                if (value != (_Code_Int))
                {
                    _Code_Int = value;
                    OnPropertyChanged(nameof(Code_Int));
                }
            }
        }
        private string _Model_Str;
        /// <summary>
        /// 
        /// </summary>
        public string Model_Str
        {
            get { return _Model_Str; }
            set
            {
                if (value != (_Model_Str))
                {
                    _Model_Str = value;
                    OnPropertyChanged(nameof(Model_Str));
                }
            }
        }
        private string _RecipeNo_Str;
        /// <summary>
        /// 
        /// </summary>
        public string RecipeNo_Str
        {
            get { return _RecipeNo_Str; }
            set
            {
                if (value != (_RecipeNo_Str))
                {
                    _RecipeNo_Str = value;
                    OnPropertyChanged(nameof(RecipeNo_Str));
                }
            }
        }

    }
    /// <summary> 
    /// 
    /// </summary>
    public class createuser : ObservableObject
    {
        private int _id;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            get { return _id; }
            set
            {
                if (value != (_id))
                {
                    _id = value;
                    OnPropertyChanged(nameof(id));
                }
            }
        }
        private string _UserName;
        /// <summary>
        /// 
        /// </summary>
        public string UserName
        {
            get { return _UserName; }
            set
            {
                if (value != (_UserName))
                {
                    _UserName = value;
                    OnPropertyChanged(nameof(UserName));
                }
            }
        }
        private string _PassWord;
        /// <summary>
        /// 
        /// </summary>
        public string PassWord
        {
            get { return _PassWord; }
            set
            {
                if (value != (_PassWord))
                {
                    _PassWord = value;
                    OnPropertyChanged(nameof(PassWord));
                }
            }
        }
        private string _Department;
        /// <summary>
        /// 
        /// </summary>
        public string Department
        {
            get { return _Department; }
            set
            {
                if (value != (_Department))
                {
                    _Department = value;
                    OnPropertyChanged(nameof(Department));
                }
            }
        }

    }
    /// <summary> 
    /// 
    /// </summary>
    public class materialstable : ObservableObject
    {
        private int _id;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            get { return _id; }
            set
            {
                if (value != (_id))
                {
                    _id = value;
                    OnPropertyChanged(nameof(id));
                }
            }
        }
        private string _Dates;
        /// <summary>
        /// 
        /// </summary>
        public string Dates
        {
            get { return _Dates; }
            set
            {
                if (value != (_Dates))
                {
                    _Dates = value;
                    OnPropertyChanged(nameof(Dates));
                }
            }
        }
        private string _NOtes1;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes1
        {
            get { return _NOtes1; }
            set
            {
                if (value != (_NOtes1))
                {
                    _NOtes1 = value;
                    OnPropertyChanged(nameof(NOtes1));
                }
            }
        }
        private string _NOtes2;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes2
        {
            get { return _NOtes2; }
            set
            {
                if (value != (_NOtes2))
                {
                    _NOtes2 = value;
                    OnPropertyChanged(nameof(NOtes2));
                }
            }
        }
        private string _NOtes3;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes3
        {
            get { return _NOtes3; }
            set
            {
                if (value != (_NOtes3))
                {
                    _NOtes3 = value;
                    OnPropertyChanged(nameof(NOtes3));
                }
            }
        }
        private string _NOtes4;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes4
        {
            get { return _NOtes4; }
            set
            {
                if (value != (_NOtes4))
                {
                    _NOtes4 = value;
                    OnPropertyChanged(nameof(NOtes4));
                }
            }
        }
        private string _NOtes5;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes5
        {
            get { return _NOtes5; }
            set
            {
                if (value != (_NOtes5))
                {
                    _NOtes5 = value;
                    OnPropertyChanged(nameof(NOtes5));
                }
            }
        }
        private string _NOtes6;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes6
        {
            get { return _NOtes6; }
            set
            {
                if (value != (_NOtes6))
                {
                    _NOtes6 = value;
                    OnPropertyChanged(nameof(NOtes6));
                }
            }
        }
        private string _NOtes7;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes7
        {
            get { return _NOtes7; }
            set
            {
                if (value != (_NOtes7))
                {
                    _NOtes7 = value;
                    OnPropertyChanged(nameof(NOtes7));
                }
            }
        }
        private string _NOtes8;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes8
        {
            get { return _NOtes8; }
            set
            {
                if (value != (_NOtes8))
                {
                    _NOtes8 = value;
                    OnPropertyChanged(nameof(NOtes8));
                }
            }
        }
        private string _NOtes9;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes9
        {
            get { return _NOtes9; }
            set
            {
                if (value != (_NOtes9))
                {
                    _NOtes9 = value;
                    OnPropertyChanged(nameof(NOtes9));
                }
            }
        }
        private string _NOtes10;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes10
        {
            get { return _NOtes10; }
            set
            {
                if (value != (_NOtes10))
                {
                    _NOtes10 = value;
                    OnPropertyChanged(nameof(NOtes10));
                }
            }
        }
        private string _NOtes11;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes11
        {
            get { return _NOtes11; }
            set
            {
                if (value != (_NOtes11))
                {
                    _NOtes11 = value;
                    OnPropertyChanged(nameof(NOtes11));
                }
            }
        }
        private string _NOtes12;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes12
        {
            get { return _NOtes12; }
            set
            {
                if (value != (_NOtes12))
                {
                    _NOtes12 = value;
                    OnPropertyChanged(nameof(NOtes12));
                }
            }
        }
        private string _NOtes13;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes13
        {
            get { return _NOtes13; }
            set
            {
                if (value != (_NOtes13))
                {
                    _NOtes13 = value;
                    OnPropertyChanged(nameof(NOtes13));
                }
            }
        }
        private string _NOtes14;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes14
        {
            get { return _NOtes14; }
            set
            {
                if (value != (_NOtes14))
                {
                    _NOtes14 = value;
                    OnPropertyChanged(nameof(NOtes14));
                }
            }
        }
        private string _NOtes15;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes15
        {
            get { return _NOtes15; }
            set
            {
                if (value != (_NOtes15))
                {
                    _NOtes15 = value;
                    OnPropertyChanged(nameof(NOtes15));
                }
            }
        }
        private string _NOtes16;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes16
        {
            get { return _NOtes16; }
            set
            {
                if (value != (_NOtes16))
                {
                    _NOtes16 = value;
                    OnPropertyChanged(nameof(NOtes16));
                }
            }
        }
        private string _NOtes17;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes17
        {
            get { return _NOtes17; }
            set
            {
                if (value != (_NOtes17))
                {
                    _NOtes17 = value;
                    OnPropertyChanged(nameof(NOtes17));
                }
            }
        }
        private string _NOtes18;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes18
        {
            get { return _NOtes18; }
            set
            {
                if (value != (_NOtes18))
                {
                    _NOtes18 = value;
                    OnPropertyChanged(nameof(NOtes18));
                }
            }
        }
        private string _NOtes19;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes19
        {
            get { return _NOtes19; }
            set
            {
                if (value != (_NOtes19))
                {
                    _NOtes19 = value;
                    OnPropertyChanged(nameof(NOtes19));
                }
            }
        }
        private string _NOtes20;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes20
        {
            get { return _NOtes20; }
            set
            {
                if (value != (_NOtes20))
                {
                    _NOtes20 = value;
                    OnPropertyChanged(nameof(NOtes20));
                }
            }
        }

    }
    /// <summary> 
    /// 
    /// </summary>
    public class operationtable : ObservableObject
    {
        private int _id;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            get { return _id; }
            set
            {
                if (value != (_id))
                {
                    _id = value;
                    OnPropertyChanged(nameof(id));
                }
            }
        }
        private string _Dates;
        /// <summary>
        /// 
        /// </summary>
        public string Dates
        {
            get { return _Dates; }
            set
            {
                if (value != (_Dates))
                {
                    _Dates = value;
                    OnPropertyChanged(nameof(Dates));
                }
            }
        }
        private string _Name;
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set
            {
                if (value != (_Name))
                {
                    _Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }
        private string _Department;
        /// <summary>
        /// 
        /// </summary>
        public string Department
        {
            get { return _Department; }
            set
            {
                if (value != (_Department))
                {
                    _Department = value;
                    OnPropertyChanged(nameof(Department));
                }
            }
        }
        private string _Logs;
        /// <summary>
        /// 
        /// </summary>
        public string Logs
        {
            get { return _Logs; }
            set
            {
                if (value != (_Logs))
                {
                    _Logs = value;
                    OnPropertyChanged(nameof(Logs));
                }
            }
        }

    }
    /// <summary> 
    /// 
    /// </summary>
    public class processstatustable : ObservableObject
    {
        private int _id;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            get { return _id; }
            set
            {
                if (value != (_id))
                {
                    _id = value;
                    OnPropertyChanged(nameof(id));
                }
            }
        }
        private string _Dates;
        /// <summary>
        /// 
        /// </summary>
        public string Dates
        {
            get { return _Dates; }
            set
            {
                if (value != (_Dates))
                {
                    _Dates = value;
                    OnPropertyChanged(nameof(Dates));
                }
            }
        }
        private string _Logs;
        /// <summary>
        /// 
        /// </summary>
        public string Logs
        {
            get { return _Logs; }
            set
            {
                if (value != (_Logs))
                {
                    _Logs = value;
                    OnPropertyChanged(nameof(Logs));
                }
            }
        }

    }
    /// <summary> 
    /// 
    /// </summary>
    public class recipetable : ObservableObject
    {
        private int _id;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            get { return _id; }
            set
            {
                if (value != (_id))
                {
                    _id = value;
                    OnPropertyChanged(nameof(id));
                }
            }
        }
        private string _productNO;
        /// <summary>
        /// 
        /// </summary>
        public string productNO
        {
            get { return _productNO; }
            set
            {
                if (value != (_productNO))
                {
                    _productNO = value;
                    OnPropertyChanged(nameof(productNO));
                }
            }
        }
        private string _machine_name;
        /// <summary>
        /// 
        /// </summary>
        public string machine_name
        {
            get { return _machine_name; }
            set
            {
                if (value != (_machine_name))
                {
                    _machine_name = value;
                    OnPropertyChanged(nameof(machine_name));
                }
            }
        }
        private string _date;
        /// <summary>
        /// 
        /// </summary>
        public string date
        {
            get { return _date; }
            set
            {
                if (value != (_date))
                {
                    _date = value;
                    OnPropertyChanged(nameof(date));
                }
            }
        }
        private string _Notes1;
        /// <summary>
        /// 
        /// </summary>
        public string Notes1
        {
            get { return _Notes1; }
            set
            {
                if (value != (_Notes1))
                {
                    _Notes1 = value;
                    OnPropertyChanged(nameof(Notes1));
                }
            }
        }
        private string _link;
        /// <summary>
        /// 
        /// </summary>
        public string link
        {
            get { return _link; }
            set
            {
                if (value != (_link))
                {
                    _link = value;
                    OnPropertyChanged(nameof(link));
                }
            }
        }
        private string _Notes2;
        /// <summary>
        /// 
        /// </summary>
        public string Notes2
        {
            get { return _Notes2; }
            set
            {
                if (value != (_Notes2))
                {
                    _Notes2 = value;
                    OnPropertyChanged(nameof(Notes2));
                }
            }
        }
        private string _Notes3;
        /// <summary>
        /// 
        /// </summary>
        public string Notes3
        {
            get { return _Notes3; }
            set
            {
                if (value != (_Notes3))
                {
                    _Notes3 = value;
                    OnPropertyChanged(nameof(Notes3));
                }
            }
        }
        private string _Notes4;
        /// <summary>
        /// 
        /// </summary>
        public string Notes4
        {
            get { return _Notes4; }
            set
            {
                if (value != (_Notes4))
                {
                    _Notes4 = value;
                    OnPropertyChanged(nameof(Notes4));
                }
            }
        }
        private string _Notes5;
        /// <summary>
        /// 
        /// </summary>
        public string Notes5
        {
            get { return _Notes5; }
            set
            {
                if (value != (_Notes5))
                {
                    _Notes5 = value;
                    OnPropertyChanged(nameof(Notes5));
                }
            }
        }
        private string _Notes6;
        /// <summary>
        /// 
        /// </summary>
        public string Notes6
        {
            get { return _Notes6; }
            set
            {
                if (value != (_Notes6))
                {
                    _Notes6 = value;
                    OnPropertyChanged(nameof(Notes6));
                }
            }
        }
        private string _Notes7;
        /// <summary>
        /// 
        /// </summary>
        public string Notes7
        {
            get { return _Notes7; }
            set
            {
                if (value != (_Notes7))
                {
                    _Notes7 = value;
                    OnPropertyChanged(nameof(Notes7));
                }
            }
        }
        private string _Notes8;
        /// <summary>
        /// 
        /// </summary>
        public string Notes8
        {
            get { return _Notes8; }
            set
            {
                if (value != (_Notes8))
                {
                    _Notes8 = value;
                    OnPropertyChanged(nameof(Notes8));
                }
            }
        }
        private string _Notes9;
        /// <summary>
        /// 
        /// </summary>
        public string Notes9
        {
            get { return _Notes9; }
            set
            {
                if (value != (_Notes9))
                {
                    _Notes9 = value;
                    OnPropertyChanged(nameof(Notes9));
                }
            }
        }
        private string _Notes10;
        /// <summary>
        /// 
        /// </summary>
        public string Notes10
        {
            get { return _Notes10; }
            set
            {
                if (value != (_Notes10))
                {
                    _Notes10 = value;
                    OnPropertyChanged(nameof(Notes10));
                }
            }
        }
        private string _Notes11;
        /// <summary>
        /// 
        /// </summary>
        public string Notes11
        {
            get { return _Notes11; }
            set
            {
                if (value != (_Notes11))
                {
                    _Notes11 = value;
                    OnPropertyChanged(nameof(Notes11));
                }
            }
        }
        private string _Notes12;
        /// <summary>
        /// 
        /// </summary>
        public string Notes12
        {
            get { return _Notes12; }
            set
            {
                if (value != (_Notes12))
                {
                    _Notes12 = value;
                    OnPropertyChanged(nameof(Notes12));
                }
            }
        }
        private string _Notes13;
        /// <summary>
        /// 
        /// </summary>
        public string Notes13
        {
            get { return _Notes13; }
            set
            {
                if (value != (_Notes13))
                {
                    _Notes13 = value;
                    OnPropertyChanged(nameof(Notes13));
                }
            }
        }
        private string _Notes14;
        /// <summary>
        /// 
        /// </summary>
        public string Notes14
        {
            get { return _Notes14; }
            set
            {
                if (value != (_Notes14))
                {
                    _Notes14 = value;
                    OnPropertyChanged(nameof(Notes14));
                }
            }
        }
        private string _Notes15;
        /// <summary>
        /// 
        /// </summary>
        public string Notes15
        {
            get { return _Notes15; }
            set
            {
                if (value != (_Notes15))
                {
                    _Notes15 = value;
                    OnPropertyChanged(nameof(Notes15));
                }
            }
        }
        private string _Notes16;
        /// <summary>
        /// 
        /// </summary>
        public string Notes16
        {
            get { return _Notes16; }
            set
            {
                if (value != (_Notes16))
                {
                    _Notes16 = value;
                    OnPropertyChanged(nameof(Notes16));
                }
            }
        }
        private string _Notes17;
        /// <summary>
        /// 
        /// </summary>
        public string Notes17
        {
            get { return _Notes17; }
            set
            {
                if (value != (_Notes17))
                {
                    _Notes17 = value;
                    OnPropertyChanged(nameof(Notes17));
                }
            }
        }
        private string _Notes18;
        /// <summary>
        /// 
        /// </summary>
        public string Notes18
        {
            get { return _Notes18; }
            set
            {
                if (value != (_Notes18))
                {
                    _Notes18 = value;
                    OnPropertyChanged(nameof(Notes18));
                }
            }
        }
        private string _Notes19;
        /// <summary>
        /// 
        /// </summary>
        public string Notes19
        {
            get { return _Notes19; }
            set
            {
                if (value != (_Notes19))
                {
                    _Notes19 = value;
                    OnPropertyChanged(nameof(Notes19));
                }
            }
        }
        private string _Notes20;
        /// <summary>
        /// 
        /// </summary>
        public string Notes20
        {
            get { return _Notes20; }
            set
            {
                if (value != (_Notes20))
                {
                    _Notes20 = value;
                    OnPropertyChanged(nameof(Notes20));
                }
            }
        }
        private string _Notes21;
        /// <summary>
        /// 
        /// </summary>
        public string Notes21
        {
            get { return _Notes21; }
            set
            {
                if (value != (_Notes21))
                {
                    _Notes21 = value;
                    OnPropertyChanged(nameof(Notes21));
                }
            }
        }
        private string _Notes22;
        /// <summary>
        /// 
        /// </summary>
        public string Notes22
        {
            get { return _Notes22; }
            set
            {
                if (value != (_Notes22))
                {
                    _Notes22 = value;
                    OnPropertyChanged(nameof(Notes22));
                }
            }
        }
        private string _Notes23;
        /// <summary>
        /// 
        /// </summary>
        public string Notes23
        {
            get { return _Notes23; }
            set
            {
                if (value != (_Notes23))
                {
                    _Notes23 = value;
                    OnPropertyChanged(nameof(Notes23));
                }
            }
        }
        private string _Notes24;
        /// <summary>
        /// 
        /// </summary>
        public string Notes24
        {
            get { return _Notes24; }
            set
            {
                if (value != (_Notes24))
                {
                    _Notes24 = value;
                    OnPropertyChanged(nameof(Notes24));
                }
            }
        }
        private string _Notes25;
        /// <summary>
        /// 
        /// </summary>
        public string Notes25
        {
            get { return _Notes25; }
            set
            {
                if (value != (_Notes25))
                {
                    _Notes25 = value;
                    OnPropertyChanged(nameof(Notes25));
                }
            }
        }
        private string _Notes26;
        /// <summary>
        /// 
        /// </summary>
        public string Notes26
        {
            get { return _Notes26; }
            set
            {
                if (value != (_Notes26))
                {
                    _Notes26 = value;
                    OnPropertyChanged(nameof(Notes26));
                }
            }
        }
        private string _Notes27;
        /// <summary>
        /// 
        /// </summary>
        public string Notes27
        {
            get { return _Notes27; }
            set
            {
                if (value != (_Notes27))
                {
                    _Notes27 = value;
                    OnPropertyChanged(nameof(Notes27));
                }
            }
        }
        private string _Notes28;
        /// <summary>
        /// 
        /// </summary>
        public string Notes28
        {
            get { return _Notes28; }
            set
            {
                if (value != (_Notes28))
                {
                    _Notes28 = value;
                    OnPropertyChanged(nameof(Notes28));
                }
            }
        }
        private string _Notes29;
        /// <summary>
        /// 
        /// </summary>
        public string Notes29
        {
            get { return _Notes29; }
            set
            {
                if (value != (_Notes29))
                {
                    _Notes29 = value;
                    OnPropertyChanged(nameof(Notes29));
                }
            }
        }
        private string _Notes30;
        /// <summary>
        /// 
        /// </summary>
        public string Notes30
        {
            get { return _Notes30; }
            set
            {
                if (value != (_Notes30))
                {
                    _Notes30 = value;
                    OnPropertyChanged(nameof(Notes30));
                }
            }
        }
        private string _Notes31;
        /// <summary>
        /// 
        /// </summary>
        public string Notes31
        {
            get { return _Notes31; }
            set
            {
                if (value != (_Notes31))
                {
                    _Notes31 = value;
                    OnPropertyChanged(nameof(Notes31));
                }
            }
        }
        private string _Notes32;
        /// <summary>
        /// 
        /// </summary>
        public string Notes32
        {
            get { return _Notes32; }
            set
            {
                if (value != (_Notes32))
                {
                    _Notes32 = value;
                    OnPropertyChanged(nameof(Notes32));
                }
            }
        }
        private string _Notes33;
        /// <summary>
        /// 
        /// </summary>
        public string Notes33
        {
            get { return _Notes33; }
            set
            {
                if (value != (_Notes33))
                {
                    _Notes33 = value;
                    OnPropertyChanged(nameof(Notes33));
                }
            }
        }
        private string _Notes34;
        /// <summary>
        /// 
        /// </summary>
        public string Notes34
        {
            get { return _Notes34; }
            set
            {
                if (value != (_Notes34))
                {
                    _Notes34 = value;
                    OnPropertyChanged(nameof(Notes34));
                }
            }
        }
        private string _Notes35;
        /// <summary>
        /// 
        /// </summary>
        public string Notes35
        {
            get { return _Notes35; }
            set
            {
                if (value != (_Notes35))
                {
                    _Notes35 = value;
                    OnPropertyChanged(nameof(Notes35));
                }
            }
        }

    }
    /// <summary> 
    /// 
    /// </summary>
    public class repairstable : ObservableObject
    {
        private int _id;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            get { return _id; }
            set
            {
                if (value != (_id))
                {
                    _id = value;
                    OnPropertyChanged(nameof(id));
                }
            }
        }
        private string _Dates;
        /// <summary>
        /// 
        /// </summary>
        public string Dates
        {
            get { return _Dates; }
            set
            {
                if (value != (_Dates))
                {
                    _Dates = value;
                    OnPropertyChanged(nameof(Dates));
                }
            }
        }
        private string _NOtes1;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes1
        {
            get { return _NOtes1; }
            set
            {
                if (value != (_NOtes1))
                {
                    _NOtes1 = value;
                    OnPropertyChanged(nameof(NOtes1));
                }
            }
        }
        private string _NOtes2;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes2
        {
            get { return _NOtes2; }
            set
            {
                if (value != (_NOtes2))
                {
                    _NOtes2 = value;
                    OnPropertyChanged(nameof(NOtes2));
                }
            }
        }
        private string _NOtes3;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes3
        {
            get { return _NOtes3; }
            set
            {
                if (value != (_NOtes3))
                {
                    _NOtes3 = value;
                    OnPropertyChanged(nameof(NOtes3));
                }
            }
        }
        private string _NOtes4;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes4
        {
            get { return _NOtes4; }
            set
            {
                if (value != (_NOtes4))
                {
                    _NOtes4 = value;
                    OnPropertyChanged(nameof(NOtes4));
                }
            }
        }
        private string _NOtes5;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes5
        {
            get { return _NOtes5; }
            set
            {
                if (value != (_NOtes5))
                {
                    _NOtes5 = value;
                    OnPropertyChanged(nameof(NOtes5));
                }
            }
        }
        private string _NOtes6;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes6
        {
            get { return _NOtes6; }
            set
            {
                if (value != (_NOtes6))
                {
                    _NOtes6 = value;
                    OnPropertyChanged(nameof(NOtes6));
                }
            }
        }
        private string _NOtes7;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes7
        {
            get { return _NOtes7; }
            set
            {
                if (value != (_NOtes7))
                {
                    _NOtes7 = value;
                    OnPropertyChanged(nameof(NOtes7));
                }
            }
        }
        private string _NOtes8;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes8
        {
            get { return _NOtes8; }
            set
            {
                if (value != (_NOtes8))
                {
                    _NOtes8 = value;
                    OnPropertyChanged(nameof(NOtes8));
                }
            }
        }
        private string _NOtes9;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes9
        {
            get { return _NOtes9; }
            set
            {
                if (value != (_NOtes9))
                {
                    _NOtes9 = value;
                    OnPropertyChanged(nameof(NOtes9));
                }
            }
        }
        private string _NOtes10;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes10
        {
            get { return _NOtes10; }
            set
            {
                if (value != (_NOtes10))
                {
                    _NOtes10 = value;
                    OnPropertyChanged(nameof(NOtes10));
                }
            }
        }
        private string _NOtes11;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes11
        {
            get { return _NOtes11; }
            set
            {
                if (value != (_NOtes11))
                {
                    _NOtes11 = value;
                    OnPropertyChanged(nameof(NOtes11));
                }
            }
        }
        private string _NOtes12;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes12
        {
            get { return _NOtes12; }
            set
            {
                if (value != (_NOtes12))
                {
                    _NOtes12 = value;
                    OnPropertyChanged(nameof(NOtes12));
                }
            }
        }
        private string _NOtes13;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes13
        {
            get { return _NOtes13; }
            set
            {
                if (value != (_NOtes13))
                {
                    _NOtes13 = value;
                    OnPropertyChanged(nameof(NOtes13));
                }
            }
        }
        private string _NOtes14;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes14
        {
            get { return _NOtes14; }
            set
            {
                if (value != (_NOtes14))
                {
                    _NOtes14 = value;
                    OnPropertyChanged(nameof(NOtes14));
                }
            }
        }
        private string _NOtes15;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes15
        {
            get { return _NOtes15; }
            set
            {
                if (value != (_NOtes15))
                {
                    _NOtes15 = value;
                    OnPropertyChanged(nameof(NOtes15));
                }
            }
        }
        private string _NOtes16;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes16
        {
            get { return _NOtes16; }
            set
            {
                if (value != (_NOtes16))
                {
                    _NOtes16 = value;
                    OnPropertyChanged(nameof(NOtes16));
                }
            }
        }
        private string _NOtes17;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes17
        {
            get { return _NOtes17; }
            set
            {
                if (value != (_NOtes17))
                {
                    _NOtes17 = value;
                    OnPropertyChanged(nameof(NOtes17));
                }
            }
        }
        private string _NOtes18;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes18
        {
            get { return _NOtes18; }
            set
            {
                if (value != (_NOtes18))
                {
                    _NOtes18 = value;
                    OnPropertyChanged(nameof(NOtes18));
                }
            }
        }
        private string _NOtes19;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes19
        {
            get { return _NOtes19; }
            set
            {
                if (value != (_NOtes19))
                {
                    _NOtes19 = value;
                    OnPropertyChanged(nameof(NOtes19));
                }
            }
        }
        private string _NOtes20;
        /// <summary>
        /// 
        /// </summary>
        public string NOtes20
        {
            get { return _NOtes20; }
            set
            {
                if (value != (_NOtes20))
                {
                    _NOtes20 = value;
                    OnPropertyChanged(nameof(NOtes20));
                }
            }
        }

    }


}

namespace DIL
{
    public class DILDB : QwUI.Data.DIL.MySQLDB
    {
        #region Auto Declare
        /// <summary> 
        /// 皮带利用率 
        /// </summary> 
        public DBSchema.Tables.app_beltoperation app_beltoperation;
        /// <summary> 
        /// 生产记录表 
        /// </summary> 
        public DBSchema.Tables.app_pureteboard app_pureteboard;
        /// <summary> 
        ///  
        /// </summary> 
        public DBSchema.Tables.createuser createuser;
        /// <summary> 
        ///  
        /// </summary> 
        public DBSchema.Tables.materialstable materialstable;
        /// <summary> 
        ///  
        /// </summary> 
        public DBSchema.Tables.operationtable operationtable;
        /// <summary> 
        ///  
        /// </summary> 
        public DBSchema.Tables.processstatustable processstatustable;
        /// <summary> 
        ///  
        /// </summary> 
        public DBSchema.Tables.recipetable recipetable;
        /// <summary> 
        ///  
        /// </summary> 
        public DBSchema.Tables.repairstable repairstable;
        public DILDB(string ServerName, string DataBaseName, string DataBaseUserName, string DataBasePassWord) : base(ServerName, DataBaseName, DataBaseUserName, DataBasePassWord)
        {
            app_beltoperation = new DBSchema.Tables.app_beltoperation(this);
            app_pureteboard = new DBSchema.Tables.app_pureteboard(this);
            createuser = new DBSchema.Tables.createuser(this);
            materialstable = new DBSchema.Tables.materialstable(this);
            operationtable = new DBSchema.Tables.operationtable(this);
            processstatustable = new DBSchema.Tables.processstatustable(this);
            recipetable = new DBSchema.Tables.recipetable(this);
            repairstable = new DBSchema.Tables.repairstable(this);
        }
        #endregion

    }
}

