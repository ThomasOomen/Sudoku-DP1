using Microsoft.Win32;
using Sudoku_Tim_Thomas.Models.SudokuTypes;
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
        private MainViewModel _mainVM;

        private string _fileName;

        public OpenSudoku(MainViewModel mainVM)
        {
            this._mainVM = mainVM;
        }

        public void Execute()
        {
            string curDirectory = Environment.CurrentDirectory;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Directory.GetParent(curDirectory).Parent.FullName + "\\Files";

            if(openFileDialog.ShowDialog()== true)
            {
                SudokuBase sudoku;
                _fileName = openFileDialog.FileName;
                switch (_fileName)
                {
                    case string four when _fileName.Contains("4x4"):
                        //TODO Add default factory
                        //TODO Add default builder
                        //TODO give default builder source

                        break;

                    case string six when _fileName.Contains("6x6"):
                        //TODO Add default factory
                        //TODO Add default builder
                        //TODO give default builder source
                        break;

                    case string nine when _fileName.Contains("9x9"):
                        //TODO Add default factory
                        //TODO Add default builder
                        //TODO give default builder sources
                        break;

                    case string jigsaw when _fileName.Contains("jigsaw"):
                        //TODO Add NonDefault factory
                        //TODO Add NonDefault builder
                        //TODO give NonDefault builder source
                        break;

                    case string samurai when _fileName.Contains("samurai"):
                        //TODO Add NonDefault factory
                        //TODO Add NonDefault builder
                        //TODO give NonDefault builder source
                        break;
                }
            }
        }

        private void InitDefaultSudoku()
        {

        }

        private void InitNonDefaultSudoku()
        {

        }
    }
}
