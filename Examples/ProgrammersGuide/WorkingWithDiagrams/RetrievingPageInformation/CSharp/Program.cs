//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Diagram. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Diagram;
using System;

namespace RetrievingPageInformation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Call the diagram constructor to load diagram from a VDX file
            Diagram vdxDiagram = new Diagram(dataDir + "drawing.vdx");

            foreach (Aspose.Diagram.Page page in vdxDiagram.Pages)
            {
                //Checks if current page is a background page
                if (page.Background == Aspose.Diagram.BOOL.True)
                {
                    //Display information about the background page
                    Console.WriteLine("Background Page ID : " + page.ID);
                    Console.WriteLine("Background Page Name : " + page.Name);
                }
                else
                {
                    //Display information about the foreground page
                    Console.WriteLine("\nPage ID : " + page.ID);
                    Console.WriteLine("Universal Name : " + page.NameU);
                    Console.WriteLine("ID of the Background Page : " + page.BackPage);
                }
            }

            Console.ReadLine();
        }
    }
}