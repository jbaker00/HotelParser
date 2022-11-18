//using System;
//using System.IO;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//specify file name for reading
string fileName = @"./HotelList.csv";

{
using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            string[] row = new string [6];
            String lineHeader = "Recipe(";
            string fileFooter = "),";

            using(StreamWriter writetext = new StreamWriter("output1.txt"))
            {
                writetext.WriteLine("import Foundation");
                writetext.WriteLine("enum Category: String, CaseIterable, Identifiable {");
                writetext.WriteLine("    var id: String {self.rawValue}");
                writetext.WriteLine("    case beach = \"Beach\"       ");
                writetext.WriteLine("    case mountain = \"Mountain\"   ");
                writetext.WriteLine("    case city = \"City\"   ");
                writetext.WriteLine("    case desert = \"Desert\"    ");
                writetext.WriteLine("}");
                writetext.WriteLine("struct Recipe: Identifiable {");
                writetext.WriteLine("    let id = UUID()");
                writetext.WriteLine("    let name: String");
                writetext.WriteLine("    let image: String");
                writetext.WriteLine("    let description: String");
                writetext.WriteLine("    let city: String");
                writetext.WriteLine("    let country: String");
                writetext.WriteLine("    let category: Category.RawValue");
                writetext.WriteLine("    let airport: String");
                writetext.WriteLine("    let url: String");
                writetext.WriteLine("}");
                writetext.WriteLine("extension Recipe {");
                writetext.WriteLine("    static let all: [Recipe] = [");

                while ((line = reader.ReadLine()) != null) {
                    //Console.WriteLine(line);
                    row = line.Split(',');

                        writetext.WriteLine(lineHeader);
                        writetext.WriteLine("name: \"" + row[0] + "\",");
                        writetext.WriteLine("image: \"" + row[1] + "\",");
                        writetext.WriteLine("description: \"" + row[2] + "\",");
                        writetext.WriteLine("city: \"" + row[3] + ", " + row[4] + "\",");  //Write out City and State on same line as some places may not have a state
                        writetext.WriteLine("country: \"" + row[5] + "\",");
                        writetext.WriteLine("category: \"" + row[6] + "\",");
                        writetext.WriteLine("airport: \"" + row[7] + "\",");
                        writetext.WriteLine("url: \"" + row[8]+ "\"");
                        writetext.WriteLine(fileFooter);
                }

                writetext.WriteLine("   ]");
                writetext.WriteLine("}");
            }
        }
}


