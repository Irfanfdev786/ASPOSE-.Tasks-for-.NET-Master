﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            string FileName = @"E:\Aspose\Aspose Vs VSTO\Aspose.Tasks VS VSTO Projects\Sample Files\NewProject.xml";
            Project MyProject = new Project();

            MyProject.Save(FileName, Saving.SaveFileFormat.XML);
        }
    }
}
