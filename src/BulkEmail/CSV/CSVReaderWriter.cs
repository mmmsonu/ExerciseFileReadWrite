using System;
using System.IO;

namespace BulkEmail.CSV
{
    /*
     2) Refactor the CSVReaderWriter implementation into clean, elegant, well performing 
        and maintainable code, as you see fit.
        You should not update the BulkEmailProcessor as part of this task.
        Backwards compatibility of the CSVReaderWriter must be maintained, so that the 
        existing BulkEmailProcessor is not broken.
        Other that that, you can make any change you see fit, even to the code structure.
    */


    /*
     * Refactor Notes-
     * 1. Removed Read overload method which have normal parameter. 
     *      And keeping Read method which is used in BulkEmailProcessor.cs and having 2 out parameter.
     */
    public class CSVReaderWriter
    {
        private StreamReader _readerStream = null;
        private StreamWriter _writerStream = null;

        const int firstcolumn = 0;
        const int secondcolumn = 1;
        const char defaultseparator = '\t';

        [Flags]
        public enum Mode { Read = 1, Write = 2 };

        public void Open(string fileName, Mode mode)
        {
            try
            {
                if (mode == Mode.Read)
                {
                    _readerStream = File.OpenText(fileName);
                }
                else if (mode == Mode.Write)
                {
                    FileInfo fileInfo = new FileInfo(fileName);
                    _writerStream = fileInfo.CreateText();
                }
                else
                {
                    throw new Exception("Unknown file mode for " + fileName);
                }
            }
            catch
            {
                throw new Exception("Error reading or writing to file : " + fileName);
            }
        }

        public void Write(params string[] columns)
        {
            string outPut = "";

            for (int i = 0; i < columns.Length; i++)
            {
                outPut += columns[i];
                if ((columns.Length - 1) != i)
                {
                    outPut += defaultseparator;
                }
            }

            WriteLine(outPut);
        }


        public bool Read(out string column1, out string column2)
        {
            const int FIRST_COLUMN = firstcolumn;
            const int SECOND_COLUMN = secondcolumn;
            const char defaultSeparator = defaultseparator;

            string line;
            string[] columns;

            column1 = null;
            column2 = null;

            char[] separator = { defaultSeparator };
            line = ReadLine();
            bool returnVal = (line != null); //null check on read line

            if (returnVal)
            {
                columns = line.Split(separator);
                returnVal = (columns.Length > 0);  //evaluating return value again
                if (returnVal)
                {
                    column1 = columns[FIRST_COLUMN];
                    column2 = columns[SECOND_COLUMN];
                }
            }

            return returnVal;
        }

        private void WriteLine(string line)
        {
            if (_writerStream != null)
            {
                _writerStream.WriteLine(line);
            }
        }

        private string ReadLine()
        {
            var returnVal = "";
            if (_readerStream != null)
            {
                returnVal = _readerStream.ReadLine();
            }
            return returnVal;
        }

        public void Close()
        {
            if (_writerStream != null)
            {
                _writerStream.Close();
            }

            if (_readerStream != null)
            {
                _readerStream.Close();
            }
        }
    }
}
