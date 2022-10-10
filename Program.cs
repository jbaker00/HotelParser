//using System;
//using System.IO; 

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//specify file name for reading
string fileName = @"./2020- 2022HotelList.csv";
{
using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            string[] row = new string [6];
            String lineHeader = "Recipe(";
            string fileFooter = "),";




            using(StreamWriter writetext = new StreamWriter("output1.txt"))
            {
                while ((line = reader.ReadLine()) != null) {
                    //Console.WriteLine(line);
                    row = line.Split(',');

                        writetext.WriteLine(lineHeader);
                        writetext.WriteLine("name: \"" + row[0] + "\",");
                        writetext.WriteLine("image: \"" + row[1] + "\",");
                        writetext.WriteLine("description: \"" + "Put Description here" + "\",");
                        writetext.WriteLine("city: \"" + row[3] + ", " + row[4] + "\",");  //Write out City and State on same line as some places may not have a state
                        writetext.WriteLine("country: \"" + row[5] + "\",");
                        writetext.WriteLine("category: \"" + row[6] + "\",");
                        writetext.WriteLine("airport: \"" + "Put Airport code here" + "\",");
                        writetext.WriteLine("url: \"" + row[2]+ "\"");
                        writetext.WriteLine(fileFooter);
                }
            }
        }
}

/*
Recipe(
            name: "Hotel Riu Palace Aruba",
            image: "https://thetravelplannerscouple.com/wp-content/uploads/2021/04/aruba-palace-768x445.jpg",
            description: "The 24-hour All Inclusive Hotel Riu Palace Aruba opens all year round and is located directly on the beautiful Palm Beach. RIU Palace is the most elegant category in the RIU hotel chain, with hotels that meet the highest standards in terms of luxury, excellence and sophistication, creating a unique experience. The location is ideal due to its proximity to Aruba Airport (10 km) and Oranjestad (11 km) and invites you to explore the area. The hotel has 450 cozily furnished rooms with free Wi-Fi and offers many amenities. Relax in our spa, or get in shape at the fitness center. 2 outdoor pools, 1 children's pool. Day and evening entertainment, as well as our discotheque in the neighboring Hotel Riu Palace Antillas. For lovers of gastronomy, we offer live cooking stations at our main buffet restaurant, Japanese and Italian, Fusion restaurants and Steakhouse, as well as 5 bars and our Capuchino patisserie & ice cream parlor.",
            city: "Eagle Beach",
            country: "Aruba",
            category: "All Inclusive",
            airport: "AUA",
            url: "https://www.riu.com/en/hotel/aruba/palmbeach/hotel-riu-palace-aruba/"
        ),
*/


//
/*StreamReader sr = new StreamReader(@"./2020- 2022HotelList.csv");
string line;
string[] row = new string [5];
string HotelName;
string imageLink;
string city;
string state;
string country;
string openingDate;
while ((line = sr.ReadLine()) != null)
{
    //Read in each line and assign each line to a var each line will be a different setion of XML
    row = line.Split(',');
    HotelName = row[0],
    imageLink = row[1],
    city = row[2],
    state = row[3],
    country = row[4],
    openingDate = row[5]

     //write out each line to new file
}*/

