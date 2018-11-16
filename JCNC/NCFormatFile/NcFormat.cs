using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace NCFormatFile
{
    public class NcFormat
    {
        public string InputFilePath;
        public string OutputFilePath;
        public string FileSource;  // MDI or MEM

        private Int32 programNum;   // MDI = 999 or MER = ss
        public Int32 ProgramNum { get { return programNum; } }

        private bool initialResult;
        public bool InitialResult { get { return initialResult; } }

        private string openCommand;
        private string firstCommand;
        private string closeCommand;

        public NcFormat()
        {
        }
        public NcFormat(string input_file_path, string file_source)
        {
            this.Initialize(input_file_path, file_source);
        }

        public bool Initialize(string input_file_path, string file_source)
        {
            if (true == File.Exists(input_file_path))
            {
                this.InputFilePath = input_file_path;
                this.OutputFilePath = "";

                this.FileSource = file_source;
                if ("MDI" == this.FileSource)
                {
                    this.OutputFilePath = @".\NCFile\MDI.NC";
                    this.programNum = 999;   // our definition
                }
                else    // "MEM"
                {
                    this.OutputFilePath = @".\NCFile\MEM.NC";
                    this.programNum = 998;   // our definition
                }

                if (false == File.Exists(OutputFilePath))
                {
                    File.CreateText(OutputFilePath);
                }
                this.openCommand = "Open Prog " + this.programNum.ToString();

                this.firstCommand = "N1";
                this.closeCommand = "Close";

                this.initialResult = true;
            }
            else
            {
                this.initialResult = false;
            }

            return this.initialResult;
        }

        /////////////////////////////////////////
        #region G81
         private bool isG81Replace = false;
        private enum WORD_G81 { X, Y, Z, R, F, K };
        private const int word_g81_num = 6;
        private List<string> word_g81_content = new List<string> { "X", "Y", "Z", "R", "F", "K" };
        private List<string> word_g81_cmd = new List<string> { "X0", "Y0", "Z0", "R0", "F0", "K1" };
        private List<int> word_g81_position = new List<int> { 0, 0, 0, 0, 0, 0 };

        private int nearest_length_g81(int current_index, int max_length)
        {
            int length = 0;

            List<int> temp_pos = new List<int> { };
            for (int i = 0; i < this.word_g81_position.Count(); i++)
            {
                temp_pos.Add(this.word_g81_position[i]);
            }

            temp_pos.Sort();
            current_index = temp_pos.FindIndex(delegate(int index) { return index == this.word_g81_position[current_index]; });
            if (current_index < temp_pos.Count() - 1)
            {
                length = temp_pos[current_index + 1] - temp_pos[current_index];
                //length = this.word_g81_position[current_index + 1] - this.word_g81_position[current_index];
            }
            else
            {
                length = max_length - temp_pos[current_index];
            }

            return length;
        }

        private string CheckG81State(bool isSlash, string gcode)
        {
            string new_gcode = string.Empty;
            string temp_gcode = string.Empty;

            if (-1 == gcode.IndexOf("G81"))
            {
                if ((-1 != gcode.IndexOf("G80")) ||
                    (-1 != gcode.IndexOf("G82")) ||
                    (-1 != gcode.IndexOf("G83")) ||
                    (-1 != gcode.IndexOf("G84")))
                {
                    this.isG81Replace = false;
                }
            

                if (true == this.isG81Replace)
                {
                    if (true == isSlash)
                    {
                        gcode = gcode.Remove(0, 1);
                    }

                    ////////////////////////////////////////
                    #region Parse
                    int word_pos = -1;
                    word_pos = gcode.IndexOf("X");
                    if (-1 != word_pos)
                    {
                        temp_gcode = gcode.Remove(word_pos, 1);
                        this.word_g81_cmd[(int)WORD_G81.X] = "X" + temp_gcode;
                    }
                    else
                    {
                        word_pos = gcode.IndexOf("Y");
                        if (-1 != word_pos)
                        {
                            temp_gcode = gcode.Remove(word_pos, 1);
                            this.word_g81_cmd[(int)WORD_G81.Y] = "Y" + temp_gcode;
                        }
                    }

                    gcode = "G81 " + this.word_g81_cmd[(int)WORD_G81.X] + " "
                                   + this.word_g81_cmd[(int)WORD_G81.Y] + " "
                                   + this.word_g81_cmd[(int)WORD_G81.Z] + " "
                                   + this.word_g81_cmd[(int)WORD_G81.R] + " "
                                   + this.word_g81_cmd[(int)WORD_G81.K] + " "
                                   + this.word_g81_cmd[(int)WORD_G81.F];

                    #endregion
                    ////////////////////////////////////////

                }

                if (true == isSlash)
                {
                    new_gcode = "/" + gcode;
                }
                else
                {
                    new_gcode = gcode;
                }
            }
            else
            {
                this.isG81Replace = true;
                this.isG82Replace = false;
                this.isG83Replace = false;
                this.isG84Replace = false;
                // EX: G81 X130.8 Y-32 Z-134 R653 F4444 K1
                ////////////////////////////////////////
                #region Parse

                for (int index = 0; index < this.word_g81_position.Count(); index++)
                {
                    this.word_g81_position[index] = gcode.IndexOf(word_g81_content[index]);
                }
                for (int index = 0; index < this.word_g81_position.Count(); index++)
                {
                    if (-1 != this.word_g81_position[index])
                    {
                        this.word_g81_cmd[index] = gcode.Substring(this.word_g81_position[index], this.nearest_length_g81(index, gcode.Length));
                    }
                }

                #endregion
                ////////////////////////////////////////

                new_gcode = gcode;
            }

            return new_gcode;
        }
        #endregion

        /////////////////////////////////////////
        #region G82
        private bool isG82Replace = false;
        private enum WORD_G82 { X, Y, Z, R, P, F, K };
        private List<string> word_g82_content = new List<string> { "X", "Y", "Z", "R", "P", "F", "K" };
        private List<string> word_g82_cmd = new List<string> { "X0", "Y0", "Z0", "R0", "P0", "F0", "K1" };
        private List<int> word_g82_position = new List<int> { 0, 0, 0, 0, 0, 0, 0 };

        private int nearest_length_g82(int current_index, int max_length)
        {
            int length = 0;

            List<int> temp_pos = new List<int> { };
            for (int i = 0; i < this.word_g82_position.Count(); i++)
            {
                temp_pos.Add(this.word_g82_position[i]);
            }

            temp_pos.Sort();
            current_index = temp_pos.FindIndex(delegate(int index) { return index == this.word_g82_position[current_index]; });
            if (current_index < temp_pos.Count() - 1)
            {
                length = temp_pos[current_index + 1] - temp_pos[current_index];
                //length = this.word_g82_position[current_index + 1] - this.word_g82_position[current_index];
            }
            else
            {
                length = max_length - temp_pos[current_index];
            }

            return length;
        }

        private string CheckG82State(bool isSlash, string gcode)
        {
            string new_gcode = string.Empty;
            string temp_gcode = string.Empty;

            if (-1 == gcode.IndexOf("G82"))
            {
                if ((-1 != gcode.IndexOf("G80")) ||
                    (-1 != gcode.IndexOf("G81")) ||
                    (-1 != gcode.IndexOf("G82")) ||
                    (-1 != gcode.IndexOf("G84")))
                {
                    this.isG82Replace = false;
                }

                if (true == this.isG82Replace)
                {
                    if (true == isSlash)
                    {
                        gcode = gcode.Remove(0, 1);
                    }

                    ////////////////////////////////////////
                    #region Parse
                    int word_pos = -1;
                    word_pos = gcode.IndexOf("X");
                    if (-1 != word_pos)
                    {
                        temp_gcode = gcode.Remove(word_pos, 1);
                        this.word_g82_cmd[(int)WORD_G82.X] = "X" + temp_gcode;
                    }
                    else
                    {
                        word_pos = gcode.IndexOf("Y");
                        if (-1 != word_pos)
                        {
                            temp_gcode = gcode.Remove(word_pos, 1);
                            this.word_g82_cmd[(int)WORD_G82.Y] = "Y" + temp_gcode;
                        }
                    }

                    gcode = "G82 " + this.word_g82_cmd[(int)WORD_G82.X] + " "
                                   + this.word_g82_cmd[(int)WORD_G82.Y] + " "
                                   + this.word_g82_cmd[(int)WORD_G82.Z] + " "
                                   + this.word_g82_cmd[(int)WORD_G82.R] + " "
                                   + this.word_g82_cmd[(int)WORD_G82.P] + " "
                                   + this.word_g82_cmd[(int)WORD_G82.K] + " "
                                   + this.word_g82_cmd[(int)WORD_G82.F];

                    #endregion
                    ////////////////////////////////////////

                }

                if (true == isSlash)
                {
                    new_gcode = "/" + gcode;
                }
                else
                {
                    new_gcode = gcode;
                }
            }
            else
            {
                this.isG82Replace = true;
                this.isG81Replace = false;
                this.isG83Replace = false;
                this.isG84Replace = false;
                // EX: G82 X130.8 Y-232 Z-138.775 R-117 P5 f1111 K6
                ////////////////////////////////////////
                #region Parse

                for (int index = 0; index < this.word_g82_position.Count(); index++)
                {
                    this.word_g82_position[index] = gcode.IndexOf(word_g82_content[index]);
                }
                for (int index = 0; index < this.word_g82_position.Count(); index++)
                {
                    if (-1 != this.word_g82_position[index])
                    {
                        this.word_g82_cmd[index] = gcode.Substring(this.word_g82_position[index], this.nearest_length_g82(index, gcode.Length));
                    }
                }

                #endregion
                ////////////////////////////////////////

                new_gcode = gcode;
                this.isG82Replace = true;
            }

            return new_gcode;
        }
        #endregion

        /////////////////////////////////////////
        #region G83
        private bool isG83Replace = false;
        private enum WORD_G83 { X, Y, Z, R, Q, D, K, F };
        private List<string> word_g83_content = new List<string> { "X", "Y", "Z", "R", "Q", "D", "K", "F" };
        private List<string> word_g83_cmd = new List<string> { "X0", "Y0", "Z0", "R0", "Q0", "D0", "K1", "F0" };
        private List<int> word_g83_position = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };

        private int nearest_length_g83(int current_index, int max_length)
        {
            int length = 0;

            List<int> temp_pos = new List<int> { };
            for (int i = 0; i < this.word_g83_position.Count(); i++)
            {
                temp_pos.Add(this.word_g83_position[i]);
            }
                
            temp_pos.Sort();
            current_index = temp_pos.FindIndex(delegate(int index) { return index == this.word_g83_position[current_index]; });
            if (current_index < temp_pos.Count() - 1)
            {
                length = temp_pos[current_index + 1] - temp_pos[current_index];
                //length = this.word_g83_position[current_index + 1] - this.word_g83_position[current_index];
            }
            else
            {
                length = max_length - temp_pos[current_index];
            }

            return length;
        }

        private string CheckG83State(bool isSlash, string gcode)
        {
            string new_gcode = string.Empty;
            string temp_gcode = string.Empty;

            if (-1 == gcode.IndexOf("G83"))
            {
                if ((-1 != gcode.IndexOf("G80")) ||
                    (-1 != gcode.IndexOf("G81")) ||
                    (-1 != gcode.IndexOf("G82")) ||
                    (-1 != gcode.IndexOf("G84")))
                {
                    this.isG83Replace = false;
                }

                if (true == this.isG83Replace)
                {
                    if (true == isSlash)
                    {
                        gcode = gcode.Remove(0, 1);
                    }

                    ////////////////////////////////////////
                    #region Parse
                    int word_pos = -1;
                    word_pos = gcode.IndexOf("X");
                    if (-1 != word_pos)
                    {
                        temp_gcode = gcode.Remove(word_pos, 1);
                        this.word_g83_cmd[(int)WORD_G83.X] = "X" + temp_gcode;
                    }
                    else
                    {
                        word_pos = gcode.IndexOf("Y");
                        if (-1 != word_pos)
                        {
                            temp_gcode = gcode.Remove(word_pos, 1);
                            this.word_g83_cmd[(int)WORD_G83.Y] = "Y" + temp_gcode;
                        }
                    }

                   gcode = "G83 " + this.word_g83_cmd[(int)WORD_G83.X] + " "
                                  + this.word_g83_cmd[(int)WORD_G83.Y] + " "
                                  + this.word_g83_cmd[(int)WORD_G83.Z] + " "
                                  + this.word_g83_cmd[(int)WORD_G83.R] + " "
                                  + this.word_g83_cmd[(int)WORD_G83.Q] + " "
                                  + this.word_g83_cmd[(int)WORD_G83.D] + " "
                                  + this.word_g83_cmd[(int)WORD_G83.K] + " "
                                  + this.word_g83_cmd[(int)WORD_G83.F];

                    #endregion
                    ////////////////////////////////////////

                }

                if (true == isSlash)
                {
                    new_gcode = "/" + gcode;
                }
                else
                {
                    new_gcode = gcode;
                }
            }
            else
            {
                this.isG83Replace = true;
                this.isG81Replace = false;
                this.isG82Replace = false;
                this.isG84Replace = false;
                // EX: G83 X130.8 Y-232 Z-138.775 R-117.775 Q5 D3 K1 F100
                ////////////////////////////////////////
                #region Parse

                for (int index = 0; index < this.word_g83_position.Count(); index++)
                {
                    this.word_g83_position[index] = gcode.IndexOf(word_g83_content[index]);
                }
                for (int index = 0; index < this.word_g83_position.Count(); index++)
                {
                    if (-1 != this.word_g83_position[index])
                    {
                        this.word_g83_cmd[index] = gcode.Substring(this.word_g83_position[index], this.nearest_length_g83(index, gcode.Length));
                    }
                }

                #endregion
                ////////////////////////////////////////

                new_gcode = gcode;
            }

            return new_gcode;
        }
        #endregion

        /////////////////////////////////////////
        #region G84
        private bool isG84Replace = false;
        private enum WORD_G84 { X, Y, Z, R, P, F, K };
        private List<string> word_g84_content = new List<string> { "X", "Y", "Z", "R", "P", "F", "K" };
        private List<string> word_g84_cmd = new List<string> { "X0", "Y0", "Z0", "R0", "P0", "F0", "K1" };
        private List<int> word_g84_position = new List<int> { 0, 0, 0, 0, 0, 0, 0 };

        private int nearest_length_g84(int current_index, int max_length)
        {
            int length = 0;

            List<int> temp_pos = new List<int> { };
            for (int i = 0; i < this.word_g84_position.Count(); i++)
            {
                temp_pos.Add(this.word_g84_position[i]);
            }

            temp_pos.Sort();
            current_index = temp_pos.FindIndex(delegate(int index) { return index == this.word_g84_position[current_index]; });
            if (current_index < temp_pos.Count() - 1)
            {
                length = temp_pos[current_index + 1] - temp_pos[current_index];
                //length = this.word_g84_position[current_index + 1] - this.word_g84_position[current_index];
            }
            else
            {
                length = max_length - temp_pos[current_index];
            }

            return length;
        }

        private string CheckG84State(bool isSlash, string gcode)
        {
            string new_gcode = string.Empty;
            string temp_gcode = string.Empty;

            if (-1 == gcode.IndexOf("G84"))
            {
                if ((-1 != gcode.IndexOf("G80")) ||
                    (-1 != gcode.IndexOf("G81")) ||
                    (-1 != gcode.IndexOf("G82")) ||
                    (-1 != gcode.IndexOf("G83")))
                {
                    this.isG84Replace = false;
                }

                if (true == this.isG84Replace)
                {
                    if (true == isSlash)
                    {
                        gcode = gcode.Remove(0, 1);
                    }

                    ////////////////////////////////////////
                    #region Parse
                    int word_pos = -1;
                    word_pos = gcode.IndexOf("X");
                    if (-1 != word_pos)
                    {
                        temp_gcode = gcode.Remove(word_pos, 1);
                        this.word_g84_cmd[(int)WORD_G84.X] = "X" + temp_gcode;
                    }
                    else
                    {
                        word_pos = gcode.IndexOf("Y");
                        if (-1 != word_pos)
                        {
                            temp_gcode = gcode.Remove(word_pos, 1);
                            this.word_g84_cmd[(int)WORD_G84.Y] = "Y" + temp_gcode;
                        }
                    }

                    gcode = "G84 " + this.word_g84_cmd[(int)WORD_G84.X] + " "
                                   + this.word_g84_cmd[(int)WORD_G84.Y] + " "
                                   + this.word_g84_cmd[(int)WORD_G84.Z] + " "
                                   + this.word_g84_cmd[(int)WORD_G84.R] + " "
                                   + this.word_g84_cmd[(int)WORD_G84.P] + " "
                                   + this.word_g84_cmd[(int)WORD_G84.K] + " "
                                   + this.word_g84_cmd[(int)WORD_G84.F];

                    #endregion
                    ////////////////////////////////////////

                }

                if (true == isSlash)
                {
                    new_gcode = "/" + gcode;
                }
                else
                {
                    new_gcode = gcode;
                }
            }
            else
            {
                this.isG84Replace = true;
                this.isG81Replace = false;
                this.isG82Replace = false;
                this.isG83Replace = false;
                // EX: G84 X108 Y-2 Z-15 R45 P9 F6000 K1
                ////////////////////////////////////////
                #region Parse

                for (int index = 0; index < this.word_g84_position.Count(); index++)
                {
                    this.word_g84_position[index] = gcode.IndexOf(word_g84_content[index]);
                }
                for (int index = 0; index < this.word_g84_position.Count(); index++)
                {
                    if (-1 != this.word_g84_position[index])
                    {
                        this.word_g84_cmd[index] = gcode.Substring(this.word_g84_position[index], this.nearest_length_g84(index, gcode.Length));
                    }
                }

                #endregion
                ////////////////////////////////////////

                new_gcode = gcode;
            }

            return new_gcode;
        }
        #endregion
        
        /////////////////////////////////////////
        public bool FormatFile()
        {
            UInt32 line_num = 0;
            string currnetLine = "";
            string writeLine = "";
            bool is_found_M30 = false;

            string[] readText = File.ReadAllLines(this.InputFilePath);
            string[] writeText = new string[readText.Length + 4];
            writeText[line_num++] = this.openCommand;
            writeText[line_num++] = this.firstCommand;

            for (UInt32 index = 0; index < readText.Length; index++)
            {
                currnetLine = readText[index];
                if (false == is_found_M30)     // 
                {
                    if ("" == currnetLine)
                    {
                        writeLine = "N" + line_num.ToString();
                        writeText[line_num++] = writeLine;
                    }
                    else
                    {
                        if (-1 == currnetLine.IndexOf("M30"))
                        {
                            if (-1 == currnetLine.IndexOf("Close"))
                            {
                                if (-1 == currnetLine.IndexOf("/"))
                                {
                                    currnetLine = this.CheckG81State(false, currnetLine);
                                    currnetLine = this.CheckG82State(false, currnetLine);
                                    currnetLine = this.CheckG83State(false, currnetLine);
                                    currnetLine = this.CheckG84State(false, currnetLine);
                                    writeLine = "BSTART N" + line_num.ToString() + " " + currnetLine + " BSTOP";
                                    writeText[line_num++] = writeLine;
                                }
                                else
                                {
                                    currnetLine = this.CheckG81State(true, currnetLine);
                                    currnetLine = this.CheckG82State(true, currnetLine);
                                    currnetLine = this.CheckG83State(true, currnetLine);
                                    currnetLine = this.CheckG84State(true, currnetLine);
                                    writeLine = "BSTART N" + line_num.ToString() + " " + "if(P123) {" + currnetLine.Substring(currnetLine.IndexOf("/") + 1) + "}" + " BSTOP";
                                    writeText[line_num++] = writeLine;
                                }
                            }
                        }
                        else
                        {
                            is_found_M30 = true;

                            writeLine = "BSTART N1 M30 BSTOP";
                            writeText[line_num++] = writeLine;

                            writeLine = "BSTART N1 BSTOP";
                            writeText[line_num++] = writeLine;
                        }
                    }
                }
            }
            writeText[line_num++] = this.closeCommand;

            File.WriteAllLines(this.OutputFilePath, writeText);
            return true;
        }
    }
}
