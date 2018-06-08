﻿namespace Python
{
    public enum FlagsEnum
    {
        HasArgs = 4,
        HasKwargs = 8,
        Generator = 32,
    }

    public enum ObjectType
    {
        Tuple = 40,
        False = 70,
        None = 78,
        StringRef = 82,
        True = 84,
        Code = 99,
        Int = 105,
        String = 115,
        Interned = 116,
        UnicodeString = 117
    }

    public enum OpCode
    {
        StopCode = 0,
        Pop_Top = 1,
        Rot_Two = 2,
        Rot_Three = 3,
        Dup_Top = 4,
        Rot_Four = 5,
        Nop = 9,
        Unary_Positive = 10,
        Unary_Negative = 11,
        Unary_Not = 12,
        Unary_Convert = 13,
        Unary_Invert = 15,
        Binary_Power = 19,
        Binary_Multiply = 20,
        Binary_Divide = 21,
        Binary_Modulo = 22,
        Binary_Add = 23,
        Binary_Subtract = 24,
        Binary_Subscr = 25,
        Binary_FloorDivide = 26,
        Binary_TrueDivide = 27,
        Inplace_FloorDivide = 28,
        Inplace_TrueDivide = 29,
        Slice0 = 30,
        Slice1 = 31,
        Slice2 = 32,
        Slice3 = 33,
        Store_Slice0 = 40,
        Store_Slice1 = 41,
        Store_Slice2 = 42,
        Store_Slice3 = 43,
        Delete_Slice0 = 50,
        Delete_Slice1 = 51,
        Delete_Slice2 = 52,
        Delete_Slice3 = 53,
        Store_Map = 54,
        Inplace_Add = 55,
        Inplace_Subtract = 56,
        Inplace_Multiply = 57,
        Inplace_Divide = 58,
        Inplace_Modulo = 59,
        Store_Subscr = 60,
        Delete_Subscr = 61,
        Binary_Lshift = 62,
        Binary_Rshift = 63,
        Binary_And = 64,
        Binary_Xor = 65,
        Binary_Or = 66,
        Inplace_Power = 67,
        Get_Iter = 68,
        Get_Yeild_From_Iter = 69,
        Print_Expr = 70,
        Print_Item = 71,
        Print_Newline = 72,
        Print_Item_To = 73,
        Print_Newline_To = 74,
        Inplace_Lshift = 75,
        Inplace_Rshift = 76,
        Inplace_And = 77,
        Inplace_Xor = 78,
        Inplace_Or = 79,
        Break_Loop = 80,
        With_Cleanup = 81,
        Load_Locals = 82,
        Return_Value = 83,
        Import_Star = 84,
        Exec_Stmt = 85,
        Yield_Value = 86,
        Pop_Block = 87,
        End_Finally = 88,
        Build_Class = 89,
        Store_Name = 90,
        Delete_Name = 91,
        Unpack_Sequence = 92,
        For_Iter = 93,
        List_Append = 94,
        Store_Attr = 95,
        Delete_Attr = 96,
        Store_Global = 97,
        Delete_Global = 98,
        Dup_Topx = 99,
        Load_Const = 100,
        Load_Name = 101,
        Build_Tuple = 102,
        Build_List = 103,
        Build_Set = 104,
        Build_Map = 105,
        Load_Attr = 106,
        Compare_Op = 107,
        Import_Name = 108,
        Import_From = 109,
        Jump_Forward = 110,
        Jump_If_False_Or_Pop = 111,
        Jump_If_True_Or_Pop = 112,
        Jump_Absolute = 113,
        Pop_Jump_If_False = 114,
        Pop_Jump_If_True = 115,
        Load_Global = 116,
        Continue_Loop = 119,
        Setup_Loop = 120,
        Setup_Except = 121,
        Setup_Finally = 122,
        Load_Fast = 124,
        Store_Fast = 125,
        Delete_Fast = 126,
        Raise_Varargs = 130,
        Call_Function = 131,
        Make_Function = 132,
        Build_Slice = 133,
        Make_Closure = 134,
        Load_Closure = 135,
        Load_Deref = 136,
        Store_Deref = 137,
        Call_Function_Var = 140,
        Call_Function_Kw = 141,
        Call_Function_Var_Kw = 142,
        Setup_With = 143,
        Extended_Arg = 145,
        Set_Add = 146,
        Map_Add = 147,
    }
}