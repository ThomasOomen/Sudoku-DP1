using Sudoku_Tim_Thomas.Models.SudokuTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Tim_Thomas.SudokuBuilder
{
    public interface ISudokuCloner
    {
        //TODO Idk waarom dit nodig is, moet nog even kijken of het nodig is, als niet nodig is weghalen. 
        ISudokuCloner Clone();

        SudokuBase Build(string file);
    }
}
