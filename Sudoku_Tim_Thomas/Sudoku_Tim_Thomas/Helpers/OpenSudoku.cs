using Microsoft.Win32;
using Sudoku_Tim_Thomas.FactoryPattern;
using Sudoku_Tim_Thomas.Models.SudokuTypes;
using Sudoku_Tim_Thomas.SudokuBuilder;
using Sudoku_Tim_Thomas.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Tim_Thomas.Helpers
{
    class OpenSudoku : IHelperBase
    {
        private MainFactory _mainFactory;
        private MainViewModel _mainVM;
        string curDirectory;
        OpenFileDialog openFileDialog;
        private string _fileName;

        public OpenSudoku(MainViewModel mainVM)
        {
            _mainFactory = new MainFactory();
            this._mainVM = mainVM;
        }

        public void Execute()
        {
            curDirectory = Environment.CurrentDirectory;
            openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Directory.GetParent(curDirectory).Parent.FullName + "\\Files";

            if(openFileDialog.ShowDialog()== true)
            {
                
                _fileName = openFileDialog.FileName;
                switch (_fileName)
                {
                    case string four when _fileName.Contains("4x4"):
                        InitDefaultSudoku(four, sudoku);
                        break;

                    case string six when _fileName.Contains("6x6"):
                        InitDefaultSudoku(six, sudoku);

                        break;

                    case string nine when _fileName.Contains("9x9"):
                        InitDefaultSudoku(nine, sudoku);

                        break;

                    case string jigsaw when _fileName.Contains("jigsaw"):
                        InitNonDefaultSudoku(jigsaw, sudoku);
                        break;

                    case string samurai when _fileName.Contains("samurai"):
                        InitNonDefaultSudoku(samurai, sudoku);
                        break;
                }
            }
        }

        private void InitDefaultSudoku(string sudokuType, SudokuBase sudoku)
        {
            DefaultSudokuFactory defaultSudokuFactory = (DefaultSudokuFactory)_mainFactory.TypeBuilder("Default");
            ISudokuClonerDefault sudokuClonerDefault = defaultSudokuFactory.TypeBuilder("Default");
            SudokuBase sudoku1;
            sudoku1 = sudokuClonerDefault.Build(sudokuType);


        }

        private void InitNonDefaultSudoku(string sudokuType, SudokuBase sudoku)
        {
            NonDefaultSudokuFactory nonDefaultSudokuFactory = (NonDefaultSudokuFactory)_mainFactory.TypeBuilder("NonDefault");
            ISudokuClonerNonDefault sudokuClonerNonDefault = nonDefaultSudokuFactory.TypeBuilder("NonDefault");
            SudokuBase sudoku2;
            sudoku2 = sudokuClonerNonDefault.Build(sudokuType);
        }
    }
}
