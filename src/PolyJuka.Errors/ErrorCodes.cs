using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyJuka.Errors
{
    /*
     * Error Format:
     * 
     * [Error Type]: ER[ERROR_CODE] [LINE]:[COLUMN] - [FILE]
     * 
     */
    public enum ErrorCodes
    {
        SIF, // ERROR TYPE STRING INVALID FORMAT
        VTI, // ERROR TYPE VARIABLE TYPE INVALID
        IVA, // ERROR TYPE INVALID VARIABLE ASSIGNEMENT
        CNC, // ERROR TYPE CAN NOT CONVERT
        FND, // ERROR TYPE FUNCTION NOT DEFINED
        DNA, // ERROR TYPE DATA NON ACCESABLE 
    }
    public enum ErrorTypes
    {
        SYNTAX_ERROR,
        LOGIC_ERROR,
        RUNTIME_ERROR
    }
}
