using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sudoku_Tim_Thomas.Models.SudokuTypes;

namespace Sudoku_Tim_Thomas.SudokuBuilder
{
    public class NormalSudokuBuilder : ISudokuCloner
    {
        //TODO zie ISudokuCloner Clone todo.
        public ISudokuCloner Clone()
        {
            return (NormalSudokuBuilder)MemberwiseClone();
        }

        public SudokuBase Build(string file)
        {
            throw new NotImplementedException();
        }
    }
}
