using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlTypes;
using FuzzySharp;

public class FuzzyWuzzy
{

    [Microsoft.SqlServer.Server.SqlFunction(IsDeterministic = true, IsPrecise = true)]
    public static SqlInt32 FuzzyWuzzy_Ratio(SqlString input1, SqlString input2)
    {
        if (input1.IsNull || input2.IsNull)
            return 0;

        return new SqlInt32(Fuzz.Ratio(input1.Value, input2.Value));
    }

    [Microsoft.SqlServer.Server.SqlFunction(IsDeterministic = true, IsPrecise = true)]
    public static SqlInt32 FuzzyWuzzy_PartialRatio(SqlString input1, SqlString input2)
    {
        if (input1.IsNull || input2.IsNull)
            return 0;

        return new SqlInt32(Fuzz.PartialRatio(input1.Value, input2.Value));
    }

    [Microsoft.SqlServer.Server.SqlFunction(IsDeterministic = true, IsPrecise = true)]
    public static SqlInt32 FuzzyWuzzy_TokenSortRatio(SqlString input1, SqlString input2)
    {
        if (input1.IsNull || input2.IsNull)
            return 0;

        return new SqlInt32(Fuzz.TokenSortRatio(input1.Value, input2.Value));
    }

    [Microsoft.SqlServer.Server.SqlFunction(IsDeterministic = true, IsPrecise = true)]
    public static SqlInt32 FuzzyWuzzy_PartialTokenSortRatio(SqlString input1, SqlString input2)
    {
        if (input1.IsNull || input2.IsNull)
            return 0;

        return new SqlInt32(Fuzz.PartialTokenSortRatio(input1.Value, input2.Value));
    }

    [Microsoft.SqlServer.Server.SqlFunction(IsDeterministic = true, IsPrecise = true)]
    public static SqlInt32 FuzzyWuzzy_TokenSetRatio(SqlString input1, SqlString input2)
    {
        if (input1.IsNull || input2.IsNull)
            return 0;

        return new SqlInt32(Fuzz.TokenSetRatio(input1.Value, input2.Value));
    }

    [Microsoft.SqlServer.Server.SqlFunction(IsDeterministic = true, IsPrecise = true)]
    public static SqlInt32 FuzzyWuzzy_PartialTokenSetRatio(SqlString input1, SqlString input2)
    {
        if (input1.IsNull || input2.IsNull)
            return 0;

        return new SqlInt32(Fuzz.PartialTokenSetRatio(input1.Value, input2.Value));
    }

    [Microsoft.SqlServer.Server.SqlFunction(IsDeterministic = true, IsPrecise = true)]
    public static SqlInt32 FuzzyWuzzy_TokenInitialismRatio(SqlString input1, SqlString input2)
    {
        if (input1.IsNull || input2.IsNull)
            return 0;

        return new SqlInt32(Fuzz.TokenInitialismRatio(input1.Value, input2.Value));
    }

    [Microsoft.SqlServer.Server.SqlFunction(IsDeterministic = true, IsPrecise = true)]
    public static SqlInt32 FuzzyWuzzy_PartialTokenInitialismRatio(SqlString input1, SqlString input2)
    {
        if (input1.IsNull || input2.IsNull)
            return 0;

        return new SqlInt32(Fuzz.PartialTokenInitialismRatio(input1.Value, input2.Value));
    }


    //Token Abbreviation Ratio
    //Fuzz.TokenAbbreviationRatio("bl 420", "Baseline section 420", PreprocessMode.Full);
    //40
    //Fuzz.PartialTokenAbbreviationRatio("bl 420", "Baseline section 420", PreprocessMode.Full);
    //50      

    [Microsoft.SqlServer.Server.SqlFunction(IsDeterministic = true, IsPrecise = true)]
    public static SqlInt32 FuzzyWuzzy_WeightedRatio(SqlString input1, SqlString input2)
    {
        if (input1.IsNull || input2.IsNull)
            return 0;

        return new SqlInt32(Fuzz.WeightedRatio(input1.Value, input2.Value));
    }

}